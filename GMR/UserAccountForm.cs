using GMR.BLL;
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
            var viewModel = new UpdatePersonViewModel()
            {
                FirstName = firstNameTBox.Text,
                LastName = lastNameTBox.Text,
                Country = countryTBox.Text,
                Company = companyTBox.Text,
                Phone = phoneTBox.Text,
                Password = new UpdatePasswordViewModel()
                {
                    Login = loginTBox.Text,
                    OldValue = oldPasswordTBox.Text,
                    NewValue = newPasswordTBox.Text,
                    ConfirmValue = confirmPasswordTBox.Text
                }
            };           

            if (ValidateModel(viewModel))
            {
                
            }
            else
            {
                viewModel = Mapper.Map<PersonModel, UpdatePersonViewModel>(Session.Person);
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
            var viewModel = Mapper.Map<PersonModel, UpdatePersonViewModel>(Session.Person);

            firstNameTBox.Text = viewModel.FirstName;
            lastNameTBox.Text = viewModel.LastName;
            countryTBox.Text = viewModel.Country;
            companyTBox.Text = viewModel.Company;
            phoneTBox.Text = viewModel.Phone;
            loginTBox.Text = viewModel.Password.Login;
        }

        private void UserAccountForm_FormClosing(object sender, FormClosingEventArgs e)
            => (_personService as IDisposable).Dispose();

        private bool ValidateModel(UpdatePersonViewModel viewModel)
        {
            var results = new List<ValidationResult>();
            var isValid = Validator.TryValidateObject(viewModel, new ValidationContext(viewModel), results, true) &
            Validator.TryValidateObject(viewModel.Password, new ValidationContext(viewModel.Password), results, true);

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

        private void FirstNameTBox_TextChanged(object sender, EventArgs e)
            => errorFirstNameLabel.Visible = string.IsNullOrEmpty((sender as TextBox).Text);

        private void LastNameTBox_TextChanged(object sender, EventArgs e)
            => errorLastNameLabel.Visible = string.IsNullOrEmpty((sender as TextBox).Text);

        private void PhoneTBox_TextChanged(object sender, EventArgs e)
            => errorPhoneLabel.Visible = string.IsNullOrEmpty((sender as TextBox).Text);

        private void LoginTBox_TextChanged(object sender, EventArgs e)
            => errorLoginLabel.Visible = string.IsNullOrEmpty((sender as TextBox).Text);
    }
}
