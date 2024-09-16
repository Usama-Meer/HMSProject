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
    public partial class PatientDashboard : Form
    {
        public int userId;
        private HMSDBContext _context;

        public PatientDashboard(int userId, HMSDBContext context)
        {
            InitializeComponent();
            this.userId = userId;
            this._context = context;
        }
        private void PatientDashboard_Load(object sender, EventArgs e)
        {
            var appointments = _context.Appointments
        .Include(a => a.Patient)
        .Include(a => a.Doctor)
        .Include(a => a.Receiptionist)
        .Where(a => a.PatientId == userId)
        .Select(a => new
        {
            a.AppointmentId,
            PatientName = a.Patient.PatientName,
            DoctorName = a.Doctor.DoctorName,
            ReceiptionistName = a.Receiptionist.ReceiptionistName,
            a.Date,
            a.Status
        })
        .ToList();

            dataGridViewAppointment.DataSource = appointments;



        }

        
    }
}
