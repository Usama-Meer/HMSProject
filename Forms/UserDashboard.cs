using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMSProject.Forms
{
    public partial class UserDashboard : Form
    {
        public UserDashboard()
        {
            InitializeComponent();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Form LogoutForm = new LoginForm();
            LogoutForm.Show();
            this.Close();
        }

        private void UserManagment_Click(object sender, EventArgs e)
        {
            Form userManagementForm = new UserManagement();
            userManagementForm.Show();
            this.Hide();
        }

        private void DoctoManagemet_Click(object sender, EventArgs e)
        {

        }
    }
}
