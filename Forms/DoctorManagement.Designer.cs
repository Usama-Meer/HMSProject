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
            buttonPatientList = new Button();
            panelUpdateDoctor = new Panel();
            panelAddDoctor = new Panel();
            labelPnlAddFee = new Label();
            textBoxPnlAddFee = new TextBox();
            comboBoxPnlAddQualif = new ComboBox();
            textBoxPnlAddDesc = new TextBox();
            labelPnlAddDesc = new Label();
            labelPnlAddSpeciality = new Label();
            textBoxPnlAddSpeciality = new TextBox();
            label7 = new Label();
            textBox4 = new TextBox();
            textBoxPnlAddName = new TextBox();
            labelPnlAddQualif = new Label();
            labelPnlAddPatientName = new Label();
            label3 = new Label();
            buttonPnlAddCancel = new Button();
            buttonPnlCreateUser = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            buttonPnlEditCancel = new Button();
            textBox2 = new TextBox();
            buttonPnlUpdate = new Button();
            label5 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            label11 = new Label();
            textBox3 = new TextBox();
            label10 = new Label();
            label8 = new Label();
            textBox5 = new TextBox();
            label1 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            label9 = new Label();
            buttonDeleteDoctor = new Button();
            buttonAddDoctor = new Button();
            panelDoctorList = new Panel();
            dataGridViewDoctor = new DataGridView();
            panelUpdateDoctor.SuspendLayout();
            panelAddDoctor.SuspendLayout();
            panelDoctorList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDoctor).BeginInit();
            SuspendLayout();
            // 
            // buttonPatientList
            // 
            buttonPatientList.Location = new Point(26, 190);
            buttonPatientList.Margin = new Padding(2, 2, 2, 2);
            buttonPatientList.Name = "buttonPatientList";
            buttonPatientList.Size = new Size(102, 27);
            buttonPatientList.TabIndex = 38;
            buttonPatientList.Text = "Patient List";
            buttonPatientList.UseVisualStyleBackColor = true;
            // 
            // panelUpdateDoctor
            // 
            panelUpdateDoctor.Controls.Add(panelAddDoctor);
            panelUpdateDoctor.Controls.Add(textBox1);
            panelUpdateDoctor.Controls.Add(label2);
            panelUpdateDoctor.Controls.Add(comboBox1);
            panelUpdateDoctor.Controls.Add(buttonPnlEditCancel);
            panelUpdateDoctor.Controls.Add(textBox2);
            panelUpdateDoctor.Controls.Add(buttonPnlUpdate);
            panelUpdateDoctor.Controls.Add(label5);
            panelUpdateDoctor.Controls.Add(textBox6);
            panelUpdateDoctor.Controls.Add(label6);
            panelUpdateDoctor.Controls.Add(label11);
            panelUpdateDoctor.Controls.Add(textBox3);
            panelUpdateDoctor.Controls.Add(label10);
            panelUpdateDoctor.Controls.Add(label8);
            panelUpdateDoctor.Controls.Add(textBox5);
            panelUpdateDoctor.Controls.Add(label1);
            panelUpdateDoctor.Location = new Point(158, 143);
            panelUpdateDoctor.Margin = new Padding(2, 2, 2, 2);
            panelUpdateDoctor.Name = "panelUpdateDoctor";
            panelUpdateDoctor.Size = new Size(562, 258);
            panelUpdateDoctor.TabIndex = 37;
            panelUpdateDoctor.Visible = false;
            // 
            // panelAddDoctor
            // 
            panelAddDoctor.Controls.Add(panelDoctorList);
            panelAddDoctor.Controls.Add(labelPnlAddFee);
            panelAddDoctor.Controls.Add(textBoxPnlAddFee);
            panelAddDoctor.Controls.Add(comboBoxPnlAddQualif);
            panelAddDoctor.Controls.Add(textBoxPnlAddDesc);
            panelAddDoctor.Controls.Add(labelPnlAddDesc);
            panelAddDoctor.Controls.Add(labelPnlAddSpeciality);
            panelAddDoctor.Controls.Add(textBoxPnlAddSpeciality);
            panelAddDoctor.Controls.Add(label7);
            panelAddDoctor.Controls.Add(textBox4);
            panelAddDoctor.Controls.Add(textBoxPnlAddName);
            panelAddDoctor.Controls.Add(labelPnlAddQualif);
            panelAddDoctor.Controls.Add(labelPnlAddPatientName);
            panelAddDoctor.Controls.Add(label3);
            panelAddDoctor.Controls.Add(buttonPnlAddCancel);
            panelAddDoctor.Controls.Add(buttonPnlCreateUser);
            panelAddDoctor.Location = new Point(0, 0);
            panelAddDoctor.Margin = new Padding(2, 2, 2, 2);
            panelAddDoctor.Name = "panelAddDoctor";
            panelAddDoctor.Size = new Size(562, 258);
            panelAddDoctor.TabIndex = 29;
            panelAddDoctor.Visible = false;
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
            textBoxPnlAddFee.Margin = new Padding(2, 2, 2, 2);
            textBoxPnlAddFee.Name = "textBoxPnlAddFee";
            textBoxPnlAddFee.Size = new Size(88, 27);
            textBoxPnlAddFee.TabIndex = 33;
            // 
            // comboBoxPnlAddQualif
            // 
            comboBoxPnlAddQualif.FormattingEnabled = true;
            comboBoxPnlAddQualif.Location = new Point(405, 77);
            comboBoxPnlAddQualif.Margin = new Padding(2, 2, 2, 2);
            comboBoxPnlAddQualif.Name = "comboBoxPnlAddQualif";
            comboBoxPnlAddQualif.Size = new Size(134, 28);
            comboBoxPnlAddQualif.TabIndex = 32;
            // 
            // textBoxPnlAddDesc
            // 
            textBoxPnlAddDesc.Location = new Point(134, 154);
            textBoxPnlAddDesc.Margin = new Padding(2, 2, 2, 2);
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
            // textBoxPnlAddSpeciality
            // 
            textBoxPnlAddSpeciality.Location = new Point(405, 114);
            textBoxPnlAddSpeciality.Margin = new Padding(2, 2, 2, 2);
            textBoxPnlAddSpeciality.Name = "textBoxPnlAddSpeciality";
            textBoxPnlAddSpeciality.Size = new Size(134, 27);
            textBoxPnlAddSpeciality.TabIndex = 27;
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
            // textBox4
            // 
            textBox4.Location = new Point(134, 116);
            textBox4.Margin = new Padding(2, 2, 2, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(158, 27);
            textBox4.TabIndex = 24;
            // 
            // textBoxPnlAddName
            // 
            textBoxPnlAddName.Location = new Point(134, 74);
            textBoxPnlAddName.Margin = new Padding(2, 2, 2, 2);
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
            // textBox1
            // 
            textBox1.Location = new Point(448, 153);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(87, 27);
            textBox1.TabIndex = 51;
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(404, 75);
            comboBox1.Margin = new Padding(2, 2, 2, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(134, 28);
            comboBox1.TabIndex = 50;
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
            // textBox2
            // 
            textBox2.Location = new Point(133, 152);
            textBox2.Margin = new Padding(2, 2, 2, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(221, 27);
            textBox2.TabIndex = 49;
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
            // textBox6
            // 
            textBox6.Location = new Point(134, 73);
            textBox6.Margin = new Padding(2, 2, 2, 2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(158, 27);
            textBox6.TabIndex = 43;
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
            // textBox3
            // 
            textBox3.Location = new Point(404, 113);
            textBox3.Margin = new Padding(2, 2, 2, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(134, 27);
            textBox3.TabIndex = 46;
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
            // textBox5
            // 
            textBox5.Location = new Point(134, 114);
            textBox5.Margin = new Padding(2, 2, 2, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(158, 27);
            textBox5.TabIndex = 44;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(586, 54);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 36;
            label4.Text = "{User Email}";
            // 
            // button1
            // 
            button1.Location = new Point(681, 50);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 35;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(26, 314);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(102, 27);
            button2.TabIndex = 34;
            button2.Text = "Edit Patient";
            button2.UseVisualStyleBackColor = true;
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
            buttonDeleteDoctor.Margin = new Padding(2, 2, 2, 2);
            buttonDeleteDoctor.Name = "buttonDeleteDoctor";
            buttonDeleteDoctor.Size = new Size(102, 27);
            buttonDeleteDoctor.TabIndex = 39;
            buttonDeleteDoctor.Text = "Delete Doctor";
            buttonDeleteDoctor.UseVisualStyleBackColor = true;
            // 
            // buttonAddDoctor
            // 
            buttonAddDoctor.Location = new Point(26, 230);
            buttonAddDoctor.Margin = new Padding(2, 2, 2, 2);
            buttonAddDoctor.Name = "buttonAddDoctor";
            buttonAddDoctor.Size = new Size(102, 27);
            buttonAddDoctor.TabIndex = 40;
            buttonAddDoctor.Text = "Add Doctor";
            buttonAddDoctor.UseVisualStyleBackColor = true;
            // 
            // panelDoctorList
            // 
            panelDoctorList.Controls.Add(dataGridViewDoctor);
            panelDoctorList.Location = new Point(0, 2);
            panelDoctorList.Margin = new Padding(2);
            panelDoctorList.Name = "panelDoctorList";
            panelDoctorList.Size = new Size(562, 258);
            panelDoctorList.TabIndex = 41;
            panelDoctorList.Visible = false;
            // 
            // dataGridViewDoctor
            // 
            dataGridViewDoctor.AllowUserToOrderColumns = true;
            dataGridViewDoctor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDoctor.Location = new Point(4, 1);
            dataGridViewDoctor.Name = "dataGridViewDoctor";
            dataGridViewDoctor.RowHeadersWidth = 51;
            dataGridViewDoctor.Size = new Size(558, 261);
            dataGridViewDoctor.TabIndex = 21;
            // 
            // DoctorManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAddDoctor);
            Controls.Add(buttonPatientList);
            Controls.Add(panelUpdateDoctor);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(buttonDeleteDoctor);
            Controls.Add(button2);
            Margin = new Padding(2, 2, 2, 2);
            Name = "DoctorManagement";
            Text = "DoctorManagement";
            panelUpdateDoctor.ResumeLayout(false);
            panelUpdateDoctor.PerformLayout();
            panelAddDoctor.ResumeLayout(false);
            panelAddDoctor.PerformLayout();
            panelDoctorList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDoctor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonPatientList;
        private Panel panelUpdateDoctor;
        private Panel panelAddDoctor;
        private TextBox textBoxPnlAddDesc;
        private Label labelPnlAddDesc;
        private Label labelPnlAddSpeciality;
        private TextBox textBoxPnlAddSpeciality;
        private Label label7;
        private DateTimePicker dateTimePicker2;
        private TextBox textBox4;
        private TextBox textBoxPnlAddName;
        private Label labelPnlAddQualif;
        private Label labelPnlAddPatientName;
        private Label label3;
        private Button buttonPnlAddCancel;
        private Button buttonPnlCreateUser;
        private Label label2;
        private Button buttonPnlEditCancel;
        private Button buttonPnlUpdate;
        private Label label4;
        private Button button1;
        private Button button2;
        private Label label9;
        private Button buttonDeleteDoctor;
        private Button buttonAddDoctor;
        private ComboBox comboBoxPnlAddQualif;
        private Label labelPnlAddFee;
        private TextBox textBoxPnlAddFee;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private Label label5;
        private TextBox textBox6;
        private Label label6;
        private Label label11;
        private TextBox textBox3;
        private Label label10;
        private Label label8;
        private TextBox textBox5;
        private Label label1;
        private Panel panelDoctorList;
        private DataGridView dataGridViewDoctor;
    }
}