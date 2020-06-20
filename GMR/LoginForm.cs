using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMR.Animation.Animation;
using GMR;
using GMR.BLL;
using Context = GMR.ApplicationContext;

namespace GMR
{
    public partial class LoginForm : Form
    {
        private readonly IAuthorizationService _authorizationService;

        private Point LastPosition { get; set; }

        public LoginForm(IAuthorizationService authorizationService)
        {
            InitializeComponent();

            Animator.Start();

            _authorizationService = authorizationService;
        }

        #region LoginForm EventHandlers

        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPosition.X;
                this.Top += e.Y - LastPosition.Y;
            }
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e) => LastPosition = new Point(e.X, e.Y);

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab || e.KeyCode == Keys.Enter)
            {
                if (loginTB.TextInput.Trim().Length == 0)
                {
                    passwordErrorLabel.Text = "Введите логин.";
                    loginTB.Focus();
                }
                else
                {
                    passwordErrorLabel.Text = "";
                    passwordTB.Focus();
                }
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e) => (_authorizationService as IDisposable).Dispose();

        #endregion

        #region DisplayPasswordPB EventHandlers

        private void DisplayPasswordPB_MouseDown(object sender, MouseEventArgs e)
        {
            if (!string.IsNullOrEmpty(passwordTB.tbInput.Text) && passwordTB.tbInput.UseSystemPasswordChar)
            {
                passwordTB.tbInput.UseSystemPasswordChar = false;
                showPasswordPB.Image = Properties.Resources.hidePassword;
            }
        }

        private void DisplayPasswordPB_MouseUp(object sender, MouseEventArgs e)
        {
            if (!string.IsNullOrEmpty(passwordTB.tbInput.Text) && !passwordTB.tbInput.UseSystemPasswordChar)
            {
                passwordTB.tbInput.UseSystemPasswordChar = true;
                showPasswordPB.Image = Properties.Resources.showPassword;
            }
        }

        #endregion

        #region Control buttons EventHandlers

        private async void OkBtn_Click(object sender, EventArgs e)
        {
            SwitchControls(false);

            if (CheckRequiredFields())
            {
                SwitchLoader(true);

                var person = await AuthenticateUserAsync();

                SwitchLoader(false);
                SwitchControls(true);

                if (person != null)
                {
                    Session.Person = person;

                    Context.SetExecutableForm(DIContainer.Resolve<MainForm>());
                    Context.ShowExecutableForm();

                    Close();
                }
                else
                {
                    passwordErrorLabel.Text = "Неверный логин или пароль";
                    passwordTB.Focus();
                }
            }
            else
            {
                SwitchControls(true);
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e) => Close();

        #endregion

        private bool CheckRequiredFields()
        {
            loginErrorLabel.Text = passwordErrorLabel.Text = string.Empty;

            if (loginTB.TextInput.Length == 0)
                loginErrorLabel.Text = "Введите логин";

            if (passwordTB.TextInput.Length == 0)
                passwordErrorLabel.Text = "Введите пароль";

            return string.IsNullOrEmpty(loginErrorLabel.Text) && string.IsNullOrEmpty(passwordErrorLabel.Text);
        }

        private async Task<PersonModel> AuthenticateUserAsync()
        {
            var login = loginTB.TextInput;
            var password = passwordTB.TextInput;

            /*
             Used Task.Run(..) here because here is the first call to DB with context (create connection, etg.)
             and it will take much time and will lock main UI thread, even though the call is asynchronous
             */
            return await Task.Run(() => _authorizationService.AuthorizeAsync(login, password));
        }

        private void SwitchLoader(bool visible) => loadingPictureBox.Visible = visible;

        private void SwitchControls(bool enabled)
        {
            okBtn.Enabled = enabled;
            showPasswordPB.Enabled = enabled;
            loginTB.Enabled = enabled;
            passwordTB.Enabled = enabled;
        }

        private void CreateAccountLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            => DIContainer.Resolve<CreateUserAccountForm>().ShowDialog();

        private void ForgotPasswordLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //TODO: think about it
        }
    }
}
