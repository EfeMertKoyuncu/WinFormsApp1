using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace WinFormsApp1
{

    public partial class CustomerService : Form
    {
        public CustomerService()
        {
            MaximizeBox = false;
            MinimizeBox = false;
            InitializeComponent();
            Random rnd = new Random();
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=customerServices.mdb";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand("Select * from customerService", conn))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                    {
                        using (DataTable dataTable = new DataTable())
                        {
                            try
                            {
                                conn.Open();
                                adapter.Fill(dataTable);
                                int randomRow = rnd.Next(0, 4);
                                csName.Text = "İsim: " + dataTable.Rows[randomRow][1].ToString();
                                csMail.Text = "E-Posta: " + dataTable.Rows[randomRow][2].ToString();
                                csPhone.Text = "Telefon No.:" + dataTable.Rows[randomRow][3].ToString();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
            }
        }
        private void CustomerService_Load(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void label4_Click(object sender, EventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void CustomerService_Load_1(object sender, EventArgs e)
        {
        }
        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void csMail_Click(object sender, EventArgs e)
        {

        }
    }
}
