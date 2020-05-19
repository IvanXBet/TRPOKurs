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
    public partial class Profil : Form
    {

        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=contract_work.mdb;";
        private OleDbConnection myConnection;
        

        public string login;
        public string Log {
            
            get {return login; }
            set { login = value; }
        
        }

        public Profil()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.FromArgb(19, 25, 32);
            buttonAdd.FlatAppearance.BorderSize = 0;
            buttonAdd.FlatStyle = FlatStyle.Flat;



        }
        public int IDWorkers = new int();
        private void Profil_Load(object sender, EventArgs e)
        {
            labelLogin.Text = Log;


            // создаем экземпляр класса OleDbConnection
            myConnection = new OleDbConnection(connectString);

            // открываем соединение с БД
            myConnection.Open();

            string query = "SELECT [nameWorker], [surnameWorker], [phoneNuber], [IDPosition], [IDWorker] FROM [workers] WHERE login = '" + login + "'";

            // создаем объект OleDbCommand для выполнения запроса к БД MS Access
            OleDbCommand command = new OleDbCommand(query, myConnection);

            OleDbDataReader reader = command.ExecuteReader();

            
            
            while (reader.Read())
            {
                // выводим данные столбцов текущей строки в listBox1
                labelName.Text = reader[0].ToString();
                labelSurname.Text = reader[1].ToString();
                labelPhone.Text = reader[2].ToString();

                int IDP = Convert.ToInt32(reader[3]);

                string query2 = "SELECT namePosition FROM [position] WHERE IDPosition = "+IDP+"";
                OleDbCommand selestNamePositon = new OleDbCommand(query2, myConnection);
                labelPosition.Text = selestNamePositon.ExecuteScalar().ToString();

                IDWorkers = Convert.ToInt32(reader[4]);
            }

            
            //string queryProject = "SELECT [IDProject], [IDProject] FROM [project-worker] WHERE IDWorker = " + IDWorker + "";
            string queryProject = "SELECT IDProject FROM [project-worker] WHERE IDWorker = " + IDWorkers + "";

            OleDbCommand commandProject = new OleDbCommand(queryProject, myConnection);
            OleDbDataReader readerProject = commandProject.ExecuteReader();

            while (readerProject.Read())
            {
                if (labelProject1.Text == " " || labelProject1.Text == "" || labelProject1.Text == null)
                {
                    labelProject1.Text = readerProject[0].ToString();

                    string queryDecsr1 = "SELECT description FROM [project] WHERE IDProject = " + Convert.ToInt32(readerProject[0]) + "";
                    OleDbCommand commandDesct1 = new OleDbCommand(queryDecsr1, myConnection);
                    labelDescr1.Text = commandDesct1.ExecuteScalar().ToString();
                }
                else
                    if (labelProject2.Text == " " || labelProject2.Text == "" || labelProject2.Text == null)
                {
                    labelProject2.Text = readerProject[0].ToString();

                    string queryDecsr2 = "SELECT description FROM [project] WHERE IDProject = " + Convert.ToInt32(readerProject[0]) + "";
                    OleDbCommand commandDesct2 = new OleDbCommand(queryDecsr2, myConnection);
                    labelDescr2.Text = commandDesct2.ExecuteScalar().ToString();
                }
                else
                {
                    labelProject3.Text = readerProject[0].ToString();
                    string queryDecsr3 = "SELECT description FROM [project] WHERE IDProject = " + Convert.ToInt32(readerProject[0]) + "";
                    OleDbCommand commandDesct3 = new OleDbCommand(queryDecsr3, myConnection);
                    labelDescr3.Text = commandDesct3.ExecuteScalar().ToString();
                }

            }
            
            //string queryIDProject = "SELECT IDProject FROM [project-worker] WHERE IDProject = " + Convert.ToInt32(readerProject[0]) + "";
            string queryNambProject = "SELECT COUNT(*) FROM [project]";
            OleDbCommand commandNambProject = new OleDbCommand(queryNambProject, myConnection);
            
            for (int i = 1; i <= Convert.ToInt32(commandNambProject.ExecuteScalar()); i++)
            {
                string queryIDProject = "SELECT COUNT(*) FROM [project-worker] WHERE IDProject =" + i + "";
                OleDbCommand commandIDProject = new OleDbCommand(queryIDProject, myConnection);
                
                if (Convert.ToInt32(commandIDProject.ExecuteScalar()) < 5)
                {
                   


                }
                string queryIDProjectDescr = "SELECT description FROM [project] WHERE IDProject =" + i + "";
                OleDbCommand commandIDProjectDescr = new OleDbCommand(queryIDProjectDescr, myConnection);
                comboBoxLiberProject.Items.Add("ID Проекта: " + i + " - " + commandIDProjectDescr.ExecuteScalar().ToString());
            }



        }

        private void labelProfil_Click(object sender, EventArgs e)
        {

        }

        private void Profil_FormClosed(object sender, FormClosedEventArgs e)
        {
            myConnection.Close();
        }

        private void Project_Click(object sender, EventArgs e)
        {

        }
        
        private void comboBoxLiberProject_SelectionChangeCommitted(object sender, EventArgs e)
        {


        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //string IDProjectSelect = " ";
            //IDProjectSelect = Convert.ToString(comboBoxLiberProject.Text);
            //label3.Text = IDProjectSelect;
            


            // текст запроса

            string query = "INSERT INTO request ([IDWorker], desiredProject) " + "VALUES('" + IDWorkers + "', ' " +comboBoxLiberProject.Text+ " ')";

            // создаем объект OleDbCommand для выполнения запроса к БД MS Access
            OleDbCommand command = new OleDbCommand(query, myConnection);

            // выполняем запрос к MS Access
            //if (name == " " || surname == " " || position == " " || phone == " " || login == " " || password == " " ||
            //    name == "" || surname == "" || position == "" || phone == "" || login == "" || password == "")
            //{
                
            //}
            //else
                command.ExecuteNonQuery();


            done.Text = "Готово";

        }
        
        private void comboBoxLiberProject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }


}
