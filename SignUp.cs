using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography.X509Certificates;

namespace WinFormsApp1
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            this.FormClosed += SignUp_FormClosed;
            MaximizeBox = false;
            MinimizeBox = false;
            textSecurity.TabIndex = 0;
            textNameSurname.TabIndex = 1;
            textPassword.TabIndex = 2;
            textPasswordAgain.TabIndex = 3;
            dateTimePicker1.TabIndex = 4;
            sign.TabIndex = 5;
        }
        private void SignUp_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
        }
        private void SignUp_Load(object sender, EventArgs e)
        {

        }
        private void textSecurity_TextChanged_1(object sender, EventArgs e)
        {
        }
        private void securityNo_Click_1(object sender, EventArgs e)
        {
        }
        private void textNameSurname_TextChanged(object sender, EventArgs e)
        {
        }
        private void nameSurname_Click_1(object sender, EventArgs e)
        {
        }
        private void textPassword_TextChanged_1(object sender, EventArgs e)
        {
        }
        private void password_Click_1(object sender, EventArgs e)
        {
        }
        private void textPasswordAgain_TextChanged_1(object sender, EventArgs e)
        {
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) //checkBox işaretlendiğinde şifreyi gösteriyor.
            {
                textPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textPassword.UseSystemPasswordChar = true;
            }
        }
        private void passwordAgain_Click_1(object sender, EventArgs e)
        {
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textPasswordAgain.UseSystemPasswordChar = false;
            }
            else
            {
                textPasswordAgain.UseSystemPasswordChar = true;
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }
        private void sign_Click_1(object sender, EventArgs e)
        {

            DateTime selectedDate = dateTimePicker1.Value;
            TimeSpan difference = (DateTime.Now - selectedDate);

            if (string.IsNullOrWhiteSpace(textSecurity.Text)
                || string.IsNullOrWhiteSpace(textPassword.Text)
                || string.IsNullOrWhiteSpace(passwordAgain.Text)
                || string.IsNullOrWhiteSpace(textNameSurname.Text))
            {
                MessageBox.Show("Bölümlerden Herhangi Birisi Boş Bırakılamaz!");
            }
            else if (!textSecurity.Text.All(Char.IsDigit) || textSecurity.Text.Length != 11)
            {
                MessageBox.Show("Geçersiz T.C. Kimlik No. Bilgisi!");
            }
            else if (textPassword.Text != textPasswordAgain.Text)
            {
                MessageBox.Show("Şifreler Uyuşmuyor!");
            }
            else if (difference.Days / 365 < 18)
            {
                MessageBox.Show("18 Yaşından Küçük Bireylerin Banka Hesabı Açması İçin Şubeyle Görüşmeleri Gerekmektedir.");
            }
            else
            {
                Random rnd = new Random();
                OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=securityNo_Password.mdb");
                OleDbDataAdapter adapter = new OleDbDataAdapter();

                string register = "INSERT INTO access " +
                    "(Tc, [Password],[isimSoyisim],[dogumTarihi],[turkishLira],[euro],[dollar]) VALUES " +
                    "(@Tc, @Password,@isimSoyisim,@dogumTarihi,@turkishLira,@euro,@dollar)";

                using (OleDbCommand command = new OleDbCommand(register, conn)) //Defensive programming sayesinde program crash vermeden çalışmaya devam ediyor.
                {
                    try
                    {
                        conn.Open();
                        command.Parameters.Add("@Tc", OleDbType.VarChar).Value = textSecurity.Text;
                        command.Parameters.Add("@Password", OleDbType.VarChar).Value = textPassword.Text;
                        command.Parameters.Add("@isimSoyisim", OleDbType.VarChar).Value = textNameSurname.Text;
                        command.Parameters.Add("@dogumTarihi", OleDbType.Date).Value = selectedDate;
                        command.Parameters.Add("@turkishLira", OleDbType.Integer).Value = rnd.Next(1000, 20000);  //Kullanıcının para yatırma şansı olmadığı için hesabındaki miktar rastgele belirleniyor.
                        command.Parameters.Add("@euro", OleDbType.Integer).Value = rnd.Next(100, 250);
                        command.Parameters.Add("@dollar", OleDbType.Integer).Value = rnd.Next(150, 500);
                        command.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                MessageBox.Show("Hesabınız Başarıyla Oluşturuldu!");
                Form1 login = new Form1();
                this.Close();
            }
        }

        private void birthDate_Click(object sender, EventArgs e)
        {

        }
    }
}
