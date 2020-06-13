namespace GMR
{
    partial class UserAccountForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.firstNameTBox = new System.Windows.Forms.TextBox();
            this.lastNameTBox = new System.Windows.Forms.TextBox();
            this.countryTBox = new System.Windows.Forms.TextBox();
            this.companyTBox = new System.Windows.Forms.TextBox();
            this.phoneTBox = new System.Windows.Forms.TextBox();
            this.userProfilePanel = new System.Windows.Forms.Panel();
            this.languagesCBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.errorLoginLabel = new System.Windows.Forms.Label();
            this.errorPhoneLabel = new System.Windows.Forms.Label();
            this.errorLastNameLabel = new System.Windows.Forms.Label();
            this.errorFirstNameLabel = new System.Windows.Forms.Label();
            this.loginTBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.confirmPasswordTBox = new System.Windows.Forms.TextBox();
            this.newPasswordTBox = new System.Windows.Forms.TextBox();
            this.oldPasswordTBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.changeProfileBtn = new System.Windows.Forms.Button();
            this.changeProfilePanel = new System.Windows.Forms.Panel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.errorOldPasswordLabel = new System.Windows.Forms.Label();
            this.errorConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.passwordPanel = new System.Windows.Forms.Panel();
            this.updatePasswordChBox = new System.Windows.Forms.CheckBox();
            this.userProfilePanel.SuspendLayout();
            this.changeProfilePanel.SuspendLayout();
            this.passwordPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(18, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(18, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Страна";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(18, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Компания";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(18, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Телефон*";
            // 
            // firstNameTBox
            // 
            this.firstNameTBox.Enabled = false;
            this.firstNameTBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameTBox.Location = new System.Drawing.Point(126, 17);
            this.firstNameTBox.Name = "firstNameTBox";
            this.firstNameTBox.Size = new System.Drawing.Size(196, 23);
            this.firstNameTBox.TabIndex = 5;
            this.firstNameTBox.TextChanged += new System.EventHandler(this.FirstNameTBox_TextChanged);
            // 
            // lastNameTBox
            // 
            this.lastNameTBox.Enabled = false;
            this.lastNameTBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameTBox.Location = new System.Drawing.Point(126, 64);
            this.lastNameTBox.Name = "lastNameTBox";
            this.lastNameTBox.Size = new System.Drawing.Size(196, 23);
            this.lastNameTBox.TabIndex = 6;
            this.lastNameTBox.TextChanged += new System.EventHandler(this.LastNameTBox_TextChanged);
            // 
            // countryTBox
            // 
            this.countryTBox.Enabled = false;
            this.countryTBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countryTBox.Location = new System.Drawing.Point(126, 113);
            this.countryTBox.Name = "countryTBox";
            this.countryTBox.Size = new System.Drawing.Size(196, 23);
            this.countryTBox.TabIndex = 7;
            // 
            // companyTBox
            // 
            this.companyTBox.Enabled = false;
            this.companyTBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.companyTBox.Location = new System.Drawing.Point(126, 159);
            this.companyTBox.Name = "companyTBox";
            this.companyTBox.Size = new System.Drawing.Size(196, 23);
            this.companyTBox.TabIndex = 8;
            // 
            // phoneTBox
            // 
            this.phoneTBox.Enabled = false;
            this.phoneTBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneTBox.Location = new System.Drawing.Point(126, 205);
            this.phoneTBox.Name = "phoneTBox";
            this.phoneTBox.Size = new System.Drawing.Size(196, 23);
            this.phoneTBox.TabIndex = 9;
            this.phoneTBox.TextChanged += new System.EventHandler(this.PhoneTBox_TextChanged);
            // 
            // userProfilePanel
            // 
            this.userProfilePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userProfilePanel.Controls.Add(this.languagesCBox);
            this.userProfilePanel.Controls.Add(this.label10);
            this.userProfilePanel.Controls.Add(this.errorLoginLabel);
            this.userProfilePanel.Controls.Add(this.errorPhoneLabel);
            this.userProfilePanel.Controls.Add(this.errorLastNameLabel);
            this.userProfilePanel.Controls.Add(this.errorFirstNameLabel);
            this.userProfilePanel.Controls.Add(this.loginTBox);
            this.userProfilePanel.Controls.Add(this.label9);
            this.userProfilePanel.Controls.Add(this.companyTBox);
            this.userProfilePanel.Controls.Add(this.phoneTBox);
            this.userProfilePanel.Controls.Add(this.label1);
            this.userProfilePanel.Controls.Add(this.label2);
            this.userProfilePanel.Controls.Add(this.countryTBox);
            this.userProfilePanel.Controls.Add(this.label3);
            this.userProfilePanel.Controls.Add(this.lastNameTBox);
            this.userProfilePanel.Controls.Add(this.label4);
            this.userProfilePanel.Controls.Add(this.firstNameTBox);
            this.userProfilePanel.Controls.Add(this.label5);
            this.userProfilePanel.Location = new System.Drawing.Point(12, 12);
            this.userProfilePanel.Name = "userProfilePanel";
            this.userProfilePanel.Size = new System.Drawing.Size(345, 342);
            this.userProfilePanel.TabIndex = 10;
            // 
            // languagesCBox
            // 
            this.languagesCBox.FormattingEnabled = true;
            this.languagesCBox.Location = new System.Drawing.Point(126, 310);
            this.languagesCBox.Name = "languagesCBox";
            this.languagesCBox.Size = new System.Drawing.Size(196, 21);
            this.languagesCBox.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Язык";
            // 
            // errorLoginLabel
            // 
            this.errorLoginLabel.AutoSize = true;
            this.errorLoginLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLoginLabel.Location = new System.Drawing.Point(126, 283);
            this.errorLoginLabel.Name = "errorLoginLabel";
            this.errorLoginLabel.Size = new System.Drawing.Size(81, 13);
            this.errorLoginLabel.TabIndex = 16;
            this.errorLoginLabel.Text = "Введите логин";
            this.errorLoginLabel.Visible = false;
            // 
            // errorPhoneLabel
            // 
            this.errorPhoneLabel.AutoSize = true;
            this.errorPhoneLabel.ForeColor = System.Drawing.Color.Red;
            this.errorPhoneLabel.Location = new System.Drawing.Point(126, 231);
            this.errorPhoneLabel.Name = "errorPhoneLabel";
            this.errorPhoneLabel.Size = new System.Drawing.Size(95, 13);
            this.errorPhoneLabel.TabIndex = 16;
            this.errorPhoneLabel.Text = "Введите телефон";
            this.errorPhoneLabel.Visible = false;
            // 
            // errorLastNameLabel
            // 
            this.errorLastNameLabel.AutoSize = true;
            this.errorLastNameLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLastNameLabel.Location = new System.Drawing.Point(126, 90);
            this.errorLastNameLabel.Name = "errorLastNameLabel";
            this.errorLastNameLabel.Size = new System.Drawing.Size(100, 13);
            this.errorLastNameLabel.TabIndex = 16;
            this.errorLastNameLabel.Text = "Введите фамилию";
            this.errorLastNameLabel.Visible = false;
            // 
            // errorFirstNameLabel
            // 
            this.errorFirstNameLabel.AutoSize = true;
            this.errorFirstNameLabel.ForeColor = System.Drawing.Color.Red;
            this.errorFirstNameLabel.Location = new System.Drawing.Point(126, 44);
            this.errorFirstNameLabel.Name = "errorFirstNameLabel";
            this.errorFirstNameLabel.Size = new System.Drawing.Size(72, 13);
            this.errorFirstNameLabel.TabIndex = 16;
            this.errorFirstNameLabel.Text = "Введите имя";
            this.errorFirstNameLabel.Visible = false;
            // 
            // loginTBox
            // 
            this.loginTBox.Enabled = false;
            this.loginTBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTBox.Location = new System.Drawing.Point(126, 257);
            this.loginTBox.Name = "loginTBox";
            this.loginTBox.Size = new System.Drawing.Size(196, 23);
            this.loginTBox.TabIndex = 13;
            this.loginTBox.TextChanged += new System.EventHandler(this.LoginTBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(18, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Логин*";
            // 
            // confirmPasswordTBox
            // 
            this.confirmPasswordTBox.Enabled = false;
            this.confirmPasswordTBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmPasswordTBox.Location = new System.Drawing.Point(129, 102);
            this.confirmPasswordTBox.Name = "confirmPasswordTBox";
            this.confirmPasswordTBox.Size = new System.Drawing.Size(196, 23);
            this.confirmPasswordTBox.TabIndex = 15;
            // 
            // newPasswordTBox
            // 
            this.newPasswordTBox.Enabled = false;
            this.newPasswordTBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newPasswordTBox.Location = new System.Drawing.Point(129, 56);
            this.newPasswordTBox.Name = "newPasswordTBox";
            this.newPasswordTBox.Size = new System.Drawing.Size(196, 23);
            this.newPasswordTBox.TabIndex = 14;
            // 
            // oldPasswordTBox
            // 
            this.oldPasswordTBox.Enabled = false;
            this.oldPasswordTBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oldPasswordTBox.Location = new System.Drawing.Point(129, 8);
            this.oldPasswordTBox.Name = "oldPasswordTBox";
            this.oldPasswordTBox.Size = new System.Drawing.Size(196, 23);
            this.oldPasswordTBox.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(18, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Подтвердить";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(16, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Новый пароль";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(16, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Старый пароль";
            // 
            // changeProfileBtn
            // 
            this.changeProfileBtn.Location = new System.Drawing.Point(11, 558);
            this.changeProfileBtn.Name = "changeProfileBtn";
            this.changeProfileBtn.Size = new System.Drawing.Size(115, 39);
            this.changeProfileBtn.TabIndex = 11;
            this.changeProfileBtn.Text = "Изменить профиль";
            this.changeProfileBtn.UseVisualStyleBackColor = true;
            this.changeProfileBtn.Click += new System.EventHandler(this.changeProfileBtn_Click);
            // 
            // changeProfilePanel
            // 
            this.changeProfilePanel.Controls.Add(this.cancelBtn);
            this.changeProfilePanel.Controls.Add(this.saveBtn);
            this.changeProfilePanel.Location = new System.Drawing.Point(163, 558);
            this.changeProfilePanel.Name = "changeProfilePanel";
            this.changeProfilePanel.Size = new System.Drawing.Size(193, 39);
            this.changeProfilePanel.TabIndex = 12;
            this.changeProfilePanel.Visible = false;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(105, 8);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Отменить";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(13, 8);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // errorOldPasswordLabel
            // 
            this.errorOldPasswordLabel.AutoSize = true;
            this.errorOldPasswordLabel.ForeColor = System.Drawing.Color.Red;
            this.errorOldPasswordLabel.Location = new System.Drawing.Point(129, 34);
            this.errorOldPasswordLabel.Name = "errorOldPasswordLabel";
            this.errorOldPasswordLabel.Size = new System.Drawing.Size(144, 13);
            this.errorOldPasswordLabel.TabIndex = 16;
            this.errorOldPasswordLabel.Text = "Неверный текущий пароль";
            this.errorOldPasswordLabel.Visible = false;
            // 
            // errorConfirmPasswordLabel
            // 
            this.errorConfirmPasswordLabel.AutoSize = true;
            this.errorConfirmPasswordLabel.ForeColor = System.Drawing.Color.Red;
            this.errorConfirmPasswordLabel.Location = new System.Drawing.Point(129, 128);
            this.errorConfirmPasswordLabel.Name = "errorConfirmPasswordLabel";
            this.errorConfirmPasswordLabel.Size = new System.Drawing.Size(205, 13);
            this.errorConfirmPasswordLabel.TabIndex = 16;
            this.errorConfirmPasswordLabel.Text = "Неверно продублирован новый пароль";
            this.errorConfirmPasswordLabel.Visible = false;
            // 
            // passwordPanel
            // 
            this.passwordPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordPanel.Controls.Add(this.newPasswordTBox);
            this.passwordPanel.Controls.Add(this.errorConfirmPasswordLabel);
            this.passwordPanel.Controls.Add(this.label6);
            this.passwordPanel.Controls.Add(this.errorOldPasswordLabel);
            this.passwordPanel.Controls.Add(this.label7);
            this.passwordPanel.Controls.Add(this.label8);
            this.passwordPanel.Controls.Add(this.oldPasswordTBox);
            this.passwordPanel.Controls.Add(this.confirmPasswordTBox);
            this.passwordPanel.Location = new System.Drawing.Point(11, 392);
            this.passwordPanel.Name = "passwordPanel";
            this.passwordPanel.Size = new System.Drawing.Size(345, 148);
            this.passwordPanel.TabIndex = 17;
            // 
            // updatePasswordChBox
            // 
            this.updatePasswordChBox.AutoSize = true;
            this.updatePasswordChBox.Enabled = false;
            this.updatePasswordChBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updatePasswordChBox.Location = new System.Drawing.Point(12, 369);
            this.updatePasswordChBox.Name = "updatePasswordChBox";
            this.updatePasswordChBox.Size = new System.Drawing.Size(130, 20);
            this.updatePasswordChBox.TabIndex = 18;
            this.updatePasswordChBox.Text = "Обновить пароль";
            this.updatePasswordChBox.UseVisualStyleBackColor = true;
            this.updatePasswordChBox.CheckedChanged += new System.EventHandler(this.updatePasswordChBox_CheckedChanged);
            // 
            // UserAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 608);
            this.Controls.Add(this.updatePasswordChBox);
            this.Controls.Add(this.passwordPanel);
            this.Controls.Add(this.userProfilePanel);
            this.Controls.Add(this.changeProfilePanel);
            this.Controls.Add(this.changeProfileBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UserAccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация пользователя";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserAccountForm_FormClosing);
            this.Load += new System.EventHandler(this.UserAccountForm_Load);
            this.userProfilePanel.ResumeLayout(false);
            this.userProfilePanel.PerformLayout();
            this.changeProfilePanel.ResumeLayout(false);
            this.passwordPanel.ResumeLayout(false);
            this.passwordPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox firstNameTBox;
        private System.Windows.Forms.TextBox lastNameTBox;
        private System.Windows.Forms.TextBox countryTBox;
        private System.Windows.Forms.TextBox companyTBox;
        private System.Windows.Forms.TextBox phoneTBox;
        private System.Windows.Forms.Panel userProfilePanel;
        private System.Windows.Forms.TextBox confirmPasswordTBox;
        private System.Windows.Forms.TextBox newPasswordTBox;
        private System.Windows.Forms.TextBox oldPasswordTBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button changeProfileBtn;
        private System.Windows.Forms.Panel changeProfilePanel;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox loginTBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label errorConfirmPasswordLabel;
        private System.Windows.Forms.Label errorOldPasswordLabel;
        private System.Windows.Forms.Label errorLoginLabel;
        private System.Windows.Forms.Label errorPhoneLabel;
        private System.Windows.Forms.Label errorLastNameLabel;
        private System.Windows.Forms.Label errorFirstNameLabel;
        private System.Windows.Forms.Panel passwordPanel;
        private System.Windows.Forms.CheckBox updatePasswordChBox;
        private System.Windows.Forms.ComboBox languagesCBox;
        private System.Windows.Forms.Label label10;
    }
}