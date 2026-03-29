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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void LogButton_Click(object sender, EventArgs e)
        {
            ADO ado = new ADO();
            User user = ado.Login(LogUser.Text, LogPass.Text);

            if (user != null)
            {
                Form3 thirdForm = new Form3(user);

                // 2. Show the form
                thirdForm.Show();
            }
            else {
                MessageBox.Show("Not found!");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        public void RegLink_Click(object sender, EventArgs e)
        {
            Form2 thirdForm = new Form2();

            // 2. Show the form
            thirdForm.Show();
        }
    }
}
