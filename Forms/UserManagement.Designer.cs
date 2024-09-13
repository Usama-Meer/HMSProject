namespace HMSProject.Forms
{
    partial class UserManagement
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
            labelUserEmail = new Label();
            buttonLogout = new Button();
            buttonCreateUser = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(298, 21);
            label1.Name = "label1";
            label1.Size = new Size(172, 28);
            label1.TabIndex = 0;
            label1.Text = "User Management";
            // 
            // labelUserEmail
            // 
            labelUserEmail.AutoSize = true;
            labelUserEmail.Location = new Point(595, 25);
            labelUserEmail.Name = "labelUserEmail";
            labelUserEmail.Size = new Size(89, 20);
            labelUserEmail.TabIndex = 10;
            labelUserEmail.Text = "{User Email}";
            // 
            // buttonLogout
            // 
            buttonLogout.Location = new Point(690, 21);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(94, 29);
            buttonLogout.TabIndex = 9;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = true;
            // 
            // buttonCreateUser
            // 
            buttonCreateUser.Location = new Point(280, 95);
            buttonCreateUser.Name = "buttonCreateUser";
            buttonCreateUser.Size = new Size(94, 29);
            buttonCreateUser.TabIndex = 11;
            buttonCreateUser.Text = "Create New User";
            buttonCreateUser.UseVisualStyleBackColor = true;
            buttonCreateUser.Click += CreateUser_Click;
            // 
            // UserManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCreateUser);
            Controls.Add(labelUserEmail);
            Controls.Add(buttonLogout);
            Controls.Add(label1);
            Name = "UserManagement";
            Text = "UserManagement";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelUserEmail;
        private Button buttonLogout;
        private Button buttonCreateUser;
    }
}