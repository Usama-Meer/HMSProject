namespace HMSProject.Forms
{
    partial class AppointmentManagement
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
            components = new System.ComponentModel.Container();
            loggedUserEmail = new Label();
            buttonLogout = new Button();
            label1 = new Label();
            panelAddAppointment = new Panel();
            label3 = new Label();
            panelUpdateAppoint = new Panel();
            label2 = new Label();
            buttonPnlEditCancel = new Button();
            buttonPnlUpdate = new Button();
            textBoxPnlUpdateEmail = new TextBox();
            textBoxPnlUpdateName = new TextBox();
            labelPnlUpdateAppointEmail = new Label();
            labelPnlUpdateReceptName = new Label();
            buttonPnlAddCancel = new Button();
            buttonPnlCreateUser = new Button();
            buttonAppointmentList = new Button();
            buttonEditAppointment = new Button();
            buttonDeleteAppointment = new Button();
            buttonAddAppointment = new Button();
            label4 = new Label();
            labelPnlAddDate = new Label();
            dateTimePickerPnlUpdate = new DateTimePicker();
            doctorBindingSource = new BindingSource(components);
            comboBoxPnlUpdateStatus = new ComboBox();
            this.textBoxtextBoxPnlAddEmail = new TextBox();
            textBoxPnlAddPName = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label6 = new Label();
            comboBoxPnlUpdateDName = new ComboBox();
            label5 = new Label();
            comboBoxPnlAddDName = new ComboBox();
            dateTimePickerPnlAdd = new DateTimePicker();
            label7 = new Label();
            panelAddAppointment.SuspendLayout();
            panelUpdateAppoint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)doctorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // loggedUserEmail
            // 
            loggedUserEmail.AutoSize = true;
            loggedUserEmail.Location = new Point(704, 36);
            loggedUserEmail.Margin = new Padding(4, 0, 4, 0);
            loggedUserEmail.Name = "loggedUserEmail";
            loggedUserEmail.Size = new Size(104, 25);
            loggedUserEmail.TabIndex = 22;
            loggedUserEmail.Text = "{User Email}";
            // 
            // buttonLogout
            // 
            buttonLogout.Location = new Point(823, 31);
            buttonLogout.Margin = new Padding(4);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(118, 36);
            buttonLogout.TabIndex = 21;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(334, 21);
            label1.Name = "label1";
            label1.Size = new Size(305, 32);
            label1.TabIndex = 17;
            label1.Text = "Appointment Management";
            // 
            // panelAddAppointment
            // 
            panelAddAppointment.Controls.Add(label5);
            panelAddAppointment.Controls.Add(comboBoxPnlAddDName);
            panelAddAppointment.Controls.Add(dateTimePickerPnlAdd);
            panelAddAppointment.Controls.Add(label7);
            panelAddAppointment.Controls.Add(this.textBoxtextBoxPnlAddEmail);
            panelAddAppointment.Controls.Add(textBoxPnlAddPName);
            panelAddAppointment.Controls.Add(label8);
            panelAddAppointment.Controls.Add(label9);
            panelAddAppointment.Controls.Add(buttonPnlAddCancel);
            panelAddAppointment.Controls.Add(buttonPnlCreateUser);
            panelAddAppointment.Controls.Add(label3);
            panelAddAppointment.Location = new Point(239, 123);
            panelAddAppointment.Name = "panelAddAppointment";
            panelAddAppointment.Size = new Size(702, 317);
            panelAddAppointment.TabIndex = 34;
            panelAddAppointment.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(277, 17);
            label3.Name = "label3";
            label3.Size = new Size(215, 28);
            label3.TabIndex = 14;
            label3.Text = "Add New Appointment";
            // 
            // panelUpdateAppoint
            // 
            panelUpdateAppoint.Controls.Add(label6);
            panelUpdateAppoint.Controls.Add(comboBoxPnlUpdateDName);
            panelUpdateAppoint.Controls.Add(comboBoxPnlUpdateStatus);
            panelUpdateAppoint.Controls.Add(dateTimePickerPnlUpdate);
            panelUpdateAppoint.Controls.Add(labelPnlAddDate);
            panelUpdateAppoint.Controls.Add(label4);
            panelUpdateAppoint.Controls.Add(label2);
            panelUpdateAppoint.Controls.Add(buttonPnlEditCancel);
            panelUpdateAppoint.Controls.Add(buttonPnlUpdate);
            panelUpdateAppoint.Controls.Add(textBoxPnlUpdateEmail);
            panelUpdateAppoint.Controls.Add(textBoxPnlUpdateName);
            panelUpdateAppoint.Controls.Add(labelPnlUpdateAppointEmail);
            panelUpdateAppoint.Controls.Add(labelPnlUpdateReceptName);
            panelUpdateAppoint.Location = new Point(239, 123);
            panelUpdateAppoint.Name = "panelUpdateAppoint";
            panelUpdateAppoint.Size = new Size(702, 323);
            panelUpdateAppoint.TabIndex = 19;
            panelUpdateAppoint.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(280, 15);
            label2.Name = "label2";
            label2.Size = new Size(199, 28);
            label2.TabIndex = 14;
            label2.Text = "Update Appointment";
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
            // textBoxPnlUpdateEmail
            // 
            textBoxPnlUpdateEmail.Location = new Point(224, 91);
            textBoxPnlUpdateEmail.Name = "textBoxPnlUpdateEmail";
            textBoxPnlUpdateEmail.Size = new Size(324, 31);
            textBoxPnlUpdateEmail.TabIndex = 8;
            // 
            // textBoxPnlUpdateName
            // 
            textBoxPnlUpdateName.Location = new Point(224, 54);
            textBoxPnlUpdateName.Name = "textBoxPnlUpdateName";
            textBoxPnlUpdateName.Size = new Size(324, 31);
            textBoxPnlUpdateName.TabIndex = 5;
            // 
            // labelPnlUpdateAppointEmail
            // 
            labelPnlUpdateAppointEmail.AutoSize = true;
            labelPnlUpdateAppointEmail.Location = new Point(58, 94);
            labelPnlUpdateAppointEmail.Name = "labelPnlUpdateAppointEmail";
            labelPnlUpdateAppointEmail.Size = new Size(112, 25);
            labelPnlUpdateAppointEmail.TabIndex = 3;
            labelPnlUpdateAppointEmail.Text = "Patient Email";
            // 
            // labelPnlUpdateReceptName
            // 
            labelPnlUpdateReceptName.AutoSize = true;
            labelPnlUpdateReceptName.Location = new Point(58, 57);
            labelPnlUpdateReceptName.Name = "labelPnlUpdateReceptName";
            labelPnlUpdateReceptName.Size = new Size(117, 25);
            labelPnlUpdateReceptName.TabIndex = 0;
            labelPnlUpdateReceptName.Text = "Patient Name";
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
            // buttonAppointmentList
            // 
            buttonAppointmentList.Location = new Point(59, 159);
            buttonAppointmentList.Name = "buttonAppointmentList";
            buttonAppointmentList.Size = new Size(128, 34);
            buttonAppointmentList.TabIndex = 35;
            buttonAppointmentList.Text = "Appoint. List";
            buttonAppointmentList.UseVisualStyleBackColor = true;
            // 
            // buttonEditAppointment
            // 
            buttonEditAppointment.Location = new Point(59, 312);
            buttonEditAppointment.Name = "buttonEditAppointment";
            buttonEditAppointment.Size = new Size(128, 34);
            buttonEditAppointment.TabIndex = 33;
            buttonEditAppointment.Text = "Edit Appoint.";
            buttonEditAppointment.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteAppointment
            // 
            buttonDeleteAppointment.Location = new Point(59, 262);
            buttonDeleteAppointment.Name = "buttonDeleteAppointment";
            buttonDeleteAppointment.Size = new Size(128, 34);
            buttonDeleteAppointment.TabIndex = 32;
            buttonDeleteAppointment.Text = "Delete Appoint.";
            buttonDeleteAppointment.UseVisualStyleBackColor = true;
            // 
            // buttonAddAppointment
            // 
            buttonAddAppointment.Location = new Point(59, 212);
            buttonAddAppointment.Name = "buttonAddAppointment";
            buttonAddAppointment.Size = new Size(128, 34);
            buttonAddAppointment.TabIndex = 31;
            buttonAddAppointment.Text = "Add Appoint.";
            buttonAddAppointment.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 210);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 15;
            label4.Text = "Status";
            // 
            // labelPnlAddDate
            // 
            labelPnlAddDate.AutoSize = true;
            labelPnlAddDate.Location = new Point(58, 172);
            labelPnlAddDate.Name = "labelPnlAddDate";
            labelPnlAddDate.Size = new Size(49, 25);
            labelPnlAddDate.TabIndex = 16;
            labelPnlAddDate.Text = "Date";
            // 
            // dateTimePickerPnlUpdate
            // 
            dateTimePickerPnlUpdate.Location = new Point(225, 167);
            dateTimePickerPnlUpdate.Name = "dateTimePickerPnlUpdate";
            dateTimePickerPnlUpdate.Size = new Size(324, 31);
            dateTimePickerPnlUpdate.TabIndex = 18;
            // 
            // doctorBindingSource
            // 
            doctorBindingSource.DataSource = typeof(Models.Doctor);
            // 
            // comboBoxPnlUpdateStatus
            // 
            comboBoxPnlUpdateStatus.FormattingEnabled = true;
            comboBoxPnlUpdateStatus.Items.AddRange(new object[] { "Active", "Inactive" });
            comboBoxPnlUpdateStatus.Location = new Point(224, 205);
            comboBoxPnlUpdateStatus.Name = "comboBoxPnlUpdateStatus";
            comboBoxPnlUpdateStatus.Size = new Size(323, 33);
            comboBoxPnlUpdateStatus.TabIndex = 22;
            // 
            // textBoxtextBoxPnlAddEmail
            // 
            this.textBoxtextBoxPnlAddEmail.Location = new Point(272, 103);
            this.textBoxtextBoxPnlAddEmail.Name = "textBoxtextBoxPnlAddEmail";
            this.textBoxtextBoxPnlAddEmail.Size = new Size(324, 31);
            this.textBoxtextBoxPnlAddEmail.TabIndex = 25;
            // 
            // textBoxPnlAddPName
            // 
            textBoxPnlAddPName.Location = new Point(272, 66);
            textBoxPnlAddPName.Name = "textBoxPnlAddPName";
            textBoxPnlAddPName.Size = new Size(324, 31);
            textBoxPnlAddPName.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(106, 106);
            label8.Name = "label8";
            label8.Size = new Size(112, 25);
            label8.TabIndex = 23;
            label8.Text = "Patient Email";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(106, 69);
            label9.Name = "label9";
            label9.Size = new Size(117, 25);
            label9.TabIndex = 22;
            label9.Text = "Patient Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(58, 128);
            label6.Name = "label6";
            label6.Size = new Size(119, 25);
            label6.TabIndex = 26;
            label6.Text = "Doctor Name";
            // 
            // comboBoxPnlUpdateDName
            // 
            comboBoxPnlUpdateDName.FormattingEnabled = true;
            comboBoxPnlUpdateDName.Location = new Point(224, 128);
            comboBoxPnlUpdateDName.Name = "comboBoxPnlUpdateDName";
            comboBoxPnlUpdateDName.Size = new Size(323, 33);
            comboBoxPnlUpdateDName.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(106, 141);
            label5.Name = "label5";
            label5.Size = new Size(119, 25);
            label5.TabIndex = 30;
            label5.Text = "Doctor Name";
            // 
            // comboBoxPnlAddDName
            // 
            comboBoxPnlAddDName.FormattingEnabled = true;
            comboBoxPnlAddDName.Location = new Point(272, 141);
            comboBoxPnlAddDName.Name = "comboBoxPnlAddDName";
            comboBoxPnlAddDName.Size = new Size(323, 33);
            comboBoxPnlAddDName.TabIndex = 29;
            // 
            // dateTimePickerPnlAdd
            // 
            dateTimePickerPnlAdd.Location = new Point(273, 180);
            dateTimePickerPnlAdd.Name = "dateTimePickerPnlAdd";
            dateTimePickerPnlAdd.Size = new Size(324, 31);
            dateTimePickerPnlAdd.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(106, 185);
            label7.Name = "label7";
            label7.Size = new Size(49, 25);
            label7.TabIndex = 27;
            label7.Text = "Date";
            // 
            // AppointmentManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(panelUpdateAppoint);
            Controls.Add(panelAddAppointment);
            Controls.Add(buttonAppointmentList);
            Controls.Add(buttonEditAppointment);
            Controls.Add(buttonDeleteAppointment);
            Controls.Add(buttonAddAppointment);
            Controls.Add(loggedUserEmail);
            Controls.Add(buttonLogout);
            Controls.Add(label1);
            Name = "AppointmentManagement";
            Text = "AppointmentManagement";
            panelAddAppointment.ResumeLayout(false);
            panelAddAppointment.PerformLayout();
            panelUpdateAppoint.ResumeLayout(false);
            panelUpdateAppoint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)doctorBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loggedUserEmail;
        private Button buttonLogout;
        private Label label1;
        private Panel panelAddAppointment;
        private Label label3;
        private Panel panelUpdateAppoint;
        private Label label2;
        private Button buttonPnlEditCancel;
        private Button buttonPnlUpdate;
        private TextBox textBoxPnlUpdateEmail;
        private TextBox textBoxPnlUpdateName;
        private Label labelPnlUpdateAppointEmail;
        private Label labelPnlUpdateReceptName;
        private Button buttonPnlAddCancel;
        private Button buttonPnlCreateUser;
        private Button buttonAppointmentList;
        private Button buttonEditAppointment;
        private Button buttonDeleteAppointment;
        private Button buttonAddAppointment;
        private Label label4;
        private DateTimePicker dateTimePickerPnlUpdate;
        private Label labelPnlAddDate;
        private BindingSource doctorBindingSource;
        private ComboBox comboBoxPnlUpdateStatus;
        private ComboBox comboBox3;
        private TextBox textBox1;
        private TextBox textBoxPnlAddPName;
        private Label label8;
        private Label label9;
        private Label label5;
        private ComboBox comboBoxPnlAddDName;
        private DateTimePicker dateTimePickerPnlAdd;
        private Label label7;
        private Label label6;
        private ComboBox comboBoxPnlUpdateDName;
    }
}