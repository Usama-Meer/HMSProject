namespace HMSProject.Forms
{
    partial class DoctorDashboard
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
            buttonUserManagement = new Button();
            label1 = new Label();
            dataGridViewDoctor = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDoctor).BeginInit();
            SuspendLayout();
            // 
            // loggedUserEmail
            // 
            loggedUserEmail.AutoSize = true;
            loggedUserEmail.Location = new Point(592, 23);
            loggedUserEmail.Name = "loggedUserEmail";
            loggedUserEmail.Size = new Size(89, 20);
            loggedUserEmail.TabIndex = 17;
            loggedUserEmail.Text = "{User Email}";
            // 
            // buttonLogout
            // 
            buttonLogout.Location = new Point(687, 19);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(94, 29);
            buttonLogout.TabIndex = 16;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = true;
            // 
            // buttonUserManagement
            // 
            buttonUserManagement.Location = new Point(286, 346);
            buttonUserManagement.Name = "buttonUserManagement";
            buttonUserManagement.Size = new Size(227, 29);
            buttonUserManagement.TabIndex = 10;
            buttonUserManagement.Text = "User Management";
            buttonUserManagement.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(286, 43);
            label1.Name = "label1";
            label1.Size = new Size(208, 32);
            label1.TabIndex = 9;
            label1.Text = "Doctor Dashboard";
            // 
            // dataGridViewDoctor
            // 
            dataGridViewDoctor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDoctor.Location = new Point(124, 103);
            dataGridViewDoctor.Name = "dataGridViewDoctor";
            dataGridViewDoctor.RowHeadersWidth = 51;
            dataGridViewDoctor.Size = new Size(542, 214);
            dataGridViewDoctor.TabIndex = 18;
            dataGridViewDoctor.CellContentClick += dataGridViewDoctor_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(43, 34);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 19;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // DoctorDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(dataGridViewDoctor);
            Controls.Add(loggedUserEmail);
            Controls.Add(buttonLogout);
            Controls.Add(buttonUserManagement);
            Controls.Add(label1);
            Name = "DoctorDashboard";
            Text = "DoctorDashboard";
            Load += DoctorDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDoctor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loggedUserEmail;
        private Button buttonLogout;
        private Button buttonUserManagement;
        private Label label1;
        private DataGridView dataGridViewDoctor;
        private Button button1;
    }
}