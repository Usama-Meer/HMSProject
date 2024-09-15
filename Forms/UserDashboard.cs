using HMSProject.Data;
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
        public int userId;
        private HMSDBContext _context;
        public UserDashboard(int userId, HMSDBContext context)
        {
            InitializeComponent();
            this.userId = userId;
            this._context = context;

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            _context.SaveChanges();
            _context.Dispose();
            Form LogoutForm = new LoginForm();
            LogoutForm.Show();
            this.Close();
        }

        private void UserManagment_Click(object sender, EventArgs e)
        {
            Form userManagementForm = new UserManagement(userId, _context);
            userManagementForm.Show();
            this.Hide();
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            loggedUserEmail.Text = _context.Users.Find(userId).Email;



        }

        private void DoctorManagemet_Click(object sender, EventArgs e)
        {
            Form form = new DoctorManagement(userId, _context);
            form.Show();
            this.Hide();

        }

        private void RoleManagement_Click(object sender, EventArgs e)
        {

        }

        private void PatientManagement_Click(object sender, EventArgs e)
        {

        }

        private void ReceptionistManagement_Click(object sender, EventArgs e)
        {

        }

        private void AppointmentManagemement_Click(object sender, EventArgs e)
        {

        }
    }
}
