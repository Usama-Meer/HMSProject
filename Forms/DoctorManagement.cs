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
    public partial class DoctorManagement : Form
    {
        public HMSDBContext _context;
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

        /*private void DoctorManagement_Load(object sender, EventArgs e)
        {
            loggedUserEmail.Text = _context.Users.Find(userId).Email;

            BindingList<Doctor> doctors = new BindingList<Doctor>();
            var doctorList = _context.Doctors.Include(u => u.User).ToList();
            doctors.Clear();
            foreach (var doctor in doctorList)
            {
                doctors.Add(doctor);
            }

            dataGridViewDoctor.DataSource = doctors;

            panelAddDoctor.Visible = false;
            panelUpdateDoctor.Visible = false;
            buttonDeleteDoctor.Enabled = true;
            buttonEditDoctor.Enabled = true;

        }*/

        private void DoctorManagement_Load(object sender, EventArgs e)
        {
            loggedUserEmail.Text = _context.Users.Find(userId).Email;

            var doctors = _context.Doctors
                .Include(d => d.User)
                .Select(d => new
                {
                    d.DoctorId,
                    d.DoctorName,
                    d.DoctorDescription,
                    d.Qualification,
                    d.Speciality,
                    d.Fee,
                    UserName = d.User.Email // Assuming you want to display the user's email as the name
                })
                .ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = doctors;
            dataGridViewDoctor.DataSource = bindingSource;

            panelAddDoctor.Visible = false;
            panelUpdateDoctor.Visible = false;
            buttonDeleteDoctor.Enabled = true;
            buttonEditDoctor.Enabled = true;
        }


        private void AddDoctor_Click(object sender, EventArgs e)
        {
            buttonDeleteDoctor.Enabled = false;
            buttonEditDoctor.Enabled = false;
            panelAddDoctor.Visible = true;
            loggedUserEmail.Visible = true;
            label1.Visible = true;

            panelUpdateDoctor.Visible = false;



        }

        private void buttonPanelCreateDoctor(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxPnlAddFee.Text, out int fee))
            {
                Doctor newDoctor = new Doctor
                {
                    DoctorName = textBoxPnlAddName.Text,
                    DoctorDescription = textBoxPnlAddDesc.Text,
                    Fee = fee,
                    Qualification = comboBoxPnlAddQualif.Text,
                    Speciality = comboBoxPnlAddSpeciality.Text,
                    


                    UserId = _context.Users.FirstOrDefault(u => u.Email == textBoxPnlAddEmail.Text).Id,



                };

                _context.Doctors.Add(newDoctor);
                _context.SaveChanges();

                newDoctor = new Doctor();
                DoctorManagement_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Please enter a valid number for the fee.");

            }






        }


        private void DeleteDoctor_Click(object sender, EventArgs e)
        {
            if (dataGridViewDoctor.ColumnCount > 0)
            {
                int rowId = dataGridViewDoctor.SelectedRows[0].Index;

                if (rowId != null)
                {



                    int Id = (int)dataGridViewDoctor.Rows[rowId].Cells["DoctorId"].Value;


                    DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                    if (result == DialogResult.Yes)
                    {
                        var doctor = _context.Doctors.Find(Id);

                        _context.Doctors.Remove(doctor);
                        _context.SaveChanges();
                        DoctorManagement_Load(sender, e);





                    }
                }
                else
                {
                    MessageBox.Show("No Dcotor has been selected!Please select a user.");
                }

            }

        }

        private void EditDoctor_Click(object sender, EventArgs e)
        {
            panelUpdateDoctor.Visible = true;
            panelAddDoctor.Visible = false;
            textBoxPnlUpdateEmail.Enabled = false;

            if (dataGridViewDoctor.ColumnCount > 0)
            {
                int rowId = dataGridViewDoctor.SelectedRows[0].Index;

                if (rowId != null)
                {

                    int Id = (int)dataGridViewDoctor.Rows[rowId].Cells["DoctorId"].Value;




                    var doctor = _context.Doctors.Find(Id);
                    textBoxPnlUpdateName.Text = doctor.DoctorName;
                    textBoxPnlUpdateDesc.Text = doctor.DoctorDescription;
                    textBoxPnlUpdateEmail.Text = doctor.User.Email;
                    textBoxPnlUpdateFee.Text = doctor.Fee.ToString();
                    comboBoxPnlUpdateQuali.Text = doctor.Qualification;
                    comboBoxPnlUpdateSpeciality.Text = doctor.Speciality;
                    
                }
                else
                {
                    MessageBox.Show("No Doctor has been selected!Please select a Doctor.");
                }

            }

        }


        private void buttonPanelUpdateDoctor(object sender, EventArgs e)
        {
            int doctorId = (int)dataGridViewDoctor.SelectedRows[0].Cells["DoctorId"].Value;
            var doctor = _context.Doctors.Include(u => u.User).FirstOrDefault(u => u.DoctorId == doctorId);
            if (int.TryParse(textBoxPnlUpdateFee.Text, out int fee))
            {
                doctor.DoctorName = textBoxPnlUpdateName.Text;
                doctor.DoctorDescription = textBoxPnlUpdateDesc.Text;
                doctor.Fee = fee;
                doctor.Qualification = comboBoxPnlUpdateQuali.Text;
                doctor.Speciality = comboBoxPnlUpdateSpeciality.Text;
                doctor.UserId=_context.Users.FirstOrDefault(u=>u.Email==textBoxPnlUpdateEmail.Text).Id;
                
                _context.SaveChanges();

                DoctorManagement_Load(sender, e);
            }


        }
    }
}
