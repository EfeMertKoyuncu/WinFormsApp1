using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class paraTransferi : Form
    {
        private int _rowNum;
        private int radioCheck = 0; // Initialize radioCheck to 0 to indicate no selection

        public int RowNum
        {
            get { return _rowNum; }
            set { _rowNum = value; }
        }
        public int RadioCheck
        {
            get { return radioCheck; }
            set { radioCheck = value; }
        }
        public paraTransferi(int rowNum)
        {
            InitializeComponent();
            InitializeRadioButtons();
            this.RowNum = rowNum;
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void InitializeRadioButtons()
        {

            GroupBox groupBox = new GroupBox();


            // Initialize RadioButtons
            RadioButton radioButton1 = new RadioButton { Text = ".", Location = new Point(643, 181) };
            RadioButton radioButton2 = new RadioButton { Text = ",", Location = new Point(862, 181)};
            RadioButton radioButton3 = new RadioButton { Text = "*", Location = new Point(997, 181) };



            // Subscribe to the CheckedChanged event
            radioButton1.CheckedChanged += RadioButton_CheckedChanged;
            radioButton2.CheckedChanged += RadioButton_CheckedChanged;
            radioButton3.CheckedChanged += RadioButton_CheckedChanged;

            // Add RadioButtons to the GroupBox
            groupBox.Controls.Add(radioButton1);
            groupBox.Controls.Add(radioButton2);
            groupBox.Controls.Add(radioButton3);

            // Add the GroupBox to the form
            this.Controls.Add(groupBox);
            groupBox.BackColor = Color.Transparent;
            groupBox.FlatStyle = FlatStyle.Flat;
            groupBox.Dock = DockStyle.Fill;
        }

        private void paraTransferi_Load(object sender, EventArgs e)
        {
            // Perform any necessary load operations
        }

        private void gonderButon_Click(object sender, EventArgs e)
        {
            int currentRowNum = this.RowNum;
            int currentRadio = this.RadioCheck;
            string connectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=securityNo_Password.mdb";
            string query = "SELECT Id FROM access WHERE Tc = ? AND isimSoyisim = ?";

            using (OleDbConnection connect = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(query, connect))
                {
                    command.Parameters.AddWithValue("@Tc", hesapNoText.Text);
                    command.Parameters.AddWithValue("@isimSoyisim", isimSoyisimText.Text);
                    try
                    {
                        connect.Open();
                        using (OleDbDataReader reader = command.ExecuteReader())
                        {

                            using (OleDbConnection conn = new OleDbConnection(connectionString))
                            {
                                using (OleDbCommand commandMoney = new OleDbCommand("Select * from access", conn))
                                {
                                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(commandMoney))
                                    {
                                        try
                                        {

                                            conn.Open();
                                            DataTable dataTable = new DataTable();
                                            adapter.Fill(dataTable);
                                            int userTl = Convert.ToInt32(dataTable.Rows[currentRowNum - 14][5]);
                                            int userDollar = Convert.ToInt32(dataTable.Rows[currentRowNum - 14][7]);
                                            int userEuro = Convert.ToInt32(dataTable.Rows[currentRowNum - 14][6]);

                                            if (reader.Read())
                                            {
                                                int rowNum = reader.GetInt32(0);
                                                if (!paraMiktarıText.Text.All(Char.IsDigit) || string.IsNullOrWhiteSpace(paraMiktarıText.Text) || Convert.ToInt32(paraMiktarıText.Text) < 0)
                                                {
                                                    MessageBox.Show("Geçersiz Para Girdisi!");
                                                }
                                                else
                                                {
                                                    int userInputMoney = Convert.ToInt32(paraMiktarıText.Text);
                                                    if (radioCheck == 1)
                                                    {
                                                        if (userInputMoney >= userTl)
                                                        {
                                                            MessageBox.Show("Girmiş Olduğunuz Miktar Sahip Olduğunuz Miktardan Fazladır!");
                                                        }
                                                        else
                                                        {
                                                            userTl = userTl - userInputMoney;
                                                            dataTable.Rows[currentRowNum - 14][5] = userTl;
                                                            int temp = Convert.ToInt32(dataTable.Rows[rowNum - 14][5]);
                                                            dataTable.Rows[rowNum - 14][5] = temp + userTl;
                                                        }
                                                    }
                                                    else if (radioCheck == 2)
                                                    {
                                                        if (userInputMoney >= userDollar)
                                                        {
                                                            MessageBox.Show("Girmiş Olduğunuz Miktar Sahip Olduğunuz Miktardan Fazladır!");
                                                        }
                                                        else
                                                        {
                                                            userDollar = userDollar - userInputMoney;
                                                            dataTable.Rows[currentRowNum - 14][7] = userDollar;
                                                            int temp = Convert.ToInt32(dataTable.Rows[rowNum - 14][7]);
                                                            dataTable.Rows[rowNum - 14][7] = temp + userDollar;
                                                        }
                                                    }
                                                    else if (radioCheck == 3)
                                                    {
                                                        if (userInputMoney >= userEuro)
                                                        {
                                                            MessageBox.Show("Girmiş Olduğunuz Miktar Sahip Olduğunuz Miktardan Fazladır!");
                                                        }
                                                        else
                                                        {
                                                            userEuro = userEuro - userInputMoney;
                                                            dataTable.Rows[currentRowNum - 14][6] = userEuro;
                                                            int temp = Convert.ToInt32(dataTable.Rows[rowNum - 14][6]);
                                                            dataTable.Rows[rowNum - 14][6] = temp + userEuro;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Bir Para Birimi Seçilmelidir!");
                                                    }
                                                }


                                            }
                                            else
                                            {
                                                MessageBox.Show("Hatalı Hesap Bilgisi!");
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show(ex.ToString());
                                        }
                                    }
                                }


                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Beklenmeyen bir hata oluştu, lütfen tekrar deneyin!");
                    }
                }
            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton changedRadioButton = sender as RadioButton;
            if (changedRadioButton != null && changedRadioButton.Checked)
            {
                if (changedRadioButton.Text == ".")
                {
                    radioCheck = 1;

                }
                else if (changedRadioButton.Text == ",")
                {
                    radioCheck = 2;

                }
                else if (changedRadioButton.Text == "*")
                {
                    radioCheck = 3;

                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void paraMiktarıText_TextChanged(object sender, EventArgs e)
        {
            // Handle text changed event for paraMiktarıText
        }

        private void baslikLabel_Click(object sender, EventArgs e)
        {
            // Handle label click event
        }

        private void hesapNoLabel_Click(object sender, EventArgs e)
        {
            // Handle label click event
        }

        private void isimSoyisimLabel_Click(object sender, EventArgs e)
        {
            // Handle label click event
        }

        private void hesapNoText_TextChanged(object sender, EventArgs e)
        {
            // Handle text changed event for hesapNoText
        }

        private void isimSoyisimText_TextChanged(object sender, EventArgs e)
        {
            // Handle text changed event for isimSoyisimText
        }

        private void paraBirimiLabel_Click(object sender, EventArgs e)
        {
            // Handle label click event
        }

        private void tlCheck_CheckedChanged(object sender, EventArgs e)
        {
            // Handle check changed event for tlCheck
        }

        private void dolarCheck_CheckedChanged(object sender, EventArgs e)
        {
            // Handle check changed event for dolarCheck
        }

        private void euroCheck_CheckedChanged(object sender, EventArgs e)
        {
            // Handle check changed event for euroCheck
        }

        private void paraMiktarıLabel_Click(object sender, EventArgs e)
        {
            // Handle label click event
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle selected index changed event for checkedListBox1
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
