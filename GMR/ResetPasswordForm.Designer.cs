namespace GMR
{
    partial class ResetPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPasswordForm));
            this.errorPasswordLabel = new System.Windows.Forms.Label();
            this.passwordTBox = new System.Windows.Forms.TextBox();
            this.errorConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.confirmPasswordTBox = new System.Windows.Forms.TextBox();
            this.errorLoginLabel = new System.Windows.Forms.Label();
            this.loginTBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.closeBtn = new GMR.Controls.GMRButton();
            this.resetBtn = new GMR.Controls.GMRButton();
            this.SuspendLayout();
            // 
            // errorPasswordLabel
            // 
            this.errorPasswordLabel.AutoSize = true;
            this.errorPasswordLabel.ForeColor = System.Drawing.Color.Red;
            this.errorPasswordLabel.Location = new System.Drawing.Point(139, 111);
            this.errorPasswordLabel.Name = "errorPasswordLabel";
            this.errorPasswordLabel.Size = new System.Drawing.Size(88, 13);
            this.errorPasswordLabel.TabIndex = 33;
            this.errorPasswordLabel.Text = "Введите пароль";
            this.errorPasswordLabel.Visible = false;
            // 
            // passwordTBox
            // 
            this.passwordTBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTBox.Location = new System.Drawing.Point(139, 85);
            this.passwordTBox.Name = "passwordTBox";
            this.passwordTBox.Size = new System.Drawing.Size(226, 23);
            this.passwordTBox.TabIndex = 30;
            this.passwordTBox.UseSystemPasswordChar = true;
            this.passwordTBox.TextChanged += new System.EventHandler(this.PasswordTBox_TextChanged);
            // 
            // errorConfirmPasswordLabel
            // 
            this.errorConfirmPasswordLabel.AutoSize = true;
            this.errorConfirmPasswordLabel.ForeColor = System.Drawing.Color.Red;
            this.errorConfirmPasswordLabel.Location = new System.Drawing.Point(139, 163);
            this.errorConfirmPasswordLabel.Name = "errorConfirmPasswordLabel";
            this.errorConfirmPasswordLabel.Size = new System.Drawing.Size(0, 13);
            this.errorConfirmPasswordLabel.TabIndex = 32;
            this.errorConfirmPasswordLabel.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(31, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Новый пароль*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(31, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "Подтвердить*";
            // 
            // confirmPasswordTBox
            // 
            this.confirmPasswordTBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmPasswordTBox.Location = new System.Drawing.Point(139, 137);
            this.confirmPasswordTBox.Name = "confirmPasswordTBox";
            this.confirmPasswordTBox.Size = new System.Drawing.Size(226, 23);
            this.confirmPasswordTBox.TabIndex = 31;
            this.confirmPasswordTBox.UseSystemPasswordChar = true;
            this.confirmPasswordTBox.TextChanged += new System.EventHandler(this.ConfirmPasswordTBox_TextChanged);
            // 
            // errorLoginLabel
            // 
            this.errorLoginLabel.AutoSize = true;
            this.errorLoginLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLoginLabel.Location = new System.Drawing.Point(139, 59);
            this.errorLoginLabel.Name = "errorLoginLabel";
            this.errorLoginLabel.Size = new System.Drawing.Size(81, 13);
            this.errorLoginLabel.TabIndex = 27;
            this.errorLoginLabel.Text = "Введите логин";
            this.errorLoginLabel.Visible = false;
            // 
            // loginTBox
            // 
            this.loginTBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTBox.Location = new System.Drawing.Point(139, 33);
            this.loginTBox.Name = "loginTBox";
            this.loginTBox.Size = new System.Drawing.Size(226, 23);
            this.loginTBox.TabIndex = 26;
            this.loginTBox.TextChanged += new System.EventHandler(this.LoginTBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(31, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "Логин*";
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(204)))), ((int)(((byte)(211)))));
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Font = new System.Drawing.Font("Tahoma", 11F);
            this.closeBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.closeBtn.Location = new System.Drawing.Point(117, 192);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Rounding = 80;
            this.closeBtn.RoundingEnabled = true;
            this.closeBtn.Size = new System.Drawing.Size(110, 26);
            this.closeBtn.TabIndex = 34;
            this.closeBtn.Text = "Отмена";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(204)))), ((int)(((byte)(211)))));
            this.resetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetBtn.Enabled = false;
            this.resetBtn.Font = new System.Drawing.Font("Tahoma", 11F);
            this.resetBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.resetBtn.Location = new System.Drawing.Point(255, 192);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(2);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Rounding = 80;
            this.resetBtn.RoundingEnabled = true;
            this.resetBtn.Size = new System.Drawing.Size(110, 26);
            this.resetBtn.TabIndex = 35;
            this.resetBtn.Text = "Обновить";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // ResetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 248);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.errorPasswordLabel);
            this.Controls.Add(this.passwordTBox);
            this.Controls.Add(this.errorConfirmPasswordLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.confirmPasswordTBox);
            this.Controls.Add(this.errorLoginLabel);
            this.Controls.Add(this.loginTBox);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResetPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обновить пароль";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ResetPasswordForm_FormClosing);
            this.Load += new System.EventHandler(this.ResetPasswordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label errorPasswordLabel;
        private System.Windows.Forms.TextBox passwordTBox;
        private System.Windows.Forms.Label errorConfirmPasswordLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox confirmPasswordTBox;
        private System.Windows.Forms.Label errorLoginLabel;
        private System.Windows.Forms.TextBox loginTBox;
        private System.Windows.Forms.Label label9;
        private Controls.GMRButton closeBtn;
        private Controls.GMRButton resetBtn;
    }
}