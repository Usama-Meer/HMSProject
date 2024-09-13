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
    public partial class UserManagement : Form
    {
        public int userId;
        private HMSDBContext _context;

        public UserManagement(int userId, HMSDBContext context)
        {
            InitializeComponent();
            this.userId = userId;
            this._context = context;


            
        }



        private void CreateUser_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Form LogoutForm = new LoginForm();
            LogoutForm.Show();
            this.Close();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            
            panelAddUser.Visible = true;
            loggedUserEmail.Visible = true;
            label1.Visible = true;

        }

        private void buttonPnlCreateUser_Click(object sender, EventArgs e)
        {
            

        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {

                
                DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                
                if (result == DialogResult.Yes)
                {

                    
                    
                   
                }
            

        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            panelUpdateUser.Visible=true;
            panelAddUser.Visible=false;

        }

        private void UserManagement_Load(object sender, EventArgs e)
        {

        }

        private void hideAllComp_Click(object sender, EventArgs e)
        {
            panelAddUser.Visible=false;
            panelUpdateUser.Visible = false;

        }
    }
}
