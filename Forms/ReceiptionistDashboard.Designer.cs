namespace HMSProject.Forms
{
    partial class ReceiptionistDashboard
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
            loggedUserEmail = new Label();
            buttonLogout = new Button();
            buttonAppointmentManagement = new Button();
            buttonPatientManagement = new Button();
            buttonUserManagement = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // loggedUserEmail
            // 
            loggedUserEmail.AutoSize = true;
            loggedUserEmail.Location = new Point(592, 17);
            loggedUserEmail.Name = "loggedUserEmail";
            loggedUserEmail.Size = new Size(89, 20);
            loggedUserEmail.TabIndex = 17;
            loggedUserEmail.Text = "{User Email}";
            // 
            // buttonLogout
            // 
            buttonLogout.Location = new Point(687, 13);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(94, 29);
            buttonLogout.TabIndex = 16;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = true;
            // 
            // buttonAppointmentManagement
            // 
            buttonAppointmentManagement.Location = new Point(269, 180);
            buttonAppointmentManagement.Name = "buttonAppointmentManagement";
            buttonAppointmentManagement.Size = new Size(227, 29);
            buttonAppointmentManagement.TabIndex = 14;
            buttonAppointmentManagement.Text = "Appointment Management";
            buttonAppointmentManagement.UseVisualStyleBackColor = true;
            buttonAppointmentManagement.Click += buttonAppointmentManagement_Click;
            // 
            // buttonPatientManagement
            // 
            buttonPatientManagement.Location = new Point(269, 145);
            buttonPatientManagement.Name = "buttonPatientManagement";
            buttonPatientManagement.Size = new Size(227, 29);
            buttonPatientManagement.TabIndex = 12;
            buttonPatientManagement.Text = "Patient Management";
            buttonPatientManagement.UseVisualStyleBackColor = true;
            buttonPatientManagement.Click += buttonPatientManagement_Click;
            // 
            // buttonUserManagement
            // 
            buttonUserManagement.Location = new Point(269, 108);
            buttonUserManagement.Name = "buttonUserManagement";
            buttonUserManagement.Size = new Size(227, 29);
            buttonUserManagement.TabIndex = 10;
            buttonUserManagement.Text = "User Management";
            buttonUserManagement.UseVisualStyleBackColor = true;
            buttonUserManagement.Click += buttonUserManagement_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(286, 37);
            label1.Name = "label1";
            label1.Size = new Size(183, 32);
            label1.TabIndex = 9;
            label1.Text = "User Dashboard";
            // 
            // ReceiptionistDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loggedUserEmail);
            Controls.Add(buttonLogout);
            Controls.Add(buttonAppointmentManagement);
            Controls.Add(buttonPatientManagement);
            Controls.Add(buttonUserManagement);
            Controls.Add(label1);
            Name = "ReceiptionistDashboard";
            Text = "ReceiptionistDashboard";
            Load += ReceiptionistDashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loggedUserEmail;
        private Button buttonLogout;
        private Button buttonAppointmentManagement;
        private Button buttonPatientManagement;
        private Button buttonUserManagement;
        private Label label1;
    }
}