using System;
using System.Data.OleDb;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Bireysel Bankac�l�k";
            
         
            
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
                MessageBox.Show("B�l�mlerden Herhangi Biri Bo� B�rak�lamaz!");
                return;
            }

            if (securityNo.Length != 11 || !securityNo.All(Char.IsDigit))
            {
                MessageBox.Show("Ge�ersiz T.C. Kimlik No. Bilgisi!");
                return;
            }

            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\efeme\Documents\securityNo_Password.accdb";
            string query = "SELECT Tc, Password, Kimlik FROM access WHERE Tc = ? ,Password = ? AND Kimlik = ?";

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
                                MessageBox.Show("Giri� Yap�l�yor...");
                                this.Hide();
                                Interface giris = new Interface();
                                giris.Show();
                            }
                            else
                            {
                                MessageBox.Show("Hesap Sistemde Bulunamad�.");
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Beklenmeyen bir hata olu�tu, l�tfen tekrar deneyin!");
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
                textBox3.UseSystemPasswordChar = false; // Show the password
            }
            else
            {
                textBox3.UseSystemPasswordChar = true; // Hide the password
            }

        }
       
    }
}