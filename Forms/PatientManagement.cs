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
    public partial class PatientManagement : Form
    {
        public int userId;
        private HMSDBContext _context;

        public PatientManagement(int userId, HMSDBContext context)
        {
            InitializeComponent();
            this.userId = userId;
            this._context = context;
        }


        /*private void PatientManagement_Load(object sender, EventArgs e)
        {
            loggedUserEmail.Text = _context.Users.Find(userId).Email;

            BindingList<Patient> patients = new BindingList<Patient>();
            var patientList = _context.Patients.Include(u => u.User).ToList();
            patients.Clear();
            foreach (var patient in patientList)
            {
                patients.Add(patient);
            }

            dataGridViewPatient.DataSource = patients;
            
            panelAddPatient.Visible = false;
            panelUpdatePatient.Visible = false;
            buttonDeletePatient.Enabled = true;
            buttonEditPatient.Enabled = true;

        }
*/

        private void PatientManagement_Load(object sender, EventArgs e)
        {
            loggedUserEmail.Text = _context.Users.Find(userId).Email;

            var patients = _context.Patients
                .Include(p => p.User)
                .Select(p => new
                {
                    p.PatientId,
                    p.PatientName,
                    p.Dob,
                    p.Address,
                    p.PhoneNumber,
                    p.PatientEmail,
                    UserName = p.User.Email // Assuming you want to display the user's email as the name
                })
                .ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = patients;
            dataGridViewPatient.DataSource = bindingSource;

            panelAddPatient.Visible = false;
            panelUpdatePatient.Visible = false;
            buttonDeletePatient.Enabled = true;
            buttonEditPatient.Enabled = true;
        }

        private void textBoxPnlUpdateRoleName_TextChanged(object sender, EventArgs e)
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

        private void buttonAddPatient_Click(object sender, EventArgs e)
        {
            buttonDeletePatient.Enabled = false;
            buttonEditPatient.Enabled = false;
            panelAddPatient.Visible = true;
            loggedUserEmail.Visible = true;
            label1.Visible = true;

            panelUpdatePatient.Visible = false;



        }

        private void buttonPanelCreatePatient(object sender, EventArgs e)
        {
            var patientUserId = _context.Users.FirstOrDefault(u => u.Email == textBoxPnlAddEmail.Text).Id;
            if (patientUserId != null)
            {
                Patient newPatient = new Patient
                {
                    PatientName = textBoxPnlAddName.Text,
                    PatientEmail = textBoxPnlAddEmail.Text,
                    Address = textBoxPnlAddAddress.Text,
                    PhoneNumber = textBoxPnlAddPhone.Text,
                    Dob = PnlAddDateTimePicker.Value,


                    UserId = patientUserId,
                };

                _context.Patients.Add(newPatient);
                _context.SaveChanges();

                newPatient = new Patient();
                PatientManagement_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Please Enter a valid Email which match user account email");

            }






        }


        private void buttonDeletePatient_Click(object sender, EventArgs e)
        {
            if (dataGridViewPatient.ColumnCount > 0)
            {
                int rowId = dataGridViewPatient.SelectedRows[0].Index;

                if (rowId != null)
                {



                    int Id = (int)dataGridViewPatient.Rows[rowId].Cells["PatientId"].Value;


                    DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                    if (result == DialogResult.Yes)
                    {
                        var patient = _context.Patients.Find(Id);

                        _context.Patients.Remove(patient);
                        _context.SaveChanges();
                        PatientManagement_Load(sender, e);





                    }
                }
                else
                {
                    MessageBox.Show("No Patient has been selected!Please select a Patient.");
                }

            }

        }

        private void buttonEditPatient_Click(object sender, EventArgs e)
        {
            panelUpdatePatient.Visible = true;
            panelAddPatient.Visible = false;
            textBoxPnlUpdateEmail.Enabled = false;
            

            if (dataGridViewPatient.ColumnCount > 0)
            {
                int rowId = dataGridViewPatient.SelectedRows[0].Index;


                if (rowId != null)
                {

                    int Id = (int)dataGridViewPatient.Rows[rowId].Cells["PatientId"].Value;




                    var patient = _context.Patients.Find(Id);
                    textBoxPnlUpdateEmail.Text = patient.PatientEmail;
                    textBoxPnlUpdateName.Text = patient.PatientName;
                    pnlUpdateDateTimePicker.Value = patient.Dob;
                    
                    textBoxPnlUpdatePhone.Text = patient.PhoneNumber;
                    textBoxPnlUpdateAddress.Text = patient.Address;


                }
                else
                {
                    MessageBox.Show("No Patient has been selected!Please select a Patient.");
                }

            }
        }

        
        private void buttonPanelUpdatePatient(object sender, EventArgs e)
        {
            int patientId = (int)dataGridViewPatient.SelectedRows[0].Cells["PatientId"].Value;
            var patient = _context.Patients.Include(u => u.User).FirstOrDefault(u => u.PatientId == patientId);

            patient.PhoneNumber = textBoxPnlUpdatePhone.Text;
            patient.PatientName = textBoxPnlUpdateName.Text;
            patient.Address = textBoxPnlUpdateAddress.Text;
            patient.UserId = _context.Users.FirstOrDefault(r => r.Email == textBoxPnlUpdateEmail.Text).Id;
            patient.Dob=pnlUpdateDateTimePicker.Value;


            _context.SaveChanges();

            PatientManagement_Load(sender, e);



        }
    }
}
