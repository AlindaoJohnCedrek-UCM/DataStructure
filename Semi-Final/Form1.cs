using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeRoster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            EmpADO empAdo = new EmpADO();
            Employee emp = empAdo.GetEmployee(SearchFName.Text, SearchLName.Text);

            if (emp != null)
            {
                ShowFName.Text = emp.firstName;
                ShowLName.Text = emp.lastName;
                ShowAddress.Text = emp.Address;
                ShowNumber.Text = emp.Number;

            }
            else
            {
                MessageBox.Show("Employee not found.");
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee
            {
                firstName = AddFName.Text,
                lastName = AddLName.Text,
                Address = AddAddress.Text,
                Number = AddContact.Text
            };
            EmpADO empAdo = new EmpADO();
            if (empAdo.AddEmployee(emp))
            {
                MessageBox.Show("Employee added successfully.");
            }
            else
            {
                MessageBox.Show("Failed to add employee.");
            }

        }

        private void DashBoardButton_Click(object sender, EventArgs e)
        {
            EmpADO empADO = new EmpADO();
            List<Employee> AllEmployee = empADO.getAllEmployee();

            Form2 dashboardWindow = new Form2();

            dashboardWindow.dgvAllEmployees.DataSource = AllEmployee;
            dashboardWindow.Show();

        }
    }
}
