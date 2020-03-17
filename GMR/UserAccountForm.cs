using GMR.BLL.Abstractions.Models;
using GMR.BLL.Abstractions.Services;
using GMR.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMR
{
    public partial class UserAccountForm : Form
    {
        private IPersonService _personService;

        private List<TextBox> _userInputTextBoxes;

        private List<TextBox> _passwordInputTextBoxes;

        private UpdatePersonViewModel _viewModel;

        public UserAccountForm(IPersonService personService)
        {
            InitializeComponent();

            _personService = personService;
        }

        private void UserAccountForm_Load(object sender, EventArgs e)
        {
            _userInputTextBoxes = userProfilePanel.Controls.OfType<TextBox>().ToList();
            _passwordInputTextBoxes = passwordPanel.Controls.OfType<TextBox>().ToList();

            SetCurrentUserValues();
        }

        private void changeProfileBtn_Click(object sender, EventArgs e) => SwitchControls(true);

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            SetCurrentUserValues();
            SwitchControls(false);
        }

        private async void saveBtn_Click(object sender, EventArgs e)
        {
            _viewModel.FirstName = firstNameTBox.Text;
            _viewModel.LastName = lastNameTBox.Text;
            _viewModel.Country = countryTBox.Text;
            _viewModel.Company = companyTBox.Text;
            _viewModel.Phone = phoneTBox.Text;

            _viewModel.Password.Login = loginTBox.Text;
            _viewModel.Password.OldValue = oldPasswordTBox.Text;
            _viewModel.Password.NewValue = newPasswordTBox.Text;
            _viewModel.Password.ConfirmValue = confirmPasswordTBox.Text;

            if (ValidateModel())
            {
                
            }
            else
            {
                _viewModel = Mapper.Map<PersonModel, UpdatePersonViewModel>(Session.Person);
            }
            //var userClone = (PersonModel)Session.Person.Clone();

            SwitchControls(false);
        }

        private void SwitchControls(bool available)
        {
            _userInputTextBoxes.ForEach(_ => _.Enabled = available);
            changeProfilePanel.Visible = available;
            updatePasswordChBox.Enabled = available;
            if (!available)
                updatePasswordChBox.Checked = available;
        }

        private void SetCurrentUserValues()
        {
            _viewModel = Mapper.Map<PersonModel, UpdatePersonViewModel>(Session.Person);

            firstNameTBox.Text = _viewModel.FirstName;
            lastNameTBox.Text = _viewModel.LastName;
            countryTBox.Text = _viewModel.Country;
            companyTBox.Text = _viewModel.Company;
            phoneTBox.Text = _viewModel.Phone;
            loginTBox.Text = _viewModel.Password.Login;
        }

        private void UserAccountForm_FormClosing(object sender, FormClosingEventArgs e)
            => (_personService as IDisposable).Dispose();

        private bool ValidateModel()
        {
            var results = new List<ValidationResult>();
            var isValid = Validator.TryValidateObject(_viewModel, new ValidationContext(_viewModel), results, true) &
            Validator.TryValidateObject(_viewModel.Password, new ValidationContext(_viewModel.Password), results, true);

            if (isValid)
                return true;



            return false;
        }

        private void updatePasswordChBox_CheckedChanged(object sender, EventArgs e)
        {
            if (updatePasswordChBox.Checked)
            {
                _passwordInputTextBoxes.ForEach(_ =>
                {
                    _.Enabled = updatePasswordChBox.Checked;
                });
            }
            else
            {
                _passwordInputTextBoxes.ForEach(_ =>
                {
                    _.Clear();
                    _.Enabled = updatePasswordChBox.Checked;
                });
            } 
        }
    }
}
