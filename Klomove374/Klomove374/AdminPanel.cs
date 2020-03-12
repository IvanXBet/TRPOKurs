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
    public partial class AdminPanel : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=contract_work.mdb;";
        private OleDbConnection myConnection;


        OleDbDataAdapter adap;
        OleDbCommandBuilder cb;
        DataTable dt = new DataTable();

        public AdminPanel()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.FromArgb(19, 25, 32);

            myConnection = new OleDbConnection(connectString);

        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "contract_workDataSet._project_worker". При необходимости она может быть перемещена или удалена.
            this.project_workerTableAdapter.Fill(this.contract_workDataSet._project_worker);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "contract_workDataSet.project". При необходимости она может быть перемещена или удалена.
            this.projectTableAdapter.Fill(this.contract_workDataSet.project);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "contract_workDataSet.position". При необходимости она может быть перемещена или удалена.
            this.positionTableAdapter.Fill(this.contract_workDataSet.position);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "contract_workDataSet.workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.contract_workDataSet.workers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "contract_workDataSet.workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.contract_workDataSet.workers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "contract_workDataSet.workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.contract_workDataSet.workers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "contract_workDataSet.workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.contract_workDataSet.workers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "contract_workDataSet.workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.contract_workDataSet.workers);


        }

        private void workersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.workersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contract_workDataSet);

        }

        private void workersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.workersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contract_workDataSet);

        }

        private void tabPageWorkers_Click(object sender, EventArgs e)
        {

        }

        private void workersBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.workersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contract_workDataSet);

        }

        private void buttonUpdateWorkers_Click(object sender, EventArgs e)
        {
            myConnection.Open();
            adap = new OleDbDataAdapter("SELECT * FROM workers", myConnection);


            cb = new OleDbCommandBuilder(adap);
            adap.Update(dt);
            dt = new DataTable();
            adap.Fill(dt);
            workersDataGridView.DataSource = dt;

            myConnection.Close();
        }

        private void buttonUpdatePosition_Click(object sender, EventArgs e)
        {
            myConnection.Open();
            adap = new OleDbDataAdapter("SELECT * FROM position", myConnection);


            cb = new OleDbCommandBuilder(adap);
            adap.Update(dt);
            dt = new DataTable();
            adap.Fill(dt);
            dataGridViewPosition.DataSource = dt;

            myConnection.Close();
        }

        private void buttonUpdatePoject_Click(object sender, EventArgs e)
        {
            myConnection.Open();
            adap = new OleDbDataAdapter("SELECT * FROM project", myConnection);


            cb = new OleDbCommandBuilder(adap);
            adap.Update(dt);
            dt = new DataTable();
            adap.Fill(dt);
            dataGridViewProject.DataSource = dt;

            myConnection.Close();
        }

        private void buttonUpdateWorkPos_Click(object sender, EventArgs e)
        {
            myConnection.Open();
            adap = new OleDbDataAdapter("SELECT * FROM workers-project", myConnection);


            cb = new OleDbCommandBuilder(adap);
            adap.Update(dt);
            dt = new DataTable();
            adap.Fill(dt);
            dataGridViewWorkPos.DataSource = dt;

            myConnection.Close();
        }
    }
}
