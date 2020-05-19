namespace Klomove374
{
    partial class Panel_redact
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
            this.NameTable_comboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Search_comboBox = new System.Windows.Forms.ComboBox();
            this.Search_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.find_button = new System.Windows.Forms.Button();
            this.Add_button = new System.Windows.Forms.Button();
            this.Del_button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.Update_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // NameTable_comboBox
            // 
            this.NameTable_comboBox.BackColor = System.Drawing.Color.Gray;
            this.NameTable_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTable_comboBox.FormattingEnabled = true;
            this.NameTable_comboBox.Items.AddRange(new object[] {
            "Должности",
            "Проекты",
            "Сотрудник - Проект",
            "Сотрудники"});
            this.NameTable_comboBox.Location = new System.Drawing.Point(34, 34);
            this.NameTable_comboBox.Name = "NameTable_comboBox";
            this.NameTable_comboBox.Size = new System.Drawing.Size(200, 23);
            this.NameTable_comboBox.TabIndex = 0;
            this.NameTable_comboBox.SelectionChangeCommitted += new System.EventHandler(this.NameTable_comboBox_SelectionChangeCommitted_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1284, 422);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(370, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Выберите поле";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Search_comboBox
            // 
            this.Search_comboBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Search_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_comboBox.Font = new System.Drawing.Font("Yu Gothic UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_comboBox.ForeColor = System.Drawing.SystemColors.Window;
            this.Search_comboBox.FormattingEnabled = true;
            this.Search_comboBox.Location = new System.Drawing.Point(347, 34);
            this.Search_comboBox.Name = "Search_comboBox";
            this.Search_comboBox.Size = new System.Drawing.Size(142, 23);
            this.Search_comboBox.TabIndex = 7;
            this.Search_comboBox.SelectedIndexChanged += new System.EventHandler(this.Search_comboBox_SelectedIndexChanged);
            // 
            // Search_textBox
            // 
            this.Search_textBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Search_textBox.Font = new System.Drawing.Font("Yu Gothic UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_textBox.ForeColor = System.Drawing.SystemColors.Window;
            this.Search_textBox.Location = new System.Drawing.Point(539, 36);
            this.Search_textBox.Name = "Search_textBox";
            this.Search_textBox.Size = new System.Drawing.Size(195, 23);
            this.Search_textBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(580, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Введите значение";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // find_button
            // 
            this.find_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.find_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.find_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.find_button.Font = new System.Drawing.Font("Yu Gothic UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.find_button.ForeColor = System.Drawing.Color.White;
            this.find_button.Location = new System.Drawing.Point(793, 36);
            this.find_button.Name = "find_button";
            this.find_button.Size = new System.Drawing.Size(142, 26);
            this.find_button.TabIndex = 11;
            this.find_button.Text = "Поиск";
            this.find_button.UseVisualStyleBackColor = false;
            this.find_button.Click += new System.EventHandler(this.find_button_Click);
            // 
            // Add_button
            // 
            this.Add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Add_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Add_button.FlatAppearance.BorderSize = 0;
            this.Add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_button.Font = new System.Drawing.Font("Yu Gothic UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_button.ForeColor = System.Drawing.Color.White;
            this.Add_button.Location = new System.Drawing.Point(34, 520);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(142, 26);
            this.Add_button.TabIndex = 12;
            this.Add_button.Text = "Добавить строку";
            this.Add_button.UseVisualStyleBackColor = false;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Del_button
            // 
            this.Del_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Del_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Del_button.FlatAppearance.BorderSize = 0;
            this.Del_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Del_button.Font = new System.Drawing.Font("Yu Gothic UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Del_button.ForeColor = System.Drawing.Color.White;
            this.Del_button.Location = new System.Drawing.Point(220, 520);
            this.Del_button.Name = "Del_button";
            this.Del_button.Size = new System.Drawing.Size(142, 26);
            this.Del_button.TabIndex = 13;
            this.Del_button.Text = "Удалить строку";
            this.Del_button.UseVisualStyleBackColor = false;
            this.Del_button.Click += new System.EventHandler(this.Del_button_Click);
            // 
            // Save_button
            // 
            this.Save_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Save_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_button.Font = new System.Drawing.Font("Yu Gothic UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save_button.ForeColor = System.Drawing.Color.White;
            this.Save_button.Location = new System.Drawing.Point(944, 580);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(142, 26);
            this.Save_button.TabIndex = 14;
            this.Save_button.Text = "Сохранить";
            this.Save_button.UseVisualStyleBackColor = false;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // Update_button
            // 
            this.Update_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Update_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Update_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_button.Font = new System.Drawing.Font("Yu Gothic UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Update_button.ForeColor = System.Drawing.Color.White;
            this.Update_button.Location = new System.Drawing.Point(1115, 580);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(142, 26);
            this.Update_button.TabIndex = 15;
            this.Update_button.Text = "Обновить";
            this.Update_button.UseVisualStyleBackColor = false;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // Panel_redact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 618);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Del_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.find_button);
            this.Controls.Add(this.Search_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Search_comboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.NameTable_comboBox);
            this.Name = "Panel_redact";
            this.Text = "Panel_redact";
            this.Load += new System.EventHandler(this.Panel_redact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox NameTable_comboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Search_comboBox;
        private System.Windows.Forms.TextBox Search_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button find_button;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Del_button;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button Update_button;
    }
}