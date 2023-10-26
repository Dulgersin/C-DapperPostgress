using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormCRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGetAll_Click(object sender, EventArgs e)
        {
            var data = PostgresCrud.GetAll<Employee>();

            dataGridView1.DataSource = data;
        }

        private void insertEmployee_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text;
            string address = txtAddress.Text;
            string phoneNumber = txtPhoneNumber.Text;

            if (string.IsNullOrWhiteSpace(fullName))
            {
                XtraMessageBox.Show("Пожалуйста, введите своё имя.");
                txtFullName.Focus();
                return;
            }
            var newEmployee = new Employee();
            newEmployee.FullName = fullName;
            newEmployee.Address = address;
            newEmployee.Phone = phoneNumber;

            PostgresCrud.Insert(newEmployee);
            txtFullName.Text = "";
            txtAddress.Text = "";
            txtPhoneNumber.Text = "";
            txtFullName.Focus();
            buttonGetAll_Click(null, null);

        }

        private void GetEmployee_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            var employee = PostgresCrud.GetById<Employee>(id);
            txtFullName.Text = employee.FullName;
            txtAddress.Text = employee.Address;
            txtPhoneNumber.Text = employee.Phone;
        }

        private void UpdateEmpl_Click(object sender, EventArgs e)
        {
            var fullname = txtFullName.Text;
            var address = txtAddress.Text;
            var phone = txtPhoneNumber.Text;
            int id = Convert.ToInt32(txtId.Text);
            var updateEmployee = new Employee();
            updateEmployee.FullName = fullname;
            updateEmployee.Address = address;
            updateEmployee.Phone = phone;
            updateEmployee.Id = id;

            PostgresCrud.Update(updateEmployee);

            buttonGetAll_Click(null, null);

        }

        private void DelEmpl_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            var deleteEmployee = new Employee() { Id = id };
            PostgresCrud.Delete(deleteEmployee);


            buttonGetAll_Click(null, null);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonGetAll_Click(null, null);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }



}
