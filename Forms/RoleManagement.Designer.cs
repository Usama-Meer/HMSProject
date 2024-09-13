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
            panelUpdateRole = new Panel();
            label2 = new Label();
            buttonPnlEditCancel = new Button();
            buttonPnlUpdate = new Button();
            textBoxPnlUpdateRoleDesc = new TextBox();
            textBoxPnlUpdateRoleName = new TextBox();
            labelPnlUpdateRoleDesc = new Label();
            labelPnlUpdateRoleName = new Label();
            buttonPnlAddCancel = new Button();
            buttonPnlCreateUser = new Button();
            textBoxPnlAddRoleId = new TextBox();
            textBoxPnlAddRoleDesc = new TextBox();
            labelPnlAddRoleDesc = new Label();
            labelPnlAddRoleId = new Label();
            labelPnlAddRoleName = new Label();
            panelAddRole.SuspendLayout();
            panelUpdateRole.SuspendLayout();
            SuspendLayout();
            // 
            // loggedUserEmail
            // 
            loggedUserEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            loggedUserEmail.AutoSize = true;
            loggedUserEmail.Location = new Point(726, 31);
            loggedUserEmail.Margin = new Padding(4, 0, 4, 0);
            loggedUserEmail.Name = "loggedUserEmail";
            loggedUserEmail.Size = new Size(104, 25);
            loggedUserEmail.TabIndex = 16;
            loggedUserEmail.Text = "{User Email}";
            // 
            // buttonLogout
            // 
            buttonLogout.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonLogout.Location = new Point(845, 26);
            buttonLogout.Margin = new Padding(4);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(118, 36);
            buttonLogout.TabIndex = 15;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = true;
            // 
            // buttonEditRole
            // 
            buttonEditRole.Location = new Point(19, 316);
            buttonEditRole.Name = "buttonEditRole";
            buttonEditRole.Size = new Size(128, 34);
            buttonEditRole.TabIndex = 14;
            buttonEditRole.Text = "Edit Role";
            buttonEditRole.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteRole
            // 
            buttonDeleteRole.Location = new Point(19, 266);
            buttonDeleteRole.Name = "buttonDeleteRole";
            buttonDeleteRole.Size = new Size(128, 34);
            buttonDeleteRole.TabIndex = 13;
            buttonDeleteRole.Text = "Delete Role";
            buttonDeleteRole.UseVisualStyleBackColor = true;
            // 
            // buttonAddRole
            // 
            buttonAddRole.Location = new Point(19, 216);
            buttonAddRole.Name = "buttonAddRole";
            buttonAddRole.Size = new Size(128, 34);
            buttonAddRole.TabIndex = 12;
            buttonAddRole.Text = "Add Role";
            buttonAddRole.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(365, 30);
            label1.Name = "label1";
            label1.Size = new Size(210, 32);
            label1.TabIndex = 11;
            label1.Text = "Role Management";
            // 
            // buttonRoleList
            // 
            buttonRoleList.Location = new Point(19, 163);
            buttonRoleList.Name = "buttonRoleList";
            buttonRoleList.Size = new Size(128, 34);
            buttonRoleList.TabIndex = 22;
            buttonRoleList.Text = "Role List";
            buttonRoleList.UseVisualStyleBackColor = true;
            // 
            // panelAddRole
            // 
            panelAddRole.Controls.Add(label3);
            panelAddRole.Controls.Add(panelUpdateRole);
            panelAddRole.Controls.Add(buttonPnlAddCancel);
            panelAddRole.Controls.Add(buttonPnlCreateUser);
            panelAddRole.Controls.Add(textBoxPnlAddRoleId);
            panelAddRole.Controls.Add(textBoxPnlAddRoleDesc);
            panelAddRole.Controls.Add(labelPnlAddRoleDesc);
            panelAddRole.Controls.Add(labelPnlAddRoleId);
            panelAddRole.Controls.Add(labelPnlAddRoleName);
            panelAddRole.Location = new Point(199, 127);
            panelAddRole.Name = "panelAddRole";
            panelAddRole.Size = new Size(702, 317);
            panelAddRole.TabIndex = 21;
            panelAddRole.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(277, 17);
            label3.Name = "label3";
            label3.Size = new Size(136, 28);
            label3.TabIndex = 14;
            label3.Text = "Add New Role";
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
            panelUpdateRole.Location = new Point(0, 0);
            panelUpdateRole.Name = "panelUpdateRole";
            panelUpdateRole.Size = new Size(702, 323);
            panelUpdateRole.TabIndex = 19;
            panelUpdateRole.Visible = false;
            panelUpdateRole.Paint += panelUpdateUser_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(280, 15);
            label2.Name = "label2";
            label2.Size = new Size(120, 28);
            label2.TabIndex = 14;
            label2.Text = "Update Role";
            // 
            // buttonPnlEditCancel
            // 
            buttonPnlEditCancel.Location = new Point(237, 252);
            buttonPnlEditCancel.Name = "buttonPnlEditCancel";
            buttonPnlEditCancel.Size = new Size(112, 34);
            buttonPnlEditCancel.TabIndex = 13;
            buttonPnlEditCancel.Text = "Cancel";
            buttonPnlEditCancel.UseVisualStyleBackColor = true;
            // 
            // buttonPnlUpdate
            // 
            buttonPnlUpdate.Location = new Point(368, 252);
            buttonPnlUpdate.Name = "buttonPnlUpdate";
            buttonPnlUpdate.Size = new Size(112, 34);
            buttonPnlUpdate.TabIndex = 12;
            buttonPnlUpdate.Text = "Update";
            buttonPnlUpdate.UseVisualStyleBackColor = true;
            // 
            // textBoxPnlUpdateRoleDesc
            // 
            textBoxPnlUpdateRoleDesc.Location = new Point(330, 156);
            textBoxPnlUpdateRoleDesc.Name = "textBoxPnlUpdateRoleDesc";
            textBoxPnlUpdateRoleDesc.Size = new Size(274, 31);
            textBoxPnlUpdateRoleDesc.TabIndex = 8;
            // 
            // textBoxPnlUpdateRoleName
            // 
            textBoxPnlUpdateRoleName.Location = new Point(328, 93);
            textBoxPnlUpdateRoleName.Name = "textBoxPnlUpdateRoleName";
            textBoxPnlUpdateRoleName.Size = new Size(274, 31);
            textBoxPnlUpdateRoleName.TabIndex = 5;
            // 
            // labelPnlUpdateRoleDesc
            // 
            labelPnlUpdateRoleDesc.AutoSize = true;
            labelPnlUpdateRoleDesc.Location = new Point(144, 161);
            labelPnlUpdateRoleDesc.Name = "labelPnlUpdateRoleDesc";
            labelPnlUpdateRoleDesc.Size = new Size(141, 25);
            labelPnlUpdateRoleDesc.TabIndex = 3;
            labelPnlUpdateRoleDesc.Text = "Role Description";
            // 
            // labelPnlUpdateRoleName
            // 
            labelPnlUpdateRoleName.AutoSize = true;
            labelPnlUpdateRoleName.Location = new Point(143, 99);
            labelPnlUpdateRoleName.Name = "labelPnlUpdateRoleName";
            labelPnlUpdateRoleName.Size = new Size(98, 25);
            labelPnlUpdateRoleName.TabIndex = 0;
            labelPnlUpdateRoleName.Text = "Role Name";
            // 
            // buttonPnlAddCancel
            // 
            buttonPnlAddCancel.Location = new Point(245, 258);
            buttonPnlAddCancel.Name = "buttonPnlAddCancel";
            buttonPnlAddCancel.Size = new Size(112, 34);
            buttonPnlAddCancel.TabIndex = 13;
            buttonPnlAddCancel.Text = "Cancel";
            buttonPnlAddCancel.UseVisualStyleBackColor = true;
            // 
            // buttonPnlCreateUser
            // 
            buttonPnlCreateUser.Location = new Point(373, 258);
            buttonPnlCreateUser.Name = "buttonPnlCreateUser";
            buttonPnlCreateUser.Size = new Size(112, 34);
            buttonPnlCreateUser.TabIndex = 12;
            buttonPnlCreateUser.Text = "Create";
            buttonPnlCreateUser.UseVisualStyleBackColor = true;
            // 
            // textBoxPnlAddRoleId
            // 
            textBoxPnlAddRoleId.Location = new Point(318, 198);
            textBoxPnlAddRoleId.Name = "textBoxPnlAddRoleId";
            textBoxPnlAddRoleId.Size = new Size(274, 31);
            textBoxPnlAddRoleId.TabIndex = 11;
            // 
            // textBoxPnlAddRoleDesc
            // 
            textBoxPnlAddRoleDesc.Location = new Point(318, 134);
            textBoxPnlAddRoleDesc.Name = "textBoxPnlAddRoleDesc";
            textBoxPnlAddRoleDesc.Size = new Size(274, 31);
            textBoxPnlAddRoleDesc.TabIndex = 8;
            // 
            // labelPnlAddRoleDesc
            // 
            labelPnlAddRoleDesc.AutoSize = true;
            labelPnlAddRoleDesc.Location = new Point(142, 134);
            labelPnlAddRoleDesc.Name = "labelPnlAddRoleDesc";
            labelPnlAddRoleDesc.Size = new Size(87, 25);
            labelPnlAddRoleDesc.TabIndex = 3;
            labelPnlAddRoleDesc.Text = "Password";
            // 
            // labelPnlAddRoleId
            // 
            labelPnlAddRoleId.AutoSize = true;
            labelPnlAddRoleId.Location = new Point(142, 200);
            labelPnlAddRoleId.Name = "labelPnlAddRoleId";
            labelPnlAddRoleId.Size = new Size(67, 25);
            labelPnlAddRoleId.TabIndex = 1;
            labelPnlAddRoleId.Text = "Role Id";
            // 
            // labelPnlAddRoleName
            // 
            labelPnlAddRoleName.AutoSize = true;
            labelPnlAddRoleName.Location = new Point(141, 72);
            labelPnlAddRoleName.Name = "labelPnlAddRoleName";
            labelPnlAddRoleName.Size = new Size(98, 25);
            labelPnlAddRoleName.TabIndex = 0;
            labelPnlAddRoleName.Text = "Role Name";
            // 
            // RoleManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(buttonRoleList);
            Controls.Add(panelAddRole);
            Controls.Add(loggedUserEmail);
            Controls.Add(buttonLogout);
            Controls.Add(buttonEditRole);
            Controls.Add(buttonDeleteRole);
            Controls.Add(buttonAddRole);
            Controls.Add(label1);
            Name = "RoleManagement";
            Text = "RoleManagement";
            Load += RoleManagement_Load;
            panelAddRole.ResumeLayout(false);
            panelAddRole.PerformLayout();
            panelUpdateRole.ResumeLayout(false);
            panelUpdateRole.PerformLayout();
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
    }
}