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
    public partial class RoleManagement : Form
    {
        public RoleManagement()
        {
            InitializeComponent();
        }

        private void panelUpdateUser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RoleManagement_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Form LogoutForm = new LoginForm();
            LogoutForm.Show();
            this.Close();
        }
    }
}
