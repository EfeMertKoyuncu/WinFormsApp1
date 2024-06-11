namespace WinFormsApp1
{
    partial class paraTransferi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paraTransferi));
            baslikLabel = new Label();
            hesapNoLabel = new Label();
            isimSoyisimLabel = new Label();
            hesapNoText = new TextBox();
            isimSoyisimText = new TextBox();
            paraBirimiLabel = new Label();
            paraMiktarıLabel = new Label();
            paraMiktarıText = new TextBox();
            gonderButon = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // baslikLabel
            // 
            baslikLabel.AutoSize = true;
            baslikLabel.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            baslikLabel.Location = new Point(363, 9);
            baslikLabel.Margin = new Padding(6, 0, 6, 0);
            baslikLabel.Name = "baslikLabel";
            baslikLabel.Size = new Size(498, 35);
            baslikLabel.TabIndex = 0;
            baslikLabel.Text = "Hesaplar Arası Para Transfer İşlemleri\r\n";
            baslikLabel.Click += baslikLabel_Click;
            // 
            // hesapNoLabel
            // 
            hesapNoLabel.AutoSize = true;
            hesapNoLabel.BackColor = Color.Transparent;
            hesapNoLabel.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            hesapNoLabel.Location = new Point(46, 140);
            hesapNoLabel.Name = "hesapNoLabel";
            hesapNoLabel.Size = new Size(219, 35);
            hesapNoLabel.TabIndex = 1;
            hesapNoLabel.Text = "T.C. Kimlik No.";
            hesapNoLabel.Click += hesapNoLabel_Click;
            // 
            // isimSoyisimLabel
            // 
            isimSoyisimLabel.AutoSize = true;
            isimSoyisimLabel.BackColor = Color.Transparent;
            isimSoyisimLabel.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            isimSoyisimLabel.Location = new Point(46, 284);
            isimSoyisimLabel.Name = "isimSoyisimLabel";
            isimSoyisimLabel.Size = new Size(177, 35);
            isimSoyisimLabel.TabIndex = 2;
            isimSoyisimLabel.Text = "İsim Soyisim";
            isimSoyisimLabel.Click += isimSoyisimLabel_Click;
            // 
            // hesapNoText
            // 
            hesapNoText.Location = new Point(46, 191);
            hesapNoText.Name = "hesapNoText";
            hesapNoText.Size = new Size(493, 42);
            hesapNoText.TabIndex = 3;
            hesapNoText.TextChanged += hesapNoText_TextChanged;
            // 
            // isimSoyisimText
            // 
            isimSoyisimText.Location = new Point(46, 354);
            isimSoyisimText.Name = "isimSoyisimText";
            isimSoyisimText.Size = new Size(493, 42);
            isimSoyisimText.TabIndex = 4;
            isimSoyisimText.TextChanged += isimSoyisimText_TextChanged;
            // 
            // paraBirimiLabel
            // 
            paraBirimiLabel.AutoSize = true;
            paraBirimiLabel.BackColor = Color.Transparent;
            paraBirimiLabel.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            paraBirimiLabel.Location = new Point(820, 140);
            paraBirimiLabel.Name = "paraBirimiLabel";
            paraBirimiLabel.Size = new Size(163, 35);
            paraBirimiLabel.TabIndex = 5;
            paraBirimiLabel.Text = "Para Birimi";
            paraBirimiLabel.Click += paraBirimiLabel_Click;
            // 
            // paraMiktarıLabel
            // 
            paraMiktarıLabel.AutoSize = true;
            paraMiktarıLabel.BackColor = Color.Transparent;
            paraMiktarıLabel.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            paraMiktarıLabel.Location = new Point(808, 284);
            paraMiktarıLabel.Name = "paraMiktarıLabel";
            paraMiktarıLabel.Size = new Size(177, 35);
            paraMiktarıLabel.TabIndex = 9;
            paraMiktarıLabel.Text = "Para Miktarı";
            paraMiktarıLabel.Click += paraMiktarıLabel_Click;
            // 
            // paraMiktarıText
            // 
            paraMiktarıText.Location = new Point(636, 354);
            paraMiktarıText.Name = "paraMiktarıText";
            paraMiktarıText.Size = new Size(469, 42);
            paraMiktarıText.TabIndex = 10;
            paraMiktarıText.TextChanged += paraMiktarıText_TextChanged;
            // 
            // gonderButon
            // 
            gonderButon.Location = new Point(514, 453);
            gonderButon.Name = "gonderButon";
            gonderButon.Size = new Size(146, 51);
            gonderButon.TabIndex = 11;
            gonderButon.Text = "Gönder";
            gonderButon.UseVisualStyleBackColor = true;
            gonderButon.Click += gonderButon_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(665, 191);
            label1.Name = "label1";
            label1.Size = new Size(170, 34);
            label1.TabIndex = 12;
            label1.Text = "Türk Lirası ₺";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(884, 191);
            label2.Name = "label2";
            label2.Size = new Size(105, 34);
            label2.TabIndex = 13;
            label2.Text = "Dolar $";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(1038, 191);
            label3.Name = "label3";
            label3.Size = new Size(96, 34);
            label3.TabIndex = 14;
            label3.Text = "Euro €";
            label3.Click += label3_Click;
            // 
            // paraTransferi
            // 
            AutoScaleDimensions = new SizeF(17F, 34F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Interface;
            ClientSize = new Size(1156, 562);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(gonderButon);
            Controls.Add(paraMiktarıText);
            Controls.Add(paraMiktarıLabel);
            Controls.Add(paraBirimiLabel);
            Controls.Add(isimSoyisimText);
            Controls.Add(hesapNoText);
            Controls.Add(isimSoyisimLabel);
            Controls.Add(hesapNoLabel);
            Controls.Add(baslikLabel);
            Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6, 5, 6, 5);
            Name = "paraTransferi";
            Text = "Para Transfer İşlemleri";
            Load += paraTransferi_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label baslikLabel;
        private Label hesapNoLabel;
        private Label isimSoyisimLabel;
        private TextBox hesapNoText;
        private TextBox isimSoyisimText;
        private Label paraBirimiLabel;
        private Label paraMiktarıLabel;
        private TextBox paraMiktarıText;
        private Button gonderButon;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}