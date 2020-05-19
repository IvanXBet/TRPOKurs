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
    public partial class ProfilSupervaser2 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=contract_work.mdb;";
        private OleDbConnection myConnection;
        public OleDbDataAdapter adapter;
        public DataSet ds;

        public string login;
        public string Log
        {

            get { return login; }
            set { login = value; }

        }

        public ProfilSupervaser2()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.FromArgb(19, 25, 32);
            buttonAddProject.FlatAppearance.BorderSize = 0;
            buttonAddProject.FlatStyle = FlatStyle.Flat;
        }

        private void ProfilSupervaser2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "contract_workDataSet1.request". При необходимости она может быть перемещена или удалена.
            //this.requestTableAdapter.Fill(this.contract_workDataSet1.request);
            labelLoginSuper.Text = Log;


            // создаем экземпляр класса OleDbConnection
            myConnection = new OleDbConnection(connectString);

            // открываем соединение с БД
            myConnection.Open();

            string query = "SELECT [nameWorker], [surnameWorker], [phoneNuber], [IDPosition], [IDWorker] FROM [workers] WHERE login = '" + login + "'";

            // создаем объект OleDbCommand для выполнения запроса к БД MS Access
            OleDbCommand command = new OleDbCommand(query, myConnection);

            OleDbDataReader reader = command.ExecuteReader();

            int IDWorkers = new int();

            while (reader.Read())
            {
                // выводим данные столбцов текущей строки в listBox1
                labelNameSuper.Text = reader[0].ToString();
                labelSurnameSuper.Text = reader[1].ToString();
                labelPhoneSuper.Text = reader[2].ToString();

                int IDP = Convert.ToInt32(reader[3]);

                string query2 = "SELECT namePosition FROM [position] WHERE IDPosition = " + IDP + "";
                OleDbCommand selestNamePositon = new OleDbCommand(query2, myConnection);
                labelPositionSuper.Text = selestNamePositon.ExecuteScalar().ToString();

                IDWorkers = Convert.ToInt32(reader[4]);
            }


            //string queryProject = "SELECT [IDProject], [IDProject] FROM [project-worker] WHERE IDWorker = " + IDWorker + "";
            string queryProject = "SELECT IDProject FROM [project-worker] WHERE IDWorker = " + IDWorkers + "";

            OleDbCommand commandProject = new OleDbCommand(queryProject, myConnection);
            OleDbDataReader readerProject = commandProject.ExecuteReader();

            while (readerProject.Read())
            {
                if (labelProject1Super.Text == " " || labelProject1Super.Text == "" || labelProject1Super.Text == null)
                {
                    labelProject1Super.Text = readerProject[0].ToString();

                    string queryDecsr1 = "SELECT description FROM [project] WHERE IDProject = " + Convert.ToInt32(readerProject[0]) + "";
                    OleDbCommand commandDesct1 = new OleDbCommand(queryDecsr1, myConnection);
                    labelDescr1Super.Text = commandDesct1.ExecuteScalar().ToString();
                }
                else
                    if (labelProject2Super.Text == " " || labelProject2Super.Text == "" || labelProject2Super.Text == null)
                {
                    labelProject2Super.Text = readerProject[0].ToString();

                    string queryDecsr2 = "SELECT description FROM [project] WHERE IDProject = " + Convert.ToInt32(readerProject[0]) + "";
                    OleDbCommand commandDesct2 = new OleDbCommand(queryDecsr2, myConnection);
                    labelDescr2Super.Text = commandDesct2.ExecuteScalar().ToString();
                }
                else
                {
                    labelProject3Super.Text = readerProject[0].ToString();
                    string queryDecsr3 = "SELECT description FROM [project] WHERE IDProject = " + Convert.ToInt32(readerProject[0]) + "";
                    OleDbCommand commandDesct3 = new OleDbCommand(queryDecsr3, myConnection);
                    labelDescr3Super.Text = commandDesct3.ExecuteScalar().ToString();
                }

            }
        }

        private void buttonAddProject_Click(object sender, EventArgs e)
        {
            string StartProject = maskedTextStartProject.Text,
                   EndProject = maskedTextBoxendProject.Text,
                   description = textBoxDescriptionProject.Text;

            if (StartProject !=" " && EndProject != " " && description != " ") {

                // текст запроса

                string query = "INSERT INTO project (startProject, endProject, description) " +
                    "VALUES('" + StartProject + "', '" + EndProject + "', '" + description + "')";

                // создаем объект OleDbCommand для выполнения запроса к БД MS Access
                OleDbCommand command = new OleDbCommand(query, myConnection);

                // выполняем запрос к MS Access
                if (StartProject == " " || EndProject == " " || description == " " || StartProject == "" || EndProject == "" || description == "")
                {
                    labelNoInputProject.Text = "Вы заполнили не все поля";
                }
                else
                    command.ExecuteNonQuery();
                maskedTextStartProject.Text = null;
                maskedTextBoxendProject.Text = null;
                textBoxDescriptionProject.Text = null;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Panel_redact newForm = new Panel_redact();
            newForm.Show();
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            string query = "Select * From request";
            adapter = new OleDbDataAdapter(query, myConnection);

            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
