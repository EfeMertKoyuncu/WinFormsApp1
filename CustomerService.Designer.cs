namespace WinFormsApp1
{
    partial class CustomerService
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
        public struct Cs
        {
            public string name;
            public string phoneNum;
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerService));
            label1 = new Label();
            csName = new Label();
            csPhone = new Label();
            csMail = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 48F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(295, 30);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(640, 90);
            label1.TabIndex = 0;
            label1.Text = " Müşteri Temsilcin\r\n";
            label1.Click += label1_Click;
            // 
            // csName
            // 
            csName.AutoSize = true;
            csName.BackColor = Color.Transparent;
            csName.Font = new Font("Times New Roman", 24F);
            csName.Location = new Point(39, 185);
            csName.Name = "csName";
            csName.Size = new Size(117, 46);
            csName.TabIndex = 1;
            csName.Text = "label2";
            csName.Click += label2_Click;
            // 
            // csPhone
            // 
            csPhone.AutoSize = true;
            csPhone.BackColor = Color.Transparent;
            csPhone.Font = new Font("Times New Roman", 24F);
            csPhone.Location = new Point(39, 334);
            csPhone.Name = "csPhone";
            csPhone.Size = new Size(117, 46);
            csPhone.TabIndex = 2;
            csPhone.Text = "label3";
            csPhone.Click += label3_Click;
            // 
            // csMail
            // 
            csMail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            csMail.AutoSize = true;
            csMail.BackColor = Color.Transparent;
            csMail.Font = new Font("Times New Roman", 24F);
            csMail.Location = new Point(39, 481);
            csMail.Name = "csMail";
            csMail.Size = new Size(117, 46);
            csMail.TabIndex = 3;
            csMail.Text = "label4";
            csMail.Click += csMail_Click;
            // 
            // CustomerService
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Interface;
            ClientSize = new Size(1105, 664);
            Controls.Add(csMail);
            Controls.Add(csPhone);
            Controls.Add(csName);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "CustomerService";
            Text = "Müşteri Hizmetleri";
            TransparencyKey = Color.White;
            Load += CustomerService_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label csName;
        private Label csPhone;
        private Label csMail;
    }
}