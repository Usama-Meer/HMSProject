namespace HMSProject.Forms
{
    partial class RoleManagement
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
            buttonEditRole = new Button();
            buttonDeleteRole = new Button();
            buttonAddRole = new Button();
            label1 = new Label();
            buttonRoleList = new Button();
            panelAddRole = new Panel();
            label3 = new Label();
            buttonPnlAddCancel = new Button();
            buttonPnlCreateUser = new Button();
            textBoxPnlAddRoleId = new TextBox();
            textBoxPnlAddRoleDesc = new TextBox();
            labelPnlAddRoleDesc = new Label();
            labelPnlAddRoleId = new Label();
            labelPnlAddRoleName = new Label();
            panelUpdateRole = new Panel();
            label2 = new Label();
            buttonPnlEditCancel = new Button();
            buttonPnlUpdate = new Button();
            textBoxPnlUpdateRoleDesc = new TextBox();
            textBoxPnlUpdateRoleName = new TextBox();
            labelPnlUpdateRoleDesc = new Label();
            labelPnlUpdateRoleName = new Label();
            dataGridViewRole = new DataGridView();
            textBoxPnlAddRoleName = new TextBox();
            panelAddRole.SuspendLayout();
            panelUpdateRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRole).BeginInit();
            SuspendLayout();
            // 
            // loggedUserEmail
            // 
            loggedUserEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            loggedUserEmail.AutoSize = true;
            loggedUserEmail.Location = new Point(581, 25);
            loggedUserEmail.Name = "loggedUserEmail";
            loggedUserEmail.Size = new Size(89, 20);
            loggedUserEmail.TabIndex = 16;
            loggedUserEmail.Text = "{User Email}";
            // 
            // buttonLogout
            // 
            buttonLogout.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonLogout.Location = new Point(676, 21);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(94, 29);
            buttonLogout.TabIndex = 15;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = true;
            // 
            // buttonEditRole
            // 
            buttonEditRole.Location = new Point(15, 253);
            buttonEditRole.Margin = new Padding(2);
            buttonEditRole.Name = "buttonEditRole";
            buttonEditRole.Size = new Size(102, 27);
            buttonEditRole.TabIndex = 14;
            buttonEditRole.Text = "Edit Role";
            buttonEditRole.UseVisualStyleBackColor = true;
            buttonEditRole.Click += EditRole_Click;
            // 
            // buttonDeleteRole
            // 
            buttonDeleteRole.Location = new Point(15, 213);
            buttonDeleteRole.Margin = new Padding(2);
            buttonDeleteRole.Name = "buttonDeleteRole";
            buttonDeleteRole.Size = new Size(102, 27);
            buttonDeleteRole.TabIndex = 13;
            buttonDeleteRole.Text = "Delete Role";
            buttonDeleteRole.UseVisualStyleBackColor = true;
            buttonDeleteRole.Click += DeleteRole_Click;
            // 
            // buttonAddRole
            // 
            buttonAddRole.Location = new Point(15, 173);
            buttonAddRole.Margin = new Padding(2);
            buttonAddRole.Name = "buttonAddRole";
            buttonAddRole.Size = new Size(102, 27);
            buttonAddRole.TabIndex = 12;
            buttonAddRole.Text = "Add Role";
            buttonAddRole.UseVisualStyleBackColor = true;
            buttonAddRole.Click += AddRole_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(292, 24);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(171, 28);
            label1.TabIndex = 11;
            label1.Text = "Role Management";
            // 
            // buttonRoleList
            // 
            buttonRoleList.Location = new Point(15, 130);
            buttonRoleList.Margin = new Padding(2);
            buttonRoleList.Name = "buttonRoleList";
            buttonRoleList.Size = new Size(102, 27);
            buttonRoleList.TabIndex = 22;
            buttonRoleList.Text = "Role List";
            buttonRoleList.UseVisualStyleBackColor = true;
            buttonRoleList.Click += RoleManagement_Load;
            // 
            // panelAddRole
            // 
            panelAddRole.Controls.Add(textBoxPnlAddRoleName);
            panelAddRole.Controls.Add(panelUpdateRole);
            panelAddRole.Controls.Add(label3);
            panelAddRole.Controls.Add(buttonPnlAddCancel);
            panelAddRole.Controls.Add(buttonPnlCreateUser);
            panelAddRole.Controls.Add(textBoxPnlAddRoleId);
            panelAddRole.Controls.Add(textBoxPnlAddRoleDesc);
            panelAddRole.Controls.Add(labelPnlAddRoleDesc);
            panelAddRole.Controls.Add(labelPnlAddRoleId);
            panelAddRole.Controls.Add(labelPnlAddRoleName);
            panelAddRole.Location = new Point(147, 113);
            panelAddRole.Margin = new Padding(2);
            panelAddRole.Name = "panelAddRole";
            panelAddRole.Size = new Size(562, 254);
            panelAddRole.TabIndex = 21;
            panelAddRole.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(222, 14);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(118, 23);
            label3.TabIndex = 14;
            label3.Text = "Add New Role";
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
            buttonPnlAddCancel.Click += RoleManagement_Load;
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
            buttonPnlCreateUser.Click += buttonPanelCreateRole;
            // 
            // textBoxPnlAddRoleId
            // 
            textBoxPnlAddRoleId.Location = new Point(254, 158);
            textBoxPnlAddRoleId.Margin = new Padding(2);
            textBoxPnlAddRoleId.Name = "textBoxPnlAddRoleId";
            textBoxPnlAddRoleId.Size = new Size(220, 27);
            textBoxPnlAddRoleId.TabIndex = 11;
            // 
            // textBoxPnlAddRoleDesc
            // 
            textBoxPnlAddRoleDesc.Location = new Point(254, 107);
            textBoxPnlAddRoleDesc.Margin = new Padding(2);
            textBoxPnlAddRoleDesc.Name = "textBoxPnlAddRoleDesc";
            textBoxPnlAddRoleDesc.Size = new Size(220, 27);
            textBoxPnlAddRoleDesc.TabIndex = 8;
            // 
            // labelPnlAddRoleDesc
            // 
            labelPnlAddRoleDesc.AutoSize = true;
            labelPnlAddRoleDesc.Location = new Point(114, 107);
            labelPnlAddRoleDesc.Margin = new Padding(2, 0, 2, 0);
            labelPnlAddRoleDesc.Name = "labelPnlAddRoleDesc";
            labelPnlAddRoleDesc.Size = new Size(70, 20);
            labelPnlAddRoleDesc.TabIndex = 3;
            labelPnlAddRoleDesc.Text = "Password";
            // 
            // labelPnlAddRoleId
            // 
            labelPnlAddRoleId.AutoSize = true;
            labelPnlAddRoleId.Location = new Point(114, 160);
            labelPnlAddRoleId.Margin = new Padding(2, 0, 2, 0);
            labelPnlAddRoleId.Name = "labelPnlAddRoleId";
            labelPnlAddRoleId.Size = new Size(56, 20);
            labelPnlAddRoleId.TabIndex = 1;
            labelPnlAddRoleId.Text = "Role Id";
            // 
            // labelPnlAddRoleName
            // 
            labelPnlAddRoleName.AutoSize = true;
            labelPnlAddRoleName.Location = new Point(113, 58);
            labelPnlAddRoleName.Margin = new Padding(2, 0, 2, 0);
            labelPnlAddRoleName.Name = "labelPnlAddRoleName";
            labelPnlAddRoleName.Size = new Size(83, 20);
            labelPnlAddRoleName.TabIndex = 0;
            labelPnlAddRoleName.Text = "Role Name";
            // 
            // panelUpdateRole
            // 
            panelUpdateRole.Controls.Add(label2);
            panelUpdateRole.Controls.Add(buttonPnlEditCancel);
            panelUpdateRole.Controls.Add(buttonPnlUpdate);
            panelUpdateRole.Controls.Add(textBoxPnlUpdateRoleDesc);
            panelUpdateRole.Controls.Add(textBoxPnlUpdateRoleName);
            panelUpdateRole.Controls.Add(labelPnlUpdateRoleDesc);
            panelUpdateRole.Controls.Add(labelPnlUpdateRoleName);
            panelUpdateRole.Location = new Point(16, 160);
            panelUpdateRole.Margin = new Padding(2);
            panelUpdateRole.Name = "panelUpdateRole";
            panelUpdateRole.Size = new Size(562, 258);
            panelUpdateRole.TabIndex = 19;
            panelUpdateRole.Visible = false;
            panelUpdateRole.Paint += panelUpdateUser_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(224, 12);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(104, 23);
            label2.TabIndex = 14;
            label2.Text = "Update Role";
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
            buttonPnlEditCancel.Click += RoleManagement_Load;
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
            buttonPnlUpdate.Click += buttonPanelUpdateRole;
            // 
            // textBoxPnlUpdateRoleDesc
            // 
            textBoxPnlUpdateRoleDesc.Location = new Point(264, 125);
            textBoxPnlUpdateRoleDesc.Margin = new Padding(2);
            textBoxPnlUpdateRoleDesc.Name = "textBoxPnlUpdateRoleDesc";
            textBoxPnlUpdateRoleDesc.Size = new Size(220, 27);
            textBoxPnlUpdateRoleDesc.TabIndex = 8;
            // 
            // textBoxPnlUpdateRoleName
            // 
            textBoxPnlUpdateRoleName.Location = new Point(262, 74);
            textBoxPnlUpdateRoleName.Margin = new Padding(2);
            textBoxPnlUpdateRoleName.Name = "textBoxPnlUpdateRoleName";
            textBoxPnlUpdateRoleName.Size = new Size(220, 27);
            textBoxPnlUpdateRoleName.TabIndex = 5;
            // 
            // labelPnlUpdateRoleDesc
            // 
            labelPnlUpdateRoleDesc.AutoSize = true;
            labelPnlUpdateRoleDesc.Location = new Point(115, 129);
            labelPnlUpdateRoleDesc.Margin = new Padding(2, 0, 2, 0);
            labelPnlUpdateRoleDesc.Name = "labelPnlUpdateRoleDesc";
            labelPnlUpdateRoleDesc.Size = new Size(119, 20);
            labelPnlUpdateRoleDesc.TabIndex = 3;
            labelPnlUpdateRoleDesc.Text = "Role Description";
            // 
            // labelPnlUpdateRoleName
            // 
            labelPnlUpdateRoleName.AutoSize = true;
            labelPnlUpdateRoleName.Location = new Point(114, 79);
            labelPnlUpdateRoleName.Margin = new Padding(2, 0, 2, 0);
            labelPnlUpdateRoleName.Name = "labelPnlUpdateRoleName";
            labelPnlUpdateRoleName.Size = new Size(83, 20);
            labelPnlUpdateRoleName.TabIndex = 0;
            labelPnlUpdateRoleName.Text = "Role Name";
            // 
            // dataGridViewRole
            // 
            dataGridViewRole.AllowUserToOrderColumns = true;
            dataGridViewRole.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRole.Location = new Point(145, 113);
            dataGridViewRole.Name = "dataGridViewRole";
            dataGridViewRole.RowHeadersWidth = 51;
            dataGridViewRole.Size = new Size(559, 258);
            dataGridViewRole.TabIndex = 21;
            // 
            // textBoxPnlAddRoleName
            // 
            textBoxPnlAddRoleName.Location = new Point(254, 55);
            textBoxPnlAddRoleName.Margin = new Padding(2);
            textBoxPnlAddRoleName.Name = "textBoxPnlAddRoleName";
            textBoxPnlAddRoleName.Size = new Size(220, 27);
            textBoxPnlAddRoleName.TabIndex = 20;
            // 
            // RoleManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonRoleList);
            Controls.Add(panelAddRole);
            Controls.Add(loggedUserEmail);
            Controls.Add(buttonLogout);
            Controls.Add(buttonEditRole);
            Controls.Add(buttonDeleteRole);
            Controls.Add(buttonAddRole);
            Controls.Add(label1);
            Controls.Add(dataGridViewRole);
            Margin = new Padding(2);
            Name = "RoleManagement";
            Text = "RoleManagement";
            Load += RoleManagement_Load;
            panelAddRole.ResumeLayout(false);
            panelAddRole.PerformLayout();
            panelUpdateRole.ResumeLayout(false);
            panelUpdateRole.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRole).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loggedUserEmail;
        private Button buttonLogout;
        private Button buttonEditRole;
        private Button buttonDeleteRole;
        private Button buttonAddRole;
        private Label label1;
        private Button buttonRoleList;
        private Panel panelAddRole;
        private Label label3;
        private Panel panelUpdateRole;
        private Label label2;
        private Button buttonPnlEditCancel;
        private Button buttonPnlUpdate;
        private TextBox textBoxPnlUpdateRoleId;
        private TextBox textBoxPnlUpdateRoleDesc;
        private TextBox textBoxPnlUpdateRoleName;
        private Label labelPnlUpdateRoleDesc;
        private Label labelPnlUpdateRoleId;
        private Label labelPnlUpdateRoleName;
        private Button buttonPnlAddCancel;
        private Button buttonPnlCreateUser;
        private TextBox textBoxPnlAddRoleId;
        private TextBox textBoxPnlAddRoleDesc;
        private TextBox TextBoxPnlAddEmail;
        private Label labelPnlAddRoleDesc;
        private Label labelPnlAddRoleId;
        private Label labelPnlAddRoleName;
        private DataGridView dataGridViewRole;
        private TextBox textBoxPnlAddRoleName;
    }
}