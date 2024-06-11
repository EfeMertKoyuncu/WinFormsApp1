namespace WinFormsApp1
{
    partial class Interface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interface));
            button7 = new Button();
            nameSurname = new Label();
            button4 = new Button();
            tlMiktar = new Label();
            dolarMiktar = new Label();
            euroMiktar = new Label();
            dolarKur = new Label();
            euroKur = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button7
            // 
            button7.BackgroundImage = Properties.Resources.Call_Centre;
            button7.BackgroundImageLayout = ImageLayout.Stretch;
            button7.FlatAppearance.BorderColor = Color.Black;
            button7.FlatAppearance.BorderSize = 3;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button7.ForeColor = Color.Black;
            button7.Location = new Point(399, 380);
            button7.Margin = new Padding(4, 3, 4, 3);
            button7.Name = "button7";
            button7.Size = new Size(243, 199);
            button7.TabIndex = 3;
            button7.Text = "Müşteri Temsilcim";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // nameSurname
            // 
            nameSurname.AutoSize = true;
            nameSurname.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 162);
            nameSurname.ForeColor = Color.Black;
            nameSurname.Location = new Point(505, 24);
            nameSurname.Margin = new Padding(4, 0, 4, 0);
            nameSurname.Name = "nameSurname";
            nameSurname.Size = new Size(137, 68);
            nameSurname.TabIndex = 5;
            nameSurname.Text = "kUll";
            nameSurname.Click += nameSurname_Click;
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources._9191371;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.FlatAppearance.BorderColor = Color.Black;
            button4.FlatAppearance.BorderSize = 3;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button4.ForeColor = Color.Black;
            button4.ImageAlign = ContentAlignment.TopCenter;
            button4.Location = new Point(720, 380);
            button4.Name = "button4";
            button4.Size = new Size(243, 199);
            button4.TabIndex = 6;
            button4.Text = "Para Transferi";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // tlMiktar
            // 
            tlMiktar.AutoSize = true;
            tlMiktar.BackColor = Color.Transparent;
            tlMiktar.Font = new Font("Times New Roman", 19.8000011F);
            tlMiktar.Location = new Point(61, 268);
            tlMiktar.Name = "tlMiktar";
            tlMiktar.Size = new Size(98, 39);
            tlMiktar.TabIndex = 7;
            tlMiktar.Text = "label1";
            tlMiktar.Click += tlMiktar_Click;
            // 
            // dolarMiktar
            // 
            dolarMiktar.AutoSize = true;
            dolarMiktar.BackColor = Color.Transparent;
            dolarMiktar.Font = new Font("Times New Roman", 19.8000011F);
            dolarMiktar.Location = new Point(61, 342);
            dolarMiktar.Name = "dolarMiktar";
            dolarMiktar.Size = new Size(98, 39);
            dolarMiktar.TabIndex = 8;
            dolarMiktar.Text = "label2";
            dolarMiktar.Click += dolarMiktar_Click;
            // 
            // euroMiktar
            // 
            euroMiktar.AutoSize = true;
            euroMiktar.BackColor = Color.Transparent;
            euroMiktar.Font = new Font("Times New Roman", 19.8000011F);
            euroMiktar.Location = new Point(61, 413);
            euroMiktar.Name = "euroMiktar";
            euroMiktar.Size = new Size(98, 39);
            euroMiktar.TabIndex = 9;
            euroMiktar.Text = "label3";
            euroMiktar.Click += euroMiktar_Click;
            // 
            // dolarKur
            // 
            dolarKur.AutoSize = true;
            dolarKur.BackColor = Color.Transparent;
            dolarKur.Font = new Font("Times New Roman", 19.8000011F);
            dolarKur.Location = new Point(1019, 259);
            dolarKur.Name = "dolarKur";
            dolarKur.Size = new Size(98, 39);
            dolarKur.TabIndex = 10;
            dolarKur.Text = "label1";
            dolarKur.Click += dolarKur_Click;
            // 
            // euroKur
            // 
            euroKur.AutoSize = true;
            euroKur.BackColor = Color.Transparent;
            euroKur.Font = new Font("Times New Roman", 19.8000011F);
            euroKur.Location = new Point(1019, 342);
            euroKur.Name = "euroKur";
            euroKur.Size = new Size(98, 39);
            euroKur.TabIndex = 11;
            euroKur.Text = "label2";
            euroKur.Click += euroKur_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(49, 186);
            label1.Name = "label1";
            label1.Size = new Size(385, 53);
            label1.TabIndex = 12;
            label1.Text = "Mevcut Bakiyeniz";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(945, 186);
            label2.Name = "label2";
            label2.Size = new Size(416, 53);
            label2.TabIndex = 13;
            label2.Text = "Güncel Döviz Kuru\r\n";
            label2.Click += label2_Click;
            // 
            // Interface
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Interface;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1409, 689);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(euroKur);
            Controls.Add(dolarKur);
            Controls.Add(euroMiktar);
            Controls.Add(dolarMiktar);
            Controls.Add(tlMiktar);
            Controls.Add(button4);
            Controls.Add(nameSurname);
            Controls.Add(button7);
            DoubleBuffered = true;
            Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Interface";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "İşlem Arayüzü";
            Load += Interface_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button7;
        private Label nameSurname;
        private Button button4;
        private Label tlMiktar;
        private Label dolarMiktar;
        private Label euroMiktar;
        private Label dolarKur;
        private Label euroKur;
        private Label label1;
        private Label label2;
    }
}