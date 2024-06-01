using System.Data;
using System.Data.OleDb;

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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            button7 = new Button();
            nameSurname = new Label();
            dataTable = new DataTable();
            button4 = new Button();
            conn = new OleDbConnection();
            command = new OleDbCommand();
            adapter = new OleDbDataAdapter();
            ((System.ComponentModel.ISupportInitialize)dataTable).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.pngtree_3d_visualization_of_bank_safe_room_image_3844534;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.Location = new Point(12, 135);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(282, 202);
            button1.TabIndex = 0;
            button1.Text = "Hesap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.istockphoto_1203763961_612x6121;
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatAppearance.BorderSize = 3;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button2.Location = new Point(302, 135);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(261, 202);
            button2.TabIndex = 1;
            button2.Text = "Kartlarım";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderColor = Color.Black;
            button3.FlatAppearance.BorderSize = 3;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button3.ForeColor = Color.White;
            button3.Image = Properties.Resources.Ekran_görüntüsü_2024_05_22_095406;
            button3.Location = new Point(571, 135);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(254, 202);
            button3.TabIndex = 2;
            button3.Text = "Döviz";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.FlatAppearance.BorderColor = Color.Black;
            button5.FlatAppearance.BorderSize = 3;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button5.ForeColor = SystemColors.Menu;
            button5.Location = new Point(1084, 135);
            button5.Margin = new Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new Size(246, 202);
            button5.TabIndex = 4;
            button5.Text = "Canlı Döviz Kuru";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button7
            // 
            button7.BackgroundImage = (Image)resources.GetObject("button7.BackgroundImage");
            button7.FlatAppearance.BorderColor = Color.Black;
            button7.FlatAppearance.BorderSize = 3;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button7.ForeColor = Color.White;
            button7.Location = new Point(833, 135);
            button7.Margin = new Padding(4, 3, 4, 3);
            button7.Name = "button7";
            button7.Size = new Size(243, 202);
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
            nameSurname.Location = new Point(42, 34);
            nameSurname.Margin = new Padding(4, 0, 4, 0);
            nameSurname.Name = "nameSurname";
            nameSurname.RightToLeft = RightToLeft.Yes;
            nameSurname.Size = new Size(0, 68);
            nameSurname.TabIndex = 5;
            nameSurname.TextAlign = ContentAlignment.TopCenter;
            nameSurname.Click += nameSurname_Click;
            // 
            // dataTable
            // 
            dataTable.Namespace = "";
            // 
            // button4
            // 
            button4.ForeColor = Color.Black;
            button4.Location = new Point(571, 343);
            button4.Name = "button4";
            button4.Size = new Size(259, 211);
            button4.TabIndex = 6;
            button4.Text = "Para Transferi";
            button4.UseVisualStyleBackColor = true;
            // 
            // conn
            // 
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\efeme\\Documents\\securityNo_Password.accdb";
            // 
            // command
            // 
            command.CommandText = "Select * from access";
            command.CommandTimeout = 30;
            command.Connection = conn;
            // 
            // adapter
            // 
            adapter.SelectCommand = command;
            // 
            // Interface
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._3409297;
            ClientSize = new Size(1384, 689);
            Controls.Add(button4);
            Controls.Add(nameSurname);
            Controls.Add(button5);
            Controls.Add(button7);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Interface";
            Text = "İşlem Arayüzü";
            ((System.ComponentModel.ISupportInitialize)dataTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button5;
        private Button button7;
        private Label nameSurname;
        private Button button4;
        private DataTable dataTable;
        private OleDbConnection conn;
        private OleDbCommand command;
        private OleDbDataAdapter adapter;
    }
}