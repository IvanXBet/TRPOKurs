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


namespace Klomove374
{
    public partial class Panel_redact : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=contract_work.mdb;";
        static OleDbConnection myConnection = new OleDbConnection(connectString);
        public OleDbDataAdapter adapter;
        public DataSet ds;

        public static string[] nameTable = { "[position]", "[project]", "[project-worker]", "[workers]"};
        public OleDbCommandBuilder commandBuilder;
        public Panel_redact()
        {
            
            InitializeComponent();
            
            this.BackColor = System.Drawing.Color.FromArgb(19, 25, 32);


            find_button.FlatAppearance.BorderSize = 0;
            Add_button.FlatAppearance.BorderSize = 0;
            Del_button.FlatAppearance.BorderSize = 0;
            Save_button.FlatAppearance.BorderSize = 0;
            Update_button.FlatAppearance.BorderSize = 0;
        }

        private void Panel_redact_Load(object sender, EventArgs e)
        {
            myConnection.Open();
        }


        private void NameTable_comboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }



        

        

        

        

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Search_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void NameTable_comboBox_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            Search_comboBox.Items.Clear();
            Search_comboBox.Text = "";

            string query = "Select * From " + nameTable[NameTable_comboBox.SelectedIndex];
            adapter = new OleDbDataAdapter(query, myConnection);

            ds = new DataSet();
            adapter.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            for (int i = 0; i <= dataGridView1.ColumnCount - 1; i++)
            {
                Search_comboBox.Items.Add(dataGridView1.Columns[i].HeaderText);
            }
            query = "Select * From " + nameTable[NameTable_comboBox.SelectedIndex] + " Order BY " + dataGridView1.Columns[0].HeaderText;
            adapter = new OleDbDataAdapter(query, myConnection);

            ds = new DataSet();
            adapter.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

            myConnection.Close();
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            if (NameTable_comboBox.Text != "")
            {
                commandBuilder = new OleDbCommandBuilder(adapter);
                adapter.Update(ds);
            }
        }

        private void Del_button_Click(object sender, EventArgs e)
        {
            if (NameTable_comboBox.Text != "")
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            if (NameTable_comboBox.Text != "")
            {
                string query = "Select * From " + nameTable[NameTable_comboBox.SelectedIndex];
                adapter = new OleDbDataAdapter(query, myConnection);

                ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            if (NameTable_comboBox.Text != "")
            {
                DataRow row = ds.Tables[0].NewRow();
                ds.Tables[0].Rows.Add();

                int x = Convert.ToInt32(dataGridView1.RowCount) - 3;

                int stemp = Convert.ToInt32(dataGridView1.Rows[x].Cells[0].Value);


                stemp++;
                dataGridView1.Rows[Convert.ToInt32(x + 1)].Cells[0].Value = stemp;

            }
        }

        private void find_button_Click(object sender, EventArgs e)
        {
            try
            {
                string nameColumn = null, searchValue = null;
                if (Search_comboBox.SelectedItem != null && Search_textBox.Text != null)
                {
                    nameColumn = Search_comboBox.SelectedItem.ToString();

                    string query;
                    searchValue = Search_textBox.Text;

                    if (nameColumn == "ID" || nameColumn == "Price" || nameColumn == "Paymoment_amount" || nameColumn == "Discount(%)" || nameColumn == "ID_Orders" || nameColumn == "Cooking_time" || nameColumn == "Weight" || nameColumn == "Id_Dishes" || nameColumn == "Customer_Code")
                    {

                        query = "Select * From " + nameTable[NameTable_comboBox.SelectedIndex] + " WHERE " + nameColumn + " = " + searchValue;
                    }
                    else if (nameColumn == "Order_Date")
                    {
                        DateTime date1 = new DateTime();
                        date1 = Convert.ToDateTime(searchValue);
                        date1.ToShortDateString();
                        query = "Select * From " + nameTable[NameTable_comboBox.SelectedIndex] + " WHERE " + nameColumn + " Between '" + date1.ToString("dd.MM.yyyy") + "' AND '" + date1.AddDays(1) + "'";

                    }
                    else
                        query = "Select * From " + nameTable[NameTable_comboBox.SelectedIndex] + " WHERE " + nameColumn + " Like '" + searchValue + "%'";
                    adapter = new OleDbDataAdapter(query, myConnection);

                    ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
            catch (Exception q)
            {
                MessageBox.Show(q.Message);
            }
        }
    }
}
