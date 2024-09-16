namespace HMSProject.Forms
{
    partial class DoctorManagement
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
            buttonDoctorList = new Button();
            panelUpdateDoctor = new Panel();
            comboBoxPnlUpdateSpeciality = new ComboBox();
            textBoxPnlUpdateFee = new TextBox();
            comboBoxPnlUpdateQuali = new ComboBox();
            label2 = new Label();
            buttonPnlEditCancel = new Button();
            textBoxPnlUpdateDesc = new TextBox();
            buttonPnlUpdate = new Button();
            label5 = new Label();
            textBoxPnlUpdateName = new TextBox();
            label6 = new Label();
            label11 = new Label();
            label10 = new Label();
            label8 = new Label();
            textBoxPnlUpdateEmail = new TextBox();
            label1 = new Label();
            panelAddDoctor = new Panel();
            comboBoxPnlAddSpeciality = new ComboBox();
            labelPnlAddFee = new Label();
            textBoxPnlAddFee = new TextBox();
            comboBoxPnlAddQualif = new ComboBox();
            textBoxPnlAddDesc = new TextBox();
            labelPnlAddDesc = new Label();
            labelPnlAddSpeciality = new Label();
            label7 = new Label();
            textBoxPnlAddEmail = new TextBox();
            textBoxPnlAddName = new TextBox();
            labelPnlAddQualif = new Label();
            labelPnlAddPatientName = new Label();
            label3 = new Label();
            buttonPnlAddCancel = new Button();
            buttonPnlCreateUser = new Button();
            dataGridViewDoctor = new DataGridView();
            loggedUserEmail = new Label();
            button1 = new Button();
            buttonEditDoctor = new Button();
            label9 = new Label();
            buttonDeleteDoctor = new Button();
            buttonAddDoctor = new Button();
            panelUpdateDoctor.SuspendLayout();
            panelAddDoctor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDoctor).BeginInit();
            SuspendLayout();
            // 
            // buttonDoctorList
            // 
            buttonDoctorList.Location = new Point(26, 190);
            buttonDoctorList.Margin = new Padding(2);
            buttonDoctorList.Name = "buttonDoctorList";
            buttonDoctorList.Size = new Size(102, 27);
            buttonDoctorList.TabIndex = 38;
            buttonDoctorList.Text = "Doctor List";
            buttonDoctorList.UseVisualStyleBackColor = true;
            buttonDoctorList.Click += DoctorManagement_Load;
            // 
            // panelUpdateDoctor
            // 
            panelUpdateDoctor.Controls.Add(comboBoxPnlUpdateSpeciality);
            panelUpdateDoctor.Controls.Add(textBoxPnlUpdateFee);
            panelUpdateDoctor.Controls.Add(comboBoxPnlUpdateQuali);
            panelUpdateDoctor.Controls.Add(label2);
            panelUpdateDoctor.Controls.Add(buttonPnlEditCancel);
            panelUpdateDoctor.Controls.Add(textBoxPnlUpdateDesc);
            panelUpdateDoctor.Controls.Add(buttonPnlUpdate);
            panelUpdateDoctor.Controls.Add(label5);
            panelUpdateDoctor.Controls.Add(textBoxPnlUpdateName);
            panelUpdateDoctor.Controls.Add(label6);
            panelUpdateDoctor.Controls.Add(label11);
            panelUpdateDoctor.Controls.Add(label10);
            panelUpdateDoctor.Controls.Add(label8);
            panelUpdateDoctor.Controls.Add(textBoxPnlUpdateEmail);
            panelUpdateDoctor.Controls.Add(label1);
            panelUpdateDoctor.Location = new Point(188, 167);
            panelUpdateDoctor.Margin = new Padding(2);
            panelUpdateDoctor.Name = "panelUpdateDoctor";
            panelUpdateDoctor.Size = new Size(562, 261);
            panelUpdateDoctor.TabIndex = 37;
            panelUpdateDoctor.Visible = false;
            // 
            // comboBoxPnlUpdateSpeciality
            // 
            comboBoxPnlUpdateSpeciality.FormattingEnabled = true;
            comboBoxPnlUpdateSpeciality.Items.AddRange(new object[] { "Cardiologist", "Dermatologist", "Neurologist", "Pediatrician", "Orthopedic Surgeon", "Psychiatrist", "Radiologist", "Oncologist", "Endocrinologist", "Gastroenterologist" });
            comboBoxPnlUpdateSpeciality.Location = new Point(401, 113);
            comboBoxPnlUpdateSpeciality.Margin = new Padding(2);
            comboBoxPnlUpdateSpeciality.Name = "comboBoxPnlUpdateSpeciality";
            comboBoxPnlUpdateSpeciality.Size = new Size(134, 28);
            comboBoxPnlUpdateSpeciality.TabIndex = 37;
            // 
            // textBoxPnlUpdateFee
            // 
            textBoxPnlUpdateFee.Location = new Point(448, 153);
            textBoxPnlUpdateFee.Margin = new Padding(2);
            textBoxPnlUpdateFee.Name = "textBoxPnlUpdateFee";
            textBoxPnlUpdateFee.Size = new Size(87, 27);
            textBoxPnlUpdateFee.TabIndex = 51;
            // 
            // comboBoxPnlUpdateQuali
            // 
            comboBoxPnlUpdateQuali.FormattingEnabled = true;
            comboBoxPnlUpdateQuali.Items.AddRange(new object[] { "MBBS:", "BDS: Bachelor of Dental Surgery", "MDS: Master of Dental Surgery", "BAMS: Bachelor of Ayurvedic Medicine and Surgery", "BHMS: Bachelor of Homeopathic Medicine and Surgery", "BPT: Bachelor of Physiotherapy", "MPT: Master of Physiotherapy" });
            comboBoxPnlUpdateQuali.Location = new Point(400, 77);
            comboBoxPnlUpdateQuali.Margin = new Padding(2);
            comboBoxPnlUpdateQuali.Name = "comboBoxPnlUpdateQuali";
            comboBoxPnlUpdateQuali.Size = new Size(134, 28);
            comboBoxPnlUpdateQuali.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(224, 12);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(123, 23);
            label2.TabIndex = 14;
            label2.Text = "Update Doctor";
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
            buttonPnlEditCancel.Click += DoctorManagement_Load;
            // 
            // textBoxPnlUpdateDesc
            // 
            textBoxPnlUpdateDesc.Location = new Point(133, 152);
            textBoxPnlUpdateDesc.Margin = new Padding(2);
            textBoxPnlUpdateDesc.Name = "textBoxPnlUpdateDesc";
            textBoxPnlUpdateDesc.Size = new Size(221, 27);
            textBoxPnlUpdateDesc.TabIndex = 49;
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
            buttonPnlUpdate.Click += buttonPanelUpdateDoctor;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 154);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 48;
            label5.Text = "Description";
            // 
            // textBoxPnlUpdateName
            // 
            textBoxPnlUpdateName.Location = new Point(134, 73);
            textBoxPnlUpdateName.Margin = new Padding(2);
            textBoxPnlUpdateName.Name = "textBoxPnlUpdateName";
            textBoxPnlUpdateName.Size = new Size(158, 27);
            textBoxPnlUpdateName.TabIndex = 43;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(302, 114);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 47;
            label6.Text = "Speciality";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(18, 75);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(99, 20);
            label11.TabIndex = 41;
            label11.Text = "Doctor Name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(302, 77);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(94, 20);
            label10.TabIndex = 42;
            label10.Text = "Qualification";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 119);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(96, 20);
            label8.TabIndex = 45;
            label8.Text = "Doctor Email";
            // 
            // textBoxPnlUpdateEmail
            // 
            textBoxPnlUpdateEmail.Location = new Point(134, 114);
            textBoxPnlUpdateEmail.Margin = new Padding(2);
            textBoxPnlUpdateEmail.Name = "textBoxPnlUpdateEmail";
            textBoxPnlUpdateEmail.Size = new Size(158, 27);
            textBoxPnlUpdateEmail.TabIndex = 44;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(376, 154);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 52;
            label1.Text = "Fee";
            // 
            // panelAddDoctor
            // 
            panelAddDoctor.Controls.Add(comboBoxPnlAddSpeciality);
            panelAddDoctor.Controls.Add(labelPnlAddFee);
            panelAddDoctor.Controls.Add(textBoxPnlAddFee);
            panelAddDoctor.Controls.Add(comboBoxPnlAddQualif);
            panelAddDoctor.Controls.Add(textBoxPnlAddDesc);
            panelAddDoctor.Controls.Add(labelPnlAddDesc);
            panelAddDoctor.Controls.Add(labelPnlAddSpeciality);
            panelAddDoctor.Controls.Add(label7);
            panelAddDoctor.Controls.Add(textBoxPnlAddEmail);
            panelAddDoctor.Controls.Add(textBoxPnlAddName);
            panelAddDoctor.Controls.Add(labelPnlAddQualif);
            panelAddDoctor.Controls.Add(labelPnlAddPatientName);
            panelAddDoctor.Controls.Add(label3);
            panelAddDoctor.Controls.Add(buttonPnlAddCancel);
            panelAddDoctor.Controls.Add(buttonPnlCreateUser);
            panelAddDoctor.Location = new Point(186, 168);
            panelAddDoctor.Margin = new Padding(2);
            panelAddDoctor.Name = "panelAddDoctor";
            panelAddDoctor.Size = new Size(562, 258);
            panelAddDoctor.TabIndex = 29;
            panelAddDoctor.Visible = false;
            // 
            // comboBoxPnlAddSpeciality
            // 
            comboBoxPnlAddSpeciality.FormattingEnabled = true;
            comboBoxPnlAddSpeciality.Items.AddRange(new object[] { "Cardiologist", "Dermatologist", "Neurologist", "Pediatrician", "Orthopedic Surgeon", "Psychiatrist", "Radiologist", "Oncologist", "Endocrinologist", "Gastroenterologist" });
            comboBoxPnlAddSpeciality.Location = new Point(406, 113);
            comboBoxPnlAddSpeciality.Margin = new Padding(2);
            comboBoxPnlAddSpeciality.Name = "comboBoxPnlAddSpeciality";
            comboBoxPnlAddSpeciality.Size = new Size(134, 28);
            comboBoxPnlAddSpeciality.TabIndex = 35;
            // 
            // labelPnlAddFee
            // 
            labelPnlAddFee.AutoSize = true;
            labelPnlAddFee.Location = new Point(377, 156);
            labelPnlAddFee.Margin = new Padding(2, 0, 2, 0);
            labelPnlAddFee.Name = "labelPnlAddFee";
            labelPnlAddFee.Size = new Size(32, 20);
            labelPnlAddFee.TabIndex = 34;
            labelPnlAddFee.Text = "Fee";
            // 
            // textBoxPnlAddFee
            // 
            textBoxPnlAddFee.Location = new Point(448, 154);
            textBoxPnlAddFee.Margin = new Padding(2);
            textBoxPnlAddFee.Name = "textBoxPnlAddFee";
            textBoxPnlAddFee.Size = new Size(88, 27);
            textBoxPnlAddFee.TabIndex = 33;
            // 
            // comboBoxPnlAddQualif
            // 
            comboBoxPnlAddQualif.FormattingEnabled = true;
            comboBoxPnlAddQualif.Items.AddRange(new object[] { "MBBS:", "BDS: Bachelor of Dental Surgery", "MDS: Master of Dental Surgery", "BAMS: Bachelor of Ayurvedic Medicine and Surgery", "BHMS: Bachelor of Homeopathic Medicine and Surgery", "BPT: Bachelor of Physiotherapy", "MPT: Master of Physiotherapy" });
            comboBoxPnlAddQualif.Location = new Point(405, 77);
            comboBoxPnlAddQualif.Margin = new Padding(2);
            comboBoxPnlAddQualif.Name = "comboBoxPnlAddQualif";
            comboBoxPnlAddQualif.Size = new Size(134, 28);
            comboBoxPnlAddQualif.TabIndex = 32;
            // 
            // textBoxPnlAddDesc
            // 
            textBoxPnlAddDesc.Location = new Point(134, 154);
            textBoxPnlAddDesc.Margin = new Padding(2);
            textBoxPnlAddDesc.Name = "textBoxPnlAddDesc";
            textBoxPnlAddDesc.Size = new Size(221, 27);
            textBoxPnlAddDesc.TabIndex = 30;
            // 
            // labelPnlAddDesc
            // 
            labelPnlAddDesc.AutoSize = true;
            labelPnlAddDesc.Location = new Point(22, 156);
            labelPnlAddDesc.Margin = new Padding(2, 0, 2, 0);
            labelPnlAddDesc.Name = "labelPnlAddDesc";
            labelPnlAddDesc.Size = new Size(85, 20);
            labelPnlAddDesc.TabIndex = 29;
            labelPnlAddDesc.Text = "Description";
            // 
            // labelPnlAddSpeciality
            // 
            labelPnlAddSpeciality.AutoSize = true;
            labelPnlAddSpeciality.Location = new Point(303, 116);
            labelPnlAddSpeciality.Margin = new Padding(2, 0, 2, 0);
            labelPnlAddSpeciality.Name = "labelPnlAddSpeciality";
            labelPnlAddSpeciality.Size = new Size(73, 20);
            labelPnlAddSpeciality.TabIndex = 28;
            labelPnlAddSpeciality.Text = "Speciality";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 121);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(96, 20);
            label7.TabIndex = 26;
            label7.Text = "Doctor Email";
            // 
            // textBoxPnlAddEmail
            // 
            textBoxPnlAddEmail.Location = new Point(134, 116);
            textBoxPnlAddEmail.Margin = new Padding(2);
            textBoxPnlAddEmail.Name = "textBoxPnlAddEmail";
            textBoxPnlAddEmail.Size = new Size(158, 27);
            textBoxPnlAddEmail.TabIndex = 24;
            // 
            // textBoxPnlAddName
            // 
            textBoxPnlAddName.Location = new Point(134, 74);
            textBoxPnlAddName.Margin = new Padding(2);
            textBoxPnlAddName.Name = "textBoxPnlAddName";
            textBoxPnlAddName.Size = new Size(158, 27);
            textBoxPnlAddName.TabIndex = 23;
            // 
            // labelPnlAddQualif
            // 
            labelPnlAddQualif.AutoSize = true;
            labelPnlAddQualif.Location = new Point(303, 78);
            labelPnlAddQualif.Margin = new Padding(2, 0, 2, 0);
            labelPnlAddQualif.Name = "labelPnlAddQualif";
            labelPnlAddQualif.Size = new Size(94, 20);
            labelPnlAddQualif.TabIndex = 22;
            labelPnlAddQualif.Text = "Qualification";
            // 
            // labelPnlAddPatientName
            // 
            labelPnlAddPatientName.AutoSize = true;
            labelPnlAddPatientName.Location = new Point(19, 77);
            labelPnlAddPatientName.Margin = new Padding(2, 0, 2, 0);
            labelPnlAddPatientName.Name = "labelPnlAddPatientName";
            labelPnlAddPatientName.Size = new Size(99, 20);
            labelPnlAddPatientName.TabIndex = 21;
            labelPnlAddPatientName.Text = "Doctor Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(222, 14);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(137, 23);
            label3.TabIndex = 14;
            label3.Text = "Add New Doctor";
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
            buttonPnlAddCancel.Click += DoctorManagement_Load;
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
            buttonPnlCreateUser.Click += buttonPanelCreateDoctor;
            // 
            // dataGridViewDoctor
            // 
            dataGridViewDoctor.AllowUserToOrderColumns = true;
            dataGridViewDoctor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDoctor.Location = new Point(188, 167);
            dataGridViewDoctor.Name = "dataGridViewDoctor";
            dataGridViewDoctor.RowHeadersWidth = 51;
            dataGridViewDoctor.Size = new Size(558, 261);
            dataGridViewDoctor.TabIndex = 21;
            // 
            // loggedUserEmail
            // 
            loggedUserEmail.AutoSize = true;
            loggedUserEmail.Location = new Point(586, 54);
            loggedUserEmail.Name = "loggedUserEmail";
            loggedUserEmail.Size = new Size(89, 20);
            loggedUserEmail.TabIndex = 36;
            loggedUserEmail.Text = "{User Email}";
            // 
            // button1
            // 
            button1.Location = new Point(681, 50);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 35;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonLogout_Click;
            // 
            // buttonEditDoctor
            // 
            buttonEditDoctor.Location = new Point(26, 314);
            buttonEditDoctor.Margin = new Padding(2);
            buttonEditDoctor.Name = "buttonEditDoctor";
            buttonEditDoctor.Size = new Size(102, 27);
            buttonEditDoctor.TabIndex = 34;
            buttonEditDoctor.Text = "Edit Doctor";
            buttonEditDoctor.UseVisualStyleBackColor = true;
            buttonEditDoctor.Click += EditDoctor_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(282, 49);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(194, 28);
            label9.TabIndex = 31;
            label9.Text = "Doctor Management";
            // 
            // buttonDeleteDoctor
            // 
            buttonDeleteDoctor.Location = new Point(26, 272);
            buttonDeleteDoctor.Margin = new Padding(2);
            buttonDeleteDoctor.Name = "buttonDeleteDoctor";
            buttonDeleteDoctor.Size = new Size(102, 27);
            buttonDeleteDoctor.TabIndex = 39;
            buttonDeleteDoctor.Text = "Delete Doctor";
            buttonDeleteDoctor.UseVisualStyleBackColor = true;
            buttonDeleteDoctor.Click += DeleteDoctor_Click;
            // 
            // buttonAddDoctor
            // 
            buttonAddDoctor.Location = new Point(26, 230);
            buttonAddDoctor.Margin = new Padding(2);
            buttonAddDoctor.Name = "buttonAddDoctor";
            buttonAddDoctor.Size = new Size(102, 27);
            buttonAddDoctor.TabIndex = 40;
            buttonAddDoctor.Text = "Add Doctor";
            buttonAddDoctor.UseVisualStyleBackColor = true;
            buttonAddDoctor.Click += AddDoctor_Click;
            // 
            // DoctorManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelAddDoctor);
            Controls.Add(buttonAddDoctor);
            Controls.Add(buttonDoctorList);
            Controls.Add(panelUpdateDoctor);
            Controls.Add(loggedUserEmail);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(buttonDeleteDoctor);
            Controls.Add(buttonEditDoctor);
            Controls.Add(dataGridViewDoctor);
            Margin = new Padding(2);
            Name = "DoctorManagement";
            Text = "DoctorManagement";
            Load += DoctorManagement_Load;
            panelUpdateDoctor.ResumeLayout(false);
            panelUpdateDoctor.PerformLayout();
            panelAddDoctor.ResumeLayout(false);
            panelAddDoctor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDoctor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonDoctorList;
        private Panel panelUpdateDoctor;
        private Panel panelAddDoctor;
        private TextBox textBoxPnlAddDesc;
        private Label labelPnlAddDesc;
        private Label labelPnlAddSpeciality;
        private Label label7;
        private DateTimePicker dateTimePicker2;
        private TextBox textBoxPnlAddEmail;
        private TextBox textBoxPnlAddName;
        private Label labelPnlAddQualif;
        private Label labelPnlAddPatientName;
        private Label label3;
        private Button buttonPnlAddCancel;
        private Button buttonPnlCreateUser;
        private Label label2;
        private Button buttonPnlEditCancel;
        private Button buttonPnlUpdate;
        private Label loggedUserEmail;
        private Button button1;
        private Button buttonEditDoctor;
        private Label label9;
        private Button buttonDeleteDoctor;
        private Button buttonAddDoctor;
        private ComboBox comboBoxPnlAddQualif;
        private Label labelPnlAddFee;
        private TextBox textBoxPnlAddFee;
        private TextBox textBoxPnlUpdateFee;
        private TextBox textBoxPnlUpdateDesc;
        private Label label5;
        private TextBox textBoxPnlUpdateName;
        private Label label6;
        private Label label11;
        private Label label10;
        private Label label8;
        private TextBox textBoxPnlUpdateEmail;
        private Label label1;
        private DataGridView dataGridViewDoctor;
        private ComboBox comboBoxPnlAddSpeciality;
        private ComboBox comboBoxPnlUpdateSpeciality;
        private ComboBox comboBoxPnlUpdateQuali;
    }
}