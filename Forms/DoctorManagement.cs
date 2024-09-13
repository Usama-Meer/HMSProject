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
    public partial class DoctorManagement : Form
    {
        public  HMSDBContext _context;
        public int userId;
        
        public DoctorManagement(int userId, HMSDBContext context)
        {
            InitializeComponent();
            this._context = context;
            this.userId = userId;

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Form LogoutForm = new LoginForm();
            LogoutForm.Show();
            this.Close();
        }
    }
}
