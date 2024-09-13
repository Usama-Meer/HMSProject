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
    public partial class PatientManagement : Form
    {
        public PatientManagement()
        {
            InitializeComponent();
        }

        private void buttonSearchPatient_Click(object sender, EventArgs e)
        {

        }

        private void PatientManagement_Load(object sender, EventArgs e)
        {

        }

        private void textBoxPnlUpdateRoleName_TextChanged(object sender, EventArgs e)
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
