using GMR.Controls.ServiceClass;
using System.Drawing;

namespace GMR
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.passwordErrorLabel = new System.Windows.Forms.Label();
            this.closeBtn = new GMR.Controls.GMRButton();
            this.okBtn = new GMR.Controls.GMRButton();
            this.passwordTB = new GMR.Animation.Controls.GMRTextBox();
            this.loginTB = new GMR.Animation.Controls.GMRTextBox();
            this.roundingButtonsComponent1 = new GMR.Animation.Components.RoundingButtonsComponent(this.components);
            this.showPasswordPB = new System.Windows.Forms.PictureBox();
            this.loadingPictureBox = new System.Windows.Forms.PictureBox();
            this.loginErrorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.showPasswordPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordErrorLabel
            // 
            this.passwordErrorLabel.AutoSize = true;
            this.passwordErrorLabel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.passwordErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.passwordErrorLabel.Location = new System.Drawing.Point(14, 130);
            this.passwordErrorLabel.Name = "passwordErrorLabel";
            this.passwordErrorLabel.Size = new System.Drawing.Size(0, 19);
            this.passwordErrorLabel.TabIndex = 10;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(204)))), ((int)(((byte)(211)))));
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.closeBtn.Location = new System.Drawing.Point(295, 1);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Rounding = 100;
            this.closeBtn.RoundingEnabled = true;
            this.closeBtn.Size = new System.Drawing.Size(34, 34);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.Text = "x";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(204)))), ((int)(((byte)(211)))));
            this.okBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okBtn.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.okBtn.Location = new System.Drawing.Point(147, 151);
            this.okBtn.Name = "okBtn";
            this.okBtn.Rounding = 100;
            this.okBtn.RoundingEnabled = true;
            this.okBtn.Size = new System.Drawing.Size(170, 33);
            this.okBtn.TabIndex = 3;
            this.okBtn.Text = "Ок";
            this.okBtn.UseVisualStyleBackColor = false;
            this.okBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // passwordTB
            // 
            this.passwordTB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.passwordTB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.passwordTB.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.passwordTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTB.Font = new System.Drawing.Font("Arial", 12.25F);
            this.passwordTB.FontTextPreview = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTB.ForeColor = System.Drawing.Color.Black;
            this.passwordTB.Location = new System.Drawing.Point(16, 84);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Rounding = 100;
            this.passwordTB.RoundingEnabled = false;
            this.passwordTB.Size = new System.Drawing.Size(256, 46);
            this.passwordTB.TabIndex = 2;
            this.passwordTB.TextInput = "";
            this.passwordTB.TextPreview = "Пароль";
            this.passwordTB.UseSystemPasswordChar = true;
            // 
            // loginTB
            // 
            this.loginTB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.loginTB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.loginTB.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.loginTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginTB.Font = new System.Drawing.Font("Arial", 12.25F);
            this.loginTB.FontTextPreview = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTB.ForeColor = System.Drawing.Color.Black;
            this.loginTB.Location = new System.Drawing.Point(16, 22);
            this.loginTB.Name = "loginTB";
            this.loginTB.Rounding = 100;
            this.loginTB.RoundingEnabled = true;
            this.loginTB.Size = new System.Drawing.Size(256, 46);
            this.loginTB.TabIndex = 1;
            this.loginTB.TextInput = "";
            this.loginTB.TextPreview = "Имя пользователя";
            this.loginTB.UseSystemPasswordChar = false;
            // 
            // roundingButtonsComponent1
            // 
            this.roundingButtonsComponent1.RoundingEnabled = false;
            this.roundingButtonsComponent1.TargetForm = this;
            // 
            // showPasswordPB
            // 
            this.showPasswordPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPasswordPB.Image = global::GMR.Properties.Resources.showPassword;
            this.showPasswordPB.Location = new System.Drawing.Point(284, 96);
            this.showPasswordPB.MinimumSize = new System.Drawing.Size(30, 30);
            this.showPasswordPB.Name = "showPasswordPB";
            this.showPasswordPB.Size = new System.Drawing.Size(30, 30);
            this.showPasswordPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.showPasswordPB.TabIndex = 9;
            this.showPasswordPB.TabStop = false;
            this.showPasswordPB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DisplayPasswordPB_MouseDown);
            this.showPasswordPB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DisplayPasswordPB_MouseUp);
            // 
            // loadingPictureBox
            // 
            this.loadingPictureBox.Image = global::GMR.Properties.Resources.load;
            this.loadingPictureBox.Location = new System.Drawing.Point(36, 137);
            this.loadingPictureBox.Name = "loadingPictureBox";
            this.loadingPictureBox.Size = new System.Drawing.Size(90, 57);
            this.loadingPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loadingPictureBox.TabIndex = 11;
            this.loadingPictureBox.TabStop = false;
            this.loadingPictureBox.Visible = false;
            // 
            // loginErrorLabel
            // 
            this.loginErrorLabel.AutoSize = true;
            this.loginErrorLabel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.loginErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.loginErrorLabel.Location = new System.Drawing.Point(14, 68);
            this.loginErrorLabel.Name = "loginErrorLabel";
            this.loginErrorLabel.Size = new System.Drawing.Size(0, 19);
            this.loginErrorLabel.TabIndex = 12;
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(330, 195);
            this.Controls.Add(this.loginErrorLabel);
            this.Controls.Add(this.loadingPictureBox);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.passwordErrorLabel);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.showPasswordPB);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Идентификация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginForm_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.showPasswordPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox showPasswordPB;
        private GMR.Animation.Components.RoundingButtonsComponent roundingButtonsComponent1;
        private GMR.Animation.Controls.GMRTextBox passwordTB;
        private GMR.Animation.Controls.GMRTextBox loginTB;
        private GMR.Controls.GMRButton okBtn;
        private System.Windows.Forms.Label passwordErrorLabel;
        private Controls.GMRButton closeBtn;
        private System.Windows.Forms.PictureBox loadingPictureBox;
        private System.Windows.Forms.Label loginErrorLabel;
    }
}