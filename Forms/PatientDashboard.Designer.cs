namespace HMSProject.Forms
{
    partial class PatientDashboard
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
            dataGridViewAppointment = new DataGridView();
            loggedUserEmail = new Label();
            buttonLogout = new Button();
            buttonUserManagement = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointment).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAppointment
            // 
            dataGridViewAppointment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAppointment.Location = new Point(132, 92);
            dataGridViewAppointment.Name = "dataGridViewAppointment";
            dataGridViewAppointment.RowHeadersWidth = 51;
            dataGridViewAppointment.Size = new Size(542, 214);
            dataGridViewAppointment.TabIndex = 23;
            // 
            // loggedUserEmail
            // 
            loggedUserEmail.AutoSize = true;
            loggedUserEmail.Location = new Point(600, 12);
            loggedUserEmail.Name = "loggedUserEmail";
            loggedUserEmail.Size = new Size(89, 20);
            loggedUserEmail.TabIndex = 22;
            loggedUserEmail.Text = "{User Email}";
            // 
            // buttonLogout
            // 
            buttonLogout.Location = new Point(695, 8);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(94, 29);
            buttonLogout.TabIndex = 21;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = true;
            // 
            // buttonUserManagement
            // 
            buttonUserManagement.Location = new Point(294, 335);
            buttonUserManagement.Name = "buttonUserManagement";
            buttonUserManagement.Size = new Size(227, 29);
            buttonUserManagement.TabIndex = 20;
            buttonUserManagement.Text = "User Management";
            buttonUserManagement.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(294, 32);
            label1.Name = "label1";
            label1.Size = new Size(209, 32);
            label1.TabIndex = 19;
            label1.Text = "Patient Dashboard";
            // 
            // PatientDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewAppointment);
            Controls.Add(loggedUserEmail);
            Controls.Add(buttonLogout);
            Controls.Add(buttonUserManagement);
            Controls.Add(label1);
            Name = "PatientDashboard";
            Text = "PatientDashboard";
            Load += PatientDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewAppointment;
        private Label loggedUserEmail;
        private Button buttonLogout;
        private Button buttonUserManagement;
        private Label label1;
    }
}