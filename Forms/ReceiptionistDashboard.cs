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
    public partial class ReceiptionistDashboard : Form
    {
        public int userId;
        private HMSDBContext _context;

        public ReceiptionistDashboard(int userId, HMSDBContext context)
        {
            InitializeComponent();
            this.userId = userId;
            this._context = context;
        }

        private void ReceiptionistDashboard_Load(object sender, EventArgs e)
        {


        }

        private void buttonUserManagement_Click(object sender, EventArgs e)
        {

        }

        

        private void buttonPatientManagement_Click(object sender, EventArgs e)
        {
            Form form = new PatientManagement(userId, _context);
            form.Show();
            this.Hide();

        }

        private void buttonAppointmentManagement_Click(object sender, EventArgs e)
        {
            Form form = new AppointmentManagement(userId, _context);
            form.Show();
            this.Hide();

        }

        
    }
}
