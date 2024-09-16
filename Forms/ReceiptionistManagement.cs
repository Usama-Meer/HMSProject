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
    public partial class ReceiptionistManagement : Form
    {
        public int userId;
        private HMSDBContext _context;

        public ReceiptionistManagement(int userId, HMSDBContext context)
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

        /*private void ReceiptionistManagement_Load(object sender, EventArgs e)
        {
            loggedUserEmail.Text = _context.Users.Find(userId).Email;

            BindingList<Receiptionist> recepts = new BindingList<Receiptionist>();
            var receptList = _context.Receiptionists.Include(u => u.User).ToList();
            recepts.Clear();
            foreach (var recept in receptList)
            {
                recepts.Add(recept);
            }

            dataGridViewRecept.DataSource = recepts;

            panelAddRecept.Visible = false;
            panelUpdateRecept.Visible = false;
            buttonDeleteRecept.Enabled = true;
            buttonEditRecept.Enabled = true;


        }*/

        private void ReceiptionistManagement_Load(object sender, EventArgs e)
        {
            loggedUserEmail.Text = _context.Users.Find(userId).Email;

            var receptionists = _context.Receiptionists
                .Include(r => r.User)
                .Select(r => new
                {
                    r.ReceiptionistId,
                    r.ReceiptionistName,
                    UserName = r.User.Email // Assuming you want to display the user's email as the name
                })
                .ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = receptionists;
            dataGridViewRecept.DataSource = bindingSource;

            panelAddRecept.Visible = false;
            panelUpdateRecept.Visible = false;
            buttonDeleteRecept.Enabled = true;
            buttonEditRecept.Enabled = true;
        }



        private void buttonPanelCreate(object sender, EventArgs e)
        {
            var receptUserId = _context.Users.FirstOrDefault(u => u.Email == textBoxPnlAddEmail.Text).Id;
            if (receptUserId != null)
            {
                Receiptionist newRecept = new Receiptionist
                {
                    ReceiptionistName = textBoxPnlAddName.Text,
                    UserId = receptUserId,
                };

                _context.Receiptionists.Add(newRecept);
                _context.SaveChanges();

                newRecept = new Receiptionist();
                ReceiptionistManagement_Load(sender, e);

            }
            else
            {
                MessageBox.Show("Please enter a valid email!");
            }



        }

        private void buttonAddRecept_Click(object sender, EventArgs e)
        {
            buttonDeleteRecept.Enabled = false;
            buttonEditRecept.Enabled = false;
            panelAddRecept.Visible = true;
            loggedUserEmail.Visible = true;
            label1.Visible = true;

            panelUpdateRecept.Visible = false;



        }

        private void buttonDeleteRecept_Click(object sender, EventArgs e)
        {
            if (dataGridViewRecept.ColumnCount > 0)
            {
                int rowId = dataGridViewRecept.SelectedRows[0].Index;

                if (rowId != null)
                {



                    int Id = (int)dataGridViewRecept.Rows[rowId].Cells["ReceiptionistId"].Value;


                    DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                    if (result == DialogResult.Yes)
                    {
                        var recept = _context.Receiptionists.Find(Id);

                        _context.Receiptionists.Remove(recept);
                        _context.SaveChanges();
                        ReceiptionistManagement_Load(sender, e);





                    }
                }
                else
                {
                    MessageBox.Show("No User has been selected!Please select a user.");
                }

            }

        }

        private void buttonPanelUpdate(object sender, EventArgs e)
        {
            int receptId = (int)dataGridViewRecept.SelectedRows[0].Cells["ReceiptionistId"].Value;
            var recept = _context.Receiptionists.Include(u => u.User).FirstOrDefault(u => u.ReceiptionistId == receptId);

            recept.UserId = _context.Users.FirstOrDefault(r => r.Email == textBoxPnlUpdateEmail.Text).Id;
            recept.ReceiptionistName = textBoxPnlUpdateName.Text;
            
            _context.SaveChanges();

            ReceiptionistManagement_Load(sender, e);

        }

        private void buttonEditRecept_Click(object sender, EventArgs e)
        {
            panelUpdateRecept.Visible = true;
            panelAddRecept.Visible = false;
            textBoxPnlUpdateEmail.Enabled = false;

            if (dataGridViewRecept.ColumnCount > 0)
            {
                int rowId = dataGridViewRecept.SelectedRows[0].Index;

                if (rowId != null)
                {

                    int Id = (int)dataGridViewRecept.Rows[rowId].Cells["ReceiptionistId"].Value;




                    var recept = _context.Receiptionists.Find(Id);
                    textBoxPnlUpdateEmail.Text = recept.User.Email;
                    textBoxPnlUpdateName.Text = recept.ReceiptionistName;
                    
                }
                else
                {
                    MessageBox.Show("No Receptionist has been selected!Please select a Receptionist.");
                }

            }

        }
    }
}
