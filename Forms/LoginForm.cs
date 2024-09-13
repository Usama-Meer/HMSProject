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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HMSProject.Forms
{
    public partial class LoginForm : Form
    {
        private HMSDBContext _context;
        public LoginForm()
        {
            InitializeComponent();
            _context = new HMSDBContext();

            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {



        }
        


        private void LoginButton_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;

            var user = _context.Users
        .Include(u => u.Role)
        .FirstOrDefault(u => u.Email == email && u.Password == password);

            if (user != null)
            {
                Form formToOpen;
                var roleName = user.Role.RoleName;

                switch (roleName)
                {
                    case "Admin":
                        formToOpen = new UserDashboard(user.Id,_context);
                        
                        
                        break;
                    case "Doctor":
                        formToOpen = new UserDashboard(user.Id, _context);
                        break;
                    case "Patient":
                        formToOpen = new UserDashboard(user.Id, _context);
                        break;
                    case "Receiptionist":
                        formToOpen = new UserDashboard(user.Id, _context);
                        break;
                    default:
                        MessageBox.Show("Role not recognized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                }
                formToOpen.Show();
                this.Hide();

            }

            else
            {
                MessageBox.Show("Invalid email or password.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
