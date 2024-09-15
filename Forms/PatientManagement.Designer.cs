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
            panelAddRole = new Panel();
            textBox2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            dateTimePicker2 = new DateTimePicker();
            textBox4 = new TextBox();
            textBoxPnlAddName = new TextBox();
            label8 = new Label();
            labelPnlAddPatientName = new Label();
            panelUpdateRole = new Panel();
            textBoxlabelPnlUpdateAddress = new TextBox();
            labelPnlUpdateAdress = new Label();
            labelPnlUpdatePhone = new Label();
            textBoxPnlUpdatePhone = new TextBox();
            labelPnlUpdateEmail = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBoxPnlUpdateRoleDesc = new TextBox();
            textBoxPnlUpdateRoleName = new TextBox();
            labelPnlUpdateDob = new Label();
            labelPnlUpdatePatientName = new Label();
            buttonPatientList = new Button();
            panelPatientList = new Panel();
            dataGridViewPatient = new DataGridView();
            panelAddRole.SuspendLayout();
            panelUpdateRole.SuspendLayout();
            panelPatientList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatient).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(279, 26);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(193, 28);
            label1.TabIndex = 0;
            label1.Text = "Patient Management";
            // 
            // buttonAddPatient
            // 
            buttonAddPatient.Location = new Point(22, 208);
            buttonAddPatient.Margin = new Padding(2, 2, 2, 2);
            buttonAddPatient.Name = "buttonAddPatient";
            buttonAddPatient.Size = new Size(102, 27);
            buttonAddPatient.TabIndex = 1;
            buttonAddPatient.Text = "Add Patient";
            buttonAddPatient.UseVisualStyleBackColor = true;
            // 
            // buttonDeletePatient
            // 
            buttonDeletePatient.Location = new Point(22, 250);
            buttonDeletePatient.Margin = new Padding(2, 2, 2, 2);
            buttonDeletePatient.Name = "buttonDeletePatient";
            buttonDeletePatient.Size = new Size(102, 27);
            buttonDeletePatient.TabIndex = 2;
            buttonDeletePatient.Text = "Delete Patient";
            buttonDeletePatient.UseVisualStyleBackColor = true;
            // 
            // buttonEditPatient
            // 
            buttonEditPatient.Location = new Point(22, 291);
            buttonEditPatient.Margin = new Padding(2, 2, 2, 2);
            buttonEditPatient.Name = "buttonEditPatient";
            buttonEditPatient.Size = new Size(102, 27);
            buttonEditPatient.TabIndex = 3;
            buttonEditPatient.Text = "Edit Patient";
            buttonEditPatient.UseVisualStyleBackColor = true;
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
            // 
            // buttonPnlAddCancel
            // 
            buttonPnlAddCancel.Location = new Point(196, 206);
            buttonPnlAddCancel.Margin = new Padding(2, 2, 2, 2);
            buttonPnlAddCancel.Name = "buttonPnlAddCancel";
            buttonPnlAddCancel.Size = new Size(90, 27);
            buttonPnlAddCancel.TabIndex = 13;
            buttonPnlAddCancel.Text = "Cancel";
            buttonPnlAddCancel.UseVisualStyleBackColor = true;
            // 
            // buttonPnlCreateUser
            // 
            buttonPnlCreateUser.Location = new Point(298, 206);
            buttonPnlCreateUser.Margin = new Padding(2, 2, 2, 2);
            buttonPnlCreateUser.Name = "buttonPnlCreateUser";
            buttonPnlCreateUser.Size = new Size(90, 27);
            buttonPnlCreateUser.TabIndex = 12;
            buttonPnlCreateUser.Text = "Create";
            buttonPnlCreateUser.UseVisualStyleBackColor = true;
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
            buttonPnlEditCancel.Margin = new Padding(2, 2, 2, 2);
            buttonPnlEditCancel.Name = "buttonPnlEditCancel";
            buttonPnlEditCancel.Size = new Size(90, 27);
            buttonPnlEditCancel.TabIndex = 13;
            buttonPnlEditCancel.Text = "Cancel";
            buttonPnlEditCancel.UseVisualStyleBackColor = true;
            // 
            // buttonPnlUpdate
            // 
            buttonPnlUpdate.Location = new Point(294, 202);
            buttonPnlUpdate.Margin = new Padding(2, 2, 2, 2);
            buttonPnlUpdate.Name = "buttonPnlUpdate";
            buttonPnlUpdate.Size = new Size(90, 27);
            buttonPnlUpdate.TabIndex = 12;
            buttonPnlUpdate.Text = "Update";
            buttonPnlUpdate.UseVisualStyleBackColor = true;
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
            // panelAddRole
            // 
            panelAddRole.Controls.Add(panelPatientList);
            panelAddRole.Controls.Add(textBox2);
            panelAddRole.Controls.Add(label5);
            panelAddRole.Controls.Add(label6);
            panelAddRole.Controls.Add(textBox3);
            panelAddRole.Controls.Add(label7);
            panelAddRole.Controls.Add(dateTimePicker2);
            panelAddRole.Controls.Add(textBox4);
            panelAddRole.Controls.Add(textBoxPnlAddName);
            panelAddRole.Controls.Add(label8);
            panelAddRole.Controls.Add(labelPnlAddPatientName);
            panelAddRole.Controls.Add(label3);
            panelAddRole.Controls.Add(buttonPnlAddCancel);
            panelAddRole.Controls.Add(buttonPnlCreateUser);
            panelAddRole.Location = new Point(2, 2);
            panelAddRole.Margin = new Padding(2, 2, 2, 2);
            panelAddRole.Name = "panelAddRole";
            panelAddRole.Size = new Size(562, 254);
            panelAddRole.TabIndex = 29;
            panelAddRole.Visible = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(134, 154);
            textBox2.Margin = new Padding(2, 2, 2, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(406, 27);
            textBox2.TabIndex = 30;
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
            // textBox3
            // 
            textBox3.Location = new Point(412, 114);
            textBox3.Margin = new Padding(2, 2, 2, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(127, 27);
            textBox3.TabIndex = 27;
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
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(412, 74);
            dateTimePicker2.Margin = new Padding(2, 2, 2, 2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(132, 27);
            dateTimePicker2.TabIndex = 25;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(134, 116);
            textBox4.Margin = new Padding(2, 2, 2, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(127, 27);
            textBox4.TabIndex = 24;
            // 
            // textBoxPnlAddName
            // 
            textBoxPnlAddName.Location = new Point(134, 74);
            textBoxPnlAddName.Margin = new Padding(2, 2, 2, 2);
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
            // panelUpdateRole
            // 
            panelUpdateRole.Controls.Add(panelAddRole);
            panelUpdateRole.Controls.Add(textBoxlabelPnlUpdateAddress);
            panelUpdateRole.Controls.Add(labelPnlUpdateAdress);
            panelUpdateRole.Controls.Add(labelPnlUpdatePhone);
            panelUpdateRole.Controls.Add(textBoxPnlUpdatePhone);
            panelUpdateRole.Controls.Add(labelPnlUpdateEmail);
            panelUpdateRole.Controls.Add(dateTimePicker1);
            panelUpdateRole.Controls.Add(label2);
            panelUpdateRole.Controls.Add(buttonPnlEditCancel);
            panelUpdateRole.Controls.Add(buttonPnlUpdate);
            panelUpdateRole.Controls.Add(textBoxPnlUpdateRoleDesc);
            panelUpdateRole.Controls.Add(textBoxPnlUpdateRoleName);
            panelUpdateRole.Controls.Add(labelPnlUpdateDob);
            panelUpdateRole.Controls.Add(labelPnlUpdatePatientName);
            panelUpdateRole.Location = new Point(154, 121);
            panelUpdateRole.Margin = new Padding(2, 2, 2, 2);
            panelUpdateRole.Name = "panelUpdateRole";
            panelUpdateRole.Size = new Size(562, 258);
            panelUpdateRole.TabIndex = 19;
            panelUpdateRole.Visible = false;
            // 
            // textBoxlabelPnlUpdateAddress
            // 
            textBoxlabelPnlUpdateAddress.Location = new Point(129, 132);
            textBoxlabelPnlUpdateAddress.Margin = new Padding(2, 2, 2, 2);
            textBoxlabelPnlUpdateAddress.Name = "textBoxlabelPnlUpdateAddress";
            textBoxlabelPnlUpdateAddress.Size = new Size(406, 27);
            textBoxlabelPnlUpdateAddress.TabIndex = 20;
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
            textBoxPnlUpdatePhone.Margin = new Padding(2, 2, 2, 2);
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
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(407, 53);
            dateTimePicker1.Margin = new Padding(2, 2, 2, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(132, 27);
            dateTimePicker1.TabIndex = 15;
            // 
            // textBoxPnlUpdateRoleDesc
            // 
            textBoxPnlUpdateRoleDesc.Location = new Point(130, 94);
            textBoxPnlUpdateRoleDesc.Margin = new Padding(2, 2, 2, 2);
            textBoxPnlUpdateRoleDesc.Name = "textBoxPnlUpdateRoleDesc";
            textBoxPnlUpdateRoleDesc.Size = new Size(127, 27);
            textBoxPnlUpdateRoleDesc.TabIndex = 8;
            // 
            // textBoxPnlUpdateRoleName
            // 
            textBoxPnlUpdateRoleName.Location = new Point(130, 53);
            textBoxPnlUpdateRoleName.Margin = new Padding(2, 2, 2, 2);
            textBoxPnlUpdateRoleName.Name = "textBoxPnlUpdateRoleName";
            textBoxPnlUpdateRoleName.Size = new Size(126, 27);
            textBoxPnlUpdateRoleName.TabIndex = 5;
            textBoxPnlUpdateRoleName.TextChanged += textBoxPnlUpdateRoleName_TextChanged;
            // 
            // labelPnlUpdateDob
            // 
            labelPnlUpdateDob.AutoSize = true;
            labelPnlUpdateDob.Location = new Point(298, 57);
            labelPnlUpdateDob.Margin = new Padding(2, 0, 2, 0);
            labelPnlUpdateDob.Name = "labelPnlUpdateDob";
            labelPnlUpdateDob.Size = new Size(38, 20);
            labelPnlUpdateDob.TabIndex = 3;
            labelPnlUpdateDob.Text = "Dob";
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
            buttonPatientList.Margin = new Padding(2, 2, 2, 2);
            buttonPatientList.Name = "buttonPatientList";
            buttonPatientList.Size = new Size(102, 27);
            buttonPatientList.TabIndex = 30;
            buttonPatientList.Text = "Patient List";
            buttonPatientList.UseVisualStyleBackColor = true;
            // 
            // panelPatientList
            // 
            panelPatientList.Controls.Add(dataGridViewPatient);
            panelPatientList.Location = new Point(0, 0);
            panelPatientList.Margin = new Padding(2);
            panelPatientList.Name = "panelPatientList";
            panelPatientList.Size = new Size(562, 258);
            panelPatientList.TabIndex = 31;
            panelPatientList.Visible = false;
            // 
            // dataGridViewPatient
            // 
            dataGridViewPatient.AllowUserToOrderColumns = true;
            dataGridViewPatient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPatient.Location = new Point(17, 3);
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
            Controls.Add(panelUpdateRole);
            Controls.Add(buttonPatientList);
            Controls.Add(loggedUserEmail);
            Controls.Add(buttonLogout);
            Controls.Add(buttonEditPatient);
            Controls.Add(buttonDeletePatient);
            Controls.Add(buttonAddPatient);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "PatientManagement";
            Text = "PatientManagement";
            Load += PatientManagement_Load;
            panelAddRole.ResumeLayout(false);
            panelAddRole.PerformLayout();
            panelUpdateRole.ResumeLayout(false);
            panelUpdateRole.PerformLayout();
            panelPatientList.ResumeLayout(false);
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
        private Panel panelAddRole;
        private Panel panelUpdateRole;
        private TextBox textBoxPnlUpdateRoleDesc;
        private TextBox textBoxPnlUpdateRoleName;
        private Label labelPnlUpdateDob;
        private Label labelPnlUpdatePatientName;
        private Button buttonPatientList;
        private DateTimePicker dateTimePicker1;
        private TextBox textBoxlabelPnlUpdateAddress;
        private Label labelPnlUpdateAdress;
        private Label labelPnlUpdatePhone;
        private TextBox textBoxPnlUpdatePhone;
        private Label labelPnlUpdateEmail;
        private TextBox textBox2;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
        private Label label7;
        private DateTimePicker dateTimePicker2;
        private TextBox textBox4;
        private TextBox textBoxPnlAddName;
        private Label label8;
        private Label labelPnlAddPatientName;
        private Panel panelPatientList;
        private DataGridView dataGridViewPatient;
    }
}