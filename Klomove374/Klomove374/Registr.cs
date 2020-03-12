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
    public partial class Registr : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=contract_work.mdb;";
        //public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=группа 374 Климов Иван contract_work.mdb;";

        private OleDbConnection myConnection;
        public Registr()
        {
            InitializeComponent();

            // создаем экземпляр класса OleDbConnection
            myConnection = new OleDbConnection(connectString);

            // открываем соединение с БД
            myConnection.Open();

            
           






            this.BackColor = System.Drawing.Color.FromArgb(19, 25, 32);

           

            buttonNewRegist.FlatAppearance.BorderSize = 0;
            buttonNewRegist.FlatStyle = FlatStyle.Flat;

            

        }

        private void Registr_Load(object sender, EventArgs e)
        {

        }

        private void Registr_FormClosed(object sender, FormClosedEventArgs e)
        {
            myConnection.Close();
        }
        private void textboxNewPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                // ввод в texBox только цифр и кнопки Backspace
                char ch = e.KeyChar;
                if (!Char.IsDigit(ch) && ch != 8)
                {
                    e.Handled = true;
                }
            }
        }
        private void buttonNewRegist_Click(object sender, EventArgs e)
        {
            Registr form = new Registr();

            string name = textboxNewName.Text,
                   surname = textboxNewSurname.Text,
                   position = textboxNewPosition.Text,
                   phone = textboxNewPhone.Text,
                   login = textboxNewLogin.Text,
                   password = textboxNewPassword.Text;



            // текст запроса

            string query = "INSERT INTO workers (IDPosition, nameWorker, surnameWorker, phoneNuber, login, [password]) " +
                "VALUES('" + position + "', '" + name + "', '" + surname + "', '" + phone + "', '" + login + "', '" + password + "')";

            // создаем объект OleDbCommand для выполнения запроса к БД MS Access
            OleDbCommand command = new OleDbCommand(query, myConnection);

            // выполняем запрос к MS Access
            if (name == " " || surname==" " || position == " " || phone == " " || login == " " || password == " " ||
                name == "" || surname == "" || position == "" || phone == "" || login == "" || password == "")
            {
                noInput.Text = "Вы заполнили не все поля";
            }
            else
            command.ExecuteNonQuery();

            this.Close();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(label3, "1 - Супервайзер \n2 - Мерчиндайзер \n3 - Промоутер\n4 - Тайный покупатель");

            
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
