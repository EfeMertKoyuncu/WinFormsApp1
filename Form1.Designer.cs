namespace WinFormsApp1
{
    partial class Form1
    {
        
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            sign = new Button();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            signtext = new Label();
            label1 = new Label();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // sign
            // 
            sign.FlatAppearance.BorderColor = Color.Black;
            sign.FlatAppearance.BorderSize = 3;
            sign.ForeColor = Color.Black;
            sign.Location = new Point(667, 455);
            sign.Name = "sign";
            sign.Size = new Size(144, 48);
            sign.TabIndex = 7;
            sign.Text = "Giriş Yap";
            sign.UseVisualStyleBackColor = true;
            sign.Click += sign_Click_1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(559, 389);
            textBox3.Margin = new Padding(6, 5, 6, 5);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(375, 39);
            textBox3.TabIndex = 6;
            textBox3.UseSystemPasswordChar = true;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(559, 256);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(369, 39);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // signtext
            // 
            signtext.AutoSize = true;
            signtext.BackColor = Color.White;
            signtext.ForeColor = Color.Black;
            signtext.Location = new Point(520, 520);
            signtext.Name = "signtext";
            signtext.Size = new Size(257, 33);
            signtext.TabIndex = 12;
            signtext.Text = "Bir Hesabın Yok Mu?";
            signtext.Click += signtext_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(624, 205);
            label1.Name = "label1";
            label1.Size = new Size(240, 39);
            label1.TabIndex = 13;
            label1.Text = "T.C. Kimlik No.";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(695, 334);
            label2.Name = "label2";
            label2.Size = new Size(82, 39);
            label2.TabIndex = 13;
            label2.Text = "Şifre";
            label2.Click += label2_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            linkLabel1.Location = new Point(774, 520);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(189, 32);
            linkLabel1.TabIndex = 14;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Şimdi Kaydol!";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(900, 400);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(18, 17);
            checkBox1.TabIndex = 15;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AccessibleRole = AccessibleRole.ScrollBar;
            AutoScaleDimensions = new SizeF(15F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.LoginScreen;
            ClientSize = new Size(1426, 789);
            Controls.Add(checkBox1);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(signtext);
            Controls.Add(textBox1);
            Controls.Add(sign);
            Controls.Add(textBox3);
            DoubleBuffered = true;
            Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ForeColor = Color.Transparent;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6, 5, 6, 5);
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GaziBank";
            TransparencyKey = Color.Transparent;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnClickThis_Click(object sender,EventArgs e)
        {

        }

        #endregion

        private Button sign;
        private TextBox textBox3;
        private TextBox textBox1;
        private Label signtext;
        private Label label1;
        private Label label2;
        private LinkLabel linkLabel1;
        private CheckBox checkBox1;
    }
}
