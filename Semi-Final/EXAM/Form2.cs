using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midterm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void RegisterButton_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                Fname = Fname.Text,
                Mname = Mname.Text,
                Lname = Lname.Text,
                username = Username.Text,
                password = Password.Text,
                suffix = Suffix.Text,
                department = Department.Text,
                Number = Number.Text

            };
            ADO ado = new ADO();

            if (ado.Register(user)) {
                MessageBox.Show("Employee added successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to add employee.");
            }
        }
    }
}
