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
    public partial class ResetPasswordForm : Form
    {
        private readonly IPersonService _personService;

        private TextBox[] _requaredTextBoxes;

        private Label[] _errorLabels;

        public ResetPasswordForm(IPersonService personService)
        {
            InitializeComponent();

            _personService = personService;
        }

        private void ResetPasswordForm_Load(object sender, EventArgs e)
        {
            _requaredTextBoxes = Controls.OfType<TextBox>().ToArray();
            _errorLabels = Controls.OfType<Label>().Where(_ => _.Name.StartsWith("error")).ToArray();
        }

        private void ResetPasswordForm_FormClosing(object sender, FormClosingEventArgs e)
            => (_personService as IDisposable)?.Dispose();

        private void CloseBtn_Click(object sender, EventArgs e)
            => DialogResult = DialogResult.Cancel;

        private async void ResetBtn_Click(object sender, EventArgs e)
        {
            var persons = await _personService.GetPersonsAsync(nameof(PersonModel.Password).ToLower());
            var person = persons.FirstOrDefault(_ => _.Password.Login == loginTBox.Text);

            if (person == null)
            {
                MessageBox.Show($"Логин {loginTBox.Text} не существует в системе", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var passwordViewModel = new ResetPasswordViewModel()
            {
                ID = person.Password.ID,
                Login = loginTBox.Text,
                Value = passwordTBox.Text,
                ConfirmValue = confirmPasswordTBox.Text,
                LastUpdated = DateTime.Now
            };

            if (ValidateModel(passwordViewModel, out var validationErrors))
            {
                person.Password = Mapper.Map<ResetPasswordViewModel, PasswordModel>(passwordViewModel);
                await _personService.UpdatePersonAsync(person);
                DialogResult = DialogResult.OK;
            }
            else
            {
                StringBuilder errors = new StringBuilder();
                validationErrors.ForEach(_ => errors.AppendLine(_.ErrorMessage));
                MessageBox.Show($"Некорректно заполнены поля ввода.\nСписок ошибок:\n{errors.ToString()}", "Ошибочный ввод", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginTBox_TextChanged(object sender, EventArgs e)
        {
            errorLoginLabel.Visible = string.IsNullOrEmpty((sender as TextBox).Text);
            UpdateResetButtonEnabledState();
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
            UpdateResetButtonEnabledState();
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

            UpdateResetButtonEnabledState();
        }

        private void UpdateResetButtonEnabledState()
            => resetBtn.Enabled = !_errorLabels.Any(_ => _.Visible) && !_requaredTextBoxes.Any(_ => string.IsNullOrWhiteSpace(_.Text));

        private bool ValidateModel(ResetPasswordViewModel viewModel, out List<ValidationResult> validationErrors)
        {
            validationErrors = new List<ValidationResult>();
            return Validator.TryValidateObject(viewModel, new ValidationContext(viewModel), validationErrors, true);
        }
    }
}
