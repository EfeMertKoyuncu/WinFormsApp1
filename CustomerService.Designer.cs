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
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 48F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(117, 40);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(844, 90);
            label1.TabIndex = 0;
            label1.Text = "Senin Müşteri Temsilcin:";
            label1.Click += label1_Click;
            // 
            // CustomerService
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.customer_servic_59da589f_8115_4670_87d4_ace092245bc0;
            ClientSize = new Size(1105, 664);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 4, 5, 4);
            Name = "CustomerService";
            Text = "CustomerService";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}