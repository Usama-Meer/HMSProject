using HMSProject.Data;
using Microsoft.EntityFrameworkCore;
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
            _context.SaveChanges();
            _context.Dispose();
            Form LogoutForm = new LoginForm();
            LogoutForm.Show();
            this.Close();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {

            panelAddUser.Visible = true;
            loggedUserEmail.Visible = true;
            label1.Visible = true;

            panelUpdateUser.Visible = false;

        }

        private void buttonPnlCreateUser_Click(object sender, EventArgs e)
        {


        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {

            if (dataGridViewUser.ColumnCount > 0)
            {
                int rowId = dataGridViewUser.SelectedRows[0].Index;
                int Id =(int) dataGridViewUser.Rows[rowId].Cells["Id"].Value;
                dataGridViewUser.Rows.RemoveAt(rowId);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                if (result == DialogResult.Yes)
                {
                    var user = _context.Users.Find(Id);

                    _context.Users.Remove(user);
                    _context.SaveChanges();




                }
            }


            


        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            panelUpdateUser.Visible = true;
            panelAddUser.Visible = false;
            

        }

        private void UserManagement_Load(object sender, EventArgs e)
        {

            dataGridViewUser.DataSource = _context.Users.Include(u => u.Role).ToList();
        }

        private void hideAllComp_Click(object sender, EventArgs e)
        {
            panelAddUser.Visible = false;
            panelUpdateUser.Visible = false;

        }

        private void UserList_Click(object sender, EventArgs e)
        {
            panelAddUser.Visible = false;
            panelUpdateUser.Visible = false;


        }
    }
}
