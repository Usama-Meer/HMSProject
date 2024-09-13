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
            panelUpdateRole = new Panel();
            textBoxPnlUpdateRoleDesc = new TextBox();
            textBoxPnlUpdateRoleName = new TextBox();
            labelPnlUpdateDob = new Label();
            labelPnlUpdatePatientName = new Label();
            buttonPatientList = new Button();
            dateTimePicker1 = new DateTimePicker();
            labelPnlUpdateEmail = new Label();
            labelPnlUpdatePhone = new Label();
            textBoxPnlUpdatePhone = new TextBox();
            labelPnlUpdateAdress = new Label();
            textBoxlabelPnlUpdateAddress = new TextBox();
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
            panelAddRole.SuspendLayout();
            panelUpdateRole.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(349, 33);
            label1.Name = "label1";
            label1.Size = new Size(237, 32);
            label1.TabIndex = 0;
            label1.Text = "Patient Management";
            // 
            // buttonAddPatient
            // 
            buttonAddPatient.Location = new Point(28, 260);
            buttonAddPatient.Name = "buttonAddPatient";
            buttonAddPatient.Size = new Size(128, 34);
            buttonAddPatient.TabIndex = 1;
            buttonAddPatient.Text = "Add Patient";
            buttonAddPatient.UseVisualStyleBackColor = true;
            // 
            // buttonDeletePatient
            // 
            buttonDeletePatient.Location = new Point(28, 312);
            buttonDeletePatient.Name = "buttonDeletePatient";
            buttonDeletePatient.Size = new Size(128, 34);
            buttonDeletePatient.TabIndex = 2;
            buttonDeletePatient.Text = "Delete Patient";
            buttonDeletePatient.UseVisualStyleBackColor = true;
            // 
            // buttonEditPatient
            // 
            buttonEditPatient.Location = new Point(28, 364);
            buttonEditPatient.Name = "buttonEditPatient";
            buttonEditPatient.Size = new Size(128, 34);
            buttonEditPatient.TabIndex = 3;
            buttonEditPatient.Text = "Edit Patient";
            buttonEditPatient.UseVisualStyleBackColor = true;
            // 
            // loggedUserEmail
            // 
            loggedUserEmail.AutoSize = true;
            loggedUserEmail.Location = new Point(728, 40);
            loggedUserEmail.Margin = new Padding(4, 0, 4, 0);
            loggedUserEmail.Name = "loggedUserEmail";
            loggedUserEmail.Size = new Size(104, 25);
            loggedUserEmail.TabIndex = 10;
            loggedUserEmail.Text = "{User Email}";
            // 
            // buttonLogout
            // 
            buttonLogout.Location = new Point(847, 35);
            buttonLogout.Margin = new Padding(4);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(118, 36);
            buttonLogout.TabIndex = 9;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = true;
            // 
            // buttonPnlAddCancel
            // 
            buttonPnlAddCancel.Location = new Point(245, 258);
            buttonPnlAddCancel.Name = "buttonPnlAddCancel";
            buttonPnlAddCancel.Size = new Size(112, 34);
            buttonPnlAddCancel.TabIndex = 13;
            buttonPnlAddCancel.Text = "Cancel";
            buttonPnlAddCancel.UseVisualStyleBackColor = true;
            // 
            // buttonPnlCreateUser
            // 
            buttonPnlCreateUser.Location = new Point(373, 258);
            buttonPnlCreateUser.Name = "buttonPnlCreateUser";
            buttonPnlCreateUser.Size = new Size(112, 34);
            buttonPnlCreateUser.TabIndex = 12;
            buttonPnlCreateUser.Text = "Create";
            buttonPnlCreateUser.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(280, 15);
            label2.Name = "label2";
            label2.Size = new Size(142, 28);
            label2.TabIndex = 14;
            label2.Text = "Update Patient";
            // 
            // buttonPnlEditCancel
            // 
            buttonPnlEditCancel.Location = new Point(237, 252);
            buttonPnlEditCancel.Name = "buttonPnlEditCancel";
            buttonPnlEditCancel.Size = new Size(112, 34);
            buttonPnlEditCancel.TabIndex = 13;
            buttonPnlEditCancel.Text = "Cancel";
            buttonPnlEditCancel.UseVisualStyleBackColor = true;
            // 
            // buttonPnlUpdate
            // 
            buttonPnlUpdate.Location = new Point(368, 252);
            buttonPnlUpdate.Name = "buttonPnlUpdate";
            buttonPnlUpdate.Size = new Size(112, 34);
            buttonPnlUpdate.TabIndex = 12;
            buttonPnlUpdate.Text = "Update";
            buttonPnlUpdate.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(277, 17);
            label3.Name = "label3";
            label3.Size = new Size(158, 28);
            label3.TabIndex = 14;
            label3.Text = "Add New Patient";
            // 
            // panelAddRole
            // 
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
            panelAddRole.Location = new Point(3, 3);
            panelAddRole.Name = "panelAddRole";
            panelAddRole.Size = new Size(702, 317);
            panelAddRole.TabIndex = 29;
            panelAddRole.Visible = false;
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
            panelUpdateRole.Location = new Point(193, 151);
            panelUpdateRole.Name = "panelUpdateRole";
            panelUpdateRole.Size = new Size(702, 323);
            panelUpdateRole.TabIndex = 19;
            panelUpdateRole.Visible = false;
            // 
            // textBoxPnlUpdateRoleDesc
            // 
            textBoxPnlUpdateRoleDesc.Location = new Point(162, 118);
            textBoxPnlUpdateRoleDesc.Name = "textBoxPnlUpdateRoleDesc";
            textBoxPnlUpdateRoleDesc.Size = new Size(158, 31);
            textBoxPnlUpdateRoleDesc.TabIndex = 8;
            // 
            // textBoxPnlUpdateRoleName
            // 
            textBoxPnlUpdateRoleName.Location = new Point(162, 66);
            textBoxPnlUpdateRoleName.Name = "textBoxPnlUpdateRoleName";
            textBoxPnlUpdateRoleName.Size = new Size(157, 31);
            textBoxPnlUpdateRoleName.TabIndex = 5;
            textBoxPnlUpdateRoleName.TextChanged += textBoxPnlUpdateRoleName_TextChanged;
            // 
            // labelPnlUpdateDob
            // 
            labelPnlUpdateDob.AutoSize = true;
            labelPnlUpdateDob.Location = new Point(373, 71);
            labelPnlUpdateDob.Name = "labelPnlUpdateDob";
            labelPnlUpdateDob.Size = new Size(47, 25);
            labelPnlUpdateDob.TabIndex = 3;
            labelPnlUpdateDob.Text = "Dob";
            // 
            // labelPnlUpdatePatientName
            // 
            labelPnlUpdatePatientName.AutoSize = true;
            labelPnlUpdatePatientName.Location = new Point(18, 69);
            labelPnlUpdatePatientName.Name = "labelPnlUpdatePatientName";
            labelPnlUpdatePatientName.Size = new Size(117, 25);
            labelPnlUpdatePatientName.TabIndex = 0;
            labelPnlUpdatePatientName.Text = "Patient Name";
            // 
            // buttonPatientList
            // 
            buttonPatientList.Location = new Point(28, 209);
            buttonPatientList.Name = "buttonPatientList";
            buttonPatientList.Size = new Size(128, 34);
            buttonPatientList.TabIndex = 30;
            buttonPatientList.Text = "Patient List";
            buttonPatientList.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(509, 66);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(164, 31);
            dateTimePicker1.TabIndex = 15;
            // 
            // labelPnlUpdateEmail
            // 
            labelPnlUpdateEmail.AutoSize = true;
            labelPnlUpdateEmail.Location = new Point(19, 124);
            labelPnlUpdateEmail.Name = "labelPnlUpdateEmail";
            labelPnlUpdateEmail.Size = new Size(112, 25);
            labelPnlUpdateEmail.TabIndex = 16;
            labelPnlUpdateEmail.Text = "Patient Email";
            // 
            // labelPnlUpdatePhone
            // 
            labelPnlUpdatePhone.AutoSize = true;
            labelPnlUpdatePhone.Location = new Point(373, 118);
            labelPnlUpdatePhone.Name = "labelPnlUpdatePhone";
            labelPnlUpdatePhone.Size = new Size(95, 25);
            labelPnlUpdatePhone.TabIndex = 18;
            labelPnlUpdatePhone.Text = "Phone No.";
            // 
            // textBoxPnlUpdatePhone
            // 
            textBoxPnlUpdatePhone.Location = new Point(509, 116);
            textBoxPnlUpdatePhone.Name = "textBoxPnlUpdatePhone";
            textBoxPnlUpdatePhone.Size = new Size(158, 31);
            textBoxPnlUpdatePhone.TabIndex = 17;
            // 
            // labelPnlUpdateAdress
            // 
            labelPnlUpdateAdress.AutoSize = true;
            labelPnlUpdateAdress.Location = new Point(21, 168);
            labelPnlUpdateAdress.Name = "labelPnlUpdateAdress";
            labelPnlUpdateAdress.Size = new Size(77, 25);
            labelPnlUpdateAdress.TabIndex = 19;
            labelPnlUpdateAdress.Text = "Address";
            // 
            // textBoxlabelPnlUpdateAddress
            // 
            textBoxlabelPnlUpdateAddress.Location = new Point(161, 165);
            textBoxlabelPnlUpdateAddress.Name = "textBoxlabelPnlUpdateAddress";
            textBoxlabelPnlUpdateAddress.Size = new Size(506, 31);
            textBoxlabelPnlUpdateAddress.TabIndex = 20;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(167, 192);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(506, 31);
            textBox2.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 195);
            label5.Name = "label5";
            label5.Size = new Size(77, 25);
            label5.TabIndex = 29;
            label5.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(379, 145);
            label6.Name = "label6";
            label6.Size = new Size(95, 25);
            label6.TabIndex = 28;
            label6.Text = "Phone No.";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(515, 143);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(158, 31);
            textBox3.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 151);
            label7.Name = "label7";
            label7.Size = new Size(112, 25);
            label7.TabIndex = 26;
            label7.Text = "Patient Email";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(515, 93);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(164, 31);
            dateTimePicker2.TabIndex = 25;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(168, 145);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(158, 31);
            textBox4.TabIndex = 24;
            // 
            // textBoxPnlAddName
            // 
            textBoxPnlAddName.Location = new Point(168, 93);
            textBoxPnlAddName.Name = "textBoxPnlAddName";
            textBoxPnlAddName.Size = new Size(157, 31);
            textBoxPnlAddName.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(379, 98);
            label8.Name = "label8";
            label8.Size = new Size(47, 25);
            label8.TabIndex = 22;
            label8.Text = "Dob";
            // 
            // labelPnlAddPatientName
            // 
            labelPnlAddPatientName.AutoSize = true;
            labelPnlAddPatientName.Location = new Point(24, 96);
            labelPnlAddPatientName.Name = "labelPnlAddPatientName";
            labelPnlAddPatientName.Size = new Size(117, 25);
            labelPnlAddPatientName.TabIndex = 21;
            labelPnlAddPatientName.Text = "Patient Name";
            // 
            // PatientManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(panelUpdateRole);
            Controls.Add(buttonPatientList);
            Controls.Add(loggedUserEmail);
            Controls.Add(buttonLogout);
            Controls.Add(buttonEditPatient);
            Controls.Add(buttonDeletePatient);
            Controls.Add(buttonAddPatient);
            Controls.Add(label1);
            Name = "PatientManagement";
            Text = "PatientManagement";
            Load += PatientManagement_Load;
            panelAddRole.ResumeLayout(false);
            panelAddRole.PerformLayout();
            panelUpdateRole.ResumeLayout(false);
            panelUpdateRole.PerformLayout();
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
    }
}