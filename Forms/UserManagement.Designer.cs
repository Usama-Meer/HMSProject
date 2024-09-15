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
            buttonUserList = new Button();
            panelUpdateUser = new Panel();
            comboBoxUpdateRoleName = new ComboBox();
            label2 = new Label();
            buttonPnlEditCancel = new Button();
            buttonPnlUpdate = new Button();
            textBoxPnlUpdatePassword = new TextBox();
            textBoxPnlUpdateEmail = new TextBox();
            ord = new Label();
            labelPnlUpdateRoleName = new Label();
            labelPnlUpdateEmail = new Label();
            panelAddUser = new Panel();
            comboBoxAddRoleName = new ComboBox();
            label3 = new Label();
            buttonPnlAddCancel = new Button();
            buttonPnlCreateUser = new Button();
            textBoxPnlAddPassword = new TextBox();
            TextBoxPnlAddEmail = new TextBox();
            labelPnlAddPassword = new Label();
            labelPnlAddRoleId = new Label();
            labelPnlAddEmail = new Label();
            dataGridViewUser = new DataGridView();
            panelUpdateUser.SuspendLayout();
            panelAddUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).BeginInit();
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
            // loggedUserEmail
            // 
            loggedUserEmail.AutoSize = true;
            loggedUserEmail.Location = new Point(595, 25);
            loggedUserEmail.Name = "loggedUserEmail";
            loggedUserEmail.Size = new Size(89, 20);
            loggedUserEmail.TabIndex = 10;
            loggedUserEmail.Text = "{User Email}";
            // 
            // buttonLogout
            // 
            buttonLogout.Location = new Point(690, 21);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(94, 29);
            buttonLogout.TabIndex = 9;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // buttonEditUser
            // 
            buttonEditUser.Location = new Point(22, 266);
            buttonEditUser.Margin = new Padding(2);
            buttonEditUser.Name = "buttonEditUser";
            buttonEditUser.Size = new Size(102, 27);
            buttonEditUser.TabIndex = 17;
            buttonEditUser.Text = "Edit User";
            buttonEditUser.UseVisualStyleBackColor = true;
            buttonEditUser.Click += btnEditUser_Click;
            // 
            // buttonDeleteUser
            // 
            buttonDeleteUser.Location = new Point(22, 221);
            buttonDeleteUser.Margin = new Padding(2);
            buttonDeleteUser.Name = "buttonDeleteUser";
            buttonDeleteUser.Size = new Size(102, 27);
            buttonDeleteUser.TabIndex = 16;
            buttonDeleteUser.Text = "Delete User";
            buttonDeleteUser.UseVisualStyleBackColor = true;
            buttonDeleteUser.Click += btnDeleteUser_Click;
            // 
            // buttonAddUser
            // 
            buttonAddUser.Location = new Point(22, 177);
            buttonAddUser.Margin = new Padding(2);
            buttonAddUser.Name = "buttonAddUser";
            buttonAddUser.Size = new Size(102, 27);
            buttonAddUser.TabIndex = 15;
            buttonAddUser.Text = "Add User";
            buttonAddUser.UseVisualStyleBackColor = true;
            buttonAddUser.Click += btnAddUser_Click;
            // 
            // buttonUserList
            // 
            buttonUserList.Location = new Point(22, 134);
            buttonUserList.Margin = new Padding(2);
            buttonUserList.Name = "buttonUserList";
            buttonUserList.Size = new Size(102, 27);
            buttonUserList.TabIndex = 20;
            buttonUserList.Text = "User List";
            buttonUserList.UseVisualStyleBackColor = true;
            buttonUserList.Click += UserManagement_Load;
            // 
            // panelUpdateUser
            // 
            panelUpdateUser.Controls.Add(comboBoxUpdateRoleName);
            panelUpdateUser.Controls.Add(label2);
            panelUpdateUser.Controls.Add(buttonPnlEditCancel);
            panelUpdateUser.Controls.Add(buttonPnlUpdate);
            panelUpdateUser.Controls.Add(textBoxPnlUpdatePassword);
            panelUpdateUser.Controls.Add(textBoxPnlUpdateEmail);
            panelUpdateUser.Controls.Add(ord);
            panelUpdateUser.Controls.Add(labelPnlUpdateRoleName);
            panelUpdateUser.Controls.Add(labelPnlUpdateEmail);
            panelUpdateUser.Location = new Point(172, 116);
            panelUpdateUser.Margin = new Padding(2);
            panelUpdateUser.Name = "panelUpdateUser";
            panelUpdateUser.Size = new Size(562, 257);
            panelUpdateUser.TabIndex = 23;
            panelUpdateUser.Visible = false;
            // 
            // comboBoxUpdateRoleName
            // 
            comboBoxUpdateRoleName.FormattingEnabled = true;
            comboBoxUpdateRoleName.Location = new Point(213, 158);
            comboBoxUpdateRoleName.Name = "comboBoxUpdateRoleName";
            comboBoxUpdateRoleName.Size = new Size(225, 28);
            comboBoxUpdateRoleName.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(257, 16);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 23);
            label2.TabIndex = 14;
            label2.Text = "Update User";
            // 
            // buttonPnlEditCancel
            // 
            buttonPnlEditCancel.Location = new Point(221, 202);
            buttonPnlEditCancel.Margin = new Padding(2);
            buttonPnlEditCancel.Name = "buttonPnlEditCancel";
            buttonPnlEditCancel.Size = new Size(90, 27);
            buttonPnlEditCancel.TabIndex = 13;
            buttonPnlEditCancel.Text = "Cancel";
            buttonPnlEditCancel.UseVisualStyleBackColor = true;
            buttonPnlEditCancel.Click += UserManagement_Load;
            // 
            // buttonPnlUpdate
            // 
            buttonPnlUpdate.Location = new Point(326, 202);
            buttonPnlUpdate.Margin = new Padding(2);
            buttonPnlUpdate.Name = "buttonPnlUpdate";
            buttonPnlUpdate.Size = new Size(90, 27);
            buttonPnlUpdate.TabIndex = 12;
            buttonPnlUpdate.Text = "Update";
            buttonPnlUpdate.UseVisualStyleBackColor = true;
            buttonPnlUpdate.Click += buttonPnlUpdateUser_Click;
            // 
            // textBoxPnlUpdatePassword
            // 
            textBoxPnlUpdatePassword.Location = new Point(212, 107);
            textBoxPnlUpdatePassword.Margin = new Padding(2);
            textBoxPnlUpdatePassword.Name = "textBoxPnlUpdatePassword";
            textBoxPnlUpdatePassword.Size = new Size(220, 27);
            textBoxPnlUpdatePassword.TabIndex = 8;
            // 
            // textBoxPnlUpdateEmail
            // 
            textBoxPnlUpdateEmail.Location = new Point(211, 57);
            textBoxPnlUpdateEmail.Margin = new Padding(2);
            textBoxPnlUpdateEmail.Name = "textBoxPnlUpdateEmail";
            textBoxPnlUpdateEmail.Size = new Size(220, 27);
            textBoxPnlUpdateEmail.TabIndex = 5;
            // 
            // ord
            // 
            ord.AutoSize = true;
            ord.Location = new Point(127, 111);
            ord.Margin = new Padding(2, 0, 2, 0);
            ord.Name = "ord";
            ord.Size = new Size(70, 20);
            ord.TabIndex = 3;
            ord.Text = "Password";
            // 
            // labelPnlUpdateRoleName
            // 
            labelPnlUpdateRoleName.AutoSize = true;
            labelPnlUpdateRoleName.Location = new Point(127, 164);
            labelPnlUpdateRoleName.Margin = new Padding(2, 0, 2, 0);
            labelPnlUpdateRoleName.Name = "labelPnlUpdateRoleName";
            labelPnlUpdateRoleName.Size = new Size(83, 20);
            labelPnlUpdateRoleName.TabIndex = 1;
            labelPnlUpdateRoleName.Text = "Role Name";
            // 
            // labelPnlUpdateEmail
            // 
            labelPnlUpdateEmail.AutoSize = true;
            labelPnlUpdateEmail.Location = new Point(125, 62);
            labelPnlUpdateEmail.Margin = new Padding(2, 0, 2, 0);
            labelPnlUpdateEmail.Name = "labelPnlUpdateEmail";
            labelPnlUpdateEmail.Size = new Size(46, 20);
            labelPnlUpdateEmail.TabIndex = 0;
            labelPnlUpdateEmail.Text = "Email";
            // 
            // panelAddUser
            // 
            panelAddUser.Controls.Add(comboBoxAddRoleName);
            panelAddUser.Controls.Add(label3);
            panelAddUser.Controls.Add(buttonPnlAddCancel);
            panelAddUser.Controls.Add(buttonPnlCreateUser);
            panelAddUser.Controls.Add(textBoxPnlAddPassword);
            panelAddUser.Controls.Add(TextBoxPnlAddEmail);
            panelAddUser.Controls.Add(labelPnlAddPassword);
            panelAddUser.Controls.Add(labelPnlAddRoleId);
            panelAddUser.Controls.Add(labelPnlAddEmail);
            panelAddUser.Location = new Point(172, 116);
            panelAddUser.Margin = new Padding(2);
            panelAddUser.Name = "panelAddUser";
            panelAddUser.Size = new Size(559, 258);
            panelAddUser.TabIndex = 22;
            panelAddUser.Visible = false;
            // 
            // comboBoxAddRoleName
            // 
            comboBoxAddRoleName.FormattingEnabled = true;
            comboBoxAddRoleName.Location = new Point(212, 161);
            comboBoxAddRoleName.Name = "comboBoxAddRoleName";
            comboBoxAddRoleName.Size = new Size(225, 28);
            comboBoxAddRoleName.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(234, 13);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(119, 23);
            label3.TabIndex = 14;
            label3.Text = "Add New User";
            // 
            // buttonPnlAddCancel
            // 
            buttonPnlAddCancel.Location = new Point(219, 206);
            buttonPnlAddCancel.Margin = new Padding(2);
            buttonPnlAddCancel.Name = "buttonPnlAddCancel";
            buttonPnlAddCancel.Size = new Size(90, 27);
            buttonPnlAddCancel.TabIndex = 13;
            buttonPnlAddCancel.Text = "Cancel";
            buttonPnlAddCancel.UseVisualStyleBackColor = true;
            buttonPnlAddCancel.Click += UserManagement_Load;
            // 
            // buttonPnlCreateUser
            // 
            buttonPnlCreateUser.Location = new Point(322, 206);
            buttonPnlCreateUser.Margin = new Padding(2);
            buttonPnlCreateUser.Name = "buttonPnlCreateUser";
            buttonPnlCreateUser.Size = new Size(90, 27);
            buttonPnlCreateUser.TabIndex = 12;
            buttonPnlCreateUser.Text = "Create";
            buttonPnlCreateUser.UseVisualStyleBackColor = true;
            buttonPnlCreateUser.Click += buttonPnlCreateUser_Click;
            // 
            // textBoxPnlAddPassword
            // 
            textBoxPnlAddPassword.Location = new Point(212, 107);
            textBoxPnlAddPassword.Margin = new Padding(2);
            textBoxPnlAddPassword.Name = "textBoxPnlAddPassword";
            textBoxPnlAddPassword.Size = new Size(220, 27);
            textBoxPnlAddPassword.TabIndex = 8;
            // 
            // TextBoxPnlAddEmail
            // 
            TextBoxPnlAddEmail.Location = new Point(211, 57);
            TextBoxPnlAddEmail.Margin = new Padding(2);
            TextBoxPnlAddEmail.Name = "TextBoxPnlAddEmail";
            TextBoxPnlAddEmail.Size = new Size(220, 27);
            TextBoxPnlAddEmail.TabIndex = 5;
            // 
            // labelPnlAddPassword
            // 
            labelPnlAddPassword.AutoSize = true;
            labelPnlAddPassword.Location = new Point(127, 111);
            labelPnlAddPassword.Margin = new Padding(2, 0, 2, 0);
            labelPnlAddPassword.Name = "labelPnlAddPassword";
            labelPnlAddPassword.Size = new Size(70, 20);
            labelPnlAddPassword.TabIndex = 3;
            labelPnlAddPassword.Text = "Password";
            // 
            // labelPnlAddRoleId
            // 
            labelPnlAddRoleId.AutoSize = true;
            labelPnlAddRoleId.Location = new Point(127, 164);
            labelPnlAddRoleId.Margin = new Padding(2, 0, 2, 0);
            labelPnlAddRoleId.Name = "labelPnlAddRoleId";
            labelPnlAddRoleId.Size = new Size(83, 20);
            labelPnlAddRoleId.TabIndex = 1;
            labelPnlAddRoleId.Text = "Role Name";
            // 
            // labelPnlAddEmail
            // 
            labelPnlAddEmail.AutoSize = true;
            labelPnlAddEmail.Location = new Point(127, 64);
            labelPnlAddEmail.Margin = new Padding(2, 0, 2, 0);
            labelPnlAddEmail.Name = "labelPnlAddEmail";
            labelPnlAddEmail.Size = new Size(46, 20);
            labelPnlAddEmail.TabIndex = 0;
            labelPnlAddEmail.Text = "Email";
            // 
            // dataGridViewUser
            // 
            dataGridViewUser.AllowUserToOrderColumns = true;
            dataGridViewUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUser.Location = new Point(172, 116);
            dataGridViewUser.Name = "dataGridViewUser";
            dataGridViewUser.RowHeadersWidth = 51;
            dataGridViewUser.Size = new Size(559, 258);
            dataGridViewUser.TabIndex = 21;
            // 
            // UserManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelUpdateUser);
            Controls.Add(panelAddUser);
            Controls.Add(dataGridViewUser);
            Controls.Add(buttonUserList);
            Controls.Add(buttonEditUser);
            Controls.Add(buttonDeleteUser);
            Controls.Add(buttonAddUser);
            Controls.Add(loggedUserEmail);
            Controls.Add(buttonLogout);
            Controls.Add(label1);
            Name = "UserManagement";
            Text = "UserManagement";
            Load += UserManagement_Load;
            panelUpdateUser.ResumeLayout(false);
            panelUpdateUser.PerformLayout();
            panelAddUser.ResumeLayout(false);
            panelAddUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).EndInit();
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
        private Button buttonUserList;
        private Panel panelUpdateUser;
        private Label label2;
        private Button buttonPnlEditCancel;
        private Button buttonPnlUpdate;
        private TextBox textBoxPnlUpdateRoleId;
        private TextBox textBoxPnlUpdatePassword;
        private TextBox textBoxPnlUpdateEmail;
        private Label ord;
        private Label labelPnlUpdateRoleName;
        private Label labelPnlUpdateEmail;
        private Panel panelAddUser;
        private Label label3;
        private Button buttonPnlAddCancel;
        private Button buttonPnlCreateUser;
        private TextBox textBoxPnlAddPassword;
        private TextBox TextBoxPnlAddEmail;
        private Label labelPnlAddPassword;
        private Label labelPnlAddRoleId;
        private Label labelPnlAddEmail;
        private DataGridView dataGridViewUser;
        private ComboBox comboBoxUpdateRoleName;
        private ComboBox comboBoxAddRoleName;
    }
}