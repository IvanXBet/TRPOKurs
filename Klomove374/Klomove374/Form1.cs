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
    public partial class Form1 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=contract_work.mdb;";
        //public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=contract_work.mdb;";
        public Form1()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.FromArgb(19, 25, 32);

            buttonSingin.FlatAppearance.BorderSize = 0;
            buttonSingin.FlatStyle = FlatStyle.Flat;

            

            login.Padding = new Padding(0, 0, 0, 0);
            login.BorderStyle = BorderStyle.FixedSingle;

            // создаем экземпляр класса OleDbConnection
            myConnection = new OleDbConnection(connectString);

            // открываем соединение с БД
            myConnection.Open();
        }

        private OleDbConnection myConnection;

        private void Form1_Load(object sender, EventArgs e)
        {
            string queryNumLins = "SELECT COUNT(*) FROM [project-worker]";
            OleDbCommand commandNumLins = new OleDbCommand(queryNumLins, myConnection);
            for (int i = 1; i <= Convert.ToInt32(commandNumLins.ExecuteScalar()); i++) {
                string queryIDWorker = "SELECT [IDWorker] FROM [project-worker] WHERE ID = " + i + "";
                OleDbCommand commandIDWorker = new OleDbCommand(queryIDWorker, myConnection);
                
                string queryIDPosition = "SELECT [IDPosition] FROM [workers] WHERE IDWorker = " + Convert.ToInt32(commandIDWorker.ExecuteScalar()) + "";
                OleDbCommand commandIDPosition = new OleDbCommand(queryIDPosition, myConnection);
                

                string querySalary = "SELECT [salary] FROM [position] WHERE IDPosition = " + Convert.ToInt32(commandIDPosition.ExecuteScalar()) + "";
                OleDbCommand commandSalary = new OleDbCommand(querySalary, myConnection);
                

                string query = "UPDATE [project-worker] SET sumSalary = " + Convert.ToInt32(commandSalary.ExecuteScalar())+ " WHERE [ID] = " + i + "";

                
                OleDbCommand command = new OleDbCommand(query, myConnection);

                command.ExecuteNonQuery();
            }


            //OleDbCommand command = new OleDbCommand("SELECT COUNT(*) FROM [project-worker] WHERE ", myConnection);

            //int sumLine = Convert.ToInt32(command.ExecuteScalar());

            ////singin.Text = command.ExecuteScalar().ToString();

            //for (int i = 0; i > sumLine; i++)
            //{
            //    string query = "SELECT [IDWorker], [IDProject] FROM project-worker WHERE [ID] = " + i + "";

            //    OleDbCommand command2 = new OleDbCommand(query, myConnection);


            //    OleDbDataReader reader = command2.ExecuteReader();

            //    while (reader.Read())
            //    {

            //        string query2 = "SELECT [IDPosition] FROM workers WHERE [IDWorker] = " + Convert.ToInt32(reader[0]) + "";
            //        OleDbCommand command3 = new OleDbCommand(query2, myConnection);


            //        string query3 = "SELECT [salary] FROM position WHERE [IDPosition] = " + Convert.ToInt32(command3.ExecuteScalar()) + "";
            //        OleDbCommand command4 = new OleDbCommand(query2, myConnection);

            //        string qwer = command4.ExecuteScalar().ToString();

            //        string query4 = "INSERT INTO project-workers (sumSalary) VALUES('" + qwer + "')";

            //        OleDbCommand command5 = new OleDbCommand(query4, myConnection);

            //        // выполняем запрос к MS Access
            //        command5.ExecuteNonQuery();



            //        //string query5 = "SELECT [endProject], [startProject] FROM project WHERE [IDProject] = " + Convert.ToInt32(reader[1]) + "";

            //        //OleDbCommand command6 = new OleDbCommand(query5, myConnection);


            //        //OleDbDataReader reader2 = command2.ExecuteReader();
            //        //while (reader2.Read()) {
            //        //    string query6 = "INSERT INTO project-workers (sumSalary) VALUES('" + Convert.ToDateTime(reader2[0]) - Convert.ToDateTime(reader2[1]) + "')";



            //        //}
            //    }
            //}





        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registr newForm = new Registr();
            newForm.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            myConnection.Close();
        }
        

        
        private void buttonSingin_Click(object sender, EventArgs e)
        {
            
            Form1 secondForm = new Form1();
            ProfilSupervaser2 ProfilSupervaser2 = new ProfilSupervaser2();
            AdminPanel adminpanel = new AdminPanel();
            Profil profil = new Profil();
            
            string[] massNameAdm = new string[3];
            string[] massPassAdm = new string[3];

            massNameAdm[0] = "1A";
            massPassAdm[0] = "1A";

            massNameAdm[1] = "Name2A";
            massPassAdm[1] = "Password2A";

            massNameAdm[2] = "Name3A";
            massPassAdm[2] = "Password3A";

            for (int i = 0; i < massNameAdm.Length; i++)
            {
                for (int z = 0; z < massPassAdm.Length; z++)
                {
                    if (login.Text == massNameAdm[i] && password.Text == massPassAdm[z] && i == z)
                    {
                        adminpanel.Show();
                        break;
                    }
                    else
                    {
                        singin.Text = "Попробуйте ещё";

                    }
                }
            }
           



            // текст запроса
            string query = "SELECT [password] FROM workers WHERE [login] = '"+login.Text+"'";
            

            // создаем объект OleDbCommand для выполнения запроса к БД MS Access
            OleDbCommand command = new OleDbCommand(query, myConnection);

            //var arrivePassword = command.ExecuteScalar().ToString();
            if (command.ExecuteScalar() != null)
            {
                if (command.ExecuteScalar().ToString() != password.Text)
                {
                    singin.Text = "Пароль не верный";
                    
                }
                else
                {
                    string query2 = "SELECT [IDPosition] FROM workers WHERE [login] = '" + login.Text + "'";
                    OleDbCommand command2 = new OleDbCommand(query2, myConnection);
                    if (Convert.ToInt32(command2.ExecuteScalar()) == 1)
                    {
                        ProfilSupervaser2.Log = login.Text;
                        singin.Text = "Sing in";
                        ProfilSupervaser2.Show();

                    }
                    else {
                        profil.Log = login.Text;
                        profil.Show();
                        singin.Text = "Sing in";
                    }
                    
                }
            }
            else
            {
                singin.Text = "Попробуйте ещё";
            }

        }

        private void login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                password.Focus();
            }
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSingin.Focus();
            }

        }
    }
}
