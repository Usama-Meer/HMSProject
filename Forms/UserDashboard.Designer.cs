namespace HMSProject.Forms
{
    partial class UserDashboard
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
            buttonUserManagement = new Button();
            buttonDoctorManagement = new Button();
            buttonPatientManagement = new Button();
            buttonReceiptionistManagement = new Button();
            buttonAppointmentManagement = new Button();
            buttonRoleManagement = new Button();
            buttonLogout = new Button();
            labelUserEmail = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(278, 49);
            label1.Name = "label1";
            label1.Size = new Size(183, 32);
            label1.TabIndex = 0;
            label1.Text = "User Dashboard";
            // 
            // buttonUserManagement
            // 
            buttonUserManagement.Location = new Point(261, 120);
            buttonUserManagement.Name = "buttonUserManagement";
            buttonUserManagement.Size = new Size(227, 29);
            buttonUserManagement.TabIndex = 1;
            buttonUserManagement.Text = "User Management";
            buttonUserManagement.UseVisualStyleBackColor = true;
            buttonUserManagement.Click += UserManagment_Click;
            // 
            // buttonDoctorManagement
            // 
            buttonDoctorManagement.Location = new Point(261, 155);
            buttonDoctorManagement.Name = "buttonDoctorManagement";
            buttonDoctorManagement.Size = new Size(227, 29);
            buttonDoctorManagement.TabIndex = 2;
            buttonDoctorManagement.Text = "Doctor Management";
            buttonDoctorManagement.UseVisualStyleBackColor = true;
            buttonDoctorManagement.Click += DoctoManagemet_Click;
            // 
            // buttonPatientManagement
            // 
            buttonPatientManagement.Location = new Point(261, 190);
            buttonPatientManagement.Name = "buttonPatientManagement";
            buttonPatientManagement.Size = new Size(227, 29);
            buttonPatientManagement.TabIndex = 3;
            buttonPatientManagement.Text = "Patient Management";
            buttonPatientManagement.UseVisualStyleBackColor = true;
            // 
            // buttonReceiptionistManagement
            // 
            buttonReceiptionistManagement.Location = new Point(261, 225);
            buttonReceiptionistManagement.Name = "buttonReceiptionistManagement";
            buttonReceiptionistManagement.Size = new Size(227, 29);
            buttonReceiptionistManagement.TabIndex = 4;
            buttonReceiptionistManagement.Text = "Receiptionist Management";
            buttonReceiptionistManagement.UseVisualStyleBackColor = true;
            // 
            // buttonAppointmentManagement
            // 
            buttonAppointmentManagement.Location = new Point(261, 260);
            buttonAppointmentManagement.Name = "buttonAppointmentManagement";
            buttonAppointmentManagement.Size = new Size(227, 29);
            buttonAppointmentManagement.TabIndex = 5;
            buttonAppointmentManagement.Text = "Appointment Management";
            buttonAppointmentManagement.UseVisualStyleBackColor = true;
            // 
            // buttonRoleManagement
            // 
            buttonRoleManagement.Location = new Point(261, 295);
            buttonRoleManagement.Name = "buttonRoleManagement";
            buttonRoleManagement.Size = new Size(227, 29);
            buttonRoleManagement.TabIndex = 6;
            buttonRoleManagement.Text = "Role Management";
            buttonRoleManagement.UseVisualStyleBackColor = true;
            // 
            // buttonLogout
            // 
            buttonLogout.Location = new Point(679, 25);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(94, 29);
            buttonLogout.TabIndex = 7;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += Logout_Click;
            // 
            // labelUserEmail
            // 
            labelUserEmail.AutoSize = true;
            labelUserEmail.Location = new Point(584, 29);
            labelUserEmail.Name = "labelUserEmail";
            labelUserEmail.Size = new Size(89, 20);
            labelUserEmail.TabIndex = 8;
            labelUserEmail.Text = "{User Email}";
            // 
            // UserDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelUserEmail);
            Controls.Add(buttonLogout);
            Controls.Add(buttonRoleManagement);
            Controls.Add(buttonAppointmentManagement);
            Controls.Add(buttonReceiptionistManagement);
            Controls.Add(buttonPatientManagement);
            Controls.Add(buttonDoctorManagement);
            Controls.Add(buttonUserManagement);
            Controls.Add(label1);
            Name = "UserDashboard";
            Text = "UserDashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonUserManagement;
        private Button buttonDoctorManagement;
        private Button buttonPatientManagement;
        private Button buttonReceiptionistManagement;
        private Button buttonAppointmentManagement;
        private Button buttonRoleManagement;
        private Button buttonLogout;
        private Label labelUserEmail;
    }
}