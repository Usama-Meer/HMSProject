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
    public partial class AppointmentManagement : Form
    {
        public int userId;
        private HMSDBContext _context;

        public AppointmentManagement(int userId, HMSDBContext context)
        {
            InitializeComponent();
            this.userId = userId;
            this._context = context;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            _context.SaveChanges();
            _context.Dispose();
            Form LogoutForm = new LoginForm();
            LogoutForm.Show();
            this.Close();

        }



        /*private void AppointmentManagement_Load(object sender, EventArgs e)
        {
            loggedUserEmail.Text = _context.Users.Find(userId).Email;

            BindingList<Appointment> appointments = new BindingList<Appointment>();
            var appointmentList = _context.Appointments
                .Include(a => a.Doctor)
                .Include(p => p.Patient)
                .Include(q => q.Receiptionist)
                .ToList();

            
            appointments.Clear();
            foreach (var appointment in appointmentList)
            {
                appointments.Add(appointment);
            }

            dataGridViewAppointment.DataSource = appointments;

            panelAddAppointment.Visible = false;
            panelUpdateAppoint.Visible = false;
            buttonDeleteAppointment.Enabled = true;
            buttonEditAppointment.Enabled = true;

        }*/
        private void AppointmentManagement_Load(object sender, EventArgs e)
        {
            loggedUserEmail.Text = _context.Users.Find(userId).Email;

            var appointments = _context.Appointments
                .Include(a => a.Patient)
                .Include(a => a.Doctor)
                .Include(a => a.Receiptionist)
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

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = appointments;
            dataGridViewAppointment.DataSource = bindingSource;

            panelAddAppointment.Visible = false;
            panelUpdateAppoint.Visible = false;
            buttonDeleteAppointment.Enabled = true;
            buttonEditAppointment.Enabled = true;
        }

        private void buttonAddAppointment_Click(object sender, EventArgs e)
        {
            buttonDeleteAppointment.Enabled = false;
            buttonEditAppointment.Enabled = false;
            panelAddAppointment.Visible = true;
            loggedUserEmail.Visible = true;
            label1.Visible = true;

            panelUpdateAppoint.Visible = false;
            comboBoxPnlAddDName.DataSource = _context.Doctors.Select(r => r.DoctorName).ToList();


        }

        private void panelButtonAddAppointment(object sender, EventArgs e)
        {
            var patient = _context.Patients.FirstOrDefault(u => u.PatientEmail == textBoxPnlAddPEmail.Text);
            if (patient != null)
            {
                var doctor = _context.Doctors.FirstOrDefault(u => u.DoctorName == comboBoxPnlAddDName.Text);
                if (doctor != null)
                {
                    var receiptionist = _context.Receiptionists.FirstOrDefault(u=>u.UserId==userId);
                    if (receiptionist != null)
                    {
                        Appointment newAppointment = new Appointment
                        {
                            PatientId = patient.PatientId,
                            DoctorId = doctor.DoctorId,
                            ReceiptionistId = receiptionist.ReceiptionistId,
                            Status = true,
                            Date = dateTimePickerPnlAdd.Value,
                        };

                        _context.Appointments.Add(newAppointment);
                        _context.SaveChanges();

                        AppointmentManagement_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Receiptionist not found. Please check the user ID.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a valid doctor.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid patient email.");
            }
        }

        /*private void panelButtonAddAppointment(object sender, EventArgs e)
        {
            int patientId = _context.Patients.FirstOrDefault(u => u.PatientEmail==textBoxPnlAddPEmail.Text).PatientId;
            if (patientId != null) {
                Appointment newAppointment = new Appointment
                {
                    PatientId = patientId,
                    DoctorId = _context.Doctors.FirstOrDefault(u => u.DoctorName == comboBoxPnlAddDName.Text).DoctorId,
                    ReceiptionistId =userId,
                    Status=true,
                    Date=dateTimePickerPnlAdd.Value,


                };





                _context.Appointments.Add(newAppointment);
                _context.SaveChanges();

                newAppointment = new Appointment();
                AppointmentManagement_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Please enter a valid user email!");
            }
        }*/
        /*private void buttonDeleteAppointment_Click(object sender, EventArgs e)
        {
            if (dataGridViewAppointment.ColumnCount > 0)
            {
                int rowId = dataGridViewAppointment.SelectedRows[0].Index;

                if (rowId != null)
                {



                    int Id = (int)dataGridViewAppointment.Rows[rowId].Cells["AppointmentId"].Value;


                    DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                    if (result == DialogResult.Yes)
                    {
                        var appointment = _context.Users.Find(Id);

                        _context.Users.Remove(appointment);
                        _context.SaveChanges();
                        AppointmentManagement_Load(sender, e);





                    }
                }
                else
                {
                    MessageBox.Show("No Appointment has been selected!Please select an appointment.");
                }

            }

        }
*/

        private void buttonDeleteAppointment_Click(object sender, EventArgs e)
        {
            if (dataGridViewAppointment.ColumnCount > 0)
            {
                if (dataGridViewAppointment.SelectedRows.Count > 0)
                {
                    int rowId = dataGridViewAppointment.SelectedRows[0].Index;
                    int Id = (int)dataGridViewAppointment.Rows[rowId].Cells["AppointmentId"].Value;

                    DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        var appointment = _context.Appointments.Find(Id);

                        if (appointment != null)
                        {
                            _context.Appointments.Remove(appointment);
                            _context.SaveChanges();
                            AppointmentManagement_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Appointment not found!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No Appointment has been selected! Please select an appointment.");
                }
            }
        }

        private void buttonEditAppointment_Click(object sender, EventArgs e)
        {

            panelUpdateAppoint.Visible = true;
            panelAddAppointment.Visible = false;
            textBoxPnlUpdateEmail.Enabled= false;

            if (dataGridViewAppointment.ColumnCount > 0)
            {
                int rowId = dataGridViewAppointment.SelectedRows[0].Index;

                if (rowId != null)
                {

                    int Id = (int)dataGridViewAppointment.Rows[rowId].Cells["AppointmentId"].Value;




                    var appointment = _context.Appointments.Find(Id);
                    textBoxPnlUpdateEmail.Text = appointment.Patient.PatientEmail;
                    if (appointment.Status)
                    {
                        comboBoxPnlUpdateStatus.SelectedItem = "Expired";
                        comboBoxPnlUpdateDName.Enabled= false;
                    }
                    else
                    {
                        comboBoxPnlUpdateDName.Enabled = true;
                        comboBoxPnlUpdateStatus.SelectedItem = "Active";
                    }


                   


                    comboBoxPnlUpdateDName.SelectedItem = appointment.Doctor.DoctorName;

                    

                    
                }
                else
                {
                    MessageBox.Show("No Appointment has been selected!Please select an appointment to edit.");
                }

            }

        }

        private void panelButtonUpdateAppointment(object sender, EventArgs e)
        {
            int appointmentId = (int)dataGridViewAppointment.SelectedRows[0].Cells["AppointmentId"].Value;
            var appointment = _context.Appointments.Include(u => u.Doctor).Include(q=>q.Patient).FirstOrDefault(u => u.AppointmentId == appointmentId);

            appointment.DoctorId = _context.Doctors.FirstOrDefault(u => u.DoctorName == comboBoxPnlAddDName.Text).DoctorId;
            appointment.PatientId = _context.Patients.FirstOrDefault(u => u.PatientEmail == textBoxPnlUpdateEmail.Text).PatientId;
            appointment.Date = dateTimePickerPnlUpdate.Value;
           
            _context.SaveChanges();

            AppointmentManagement_Load(sender, e);


        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            string userRole = _context.Users.Find(userid).Role.RoleName;
            Form dashboardForm;

            if (userRole == "Admin")
            {
                dashboardForm = new UserDashboard();
            }
            else if (userRole == "Doctor")
            {
                dashboardForm = new DoctorDashboard();
            }
            else if (userRole == "Receiptionist")
            {
                dashboardForm = new ReceiptionistDashboard();
            }
            else
            {
                MessageBox.Show("Unknown user role!");
                return;
            }

            dashboardForm.Show();
            this.Close();
        }


    }
}
