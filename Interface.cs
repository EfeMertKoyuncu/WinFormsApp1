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
using System.Collections.ObjectModel;
using HtmlAgilityPack;
using System.Net;

namespace WinFormsApp1
{
    public partial class Interface : Form
    {
        private int _rowNum;

        public int RowNum
        {
            get { return _rowNum; }
            set { _rowNum = value; }
        }
        public void getDollar()
        {
            WebClient client = new WebClient();
            Uri dolar = new Uri("https://www.google.com/finance/quote/USD-TRY?hl=tr");
            HtmlAgilityPack.HtmlDocument dokumanDolar = new HtmlAgilityPack.HtmlDocument();
            string htmlDolar = client.DownloadString(dolar);
            dokumanDolar.LoadHtml(htmlDolar);
            HtmlNode htmlNode = dokumanDolar.DocumentNode.SelectSingleNode("//div[contains(@class, 'YMlKec fxKbKc')]");
            string dollarExchangeRate = htmlNode.InnerText;
            dolarKur.Text = "Dolar Kuru: " + dollarExchangeRate + "$";
        }
        public void getEuro()
        {
            WebClient client = new WebClient();
            Uri euro = new Uri("https://www.google.com/finance/quote/EUR-TRY?hl=tr");
            string htmlEuro = client.DownloadString(euro);
            HtmlAgilityPack.HtmlDocument dokumanEuro = new HtmlAgilityPack.HtmlDocument();
            dokumanEuro.LoadHtml(htmlEuro);
            HtmlNode htmlNode1 = dokumanEuro.DocumentNode.SelectSingleNode("//div[contains(@class, 'YMlKec fxKbKc')]");
            string euroExchangeRate = htmlNode1.InnerText;
            euroKur.Text = "Euro Kuru: " + euroExchangeRate + "€";


        }
        public Interface(int rowNum)
        {
            this.RowNum = rowNum;
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;

            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=securityNo_Password.mdb";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                OleDbCommand command = new OleDbCommand("Select * from access", conn);
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                {
                    try
                    {

                        conn.Open();
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        nameSurname.Text = dataTable.Rows[rowNum - 14][3].ToString();
                        tlMiktar.Text = "TL Bakiye: " + dataTable.Rows[rowNum - 14][5].ToString() + "₺";
                        euroMiktar.Text = "Euro Bakiye: " + dataTable.Rows[rowNum - 14][6].ToString() + "€";
                        dolarMiktar.Text = "Dolar Bakiye: " + dataTable.Rows[rowNum - 14][7].ToString() + "$";

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            getDollar();
            getEuro();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button7_Click(object sender, EventArgs e)
        {
            CustomerService customerService = new CustomerService();
            customerService.Show();
        }
        private void nameSurname_Click(object sender, EventArgs e)
        {

        }
        private void Interface_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void dolarKur_Click(object sender, EventArgs e)
        {

        }
        private void euroKur_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int currentRowNum = this.RowNum;
            paraTransferi paratransferi = new paraTransferi(currentRowNum);
            paratransferi.Show();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void tlMiktar_Click(object sender, EventArgs e)
        {

        }
        private void dolarMiktar_Click(object sender, EventArgs e)
        {

        }
        private void euroMiktar_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
