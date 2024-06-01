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
            securityNo.BackColor = Color.Transparent;
            securityNo.Location = new Point(328, 87);
            securityNo.Name = "securityNo";
            securityNo.Size = new Size(209, 34);
            securityNo.TabIndex = 0;
            securityNo.Text = "T.C. Kimlik No.";
            securityNo.Click += securityNo_Click_1;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(290, 237);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(283, 42);
            textPassword.TabIndex = 1;
            textPassword.UseSystemPasswordChar = true;
            textPassword.TextChanged += textPassword_TextChanged_1;
            // 
            // textPasswordAgain
            // 
            textPasswordAgain.Location = new Point(290, 339);
            textPasswordAgain.Name = "textPasswordAgain";
            textPasswordAgain.Size = new Size(283, 42);
            textPasswordAgain.TabIndex = 2;
            textPasswordAgain.UseSystemPasswordChar = true;
            textPasswordAgain.TextChanged += textPasswordAgain_TextChanged_1;
            // 
            // textNameSurname
            // 
            textNameSurname.Location = new Point(290, 451);
            textNameSurname.Name = "textNameSurname";
            textNameSurname.Size = new Size(283, 42);
            textNameSurname.TabIndex = 3;
            textNameSurname.TextChanged += textNameSurname_TextChanged;
            // 
            // password
            // 
            password.AutoSize = true;
            password.BackColor = Color.Transparent;
            password.Location = new Point(388, 200);
            password.Name = "password";
            password.Size = new Size(72, 34);
            password.TabIndex = 5;
            password.Text = "Şifre";
            password.Click += password_Click_1;
            // 
            // passwordAgain
            // 
            passwordAgain.AutoSize = true;
            passwordAgain.BackColor = Color.Transparent;
            passwordAgain.Location = new Point(353, 294);
            passwordAgain.Name = "passwordAgain";
            passwordAgain.Size = new Size(157, 34);
            passwordAgain.TabIndex = 6;
            passwordAgain.Text = "Tekrar Şifre";
            passwordAgain.Click += passwordAgain_Click_1;
            // 
            // nameSurname
            // 
            nameSurname.AutoSize = true;
            nameSurname.BackColor = Color.Transparent;
            nameSurname.Location = new Point(353, 403);
            nameSurname.Name = "nameSurname";
            nameSurname.Size = new Size(167, 34);
            nameSurname.TabIndex = 7;
            nameSurname.Text = "İsim Soyisim";
            nameSurname.Click += nameSurname_Click_1;
            // 
            // textSecurity
            // 
            textSecurity.Location = new Point(236, 140);
            textSecurity.Name = "textSecurity";
            textSecurity.Size = new Size(396, 42);
            textSecurity.TabIndex = 8;
            textSecurity.TextChanged += textSecurity_TextChanged_1;
            // 
            // sign
            // 
            sign.Location = new Point(365, 673);
            sign.Name = "sign";
            sign.Size = new Size(121, 45);
            sign.TabIndex = 9;
            sign.Text = "Kaydol";
            sign.UseVisualStyleBackColor = true;
            sign.Click += sign_Click_1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(273, 578);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(359, 42);
            dateTimePicker1.TabIndex = 10;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // birthDate
            // 
            birthDate.AutoSize = true;
            birthDate.BackColor = Color.Transparent;
            birthDate.Location = new Point(340, 520);
            birthDate.Name = "birthDate";
            birthDate.Size = new Size(180, 34);
            birthDate.TabIndex = 11;
            birthDate.Text = "Doğum Tarihi";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(544, 250);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(18, 17);
            checkBox1.TabIndex = 12;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(544, 352);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(18, 17);
            checkBox2.TabIndex = 13;
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // SignUp
            // 
            MinimizeBox = false;
            MaximizeBox = false;
            AutoScaleDimensions = new SizeF(17F, 34F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._3274408;
            ClientSize = new Size(887, 761);
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
            Margin = new Padding(6, 5, 6, 5);
            Name = "SignUp";
            Text = "SignUp";
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