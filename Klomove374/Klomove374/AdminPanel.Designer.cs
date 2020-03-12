namespace Klomove374
{
    partial class AdminPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.singin = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageWorkers = new System.Windows.Forms.TabPage();
            this.buttonUpdateWorkers = new System.Windows.Forms.Button();
            this.workersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contract_workDataSet = new Klomove374.contract_workDataSet();
            this.tabPagePosition = new System.Windows.Forms.TabPage();
            this.buttonUpdatePosition = new System.Windows.Forms.Button();
            this.dataGridViewPosition = new System.Windows.Forms.DataGridView();
            this.iDPositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namePositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageProject = new System.Windows.Forms.TabPage();
            this.buttonUpdatePoject = new System.Windows.Forms.Button();
            this.dataGridViewProject = new System.Windows.Forms.DataGridView();
            this.iDProjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startProjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endProjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageWorkPos = new System.Windows.Forms.TabPage();
            this.buttonUpdateWorkPos = new System.Windows.Forms.Button();
            this.dataGridViewWorkPos = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDWorkerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDProjectDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumDaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectworkerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workersTableAdapter = new Klomove374.contract_workDataSetTableAdapters.workersTableAdapter();
            this.tableAdapterManager = new Klomove374.contract_workDataSetTableAdapters.TableAdapterManager();
            this.positionTableAdapter = new Klomove374.contract_workDataSetTableAdapters.positionTableAdapter();
            this.projectTableAdapter = new Klomove374.contract_workDataSetTableAdapters.projectTableAdapter();
            this.project_workerTableAdapter = new Klomove374.contract_workDataSetTableAdapters.project_workerTableAdapter();
            this.tabControl.SuspendLayout();
            this.tabPageWorkers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contract_workDataSet)).BeginInit();
            this.tabPagePosition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).BeginInit();
            this.tabPageProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            this.tabPageWorkPos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectworkerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // singin
            // 
            this.singin.AutoSize = true;
            this.singin.Font = new System.Drawing.Font("Yu Gothic UI Light", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.singin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.singin.Location = new System.Drawing.Point(12, 9);
            this.singin.Name = "singin";
            this.singin.Size = new System.Drawing.Size(166, 38);
            this.singin.TabIndex = 4;
            this.singin.Text = "Admin Panel";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageWorkers);
            this.tabControl.Controls.Add(this.tabPagePosition);
            this.tabControl.Controls.Add(this.tabPageProject);
            this.tabControl.Controls.Add(this.tabPageWorkPos);
            this.tabControl.Font = new System.Drawing.Font("Yu Gothic UI Light", 9F);
            this.tabControl.Location = new System.Drawing.Point(12, 50);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(899, 388);
            this.tabControl.TabIndex = 5;
            // 
            // tabPageWorkers
            // 
            this.tabPageWorkers.Controls.Add(this.buttonUpdateWorkers);
            this.tabPageWorkers.Controls.Add(this.workersDataGridView);
            this.tabPageWorkers.Location = new System.Drawing.Point(4, 24);
            this.tabPageWorkers.Name = "tabPageWorkers";
            this.tabPageWorkers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWorkers.Size = new System.Drawing.Size(891, 360);
            this.tabPageWorkers.TabIndex = 0;
            this.tabPageWorkers.Text = "workers";
            this.tabPageWorkers.UseVisualStyleBackColor = true;
            this.tabPageWorkers.Click += new System.EventHandler(this.tabPageWorkers_Click);
            // 
            // buttonUpdateWorkers
            // 
            this.buttonUpdateWorkers.Font = new System.Drawing.Font("Yu Gothic UI Light", 11F);
            this.buttonUpdateWorkers.Location = new System.Drawing.Point(708, 315);
            this.buttonUpdateWorkers.Name = "buttonUpdateWorkers";
            this.buttonUpdateWorkers.Size = new System.Drawing.Size(130, 34);
            this.buttonUpdateWorkers.TabIndex = 3;
            this.buttonUpdateWorkers.Text = "Update";
            this.buttonUpdateWorkers.UseVisualStyleBackColor = true;
            this.buttonUpdateWorkers.Click += new System.EventHandler(this.buttonUpdateWorkers_Click);
            // 
            // workersDataGridView
            // 
            this.workersDataGridView.AutoGenerateColumns = false;
            this.workersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.workersDataGridView.DataSource = this.workersBindingSource;
            this.workersDataGridView.Location = new System.Drawing.Point(6, 16);
            this.workersDataGridView.Name = "workersDataGridView";
            this.workersDataGridView.Size = new System.Drawing.Size(859, 291);
            this.workersDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDWorker";
            this.dataGridViewTextBoxColumn1.HeaderText = "IDWorker";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IDPosition";
            this.dataGridViewTextBoxColumn2.HeaderText = "IDPosition";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nameWorker";
            this.dataGridViewTextBoxColumn3.HeaderText = "nameWorker";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "surnameWorker";
            this.dataGridViewTextBoxColumn4.HeaderText = "surnameWorker";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "descrption";
            this.dataGridViewTextBoxColumn5.HeaderText = "descrption";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "phoneNuber";
            this.dataGridViewTextBoxColumn6.HeaderText = "phoneNuber";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "login";
            this.dataGridViewTextBoxColumn7.HeaderText = "login";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "password";
            this.dataGridViewTextBoxColumn8.HeaderText = "password";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // workersBindingSource
            // 
            this.workersBindingSource.DataMember = "workers";
            this.workersBindingSource.DataSource = this.contract_workDataSet;
            // 
            // contract_workDataSet
            // 
            this.contract_workDataSet.DataSetName = "contract_workDataSet";
            this.contract_workDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPagePosition
            // 
            this.tabPagePosition.Controls.Add(this.buttonUpdatePosition);
            this.tabPagePosition.Controls.Add(this.dataGridViewPosition);
            this.tabPagePosition.Location = new System.Drawing.Point(4, 24);
            this.tabPagePosition.Name = "tabPagePosition";
            this.tabPagePosition.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePosition.Size = new System.Drawing.Size(891, 360);
            this.tabPagePosition.TabIndex = 1;
            this.tabPagePosition.Text = "position";
            this.tabPagePosition.UseVisualStyleBackColor = true;
            // 
            // buttonUpdatePosition
            // 
            this.buttonUpdatePosition.Font = new System.Drawing.Font("Yu Gothic UI Light", 11F);
            this.buttonUpdatePosition.Location = new System.Drawing.Point(697, 318);
            this.buttonUpdatePosition.Name = "buttonUpdatePosition";
            this.buttonUpdatePosition.Size = new System.Drawing.Size(130, 34);
            this.buttonUpdatePosition.TabIndex = 2;
            this.buttonUpdatePosition.Text = "Update";
            this.buttonUpdatePosition.UseVisualStyleBackColor = true;
            this.buttonUpdatePosition.Click += new System.EventHandler(this.buttonUpdatePosition_Click);
            // 
            // dataGridViewPosition
            // 
            this.dataGridViewPosition.AutoGenerateColumns = false;
            this.dataGridViewPosition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPosition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPositionDataGridViewTextBoxColumn,
            this.namePositionDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn});
            this.dataGridViewPosition.DataSource = this.positionBindingSource;
            this.dataGridViewPosition.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewPosition.Name = "dataGridViewPosition";
            this.dataGridViewPosition.Size = new System.Drawing.Size(843, 306);
            this.dataGridViewPosition.TabIndex = 1;
            // 
            // iDPositionDataGridViewTextBoxColumn
            // 
            this.iDPositionDataGridViewTextBoxColumn.DataPropertyName = "IDPosition";
            this.iDPositionDataGridViewTextBoxColumn.HeaderText = "IDPosition";
            this.iDPositionDataGridViewTextBoxColumn.Name = "iDPositionDataGridViewTextBoxColumn";
            // 
            // namePositionDataGridViewTextBoxColumn
            // 
            this.namePositionDataGridViewTextBoxColumn.DataPropertyName = "namePosition";
            this.namePositionDataGridViewTextBoxColumn.HeaderText = "namePosition";
            this.namePositionDataGridViewTextBoxColumn.Name = "namePositionDataGridViewTextBoxColumn";
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            // 
            // positionBindingSource
            // 
            this.positionBindingSource.DataMember = "position";
            this.positionBindingSource.DataSource = this.contract_workDataSet;
            // 
            // tabPageProject
            // 
            this.tabPageProject.Controls.Add(this.buttonUpdatePoject);
            this.tabPageProject.Controls.Add(this.dataGridViewProject);
            this.tabPageProject.Location = new System.Drawing.Point(4, 24);
            this.tabPageProject.Name = "tabPageProject";
            this.tabPageProject.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProject.Size = new System.Drawing.Size(891, 360);
            this.tabPageProject.TabIndex = 2;
            this.tabPageProject.Text = "project";
            this.tabPageProject.UseVisualStyleBackColor = true;
            // 
            // buttonUpdatePoject
            // 
            this.buttonUpdatePoject.Font = new System.Drawing.Font("Yu Gothic UI Light", 11F);
            this.buttonUpdatePoject.Location = new System.Drawing.Point(704, 318);
            this.buttonUpdatePoject.Name = "buttonUpdatePoject";
            this.buttonUpdatePoject.Size = new System.Drawing.Size(130, 34);
            this.buttonUpdatePoject.TabIndex = 3;
            this.buttonUpdatePoject.Text = "Update";
            this.buttonUpdatePoject.UseVisualStyleBackColor = true;
            this.buttonUpdatePoject.Click += new System.EventHandler(this.buttonUpdatePoject_Click);
            // 
            // dataGridViewProject
            // 
            this.dataGridViewProject.AutoGenerateColumns = false;
            this.dataGridViewProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDProjectDataGridViewTextBoxColumn,
            this.startProjectDataGridViewTextBoxColumn,
            this.endProjectDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridViewProject.DataSource = this.projectBindingSource;
            this.dataGridViewProject.Location = new System.Drawing.Point(15, 16);
            this.dataGridViewProject.Name = "dataGridViewProject";
            this.dataGridViewProject.Size = new System.Drawing.Size(839, 298);
            this.dataGridViewProject.TabIndex = 2;
            // 
            // iDProjectDataGridViewTextBoxColumn
            // 
            this.iDProjectDataGridViewTextBoxColumn.DataPropertyName = "IDProject";
            this.iDProjectDataGridViewTextBoxColumn.HeaderText = "IDProject";
            this.iDProjectDataGridViewTextBoxColumn.Name = "iDProjectDataGridViewTextBoxColumn";
            // 
            // startProjectDataGridViewTextBoxColumn
            // 
            this.startProjectDataGridViewTextBoxColumn.DataPropertyName = "startProject";
            this.startProjectDataGridViewTextBoxColumn.HeaderText = "startProject";
            this.startProjectDataGridViewTextBoxColumn.Name = "startProjectDataGridViewTextBoxColumn";
            // 
            // endProjectDataGridViewTextBoxColumn
            // 
            this.endProjectDataGridViewTextBoxColumn.DataPropertyName = "endProject";
            this.endProjectDataGridViewTextBoxColumn.HeaderText = "endProject";
            this.endProjectDataGridViewTextBoxColumn.Name = "endProjectDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataMember = "project";
            this.projectBindingSource.DataSource = this.contract_workDataSet;
            // 
            // tabPageWorkPos
            // 
            this.tabPageWorkPos.Controls.Add(this.buttonUpdateWorkPos);
            this.tabPageWorkPos.Controls.Add(this.dataGridViewWorkPos);
            this.tabPageWorkPos.Location = new System.Drawing.Point(4, 24);
            this.tabPageWorkPos.Name = "tabPageWorkPos";
            this.tabPageWorkPos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWorkPos.Size = new System.Drawing.Size(891, 360);
            this.tabPageWorkPos.TabIndex = 3;
            this.tabPageWorkPos.Text = "workers-position";
            this.tabPageWorkPos.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateWorkPos
            // 
            this.buttonUpdateWorkPos.Font = new System.Drawing.Font("Yu Gothic UI Light", 11F);
            this.buttonUpdateWorkPos.Location = new System.Drawing.Point(687, 312);
            this.buttonUpdateWorkPos.Name = "buttonUpdateWorkPos";
            this.buttonUpdateWorkPos.Size = new System.Drawing.Size(130, 34);
            this.buttonUpdateWorkPos.TabIndex = 3;
            this.buttonUpdateWorkPos.Text = "Update";
            this.buttonUpdateWorkPos.UseVisualStyleBackColor = true;
            this.buttonUpdateWorkPos.Click += new System.EventHandler(this.buttonUpdateWorkPos_Click);
            // 
            // dataGridViewWorkPos
            // 
            this.dataGridViewWorkPos.AutoGenerateColumns = false;
            this.dataGridViewWorkPos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWorkPos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.iDWorkerDataGridViewTextBoxColumn,
            this.iDProjectDataGridViewTextBoxColumn1,
            this.sumSalaryDataGridViewTextBoxColumn,
            this.sumDaysDataGridViewTextBoxColumn});
            this.dataGridViewWorkPos.DataSource = this.projectworkerBindingSource;
            this.dataGridViewWorkPos.Location = new System.Drawing.Point(27, 19);
            this.dataGridViewWorkPos.Name = "dataGridViewWorkPos";
            this.dataGridViewWorkPos.Size = new System.Drawing.Size(816, 285);
            this.dataGridViewWorkPos.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // iDWorkerDataGridViewTextBoxColumn
            // 
            this.iDWorkerDataGridViewTextBoxColumn.DataPropertyName = "IDWorker";
            this.iDWorkerDataGridViewTextBoxColumn.HeaderText = "IDWorker";
            this.iDWorkerDataGridViewTextBoxColumn.Name = "iDWorkerDataGridViewTextBoxColumn";
            // 
            // iDProjectDataGridViewTextBoxColumn1
            // 
            this.iDProjectDataGridViewTextBoxColumn1.DataPropertyName = "IDProject";
            this.iDProjectDataGridViewTextBoxColumn1.HeaderText = "IDProject";
            this.iDProjectDataGridViewTextBoxColumn1.Name = "iDProjectDataGridViewTextBoxColumn1";
            // 
            // sumSalaryDataGridViewTextBoxColumn
            // 
            this.sumSalaryDataGridViewTextBoxColumn.DataPropertyName = "sumSalary";
            this.sumSalaryDataGridViewTextBoxColumn.HeaderText = "sumSalary";
            this.sumSalaryDataGridViewTextBoxColumn.Name = "sumSalaryDataGridViewTextBoxColumn";
            // 
            // sumDaysDataGridViewTextBoxColumn
            // 
            this.sumDaysDataGridViewTextBoxColumn.DataPropertyName = "sumDays";
            this.sumDaysDataGridViewTextBoxColumn.HeaderText = "sumDays";
            this.sumDaysDataGridViewTextBoxColumn.Name = "sumDaysDataGridViewTextBoxColumn";
            // 
            // projectworkerBindingSource
            // 
            this.projectworkerBindingSource.DataMember = "project-worker";
            this.projectworkerBindingSource.DataSource = this.contract_workDataSet;
            // 
            // workersTableAdapter
            // 
            this.workersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.positionTableAdapter = this.positionTableAdapter;
            this.tableAdapterManager.project_workerTableAdapter = null;
            this.tableAdapterManager.projectTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Klomove374.contract_workDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.workersTableAdapter = this.workersTableAdapter;
            // 
            // positionTableAdapter
            // 
            this.positionTableAdapter.ClearBeforeFill = true;
            // 
            // projectTableAdapter
            // 
            this.projectTableAdapter.ClearBeforeFill = true;
            // 
            // project_workerTableAdapter
            // 
            this.project_workerTableAdapter.ClearBeforeFill = true;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(923, 450);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.singin);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageWorkers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.workersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contract_workDataSet)).EndInit();
            this.tabPagePosition.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).EndInit();
            this.tabPageProject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            this.tabPageWorkPos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectworkerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label singin;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageWorkers;
        private System.Windows.Forms.TabPage tabPagePosition;
        private System.Windows.Forms.DataGridView dataGridViewPosition;
        private System.Windows.Forms.TabPage tabPageProject;
        private System.Windows.Forms.DataGridView dataGridViewProject;
        private System.Windows.Forms.TabPage tabPageWorkPos;
        private contract_workDataSet contract_workDataSet;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private contract_workDataSetTableAdapters.workersTableAdapter workersTableAdapter;
        private contract_workDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView workersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private contract_workDataSetTableAdapters.positionTableAdapter positionTableAdapter;
        private System.Windows.Forms.BindingSource positionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namePositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private contract_workDataSetTableAdapters.projectTableAdapter projectTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startProjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endProjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewWorkPos;
        private System.Windows.Forms.BindingSource projectworkerBindingSource;
        private contract_workDataSetTableAdapters.project_workerTableAdapter project_workerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDWorkerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProjectDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumDaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonUpdateWorkers;
        private System.Windows.Forms.Button buttonUpdatePosition;
        private System.Windows.Forms.Button buttonUpdatePoject;
        private System.Windows.Forms.Button buttonUpdateWorkPos;
    }
}