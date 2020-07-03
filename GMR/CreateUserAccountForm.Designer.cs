namespace GMR
{
    partial class CreateUserAccountForm
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
            this.userProfilePanel = new System.Windows.Forms.Panel();
            this.errorPasswordLabel = new System.Windows.Forms.Label();
            this.passwordTBox = new System.Windows.Forms.TextBox();
            this.errorConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.confirmPasswordTBox = new System.Windows.Forms.TextBox();
            this.languagesCBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.errorLoginLabel = new System.Windows.Forms.Label();
            this.errorPhoneLabel = new System.Windows.Forms.Label();
            this.errorLastNameLabel = new System.Windows.Forms.Label();
            this.errorFirstNameLabel = new System.Windows.Forms.Label();
            this.loginTBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.companyTBox = new System.Windows.Forms.TextBox();
            this.phoneTBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.countryTBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lastNameTBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.firstNameTBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.createAccountBtn = new System.Windows.Forms.Button();
            this.userProfilePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // userProfilePanel
            // 
            this.userProfilePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userProfilePanel.Controls.Add(this.errorPasswordLabel);
            this.userProfilePanel.Controls.Add(this.passwordTBox);
            this.userProfilePanel.Controls.Add(this.errorConfirmPasswordLabel);
            this.userProfilePanel.Controls.Add(this.label7);
            this.userProfilePanel.Controls.Add(this.label8);
            this.userProfilePanel.Controls.Add(this.confirmPasswordTBox);
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
            this.userProfilePanel.Size = new System.Drawing.Size(363, 448);
            this.userProfilePanel.TabIndex = 11;
            // 
            // errorPasswordLabel
            // 
            this.errorPasswordLabel.AutoSize = true;
            this.errorPasswordLabel.ForeColor = System.Drawing.Color.Red;
            this.errorPasswordLabel.Location = new System.Drawing.Point(126, 335);
            this.errorPasswordLabel.Name = "errorPasswordLabel";
            this.errorPasswordLabel.Size = new System.Drawing.Size(88, 13);
            this.errorPasswordLabel.TabIndex = 24;
            this.errorPasswordLabel.Text = "Введите пароль";
            this.errorPasswordLabel.Visible = false;
            // 
            // passwordTBox
            // 
            this.passwordTBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTBox.Location = new System.Drawing.Point(126, 309);
            this.passwordTBox.Name = "passwordTBox";
            this.passwordTBox.Size = new System.Drawing.Size(196, 23);
            this.passwordTBox.TabIndex = 21;
            this.passwordTBox.UseSystemPasswordChar = true;
            this.passwordTBox.TextChanged += new System.EventHandler(this.PasswordTBox_TextChanged);
            // 
            // errorConfirmPasswordLabel
            // 
            this.errorConfirmPasswordLabel.AutoSize = true;
            this.errorConfirmPasswordLabel.ForeColor = System.Drawing.Color.Red;
            this.errorConfirmPasswordLabel.Location = new System.Drawing.Point(126, 381);
            this.errorConfirmPasswordLabel.Name = "errorConfirmPasswordLabel";
            this.errorConfirmPasswordLabel.Size = new System.Drawing.Size(0, 13);
            this.errorConfirmPasswordLabel.TabIndex = 23;
            this.errorConfirmPasswordLabel.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(18, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Пароль*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(18, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Подтвердить*";
            // 
            // confirmPasswordTBox
            // 
            this.confirmPasswordTBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmPasswordTBox.Location = new System.Drawing.Point(126, 355);
            this.confirmPasswordTBox.Name = "confirmPasswordTBox";
            this.confirmPasswordTBox.Size = new System.Drawing.Size(196, 23);
            this.confirmPasswordTBox.TabIndex = 22;
            this.confirmPasswordTBox.UseSystemPasswordChar = true;
            this.confirmPasswordTBox.TextChanged += new System.EventHandler(this.ConfirmPasswordTBox_TextChanged);
            // 
            // languagesCBox
            // 
            this.languagesCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languagesCBox.FormattingEnabled = true;
            this.languagesCBox.Location = new System.Drawing.Point(126, 406);
            this.languagesCBox.Name = "languagesCBox";
            this.languagesCBox.Size = new System.Drawing.Size(196, 21);
            this.languagesCBox.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(18, 409);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Язык*";
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
            this.errorPhoneLabel.Size = new System.Drawing.Size(0, 13);
            this.errorPhoneLabel.TabIndex = 16;
            this.errorPhoneLabel.Visible = false;
            // 
            // errorLastNameLabel
            // 
            this.errorLastNameLabel.AutoSize = true;
            this.errorLastNameLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLastNameLabel.Location = new System.Drawing.Point(126, 90);
            this.errorLastNameLabel.Name = "errorLastNameLabel";
            this.errorLastNameLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLastNameLabel.TabIndex = 16;
            this.errorLastNameLabel.Visible = false;
            // 
            // errorFirstNameLabel
            // 
            this.errorFirstNameLabel.AutoSize = true;
            this.errorFirstNameLabel.ForeColor = System.Drawing.Color.Red;
            this.errorFirstNameLabel.Location = new System.Drawing.Point(126, 44);
            this.errorFirstNameLabel.Name = "errorFirstNameLabel";
            this.errorFirstNameLabel.Size = new System.Drawing.Size(0, 13);
            this.errorFirstNameLabel.TabIndex = 16;
            this.errorFirstNameLabel.Visible = false;
            // 
            // loginTBox
            // 
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
            // companyTBox
            // 
            this.companyTBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.companyTBox.Location = new System.Drawing.Point(126, 159);
            this.companyTBox.Name = "companyTBox";
            this.companyTBox.Size = new System.Drawing.Size(196, 23);
            this.companyTBox.TabIndex = 8;
            // 
            // phoneTBox
            // 
            this.phoneTBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneTBox.Location = new System.Drawing.Point(126, 205);
            this.phoneTBox.Name = "phoneTBox";
            this.phoneTBox.Size = new System.Drawing.Size(196, 23);
            this.phoneTBox.TabIndex = 9;
            this.phoneTBox.TextChanged += new System.EventHandler(this.PhoneTBox_TextChanged);
            this.phoneTBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneTBox_KeyPress);
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
            // countryTBox
            // 
            this.countryTBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countryTBox.Location = new System.Drawing.Point(126, 113);
            this.countryTBox.Name = "countryTBox";
            this.countryTBox.Size = new System.Drawing.Size(196, 23);
            this.countryTBox.TabIndex = 7;
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
            // lastNameTBox
            // 
            this.lastNameTBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameTBox.Location = new System.Drawing.Point(126, 64);
            this.lastNameTBox.Name = "lastNameTBox";
            this.lastNameTBox.Size = new System.Drawing.Size(196, 23);
            this.lastNameTBox.TabIndex = 6;
            this.lastNameTBox.TextChanged += new System.EventHandler(this.LastNameTBox_TextChanged);
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
            // firstNameTBox
            // 
            this.firstNameTBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameTBox.Location = new System.Drawing.Point(126, 17);
            this.firstNameTBox.Name = "firstNameTBox";
            this.firstNameTBox.Size = new System.Drawing.Size(196, 23);
            this.firstNameTBox.TabIndex = 5;
            this.firstNameTBox.TextChanged += new System.EventHandler(this.FirstNameTBox_TextChanged);
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
            // createAccountBtn
            // 
            this.createAccountBtn.Enabled = false;
            this.createAccountBtn.Location = new System.Drawing.Point(227, 476);
            this.createAccountBtn.Name = "createAccountBtn";
            this.createAccountBtn.Size = new System.Drawing.Size(148, 33);
            this.createAccountBtn.TabIndex = 12;
            this.createAccountBtn.Text = "Создать аккаунт";
            this.createAccountBtn.UseVisualStyleBackColor = true;
            this.createAccountBtn.Click += new System.EventHandler(this.CreateAccountBtn_Click);
            // 
            // CreateUserAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 523);
            this.Controls.Add(this.createAccountBtn);
            this.Controls.Add(this.userProfilePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreateUserAccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание нового аккаунта";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateUserAccountForm_FormClosing);
            this.Load += new System.EventHandler(this.CreateUserAccountForm_Load);
            this.userProfilePanel.ResumeLayout(false);
            this.userProfilePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel userProfilePanel;
        private System.Windows.Forms.ComboBox languagesCBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label errorLoginLabel;
        private System.Windows.Forms.Label errorPhoneLabel;
        private System.Windows.Forms.Label errorLastNameLabel;
        private System.Windows.Forms.Label errorFirstNameLabel;
        private System.Windows.Forms.TextBox loginTBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox companyTBox;
        private System.Windows.Forms.TextBox phoneTBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox countryTBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastNameTBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox firstNameTBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label errorPasswordLabel;
        private System.Windows.Forms.TextBox passwordTBox;
        private System.Windows.Forms.Label errorConfirmPasswordLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox confirmPasswordTBox;
        private System.Windows.Forms.Button createAccountBtn;
    }
}