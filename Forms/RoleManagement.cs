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
    public partial class RoleManagement : Form
    {
        public int userId;
        private HMSDBContext _context;

        public RoleManagement(int userId, HMSDBContext context)
        {
            InitializeComponent();
            this.userId = userId;
            this._context = context;



        }

        private void panelUpdateUser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RoleManagement_Load(object sender, EventArgs e)
        {
            loggedUserEmail.Text = _context.Users.Find(userId).Email;

            panelUpdateRole.Visible = false;
            panelAddRole.Visible = false;
            buttonEditRole.Enabled = true;
            buttonDeleteRole.Enabled = true;


            BindingList<Role> roles = new BindingList<Role>();
            var roleList = _context.Roles.ToList();
            roles.Clear();
            foreach (var role in roleList)
            {
                roles.Add(role);
            }

            dataGridViewRole.DataSource = roles;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            _context.SaveChanges();
            _context.Dispose();
            Form LogoutForm = new LoginForm();
            LogoutForm.Show();
            this.Close();
        }

        

        private void buttonPanelCreateRole(object sender, EventArgs e)
        {
            Role newRole = new Role
            {
                RoleName = textBoxPnlAddRoleName.Text,
                RoleDescription = textBoxPnlAddRoleDesc.Text,
 
            };




            _context.Roles.Add(newRole);
            _context.SaveChanges();

            newRole = new Role();
            RoleManagement_Load(sender, e);

        }

        private void AddRole_Click(object sender, EventArgs e)
        {
            buttonDeleteRole.Enabled = false;
            buttonEditRole.Enabled = false;
            
            panelAddRole.Visible = true;
            loggedUserEmail.Visible = true;
            label1.Visible = true;
            buttonLogout.Visible = true;

            panelUpdateRole.Visible = false;
          








        }

        private void DeleteRole_Click(object sender, EventArgs e)
        {
            if (dataGridViewRole.ColumnCount > 0)
            {
                int rowId = dataGridViewRole.SelectedRows[0].Index;

                if (rowId != null)
                {



                    int Id = (int)dataGridViewRole.Rows[rowId].Cells["RoleId"].Value;


                    DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                    if (result == DialogResult.Yes)
                    {
                        var role = _context.Roles.Find(Id);

                        _context.Roles.Remove(role);
                        _context.SaveChanges();
                        RoleManagement_Load(sender, e);





                    }
                }
                else
                {
                    MessageBox.Show("No Role has been selected!Please select a Role.");
                }

            }


        }

        private void buttonPanelUpdateRole(object sender, EventArgs e)
        {
            int roleId= (int)dataGridViewRole.SelectedRows[0].Cells["RoleId"].Value;
            var role = _context.Roles.FirstOrDefault(u => u.RoleId == roleId);

            role.RoleName = textBoxPnlUpdateRoleName.Text;
            role.RoleDescription = textBoxPnlUpdateRoleDesc.Text;
            

            _context.SaveChanges();

            
            RoleManagement_Load(sender, e);


        }
        private void EditRole_Click(object sender, EventArgs e)
        {

            panelUpdateRole.Visible = true;
            panelAddRole.Visible = false;

            if (dataGridViewRole.ColumnCount > 0)
            {
                int rowId = dataGridViewRole.SelectedRows[0].Index;

                if (rowId != null)
                {

                    int Id = (int)dataGridViewRole.Rows[rowId].Cells["RoleId"].Value;




                    var role = _context.Roles.Find(Id);
                    textBoxPnlUpdateRoleName.Text = role.RoleName;
                    textBoxPnlUpdateRoleDesc.Text = role.RoleDescription;
                    

                    
                }
                else
                {
                    MessageBox.Show("No Role has been selected!Please select a Role.");
                }










            }


        }
    }
}
