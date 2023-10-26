using System;

namespace WinFormCRUD
{
   public partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);

       
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.GetEmployee = new System.Windows.Forms.Button();
            this.EmployeeData = new System.Windows.Forms.Button();
            this.InsertEmpl = new System.Windows.Forms.Button();
            this.UpdateEmpl = new System.Windows.Forms.Button();
            this.DelEmpl = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GetEmployee
            // 
            this.GetEmployee.Location = new System.Drawing.Point(639, 59);
            this.GetEmployee.Name = "GetEmployee";
            this.GetEmployee.Size = new System.Drawing.Size(127, 58);
            this.GetEmployee.TabIndex = 1;
            this.GetEmployee.Text = "Получить данные о  сотруднике";
            this.GetEmployee.UseVisualStyleBackColor = true;
            this.GetEmployee.Click += new System.EventHandler(this.GetEmployee_Click);
            // 
            // EmployeeData
            // 
            this.EmployeeData.Location = new System.Drawing.Point(93, 193);
            this.EmployeeData.Name = "EmployeeData";
            this.EmployeeData.Size = new System.Drawing.Size(128, 58);
            this.EmployeeData.TabIndex = 2;
            this.EmployeeData.Text = "Данные о сотрудниках";
            this.EmployeeData.UseVisualStyleBackColor = true;
            this.EmployeeData.Click += new System.EventHandler(this.buttonGetAll_Click);
            // 
            // InsertEmpl
            // 
            this.InsertEmpl.Location = new System.Drawing.Point(259, 193);
            this.InsertEmpl.Name = "InsertEmpl";
            this.InsertEmpl.Size = new System.Drawing.Size(128, 58);
            this.InsertEmpl.TabIndex = 3;
            this.InsertEmpl.Text = "Добавить сотрудника";
            this.InsertEmpl.UseVisualStyleBackColor = true;
            this.InsertEmpl.Click += new System.EventHandler(this.insertEmployee_Click);
            // 
            // UpdateEmpl
            // 
            this.UpdateEmpl.Location = new System.Drawing.Point(443, 193);
            this.UpdateEmpl.Name = "UpdateEmpl";
            this.UpdateEmpl.Size = new System.Drawing.Size(127, 58);
            this.UpdateEmpl.TabIndex = 4;
            this.UpdateEmpl.Text = "Обновить данные сотрудника";
            this.UpdateEmpl.UseVisualStyleBackColor = true;
            this.UpdateEmpl.Click += new System.EventHandler(this.UpdateEmpl_Click);
            // 
            // DelEmpl
            // 
            this.DelEmpl.Location = new System.Drawing.Point(639, 193);
            this.DelEmpl.Name = "DelEmpl";
            this.DelEmpl.Size = new System.Drawing.Size(127, 58);
            this.DelEmpl.TabIndex = 5;
            this.DelEmpl.Text = "Удалить данные о сотруднике";
            this.DelEmpl.UseVisualStyleBackColor = true;
            this.DelEmpl.Click += new System.EventHandler(this.DelEmpl_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 273);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(803, 165);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // npgsqlDataAdapter1
            // 
            this.npgsqlDataAdapter1.DeleteCommand = null;
            this.npgsqlDataAdapter1.InsertCommand = null;
            this.npgsqlDataAdapter1.SelectCommand = null;
            this.npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(143, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Имя:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Контактный номер:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Адрес проживания:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(0, 0);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(125, 22);
            this.textEdit1.TabIndex = 0;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(226, 54);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(183, 22);
            this.txtFullName.TabIndex = 10;
            this.txtFullName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(226, 86);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(183, 22);
            this.txtPhoneNumber.TabIndex = 11;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(226, 120);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(183, 22);
            this.txtAddress.TabIndex = 12;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(226, 26);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(183, 22);
            this.txtId.TabIndex = 13;
            this.txtId.TabStop = false;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID.Location = new System.Drawing.Point(162, 30);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(34, 24);
            this.ID.TabIndex = 14;
            this.ID.Text = "ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 450);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DelEmpl);
            this.Controls.Add(this.UpdateEmpl);
            this.Controls.Add(this.InsertEmpl);
            this.Controls.Add(this.EmployeeData);
            this.Controls.Add(this.GetEmployee);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[C#]CRUD";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button GetEmployee;
        private System.Windows.Forms.Button EmployeeData;
        private System.Windows.Forms.Button InsertEmpl;
        private System.Windows.Forms.Button UpdateEmpl;
        private System.Windows.Forms.Button DelEmpl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label ID;
    }
}

