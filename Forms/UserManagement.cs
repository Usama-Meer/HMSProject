using HMSProject.Data;
using HMSProject.Models;
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
            buttonDeleteUser.Enabled = false;
            buttonEditUser.Enabled = false; 
            panelAddUser.Visible = true;
            loggedUserEmail.Visible = true;
            label1.Visible = true;

            panelUpdateUser.Visible = false;
            comboBoxAddRoleName.DataSource = _context.Roles.Select(r => r.RoleName).ToList();

        }

        private void buttonPnlCreateUser_Click(object sender, EventArgs e)
        {
            User newuser = new User
            {
                Email = TextBoxPnlAddEmail.Text,
                Password = textBoxPnlAddPassword.Text,
                RoleId = _context.Roles.FirstOrDefault(r => r.RoleName == comboBoxAddRoleName.Text).RoleId,
            };



            
            _context.Users.Add(newuser);
            _context.SaveChanges();

            newuser = new User();
            UserManagement_Load(sender, e);








        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {

            if (dataGridViewUser.ColumnCount > 0)
            {
                int rowId = dataGridViewUser.SelectedRows[0].Index;

                if (rowId != null)
                {
                    


                    int Id = (int)dataGridViewUser.Rows[rowId].Cells["Id"].Value;


                    DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                    if (result == DialogResult.Yes)
                    {
                        var user = _context.Users.Find(Id);

                        _context.Users.Remove(user);
                        _context.SaveChanges();
                        UserManagement_Load(sender, e);





                    }
                }
                else
                {
                    MessageBox.Show("No User has been selected!Please select a user.");
                }

            }

        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            panelUpdateUser.Visible = true;
            panelAddUser.Visible = false;

            if (dataGridViewUser.ColumnCount > 0)
            {
                int rowId = dataGridViewUser.SelectedRows[0].Index;

                if (rowId != null)
                {

                    int Id = (int)dataGridViewUser.Rows[rowId].Cells["Id"].Value;




                    var user = _context.Users.Find(Id);
                    textBoxPnlUpdateEmail.Text = user.Email;
                    textBoxPnlUpdatePassword.Text = user.Password;
                    comboBoxUpdateRoleName.Text = user.Role.RoleName;

                    comboBoxUpdateRoleName.DataSource = _context.Roles.Select(r => r.RoleName).ToList();
                }
                else
                {
                    MessageBox.Show("No User has been selected!Please select a user.");
                }










            }
        }


        private void buttonPnlUpdateUser_Click(object sender, EventArgs e)
        {

            int userId = (int)dataGridViewUser.SelectedRows[0].Cells["Id"].Value;
            var user = _context.Users.Include(u => u.Role).FirstOrDefault(u => u.Id == userId);

            user.Email = textBoxPnlUpdateEmail.Text;
            user.Password = textBoxPnlUpdatePassword.Text;
            user.RoleId = _context.Roles.FirstOrDefault(r => r.RoleName == comboBoxUpdateRoleName.Text).RoleId;

            _context.SaveChanges();

            UserManagement_Load(sender, e);

        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            loggedUserEmail.Text = _context.Users.Find(userId).Email;

            BindingList<User> users = new BindingList<User>();
            var userList = _context.Users.Include(u => u.Role).ToList();
            users.Clear();
            foreach (var user in userList)
            {
                users.Add(user);
            }

            dataGridViewUser.DataSource = users;

            panelAddUser.Visible = false;
            panelUpdateUser.Visible = false;
            buttonDeleteUser.Enabled = true;
            buttonEditUser.Enabled = true;
        }

        

        

        
    }
}
