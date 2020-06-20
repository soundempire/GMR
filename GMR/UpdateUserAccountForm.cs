﻿using GMR.BLL;
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
    public partial class UpdateUserAccountForm : Form
    {
        private readonly IPersonService _personService;

        private readonly IPotentialLoginService _potentialLoginService;

        private readonly ILanguagesService _languagesService;

        private List<TextBox> _passwordInputTextBoxes;

        private Label[] _errorLabels;

        private List<Label> _errorPasswordLabels;

        public UpdateUserAccountForm(IPersonService personService, IPotentialLoginService potentialLoginService, ILanguagesService languagesService)
        {
            InitializeComponent();

            _personService = personService;
            _potentialLoginService = potentialLoginService;
            _languagesService = languagesService;
        }

        private async void UserAccountForm_Load(object sender, EventArgs e)
        {
            _passwordInputTextBoxes = passwordPanel.Controls.OfType<TextBox>().ToList();

            Func<Label, bool> errorLambda = _ => _.Name.StartsWith("error");
            _errorPasswordLabels = passwordPanel.Controls.OfType<Label>().Where(errorLambda).ToList();
            _errorLabels = userProfilePanel.Controls.OfType<Label>().Where(errorLambda)
                           .Union(_errorPasswordLabels)
                           .ToArray();

            languagesCBox.DisplayMember = nameof(LanguageViewModel.Name);
            languagesCBox.DataSource = Mapper.Map<IEnumerable<LanguageModel>, IEnumerable<LanguageViewModel>>(await _languagesService.GetLanguages()).ToArray();

            SetCurrentUserValues();
        }

        private void changeProfileBtn_Click(object sender, EventArgs e) => SwitchControls(true);

        private void cancelBtn_Click(object sender, EventArgs e) => RefreshData();

        private async void SaveBtn_Click(object sender, EventArgs e)
        {
            var viewModel = Mapper.Map<PersonModel, UpdatePersonViewModel>(Session.Person);
            viewModel.FirstName = firstNameTBox.Text;
            viewModel.LastName = lastNameTBox.Text;
            viewModel.Country = countryTBox.Text;
            viewModel.Company = companyTBox.Text;
            viewModel.Phone = phoneTBox.Text;
            viewModel.Password.Login = loginTBox.Text;
            viewModel.Language = (LanguageViewModel)languagesCBox.SelectedItem;

            if (updatePasswordChBox.Checked)
            {
                viewModel.Password.OldValue = oldPasswordTBox.Text;
                viewModel.Password.NewValue = newPasswordTBox.Text;
                viewModel.Password.ConfirmValue = confirmPasswordTBox.Text;
            }
            else
            {
                viewModel.Password.OldValue = viewModel.Password.Value;
                viewModel.Password.NewValue = viewModel.Password.Value;
                viewModel.Password.ConfirmValue = viewModel.Password.Value;
            }

            if (ValidateModel(viewModel, out var validationErrors))
            {
                if (!Session.Person.Password.Login.Equals(viewModel.Password.Login) && await _potentialLoginService.IsLoginExists(viewModel.Password.Login))
                {
                    MessageBox.Show("Вводимый логин уже существует в системе.", "Ошибочный ввод", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    loginTBox.Focus();
                    return;
                }

                if (viewModel.Password.Value != viewModel.Password.NewValue)
                    viewModel.Password.LastUpdated = DateTime.Now;

                var person = Mapper.Map<UpdatePersonViewModel, PersonModel>(viewModel);
                await _personService.UpdatePersonAsync(person);
                Session.Person = person;
                DialogResult = DialogResult.OK;
            }
            else
            {
                StringBuilder errors = new StringBuilder();
                validationErrors.ForEach(_ => errors.AppendLine(_.ErrorMessage));
                MessageBox.Show($"Некорректно заполнены поля ввода.\nСписок ошибок:\n{errors.ToString()}", "Ошибочный ввод", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RefreshData();
            }
        }

        private void SwitchControls(bool available)
        {
            userProfilePanel.Enabled = available;
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
            languagesCBox.Text = viewModel.Language.Name;

            _passwordInputTextBoxes.ForEach(_ => _.Clear());
            _errorPasswordLabels.ForEach(_ => _.Visible = false);
        }

        private void UserAccountForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            (_personService as IDisposable).Dispose();
            (_potentialLoginService as IDisposable).Dispose();
        }

        private bool ValidateModel(UpdatePersonViewModel viewModel, out List<ValidationResult> validationErrors)
        {
            validationErrors = new List<ValidationResult>();
            return Validator.TryValidateObject(viewModel, new ValidationContext(viewModel), validationErrors, true) &
                          Validator.TryValidateObject(viewModel.Password, new ValidationContext(viewModel.Password), validationErrors, true);
        }

        private void UpdatePasswordChBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordPanel.Enabled = updatePasswordChBox.Checked;
            if (!updatePasswordChBox.Checked)
            {
                _passwordInputTextBoxes.ForEach(_ => _.Clear());
                _errorPasswordLabels.ForEach(_ => _.Visible = false);
            }

            UpdateSaveButtonEnabledState();
        }

        private void RefreshData()
        {
            SwitchControls(false);
            SetCurrentUserValues();
        }

        private void FirstNameTBox_TextChanged(object sender, EventArgs e)
        {
            RequaredAndTextLengthValidation((sender as TextBox).Text, "Введите имя", lengthLimit: 50, errorFirstNameLabel);
            UpdateSaveButtonEnabledState();
        }

        private void LastNameTBox_TextChanged(object sender, EventArgs e)
        {
            RequaredAndTextLengthValidation((sender as TextBox).Text, "Введите фамилию", lengthLimit: 50, errorLastNameLabel);
            UpdateSaveButtonEnabledState();
        }

        private void PhoneTBox_TextChanged(object sender, EventArgs e)
        {
            RequaredAndTextLengthValidation((sender as TextBox).Text, "Введите номер телефона", lengthLimit: 12, errorPhoneLabel);
            UpdateSaveButtonEnabledState();
        }

        private void LoginTBox_TextChanged(object sender, EventArgs e)
        {
            errorLoginLabel.Visible = string.IsNullOrEmpty((sender as TextBox).Text);
            UpdateSaveButtonEnabledState();
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

        private void OldPasswordTBox_TextChanged(object sender, EventArgs e)
        {
            if (updatePasswordChBox.Checked)
            {
                var oldPasswordText = (sender as TextBox).Text;
                if (string.IsNullOrWhiteSpace(oldPasswordText))
                {
                    errorOldPasswordLabel.Visible = true;
                    errorOldPasswordLabel.Text = "Введите текущий пароль";
                }
                else if (!string.Equals(Session.Person.Password.Value, oldPasswordText))
                {
                    errorOldPasswordLabel.Visible = true;
                    errorOldPasswordLabel.Text = "Неверный текущий пароль";
                }
                else
                {
                    errorOldPasswordLabel.Visible = false;
                    errorOldPasswordLabel.Text = string.Empty;
                }
                
                UpdateSaveButtonEnabledState();
            }
        }

        private void NewPasswordTBox_TextChanged(object sender, EventArgs e)
        {
            if (updatePasswordChBox.Checked)
            {
                errorPasswordLabel.Visible = string.IsNullOrWhiteSpace((sender as TextBox).Text);
                if (!errorPasswordLabel.Visible && !string.IsNullOrEmpty(confirmPasswordTBox.Text))
                {
                    errorConfirmPasswordLabel.Visible = !string.Equals(newPasswordTBox.Text, confirmPasswordTBox.Text);
                }
                UpdateSaveButtonEnabledState();
            }
        }

        private void ConfirmPasswordTBox_TextChanged(object sender, EventArgs e)
        {
            if (updatePasswordChBox.Checked)
            {
                var confirmPasswordText = (sender as TextBox).Text;
                if (string.IsNullOrWhiteSpace(confirmPasswordText))
                {
                    errorConfirmPasswordLabel.Visible = true;
                    errorConfirmPasswordLabel.Text = "Продублируйте новый пароль";
                }
                else if (!string.Equals(newPasswordTBox.Text, confirmPasswordText))
                {
                    errorConfirmPasswordLabel.Visible = true;
                    errorConfirmPasswordLabel.Text = "Неверно продублирован новый пароль";
                }
                else
                {
                    errorConfirmPasswordLabel.Visible = false;
                    errorConfirmPasswordLabel.Text = string.Empty;
                }

                UpdateSaveButtonEnabledState();
            }
        }

        private void UpdateSaveButtonEnabledState()
        {
            saveBtn.Enabled = !_errorLabels.Any(_ => _.Visible) 
                              && (updatePasswordChBox.Checked ? !_passwordInputTextBoxes.Any(_ => string.IsNullOrWhiteSpace(_.Text)) : true);
        } 
    }
}