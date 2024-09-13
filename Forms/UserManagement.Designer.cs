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
            loggedUserEmail = new Label();
            buttonLogout = new Button();
            buttonEditUser = new Button();
            buttonDeleteUser = new Button();
            buttonAddUser = new Button();
            panelAddUser = new Panel();
            label3 = new Label();
            panelUpdateUser = new Panel();
            label2 = new Label();
            buttonPnlEditCancel = new Button();
            buttonPnlUpdate = new Button();
            textBoxPnlUpdateRoleId = new TextBox();
            textBoxPnlUpdatePassword = new TextBox();
            textBoxPnlUpdateEmail = new TextBox();
            ord = new Label();
            labelPnlUpdateRoleId = new Label();
            labelPnlUpdateEmail = new Label();
            buttonPnlAddCancel = new Button();
            buttonPnlCreateUser = new Button();
            textBoxPnlAddRoleId = new TextBox();
            textBoxPnlAddPassword = new TextBox();
            TextBoxPnlAddEmail = new TextBox();
            labelPnlAddPassword = new Label();
            labelPnlAddRoleId = new Label();
            labelPnlAddEmail = new Label();
            buttonUserList = new Button();
            panelAddUser.SuspendLayout();
            panelUpdateUser.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(372, 26);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(211, 32);
            label1.TabIndex = 0;
            label1.Text = "User Management";
            // 
            // loggedUserEmail
            // 
            loggedUserEmail.AutoSize = true;
            loggedUserEmail.Location = new Point(744, 31);
            loggedUserEmail.Margin = new Padding(4, 0, 4, 0);
            loggedUserEmail.Name = "loggedUserEmail";
            loggedUserEmail.Size = new Size(104, 25);
            loggedUserEmail.TabIndex = 10;
            loggedUserEmail.Text = "{User Email}";
            // 
            // buttonLogout
            // 
            buttonLogout.Location = new Point(862, 26);
            buttonLogout.Margin = new Padding(4);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(118, 36);
            buttonLogout.TabIndex = 9;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // buttonEditUser
            // 
            buttonEditUser.Location = new Point(28, 332);
            buttonEditUser.Name = "buttonEditUser";
            buttonEditUser.Size = new Size(128, 34);
            buttonEditUser.TabIndex = 17;
            buttonEditUser.Text = "Edit User";
            buttonEditUser.UseVisualStyleBackColor = true;
            buttonEditUser.Click += btnEditUser_Click;
            // 
            // buttonDeleteUser
            // 
            buttonDeleteUser.Location = new Point(28, 276);
            buttonDeleteUser.Name = "buttonDeleteUser";
            buttonDeleteUser.Size = new Size(128, 34);
            buttonDeleteUser.TabIndex = 16;
            buttonDeleteUser.Text = "Delete User";
            buttonDeleteUser.UseVisualStyleBackColor = true;
            buttonDeleteUser.Click += btnDeleteUser_Click;
            // 
            // buttonAddUser
            // 
            buttonAddUser.Location = new Point(28, 221);
            buttonAddUser.Name = "buttonAddUser";
            buttonAddUser.Size = new Size(128, 34);
            buttonAddUser.TabIndex = 15;
            buttonAddUser.Text = "Add User";
            buttonAddUser.UseVisualStyleBackColor = true;
            buttonAddUser.Click += btnAddUser_Click;
            // 
            // panelAddUser
            // 
            panelAddUser.Controls.Add(label3);
            panelAddUser.Controls.Add(buttonPnlAddCancel);
            panelAddUser.Controls.Add(buttonPnlCreateUser);
            panelAddUser.Controls.Add(textBoxPnlAddRoleId);
            panelAddUser.Controls.Add(textBoxPnlAddPassword);
            panelAddUser.Controls.Add(TextBoxPnlAddEmail);
            panelAddUser.Controls.Add(labelPnlAddPassword);
            panelAddUser.Controls.Add(labelPnlAddRoleId);
            panelAddUser.Controls.Add(labelPnlAddEmail);
            panelAddUser.Location = new Point(232, 149);
            panelAddUser.Name = "panelAddUser";
            panelAddUser.Size = new Size(702, 317);
            panelAddUser.TabIndex = 18;
            panelAddUser.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(293, 16);
            label3.Name = "label3";
            label3.Size = new Size(137, 28);
            label3.TabIndex = 14;
            label3.Text = "Add New User";
            // 
            // panelUpdateUser
            // 
            panelUpdateUser.Controls.Add(label2);
            panelUpdateUser.Controls.Add(buttonPnlEditCancel);
            panelUpdateUser.Controls.Add(buttonPnlUpdate);
            panelUpdateUser.Controls.Add(textBoxPnlUpdateRoleId);
            panelUpdateUser.Controls.Add(textBoxPnlUpdatePassword);
            panelUpdateUser.Controls.Add(textBoxPnlUpdateEmail);
            panelUpdateUser.Controls.Add(ord);
            panelUpdateUser.Controls.Add(labelPnlUpdateRoleId);
            panelUpdateUser.Controls.Add(labelPnlUpdateEmail);
            panelUpdateUser.Location = new Point(232, 149);
            panelUpdateUser.Name = "panelUpdateUser";
            panelUpdateUser.Size = new Size(702, 323);
            panelUpdateUser.TabIndex = 19;
            panelUpdateUser.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(321, 20);
            label2.Name = "label2";
            label2.Size = new Size(121, 28);
            label2.TabIndex = 14;
            label2.Text = "Update User";
            // 
            // buttonPnlEditCancel
            // 
            buttonPnlEditCancel.Location = new Point(276, 252);
            buttonPnlEditCancel.Name = "buttonPnlEditCancel";
            buttonPnlEditCancel.Size = new Size(112, 34);
            buttonPnlEditCancel.TabIndex = 13;
            buttonPnlEditCancel.Text = "Cancel";
            buttonPnlEditCancel.UseVisualStyleBackColor = true;
            // 
            // buttonPnlUpdate
            // 
            buttonPnlUpdate.Location = new Point(407, 252);
            buttonPnlUpdate.Name = "buttonPnlUpdate";
            buttonPnlUpdate.Size = new Size(112, 34);
            buttonPnlUpdate.TabIndex = 12;
            buttonPnlUpdate.Text = "Update";
            buttonPnlUpdate.UseVisualStyleBackColor = true;
            // 
            // textBoxPnlUpdateRoleId
            // 
            textBoxPnlUpdateRoleId.Location = new Point(265, 198);
            textBoxPnlUpdateRoleId.Name = "textBoxPnlUpdateRoleId";
            textBoxPnlUpdateRoleId.Size = new Size(274, 31);
            textBoxPnlUpdateRoleId.TabIndex = 11;
            // 
            // textBoxPnlUpdatePassword
            // 
            textBoxPnlUpdatePassword.Location = new Point(265, 134);
            textBoxPnlUpdatePassword.Name = "textBoxPnlUpdatePassword";
            textBoxPnlUpdatePassword.Size = new Size(274, 31);
            textBoxPnlUpdatePassword.TabIndex = 8;
            // 
            // textBoxPnlUpdateEmail
            // 
            textBoxPnlUpdateEmail.Location = new Point(264, 71);
            textBoxPnlUpdateEmail.Name = "textBoxPnlUpdateEmail";
            textBoxPnlUpdateEmail.Size = new Size(274, 31);
            textBoxPnlUpdateEmail.TabIndex = 5;
            // 
            // ord
            // 
            ord.AutoSize = true;
            ord.Location = new Point(167, 139);
            ord.Name = "ord";
            ord.Size = new Size(87, 25);
            ord.TabIndex = 3;
            ord.Text = "Password";
            // 
            // labelPnlUpdateRoleId
            // 
            labelPnlUpdateRoleId.AutoSize = true;
            labelPnlUpdateRoleId.Location = new Point(167, 205);
            labelPnlUpdateRoleId.Name = "labelPnlUpdateRoleId";
            labelPnlUpdateRoleId.Size = new Size(67, 25);
            labelPnlUpdateRoleId.TabIndex = 1;
            labelPnlUpdateRoleId.Text = "Role Id";
            // 
            // labelPnlUpdateEmail
            // 
            labelPnlUpdateEmail.AutoSize = true;
            labelPnlUpdateEmail.Location = new Point(166, 77);
            labelPnlUpdateEmail.Name = "labelPnlUpdateEmail";
            labelPnlUpdateEmail.Size = new Size(54, 25);
            labelPnlUpdateEmail.TabIndex = 0;
            labelPnlUpdateEmail.Text = "Email";
            // 
            // buttonPnlAddCancel
            // 
            buttonPnlAddCancel.Location = new Point(274, 258);
            buttonPnlAddCancel.Name = "buttonPnlAddCancel";
            buttonPnlAddCancel.Size = new Size(112, 34);
            buttonPnlAddCancel.TabIndex = 13;
            buttonPnlAddCancel.Text = "Cancel";
            buttonPnlAddCancel.UseVisualStyleBackColor = true;
            // 
            // buttonPnlCreateUser
            // 
            buttonPnlCreateUser.Location = new Point(402, 258);
            buttonPnlCreateUser.Name = "buttonPnlCreateUser";
            buttonPnlCreateUser.Size = new Size(112, 34);
            buttonPnlCreateUser.TabIndex = 12;
            buttonPnlCreateUser.Text = "Create";
            buttonPnlCreateUser.UseVisualStyleBackColor = true;
            buttonPnlCreateUser.Click += buttonPnlCreateUser_Click;
            // 
            // textBoxPnlAddRoleId
            // 
            textBoxPnlAddRoleId.Location = new Point(265, 198);
            textBoxPnlAddRoleId.Name = "textBoxPnlAddRoleId";
            textBoxPnlAddRoleId.Size = new Size(274, 31);
            textBoxPnlAddRoleId.TabIndex = 11;
            // 
            // textBoxPnlAddPassword
            // 
            textBoxPnlAddPassword.Location = new Point(265, 134);
            textBoxPnlAddPassword.Name = "textBoxPnlAddPassword";
            textBoxPnlAddPassword.Size = new Size(274, 31);
            textBoxPnlAddPassword.TabIndex = 8;
            // 
            // TextBoxPnlAddEmail
            // 
            TextBoxPnlAddEmail.Location = new Point(264, 71);
            TextBoxPnlAddEmail.Name = "TextBoxPnlAddEmail";
            TextBoxPnlAddEmail.Size = new Size(274, 31);
            TextBoxPnlAddEmail.TabIndex = 5;
            // 
            // labelPnlAddPassword
            // 
            labelPnlAddPassword.AutoSize = true;
            labelPnlAddPassword.Location = new Point(167, 139);
            labelPnlAddPassword.Name = "labelPnlAddPassword";
            labelPnlAddPassword.Size = new Size(87, 25);
            labelPnlAddPassword.TabIndex = 3;
            labelPnlAddPassword.Text = "Password";
            // 
            // labelPnlAddRoleId
            // 
            labelPnlAddRoleId.AutoSize = true;
            labelPnlAddRoleId.Location = new Point(167, 205);
            labelPnlAddRoleId.Name = "labelPnlAddRoleId";
            labelPnlAddRoleId.Size = new Size(67, 25);
            labelPnlAddRoleId.TabIndex = 1;
            labelPnlAddRoleId.Text = "Role Id";
            // 
            // labelPnlAddEmail
            // 
            labelPnlAddEmail.AutoSize = true;
            labelPnlAddEmail.Location = new Point(166, 77);
            labelPnlAddEmail.Name = "labelPnlAddEmail";
            labelPnlAddEmail.Size = new Size(54, 25);
            labelPnlAddEmail.TabIndex = 0;
            labelPnlAddEmail.Text = "Email";
            // 
            // buttonUserList
            // 
            buttonUserList.Location = new Point(28, 167);
            buttonUserList.Name = "buttonUserList";
            buttonUserList.Size = new Size(128, 34);
            buttonUserList.TabIndex = 20;
            buttonUserList.Text = "User List";
            buttonUserList.UseVisualStyleBackColor = true;
            buttonUserList.Click += UserManagement_Load;
            // 
            // UserManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(buttonUserList);
            Controls.Add(panelUpdateUser);
            Controls.Add(panelAddUser);
            Controls.Add(buttonEditUser);
            Controls.Add(buttonDeleteUser);
            Controls.Add(buttonAddUser);
            Controls.Add(loggedUserEmail);
            Controls.Add(buttonLogout);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "UserManagement";
            Text = "UserManagement";
            Load += UserManagement_Load;
            panelAddUser.ResumeLayout(false);
            panelAddUser.PerformLayout();
            panelUpdateUser.ResumeLayout(false);
            panelUpdateUser.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label loggedUserEmail;
        private Button buttonLogout;
        private Button buttonEditUser;
        private Button buttonDeleteUser;
        private Button buttonAddUser;
        private Panel panelAddUser;
        private TextBox textBoxPnlAddRoleId;
        private TextBox TextBoxPnlAddEmail;
        private Label label6;
        private Label labelPnlUpdateEmail;
        private Label labelPnlAddRoleId;
        private Label labelPnlAddEmail;
        private TextBox textBoxPnlAddPassword;
        private TextBox textBoxPnlUpdateEmail;
        private TextBox textBoxPnlUpdatePassword;
        private Label labelPnlAddPassword;
        private Button buttonPnlCreateUser;
        private Panel panelUpdateUser;
        private Button buttonPnlUpdate;
        private TextBox textBoxPnlUpdateRoleId;
        private Label ord;
        private Label labelPnlUpdateRoleId;
        private Button buttonPnlEditCancel;
        private Button buttonPnlAddCancel;
        private Label label3;
        private Label label2;
        private Button buttonUserList;
    }
}