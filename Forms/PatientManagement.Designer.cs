namespace HMSProject.Forms
{
    partial class PatientManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            buttonAddPatient = new Button();
            buttonDeletePatient = new Button();
            buttonEditPatient = new Button();
            loggedUserEmail = new Label();
            buttonLogout = new Button();
            buttonPnlAddCancel = new Button();
            buttonPnlCreateUser = new Button();
            label2 = new Label();
            buttonPnlEditCancel = new Button();
            buttonPnlUpdate = new Button();
            label3 = new Label();
            panelAddPatient = new Panel();
            PnlAddDateTimePicker = new DateTimePicker();
            textBoxPnlAddAddress = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBoxPnlAddPhone = new TextBox();
            label7 = new Label();
            textBoxPnlAddEmail = new TextBox();
            textBoxPnlAddName = new TextBox();
            label8 = new Label();
            labelPnlAddPatientName = new Label();
            panelUpdatePatient = new Panel();
            pnlUpdateDateTimePicker = new DateTimePicker();
            textBoxPnlUpdateAddress = new TextBox();
            labelPnlUpdateAdress = new Label();
            labelPnlUpdatePhone = new Label();
            textBoxPnlUpdatePhone = new TextBox();
            labelPnlUpdateEmail = new Label();
            textBoxPnlUpdateEmail = new TextBox();
            textBoxPnlUpdateName = new TextBox();
            labelPnlUpdateDob = new Label();
            labelPnlUpdatePatientName = new Label();
            buttonPatientList = new Button();
            dataGridViewPatient = new DataGridView();
            panelAddPatient.SuspendLayout();
            panelUpdatePatient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatient).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(244, 24);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(193, 28);
            label1.TabIndex = 0;
            label1.Text = "Patient Management";
            // 
            // buttonAddPatient
            // 
            buttonAddPatient.Location = new Point(22, 208);
            buttonAddPatient.Margin = new Padding(2);
            buttonAddPatient.Name = "buttonAddPatient";
            buttonAddPatient.Size = new Size(102, 27);
            buttonAddPatient.TabIndex = 1;
            buttonAddPatient.Text = "Add Patient";
            buttonAddPatient.UseVisualStyleBackColor = true;
            buttonAddPatient.Click += buttonAddPatient_Click;
            // 
            // buttonDeletePatient
            // 
            buttonDeletePatient.Location = new Point(22, 250);
            buttonDeletePatient.Margin = new Padding(2);
            buttonDeletePatient.Name = "buttonDeletePatient";
            buttonDeletePatient.Size = new Size(102, 27);
            buttonDeletePatient.TabIndex = 2;
            buttonDeletePatient.Text = "Delete Patient";
            buttonDeletePatient.UseVisualStyleBackColor = true;
            buttonDeletePatient.Click += buttonDeletePatient_Click;
            // 
            // buttonEditPatient
            // 
            buttonEditPatient.Location = new Point(22, 291);
            buttonEditPatient.Margin = new Padding(2);
            buttonEditPatient.Name = "buttonEditPatient";
            buttonEditPatient.Size = new Size(102, 27);
            buttonEditPatient.TabIndex = 3;
            buttonEditPatient.Text = "Edit Patient";
            buttonEditPatient.UseVisualStyleBackColor = true;
            buttonEditPatient.Click += buttonEditPatient_Click;
            // 
            // loggedUserEmail
            // 
            loggedUserEmail.AutoSize = true;
            loggedUserEmail.Location = new Point(582, 32);
            loggedUserEmail.Name = "loggedUserEmail";
            loggedUserEmail.Size = new Size(89, 20);
            loggedUserEmail.TabIndex = 10;
            loggedUserEmail.Text = "{User Email}";
            // 
            // buttonLogout
            // 
            buttonLogout.Location = new Point(678, 28);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(94, 29);
            buttonLogout.TabIndex = 9;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // buttonPnlAddCancel
            // 
            buttonPnlAddCancel.Location = new Point(196, 206);
            buttonPnlAddCancel.Margin = new Padding(2);
            buttonPnlAddCancel.Name = "buttonPnlAddCancel";
            buttonPnlAddCancel.Size = new Size(90, 27);
            buttonPnlAddCancel.TabIndex = 13;
            buttonPnlAddCancel.Text = "Cancel";
            buttonPnlAddCancel.UseVisualStyleBackColor = true;
            buttonPnlAddCancel.Click += PatientManagement_Load;
            // 
            // buttonPnlCreateUser
            // 
            buttonPnlCreateUser.Location = new Point(298, 206);
            buttonPnlCreateUser.Margin = new Padding(2);
            buttonPnlCreateUser.Name = "buttonPnlCreateUser";
            buttonPnlCreateUser.Size = new Size(90, 27);
            buttonPnlCreateUser.TabIndex = 12;
            buttonPnlCreateUser.Text = "Create";
            buttonPnlCreateUser.UseVisualStyleBackColor = true;
            buttonPnlCreateUser.Click += buttonPanelCreatePatient;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(224, 12);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(124, 23);
            label2.TabIndex = 14;
            label2.Text = "Update Patient";
            // 
            // buttonPnlEditCancel
            // 
            buttonPnlEditCancel.Location = new Point(190, 202);
            buttonPnlEditCancel.Margin = new Padding(2);
            buttonPnlEditCancel.Name = "buttonPnlEditCancel";
            buttonPnlEditCancel.Size = new Size(90, 27);
            buttonPnlEditCancel.TabIndex = 13;
            buttonPnlEditCancel.Text = "Cancel";
            buttonPnlEditCancel.UseVisualStyleBackColor = true;
            buttonPnlEditCancel.Click += PatientManagement_Load;
            // 
            // buttonPnlUpdate
            // 
            buttonPnlUpdate.Location = new Point(294, 202);
            buttonPnlUpdate.Margin = new Padding(2);
            buttonPnlUpdate.Name = "buttonPnlUpdate";
            buttonPnlUpdate.Size = new Size(90, 27);
            buttonPnlUpdate.TabIndex = 12;
            buttonPnlUpdate.Text = "Update";
            buttonPnlUpdate.UseVisualStyleBackColor = true;
            buttonPnlUpdate.Click += buttonPanelUpdatePatient;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(222, 14);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(138, 23);
            label3.TabIndex = 14;
            label3.Text = "Add New Patient";
            // 
            // panelAddPatient
            // 
            panelAddPatient.Controls.Add(PnlAddDateTimePicker);
            panelAddPatient.Controls.Add(textBoxPnlAddAddress);
            panelAddPatient.Controls.Add(label5);
            panelAddPatient.Controls.Add(label6);
            panelAddPatient.Controls.Add(textBoxPnlAddPhone);
            panelAddPatient.Controls.Add(label7);
            panelAddPatient.Controls.Add(textBoxPnlAddEmail);
            panelAddPatient.Controls.Add(textBoxPnlAddName);
            panelAddPatient.Controls.Add(label8);
            panelAddPatient.Controls.Add(labelPnlAddPatientName);
            panelAddPatient.Controls.Add(label3);
            panelAddPatient.Controls.Add(buttonPnlAddCancel);
            panelAddPatient.Controls.Add(buttonPnlCreateUser);
            panelAddPatient.Location = new Point(156, 113);
            panelAddPatient.Margin = new Padding(2);
            panelAddPatient.Name = "panelAddPatient";
            panelAddPatient.Size = new Size(562, 259);
            panelAddPatient.TabIndex = 29;
            panelAddPatient.Visible = false;
            // 
            // PnlAddDateTimePicker
            // 
            PnlAddDateTimePicker.Location = new Point(412, 77);
            PnlAddDateTimePicker.Name = "PnlAddDateTimePicker";
            PnlAddDateTimePicker.Size = new Size(127, 27);
            PnlAddDateTimePicker.TabIndex = 32;
            // 
            // textBoxPnlAddAddress
            // 
            textBoxPnlAddAddress.Location = new Point(134, 154);
            textBoxPnlAddAddress.Margin = new Padding(2);
            textBoxPnlAddAddress.Name = "textBoxPnlAddAddress";
            textBoxPnlAddAddress.Size = new Size(406, 27);
            textBoxPnlAddAddress.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 156);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 29;
            label5.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(303, 116);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 28;
            label6.Text = "Phone No.";
            // 
            // textBoxPnlAddPhone
            // 
            textBoxPnlAddPhone.Location = new Point(412, 114);
            textBoxPnlAddPhone.Margin = new Padding(2);
            textBoxPnlAddPhone.Name = "textBoxPnlAddPhone";
            textBoxPnlAddPhone.Size = new Size(127, 27);
            textBoxPnlAddPhone.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 121);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(95, 20);
            label7.TabIndex = 26;
            label7.Text = "Patient Email";
            // 
            // textBoxPnlAddEmail
            // 
            textBoxPnlAddEmail.Location = new Point(134, 116);
            textBoxPnlAddEmail.Margin = new Padding(2);
            textBoxPnlAddEmail.Name = "textBoxPnlAddEmail";
            textBoxPnlAddEmail.Size = new Size(127, 27);
            textBoxPnlAddEmail.TabIndex = 24;
            // 
            // textBoxPnlAddName
            // 
            textBoxPnlAddName.Location = new Point(134, 74);
            textBoxPnlAddName.Margin = new Padding(2);
            textBoxPnlAddName.Name = "textBoxPnlAddName";
            textBoxPnlAddName.Size = new Size(126, 27);
            textBoxPnlAddName.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(303, 78);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(38, 20);
            label8.TabIndex = 22;
            label8.Text = "Dob";
            // 
            // labelPnlAddPatientName
            // 
            labelPnlAddPatientName.AutoSize = true;
            labelPnlAddPatientName.Location = new Point(19, 77);
            labelPnlAddPatientName.Margin = new Padding(2, 0, 2, 0);
            labelPnlAddPatientName.Name = "labelPnlAddPatientName";
            labelPnlAddPatientName.Size = new Size(98, 20);
            labelPnlAddPatientName.TabIndex = 21;
            labelPnlAddPatientName.Text = "Patient Name";
            // 
            // panelUpdatePatient
            // 
            panelUpdatePatient.Controls.Add(pnlUpdateDateTimePicker);
            panelUpdatePatient.Controls.Add(textBoxPnlUpdateAddress);
            panelUpdatePatient.Controls.Add(labelPnlUpdateAdress);
            panelUpdatePatient.Controls.Add(labelPnlUpdatePhone);
            panelUpdatePatient.Controls.Add(textBoxPnlUpdatePhone);
            panelUpdatePatient.Controls.Add(labelPnlUpdateEmail);
            panelUpdatePatient.Controls.Add(label2);
            panelUpdatePatient.Controls.Add(buttonPnlEditCancel);
            panelUpdatePatient.Controls.Add(buttonPnlUpdate);
            panelUpdatePatient.Controls.Add(textBoxPnlUpdateEmail);
            panelUpdatePatient.Controls.Add(textBoxPnlUpdateName);
            panelUpdatePatient.Controls.Add(labelPnlUpdateDob);
            panelUpdatePatient.Controls.Add(labelPnlUpdatePatientName);
            panelUpdatePatient.Location = new Point(158, 113);
            panelUpdatePatient.Margin = new Padding(2);
            panelUpdatePatient.Name = "panelUpdatePatient";
            panelUpdatePatient.Size = new Size(562, 260);
            panelUpdatePatient.TabIndex = 19;
            panelUpdatePatient.Visible = false;
            // 
            // pnlUpdateDateTimePicker
            // 
            pnlUpdateDateTimePicker.Location = new Point(408, 51);
            pnlUpdateDateTimePicker.Name = "pnlUpdateDateTimePicker";
            pnlUpdateDateTimePicker.Size = new Size(127, 27);
            pnlUpdateDateTimePicker.TabIndex = 33;
            // 
            // textBoxPnlUpdateAddress
            // 
            textBoxPnlUpdateAddress.Location = new Point(129, 132);
            textBoxPnlUpdateAddress.Margin = new Padding(2);
            textBoxPnlUpdateAddress.Name = "textBoxPnlUpdateAddress";
            textBoxPnlUpdateAddress.Size = new Size(406, 27);
            textBoxPnlUpdateAddress.TabIndex = 20;
            // 
            // labelPnlUpdateAdress
            // 
            labelPnlUpdateAdress.AutoSize = true;
            labelPnlUpdateAdress.Location = new Point(17, 134);
            labelPnlUpdateAdress.Margin = new Padding(2, 0, 2, 0);
            labelPnlUpdateAdress.Name = "labelPnlUpdateAdress";
            labelPnlUpdateAdress.Size = new Size(62, 20);
            labelPnlUpdateAdress.TabIndex = 19;
            labelPnlUpdateAdress.Text = "Address";
            // 
            // labelPnlUpdatePhone
            // 
            labelPnlUpdatePhone.AutoSize = true;
            labelPnlUpdatePhone.Location = new Point(298, 94);
            labelPnlUpdatePhone.Margin = new Padding(2, 0, 2, 0);
            labelPnlUpdatePhone.Name = "labelPnlUpdatePhone";
            labelPnlUpdatePhone.Size = new Size(77, 20);
            labelPnlUpdatePhone.TabIndex = 18;
            labelPnlUpdatePhone.Text = "Phone No.";
            // 
            // textBoxPnlUpdatePhone
            // 
            textBoxPnlUpdatePhone.Location = new Point(407, 93);
            textBoxPnlUpdatePhone.Margin = new Padding(2);
            textBoxPnlUpdatePhone.Name = "textBoxPnlUpdatePhone";
            textBoxPnlUpdatePhone.Size = new Size(127, 27);
            textBoxPnlUpdatePhone.TabIndex = 17;
            // 
            // labelPnlUpdateEmail
            // 
            labelPnlUpdateEmail.AutoSize = true;
            labelPnlUpdateEmail.Location = new Point(15, 99);
            labelPnlUpdateEmail.Margin = new Padding(2, 0, 2, 0);
            labelPnlUpdateEmail.Name = "labelPnlUpdateEmail";
            labelPnlUpdateEmail.Size = new Size(95, 20);
            labelPnlUpdateEmail.TabIndex = 16;
            labelPnlUpdateEmail.Text = "Patient Email";
            // 
            // textBoxPnlUpdateEmail
            // 
            textBoxPnlUpdateEmail.Location = new Point(130, 94);
            textBoxPnlUpdateEmail.Margin = new Padding(2);
            textBoxPnlUpdateEmail.Name = "textBoxPnlUpdateEmail";
            textBoxPnlUpdateEmail.Size = new Size(127, 27);
            textBoxPnlUpdateEmail.TabIndex = 8;
            // 
            // textBoxPnlUpdateName
            // 
            textBoxPnlUpdateName.Location = new Point(130, 53);
            textBoxPnlUpdateName.Margin = new Padding(2);
            textBoxPnlUpdateName.Name = "textBoxPnlUpdateName";
            textBoxPnlUpdateName.Size = new Size(126, 27);
            textBoxPnlUpdateName.TabIndex = 5;
            textBoxPnlUpdateName.TextChanged += textBoxPnlUpdateRoleName_TextChanged;
            // 
            // labelPnlUpdateDob
            // 
            labelPnlUpdateDob.AutoSize = true;
            labelPnlUpdateDob.Location = new Point(298, 57);
            labelPnlUpdateDob.Margin = new Padding(2, 0, 2, 0);
            labelPnlUpdateDob.Name = "labelPnlUpdateDob";
            labelPnlUpdateDob.Size = new Size(36, 20);
            labelPnlUpdateDob.TabIndex = 3;
            labelPnlUpdateDob.Text = "Age";
            // 
            // labelPnlUpdatePatientName
            // 
            labelPnlUpdatePatientName.AutoSize = true;
            labelPnlUpdatePatientName.Location = new Point(14, 55);
            labelPnlUpdatePatientName.Margin = new Padding(2, 0, 2, 0);
            labelPnlUpdatePatientName.Name = "labelPnlUpdatePatientName";
            labelPnlUpdatePatientName.Size = new Size(98, 20);
            labelPnlUpdatePatientName.TabIndex = 0;
            labelPnlUpdatePatientName.Text = "Patient Name";
            // 
            // buttonPatientList
            // 
            buttonPatientList.Location = new Point(22, 167);
            buttonPatientList.Margin = new Padding(2);
            buttonPatientList.Name = "buttonPatientList";
            buttonPatientList.Size = new Size(102, 27);
            buttonPatientList.TabIndex = 30;
            buttonPatientList.Text = "Patient List";
            buttonPatientList.UseVisualStyleBackColor = true;
            buttonPatientList.Click += PatientManagement_Load;
            // 
            // dataGridViewPatient
            // 
            dataGridViewPatient.AllowUserToOrderColumns = true;
            dataGridViewPatient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPatient.Location = new Point(158, 113);
            dataGridViewPatient.Name = "dataGridViewPatient";
            dataGridViewPatient.RowHeadersWidth = 51;
            dataGridViewPatient.Size = new Size(559, 258);
            dataGridViewPatient.TabIndex = 21;
            // 
            // PatientManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelAddPatient);
            Controls.Add(panelUpdatePatient);
            Controls.Add(buttonPatientList);
            Controls.Add(loggedUserEmail);
            Controls.Add(buttonLogout);
            Controls.Add(buttonEditPatient);
            Controls.Add(buttonDeletePatient);
            Controls.Add(buttonAddPatient);
            Controls.Add(label1);
            Controls.Add(dataGridViewPatient);
            Margin = new Padding(2);
            Name = "PatientManagement";
            Text = "PatientManagement";
            Load += PatientManagement_Load;
            panelAddPatient.ResumeLayout(false);
            panelAddPatient.PerformLayout();
            panelUpdatePatient.ResumeLayout(false);
            panelUpdatePatient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonAddPatient;
        private Button buttonDeletePatient;
        private Button buttonEditPatient;
        private Label loggedUserEmail;
        private Button buttonLogout;
        private Button buttonPnlAddCancel;
        private Button buttonPnlCreateUser;
        private TextBox textBoxPnlAddRoleId;
        private TextBox textBoxPnlAddRoleDesc;
        private TextBox TextBoxPnlAddRoleName;
        private Label labelPnlAddRoleDesc;
        private Label labelPnlAddRoleId;
        private Label labelPnlAddRoleName;
        private Label label2;
        private Button buttonPnlEditCancel;
        private Button buttonPnlUpdate;
        private Label label3;
        private Panel panelAddPatient;
        private Panel panelUpdatePatient;
        private TextBox textBoxPnlUpdateEmail;
        private TextBox textBoxPnlUpdateName;
        private Label labelPnlUpdateDob;
        private Label labelPnlUpdatePatientName;
        private Button buttonPatientList;
        private TextBox textBoxPnlUpdateAddress;
        private Label labelPnlUpdateAdress;
        private Label labelPnlUpdatePhone;
        private TextBox textBoxPnlUpdatePhone;
        private Label labelPnlUpdateEmail;
        private TextBox textBoxPnlAddAddress;
        private Label label5;
        private Label label6;
        private TextBox textBoxPnlAddPhone;
        private Label label7;
        private TextBox textBoxPnlAddEmail;
        private TextBox textBoxPnlAddName;
        private Label label8;
        private Label labelPnlAddPatientName;
        private DataGridView dataGridViewPatient;
        private DateTimePicker PnlAddDateTimePicker;
        private DateTimePicker pnlUpdateDateTimePicker;
    }
}