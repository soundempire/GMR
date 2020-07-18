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
    public partial class CreateUserAccountForm : Form
    {
        private readonly IPersonService _personService;

        private readonly IPotentialLoginService _potentialLoginService;

        private readonly ILanguagesService _languagesService;

        private TextBox[] _requaredTextBoxes;

        private Label[] _errorLabels;

        public CreateUserAccountForm(IPersonService personService, IPotentialLoginService potentialLoginService, ILanguagesService languagesService)
        {
            InitializeComponent();

            _personService = personService;
            _potentialLoginService = potentialLoginService;
            _languagesService = languagesService;
        }

        private async void CreateUserAccountForm_Load(object sender, EventArgs e)
        {
            languagesCBox.DisplayMember = nameof(LanguageViewModel.Name);
            languagesCBox.DataSource = Mapper.Map<IEnumerable<LanguageModel>, IEnumerable<LanguageViewModel>>(await _languagesService.GetLanguages()).ToArray();

            _requaredTextBoxes = userProfilePanel.Controls.OfType<TextBox>().Except(new[] { countryTBox, companyTBox }).ToArray();
            _errorLabels = userProfilePanel.Controls.OfType<Label>().Where(_ => _.Name.StartsWith("error")).ToArray();
        }

        private void CreateUserAccountForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            (_personService as IDisposable)?.Dispose();
            (_potentialLoginService as IDisposable)?.Dispose();
        }

        private async void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            var viewModel = new CreatePersonViewModel()
            {
                FirstName = firstNameTBox.Text,
                LastName = lastNameTBox.Text,
                Country = countryTBox.Text,
                Company = companyTBox.Text,
                Phone = phoneTBox.Text,
                Language = (LanguageViewModel)languagesCBox.SelectedItem,
                Password = new CreatePasswordViewModel()
            };
            
            viewModel.Password.Login = loginTBox.Text;
            viewModel.Password.Value = passwordTBox.Text;
            viewModel.Password.ConfirmValue = confirmPasswordTBox.Text;
            viewModel.Password.LastUpdated = DateTime.Now;

            if (ValidateModel(viewModel, out var validationErrors))
            {
                if (await _potentialLoginService.IsLoginExists(viewModel.Password.Login))
                {
                    MessageBox.Show("Вводимый логин уже существует в системе.", "Ошибочный ввод", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    loginTBox.Focus();
                    return;
                }

                var person = Mapper.Map<CreatePersonViewModel, PersonModel>(viewModel);
                await _personService.AddPersonAsync(person);

                DialogResult = DialogResult.OK;
            }
            else
            {
                StringBuilder errors = new StringBuilder();
                validationErrors.ForEach(_ => errors.AppendLine(_.ErrorMessage));
                MessageBox.Show($"Некорректно заполнены поля ввода.\nСписок ошибок:\n{errors.ToString()}", "Ошибочный ввод", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private bool ValidateModel(CreatePersonViewModel viewModel, out List<ValidationResult> validationErrors)
        {
            validationErrors = new List<ValidationResult>();
            return Validator.TryValidateObject(viewModel, new ValidationContext(viewModel), validationErrors, true) &
                          Validator.TryValidateObject(viewModel.Password, new ValidationContext(viewModel.Password), validationErrors, true);
        }

        private void FirstNameTBox_TextChanged(object sender, EventArgs e)
        {
            RequaredAndTextLengthValidation((sender as TextBox).Text, "Введите имя", lengthLimit: 50, errorFirstNameLabel);
            UpdateCreateButtonEnabledState();
        }

        private void LastNameTBox_TextChanged(object sender, EventArgs e)
        {
            RequaredAndTextLengthValidation((sender as TextBox).Text, "Введите фамилию", lengthLimit: 50, errorLastNameLabel);
            UpdateCreateButtonEnabledState();
        }

        private void PhoneTBox_TextChanged(object sender, EventArgs e)
        {
            RequaredAndTextLengthValidation((sender as TextBox).Text, "Введите номер телефона", lengthLimit: 18, errorPhoneLabel);
            UpdateCreateButtonEnabledState();
        }

        private void LoginTBox_TextChanged(object sender, EventArgs e)
        {
            errorLoginLabel.Visible = string.IsNullOrEmpty((sender as TextBox).Text);
            UpdateCreateButtonEnabledState();
        }

        private void PasswordTBox_TextChanged(object sender, EventArgs e)
        {
            var newPasswordText = (sender as TextBox).Text;
            errorPasswordLabel.Visible = string.IsNullOrWhiteSpace(newPasswordText);
            if (!errorPasswordLabel.Visible && !string.IsNullOrEmpty(confirmPasswordTBox.Text))
            {
                errorConfirmPasswordLabel.Text = "Неверно продублирован пароль";
                errorConfirmPasswordLabel.Visible = !string.Equals(newPasswordText, confirmPasswordTBox.Text);
            }
            UpdateCreateButtonEnabledState();
        }

        private void ConfirmPasswordTBox_TextChanged(object sender, EventArgs e)
        {
            var confirmPasswordText = (sender as TextBox).Text;

            if (string.IsNullOrWhiteSpace(confirmPasswordText))
            {
                errorConfirmPasswordLabel.Visible = true;
                errorConfirmPasswordLabel.Text = "Продублируйте пароль";
            }
            else if (!string.Equals(passwordTBox.Text, confirmPasswordText))
            {
                errorConfirmPasswordLabel.Visible = true;
                errorConfirmPasswordLabel.Text = "Неверно продублирован пароль";
            }
            else
            {
                errorConfirmPasswordLabel.Visible = false;
                errorConfirmPasswordLabel.Text = string.Empty;
            }

            UpdateCreateButtonEnabledState();
        }

        private void RequaredAndTextLengthValidation(string text, string requaredErrorText, int lengthLimit, Label errorLabel)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                errorLabel.Text = requaredErrorText;
                errorLabel.Visible = true;
            }
            else if (text.Length > lengthLimit)
            {
                errorLabel.Text = $"Допустимая длина не более {lengthLimit.ToString()} символов";
                errorLabel.Visible = true;
            }
            else
            {
                errorLabel.Text = string.Empty;
                errorLabel.Visible = false;
            }
        }

        private void UpdateCreateButtonEnabledState()
            => createAccountBtn.Enabled = !_errorLabels.Any(_ => _.Visible) && !_requaredTextBoxes.Any(_ => string.IsNullOrWhiteSpace(_.Text));

        private void PhoneTBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                && (e.KeyChar != '+') && (e.KeyChar != '-') && (e.KeyChar != '(') && (e.KeyChar != ')'))
                e.Handled = true;

            if ((e.KeyChar == '+') && ((sender as TextBox).Text.IndexOf('+') > -1) ||
                (e.KeyChar == '(') && ((sender as TextBox).Text.IndexOf('(') > -1) ||
                (e.KeyChar == ')') && ((sender as TextBox).Text.IndexOf(')') > -1))
                e.Handled = true;
        }
    }
}
