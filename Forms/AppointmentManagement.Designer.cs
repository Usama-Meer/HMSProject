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
            label5 = new Label();
            comboBoxPnlAddDName = new ComboBox();
            dateTimePickerPnlAdd = new DateTimePicker();
            label7 = new Label();
            textBoxPnlAddPEmail = new TextBox();
            textBoxPnlAddPName = new TextBox();
            label8 = new Label();
            label9 = new Label();
            buttonPnlAddCancel = new Button();
            buttonPnlCreateUser = new Button();
            label3 = new Label();
            panelUpdateAppoint = new Panel();
            label6 = new Label();
            comboBoxPnlUpdateDName = new ComboBox();
            comboBoxPnlUpdateStatus = new ComboBox();
            dateTimePickerPnlUpdate = new DateTimePicker();
            labelPnlAddDate = new Label();
            label4 = new Label();
            label2 = new Label();
            buttonPnlEditCancel = new Button();
            buttonPnlUpdate = new Button();
            textBoxPnlUpdateEmail = new TextBox();
            textBoxPnlUpdateName = new TextBox();
            labelPnlUpdateAppointEmail = new Label();
            labelPnlUpdateReceptName = new Label();
            dataGridViewAppointment = new DataGridView();
            buttonAppointmentList = new Button();
            buttonEditAppointment = new Button();
            buttonDeleteAppointment = new Button();
            buttonAddAppointment = new Button();
            doctorBindingSource = new BindingSource(components);
            panelAddAppointment.SuspendLayout();
            panelUpdateAppoint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doctorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // loggedUserEmail
            // 
            loggedUserEmail.AutoSize = true;
            loggedUserEmail.Location = new Point(563, 29);
            loggedUserEmail.Name = "loggedUserEmail";
            loggedUserEmail.Size = new Size(89, 20);
            loggedUserEmail.TabIndex = 22;
            loggedUserEmail.Text = "{User Email}";
            // 
            // buttonLogout
            // 
            buttonLogout.Location = new Point(658, 25);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(94, 29);
            buttonLogout.TabIndex = 21;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(267, 17);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(250, 28);
            label1.TabIndex = 17;
            label1.Text = "Appointment Management";
            // 
            // panelAddAppointment
            // 
            panelAddAppointment.Controls.Add(label5);
            panelAddAppointment.Controls.Add(comboBoxPnlAddDName);
            panelAddAppointment.Controls.Add(dateTimePickerPnlAdd);
            panelAddAppointment.Controls.Add(label7);
            panelAddAppointment.Controls.Add(textBoxPnlAddPEmail);
            panelAddAppointment.Controls.Add(textBoxPnlAddPName);
            panelAddAppointment.Controls.Add(label8);
            panelAddAppointment.Controls.Add(label9);
            panelAddAppointment.Controls.Add(buttonPnlAddCancel);
            panelAddAppointment.Controls.Add(buttonPnlCreateUser);
            panelAddAppointment.Controls.Add(label3);
            panelAddAppointment.Location = new Point(176, 98);
            panelAddAppointment.Margin = new Padding(2);
            panelAddAppointment.Name = "panelAddAppointment";
            panelAddAppointment.Size = new Size(562, 273);
            panelAddAppointment.TabIndex = 34;
            panelAddAppointment.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(85, 113);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 30;
            label5.Text = "Doctor Name";
            // 
            // comboBoxPnlAddDName
            // 
            comboBoxPnlAddDName.FormattingEnabled = true;
            comboBoxPnlAddDName.Location = new Point(218, 113);
            comboBoxPnlAddDName.Margin = new Padding(2);
            comboBoxPnlAddDName.Name = "comboBoxPnlAddDName";
            comboBoxPnlAddDName.Size = new Size(259, 28);
            comboBoxPnlAddDName.TabIndex = 29;
            // 
            // dateTimePickerPnlAdd
            // 
            dateTimePickerPnlAdd.Location = new Point(218, 144);
            dateTimePickerPnlAdd.Margin = new Padding(2);
            dateTimePickerPnlAdd.Name = "dateTimePickerPnlAdd";
            dateTimePickerPnlAdd.Size = new Size(260, 27);
            dateTimePickerPnlAdd.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(85, 148);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(41, 20);
            label7.TabIndex = 27;
            label7.Text = "Date";
            // 
            // textBoxPnlAddPEmail
            // 
            textBoxPnlAddPEmail.Location = new Point(218, 82);
            textBoxPnlAddPEmail.Margin = new Padding(2);
            textBoxPnlAddPEmail.Name = "textBoxPnlAddPEmail";
            textBoxPnlAddPEmail.Size = new Size(260, 27);
            textBoxPnlAddPEmail.TabIndex = 25;
            // 
            // textBoxPnlAddPName
            // 
            textBoxPnlAddPName.Location = new Point(218, 53);
            textBoxPnlAddPName.Margin = new Padding(2);
            textBoxPnlAddPName.Name = "textBoxPnlAddPName";
            textBoxPnlAddPName.Size = new Size(260, 27);
            textBoxPnlAddPName.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(85, 85);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(95, 20);
            label8.TabIndex = 23;
            label8.Text = "Patient Email";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(85, 55);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(98, 20);
            label9.TabIndex = 22;
            label9.Text = "Patient Name";
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
            buttonPnlAddCancel.Click += AppointmentManagement_Load;
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
            buttonPnlCreateUser.Click += panelButtonAddAppointment;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(222, 14);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(186, 23);
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
            panelUpdateAppoint.Location = new Point(174, 100);
            panelUpdateAppoint.Margin = new Padding(2);
            panelUpdateAppoint.Name = "panelUpdateAppoint";
            panelUpdateAppoint.Size = new Size(562, 271);
            panelUpdateAppoint.TabIndex = 19;
            panelUpdateAppoint.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 102);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 26;
            label6.Text = "Doctor Name";
            // 
            // comboBoxPnlUpdateDName
            // 
            comboBoxPnlUpdateDName.FormattingEnabled = true;
            comboBoxPnlUpdateDName.Location = new Point(179, 102);
            comboBoxPnlUpdateDName.Margin = new Padding(2);
            comboBoxPnlUpdateDName.Name = "comboBoxPnlUpdateDName";
            comboBoxPnlUpdateDName.Size = new Size(259, 28);
            comboBoxPnlUpdateDName.TabIndex = 25;
            // 
            // comboBoxPnlUpdateStatus
            // 
            comboBoxPnlUpdateStatus.FormattingEnabled = true;
            comboBoxPnlUpdateStatus.Items.AddRange(new object[] { "Active", "Expired" });
            comboBoxPnlUpdateStatus.Location = new Point(179, 164);
            comboBoxPnlUpdateStatus.Margin = new Padding(2);
            comboBoxPnlUpdateStatus.Name = "comboBoxPnlUpdateStatus";
            comboBoxPnlUpdateStatus.Size = new Size(259, 28);
            comboBoxPnlUpdateStatus.TabIndex = 22;
            // 
            // dateTimePickerPnlUpdate
            // 
            dateTimePickerPnlUpdate.Location = new Point(180, 134);
            dateTimePickerPnlUpdate.Margin = new Padding(2);
            dateTimePickerPnlUpdate.Name = "dateTimePickerPnlUpdate";
            dateTimePickerPnlUpdate.Size = new Size(260, 27);
            dateTimePickerPnlUpdate.TabIndex = 18;
            // 
            // labelPnlAddDate
            // 
            labelPnlAddDate.AutoSize = true;
            labelPnlAddDate.Location = new Point(46, 138);
            labelPnlAddDate.Margin = new Padding(2, 0, 2, 0);
            labelPnlAddDate.Name = "labelPnlAddDate";
            labelPnlAddDate.Size = new Size(41, 20);
            labelPnlAddDate.TabIndex = 16;
            labelPnlAddDate.Text = "Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 168);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 15;
            label4.Text = "Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(224, 12);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(172, 23);
            label2.TabIndex = 14;
            label2.Text = "Update Appointment";
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
            buttonPnlEditCancel.Click += AppointmentManagement_Load;
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
            buttonPnlUpdate.Click += panelButtonUpdateAppointment;
            // 
            // textBoxPnlUpdateEmail
            // 
            textBoxPnlUpdateEmail.Location = new Point(179, 73);
            textBoxPnlUpdateEmail.Margin = new Padding(2);
            textBoxPnlUpdateEmail.Name = "textBoxPnlUpdateEmail";
            textBoxPnlUpdateEmail.Size = new Size(260, 27);
            textBoxPnlUpdateEmail.TabIndex = 8;
            // 
            // textBoxPnlUpdateName
            // 
            textBoxPnlUpdateName.Location = new Point(179, 43);
            textBoxPnlUpdateName.Margin = new Padding(2);
            textBoxPnlUpdateName.Name = "textBoxPnlUpdateName";
            textBoxPnlUpdateName.Size = new Size(260, 27);
            textBoxPnlUpdateName.TabIndex = 5;
            // 
            // labelPnlUpdateAppointEmail
            // 
            labelPnlUpdateAppointEmail.AutoSize = true;
            labelPnlUpdateAppointEmail.Location = new Point(46, 75);
            labelPnlUpdateAppointEmail.Margin = new Padding(2, 0, 2, 0);
            labelPnlUpdateAppointEmail.Name = "labelPnlUpdateAppointEmail";
            labelPnlUpdateAppointEmail.Size = new Size(95, 20);
            labelPnlUpdateAppointEmail.TabIndex = 3;
            labelPnlUpdateAppointEmail.Text = "Patient Email";
            // 
            // labelPnlUpdateReceptName
            // 
            labelPnlUpdateReceptName.AutoSize = true;
            labelPnlUpdateReceptName.Location = new Point(46, 46);
            labelPnlUpdateReceptName.Margin = new Padding(2, 0, 2, 0);
            labelPnlUpdateReceptName.Name = "labelPnlUpdateReceptName";
            labelPnlUpdateReceptName.Size = new Size(98, 20);
            labelPnlUpdateReceptName.TabIndex = 0;
            labelPnlUpdateReceptName.Text = "Patient Name";
            // 
            // dataGridViewAppointment
            // 
            dataGridViewAppointment.AllowUserToOrderColumns = true;
            dataGridViewAppointment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAppointment.Location = new Point(177, 98);
            dataGridViewAppointment.Name = "dataGridViewAppointment";
            dataGridViewAppointment.RowHeadersWidth = 51;
            dataGridViewAppointment.Size = new Size(559, 258);
            dataGridViewAppointment.TabIndex = 21;
            // 
            // buttonAppointmentList
            // 
            buttonAppointmentList.Location = new Point(47, 127);
            buttonAppointmentList.Margin = new Padding(2);
            buttonAppointmentList.Name = "buttonAppointmentList";
            buttonAppointmentList.Size = new Size(102, 27);
            buttonAppointmentList.TabIndex = 35;
            buttonAppointmentList.Text = "Appoint. List";
            buttonAppointmentList.UseVisualStyleBackColor = true;
            buttonAppointmentList.Click += AppointmentManagement_Load;
            // 
            // buttonEditAppointment
            // 
            buttonEditAppointment.Location = new Point(47, 250);
            buttonEditAppointment.Margin = new Padding(2);
            buttonEditAppointment.Name = "buttonEditAppointment";
            buttonEditAppointment.Size = new Size(102, 27);
            buttonEditAppointment.TabIndex = 33;
            buttonEditAppointment.Text = "Edit Appoint.";
            buttonEditAppointment.UseVisualStyleBackColor = true;
            buttonEditAppointment.Click += buttonEditAppointment_Click;
            // 
            // buttonDeleteAppointment
            // 
            buttonDeleteAppointment.Location = new Point(47, 210);
            buttonDeleteAppointment.Margin = new Padding(2);
            buttonDeleteAppointment.Name = "buttonDeleteAppointment";
            buttonDeleteAppointment.Size = new Size(102, 27);
            buttonDeleteAppointment.TabIndex = 32;
            buttonDeleteAppointment.Text = "Delete Appoint.";
            buttonDeleteAppointment.UseVisualStyleBackColor = true;
            buttonDeleteAppointment.Click += buttonDeleteAppointment_Click;
            // 
            // buttonAddAppointment
            // 
            buttonAddAppointment.Location = new Point(47, 170);
            buttonAddAppointment.Margin = new Padding(2);
            buttonAddAppointment.Name = "buttonAddAppointment";
            buttonAddAppointment.Size = new Size(102, 27);
            buttonAddAppointment.TabIndex = 31;
            buttonAddAppointment.Text = "Add Appoint.";
            buttonAddAppointment.UseVisualStyleBackColor = true;
            buttonAddAppointment.Click += buttonAddAppointment_Click;
            // 
            // doctorBindingSource
            // 
            doctorBindingSource.DataSource = typeof(Models.Doctor);
            // 
            // AppointmentManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelUpdateAppoint);
            Controls.Add(panelAddAppointment);
            Controls.Add(buttonAppointmentList);
            Controls.Add(buttonEditAppointment);
            Controls.Add(buttonDeleteAppointment);
            Controls.Add(buttonAddAppointment);
            Controls.Add(loggedUserEmail);
            Controls.Add(buttonLogout);
            Controls.Add(label1);
            Controls.Add(dataGridViewAppointment);
            Margin = new Padding(2);
            Name = "AppointmentManagement";
            Text = "AppointmentManagement";
            Load += AppointmentManagement_Load;
            panelAddAppointment.ResumeLayout(false);
            panelAddAppointment.PerformLayout();
            panelUpdateAppoint.ResumeLayout(false);
            panelUpdateAppoint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointment).EndInit();
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
        private TextBox textBoxPnlAddPEmail;
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
        private DataGridView dataGridViewAppointment;
    }
}