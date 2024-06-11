namespace WinFormsApp1
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            securityNo = new Label();
            textPassword = new TextBox();
            textPasswordAgain = new TextBox();
            textNameSurname = new TextBox();
            password = new Label();
            passwordAgain = new Label();
            nameSurname = new Label();
            textSecurity = new TextBox();
            sign = new Button();
            dateTimePicker1 = new DateTimePicker();
            birthDate = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            SuspendLayout();
            // 
            // securityNo
            // 
            securityNo.AutoSize = true;
            securityNo.Location = new Point(553, 66);
            securityNo.Name = "securityNo";
            securityNo.Size = new Size(209, 34);
            securityNo.TabIndex = 0;
            securityNo.Text = "T.C. Kimlik No.";
            securityNo.Click += securityNo_Click_1;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(506, 290);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(283, 42);
            textPassword.TabIndex = 1;
            textPassword.UseSystemPasswordChar = true;
            textPassword.TextChanged += textPassword_TextChanged_1;
            // 
            // textPasswordAgain
            // 
            textPasswordAgain.Location = new Point(506, 383);
            textPasswordAgain.Name = "textPasswordAgain";
            textPasswordAgain.Size = new Size(283, 42);
            textPasswordAgain.TabIndex = 2;
            textPasswordAgain.UseSystemPasswordChar = true;
            textPasswordAgain.TextChanged += textPasswordAgain_TextChanged_1;
            // 
            // textNameSurname
            // 
            textNameSurname.Location = new Point(450, 198);
            textNameSurname.Name = "textNameSurname";
            textNameSurname.Size = new Size(396, 42);
            textNameSurname.TabIndex = 3;
            textNameSurname.TextChanged += textNameSurname_TextChanged;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Location = new Point(623, 253);
            password.Name = "password";
            password.Size = new Size(72, 34);
            password.TabIndex = 5;
            password.Text = "Şifre";
            password.Click += password_Click_1;
            // 
            // passwordAgain
            // 
            passwordAgain.AutoSize = true;
            passwordAgain.Location = new Point(577, 346);
            passwordAgain.Name = "passwordAgain";
            passwordAgain.Size = new Size(157, 34);
            passwordAgain.TabIndex = 6;
            passwordAgain.Text = "Tekrar Şifre";
            passwordAgain.Click += passwordAgain_Click_1;
            // 
            // nameSurname
            // 
            nameSurname.AutoSize = true;
            nameSurname.Location = new Point(577, 161);
            nameSurname.Name = "nameSurname";
            nameSurname.Size = new Size(167, 34);
            nameSurname.TabIndex = 7;
            nameSurname.Text = "İsim Soyisim";
            nameSurname.Click += nameSurname_Click_1;
            // 
            // textSecurity
            // 
            textSecurity.Location = new Point(450, 103);
            textSecurity.Name = "textSecurity";
            textSecurity.Size = new Size(396, 42);
            textSecurity.TabIndex = 8;
            textSecurity.TextChanged += textSecurity_TextChanged_1;
            // 
            // sign
            // 
            sign.Location = new Point(597, 566);
            sign.Name = "sign";
            sign.Size = new Size(121, 45);
            sign.TabIndex = 9;
            sign.Text = "Kaydol";
            sign.UseVisualStyleBackColor = true;
            sign.Click += sign_Click_1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Times New Roman", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(553, 481);
            dateTimePicker1.MaxDate = new DateTime(2210, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(1799, 12, 30, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.RightToLeft = RightToLeft.No;
            dateTimePicker1.Size = new Size(191, 42);
            dateTimePicker1.TabIndex = 15;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // birthDate
            // 
            birthDate.AutoSize = true;
            birthDate.Location = new Point(564, 444);
            birthDate.Name = "birthDate";
            birthDate.Size = new Size(180, 34);
            birthDate.TabIndex = 11;
            birthDate.Text = "Doğum Tarihi";
            birthDate.Click += birthDate_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(760, 303);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(18, 17);
            checkBox1.TabIndex = 12;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(760, 396);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(18, 17);
            checkBox2.TabIndex = 13;
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(17F, 34F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Interface;
            ClientSize = new Size(1303, 692);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(birthDate);
            Controls.Add(dateTimePicker1);
            Controls.Add(sign);
            Controls.Add(textSecurity);
            Controls.Add(nameSurname);
            Controls.Add(passwordAgain);
            Controls.Add(password);
            Controls.Add(textNameSurname);
            Controls.Add(textPasswordAgain);
            Controls.Add(textPassword);
            Controls.Add(securityNo);
            Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6, 5, 6, 5);
            Name = "SignUp";
            Text = " Kaydol";
            Load += SignUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label securityNo;
        private TextBox textPassword;
        private TextBox textPasswordAgain;
        private TextBox textNameSurname;
        private Label password;
        private Label passwordAgain;
        private Label nameSurname;
        private TextBox textSecurity;
        private Button sign;
        private DateTimePicker dateTimePicker1;
        private Label birthDate;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
    }
}