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
    public partial class Form3 : Form
    {
        private User _currentUser;
        public Form3(User user)
        {
            InitializeComponent();
            _currentUser = user;
        }

        public void ShowID_TextChanged(object sender, EventArgs e)
        {

        }

        public void Form3_Load(object sender, EventArgs e)
        {
            if (_currentUser != null)
            {
                ShowID.Text = _currentUser.id;
                ShowUser.Text = _currentUser.username;
                ShowFname.Text = _currentUser.Fname;
                ShowMname.Text = _currentUser.Mname;
                ShowLname.Text = _currentUser.Lname;
                ShowSuffix.Text = _currentUser.suffix;
                ShowDepartment.Text = _currentUser.department;
                ShowNumber.Text = _currentUser.Number;

                // Add any other fields your User class has
            }
        }
    }
}
