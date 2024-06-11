using System;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "GaziBank";
            MaximizeBox = false;
            MinimizeBox = false;

            textBox1.TabIndex = 0;
            textBox3.TabIndex = 1;
            sign.TabIndex = 2;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }
        private void sign_Click_1(object sender, EventArgs e)
        {
            string securityNo = textBox1.Text;
            string password = textBox3.Text;

            if (string.IsNullOrWhiteSpace(securityNo) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Bölümlerden Herhangi Biri Boþ Býrakýlamaz!");
                return;
            }

            if (securityNo.Length != 11 || !securityNo.All(Char.IsDigit))
            {
                MessageBox.Show("Geçersiz T.C. Kimlik No. Bilgisi!");
                return;
            }

            string connectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=securityNo_Password.mdb";
            string query = "SELECT Id FROM access WHERE Tc = ? AND Password = ?";

            using (OleDbConnection connect = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(query, connect))
                {
                    command.Parameters.AddWithValue("@Tc", securityNo);
                    command.Parameters.AddWithValue("@Password", password);
                    try
                    {
                        connect.Open();
                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int rowNum = reader.GetInt32(0);
                                MessageBox.Show("Giriþ Yapýlýyor...");
                                this.Hide();
                                Interface giris = new Interface(rowNum);
                                giris.Show();
                            }
                            else
                            {
                                MessageBox.Show("Hesap Sistemde Bulunamadý.");
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Beklenmeyen bir hata oluþtu, lütfen tekrar deneyin!");
                    }
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void signtext_Click(object sender, EventArgs e)
        {
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUp sign = new SignUp();
            sign.Show();
        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        public void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox3.UseSystemPasswordChar = false;
            }
            else
            {
                textBox3.UseSystemPasswordChar = true;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
