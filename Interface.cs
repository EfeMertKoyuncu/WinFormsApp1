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
using System.Collections;

namespace WinFormsApp1
{
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
            Random rnd = new Random();
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\efeme\Documents\securityNo_Password.accdb";
            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbCommand command = new OleDbCommand("Select * from access", conn);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            conn.Open();
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            nameSurname.Text = dataTable.Rows[1][3].ToString();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Döviz döviz = new Döviz();
            döviz.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Hesap";
            Hesap hesap = new Hesap();
            hesap.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CustomerService customerService = new CustomerService();
            customerService.Show();
        }

        private void nameSurname_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dövizkuru kur = new dövizkuru();
            kur.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kartlarım kartlar = new kartlarım();
            kartlar.Show();
            
        }
    }
}
