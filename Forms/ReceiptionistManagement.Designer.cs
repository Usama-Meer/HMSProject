namespace HMSProject.Forms
{
    partial class ReceiptionistManagement
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
            buttonPnlAddCancel = new Button();
            buttonPnlCreateUser = new Button();
            textBoxPnlAddEmail = new TextBox();
            TextBoxPnlAddName = new TextBox();
            labelPnlAddReceptEmail = new Label();
            labelPnlAddReceptName = new Label();
            label2 = new Label();
            buttonPnlEditCancel = new Button();
            buttonPnlUpdate = new Button();
            label3 = new Label();
            panelAddRole = new Panel();
            panelUpdateRecept = new Panel();
            textBoxPnlUpdateEmail = new TextBox();
            textBoxPnlUpdateName = new TextBox();
            labelPnlUpdateReceptEmail = new Label();
            labelPnlUpdateReceptName = new Label();
            buttonRoleList = new Button();
            buttonLogout = new Button();
            buttonEditRole = new Button();
            buttonDeleteRole = new Button();
            buttonAddRole = new Button();
            label1 = new Label();
            loggedUserEmail = new Label();
            panelAddRole.SuspendLayout();
            panelUpdateRecept.SuspendLayout();
            SuspendLayout();
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
            // textBoxPnlAddEmail
            // 
            textBoxPnlAddEmail.Location = new Point(318, 134);
            textBoxPnlAddEmail.Name = "textBoxPnlAddEmail";
            textBoxPnlAddEmail.Size = new Size(274, 31);
            textBoxPnlAddEmail.TabIndex = 8;
            // 
            // TextBoxPnlAddName
            // 
            TextBoxPnlAddName.Location = new Point(317, 71);
            TextBoxPnlAddName.Name = "TextBoxPnlAddName";
            TextBoxPnlAddName.Size = new Size(274, 31);
            TextBoxPnlAddName.TabIndex = 5;
            // 
            // labelPnlAddReceptEmail
            // 
            labelPnlAddReceptEmail.AutoSize = true;
            labelPnlAddReceptEmail.Location = new Point(142, 134);
            labelPnlAddReceptEmail.Name = "labelPnlAddReceptEmail";
            labelPnlAddReceptEmail.Size = new Size(155, 25);
            labelPnlAddReceptEmail.TabIndex = 3;
            labelPnlAddReceptEmail.Text = "Receptionist Email";
            // 
            // labelPnlAddReceptName
            // 
            labelPnlAddReceptName.AutoSize = true;
            labelPnlAddReceptName.Location = new Point(141, 72);
            labelPnlAddReceptName.Name = "labelPnlAddReceptName";
            labelPnlAddReceptName.Size = new Size(160, 25);
            labelPnlAddReceptName.TabIndex = 0;
            labelPnlAddReceptName.Text = "Receptionist Name";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(277, 17);
            label3.Name = "label3";
            label3.Size = new Size(205, 28);
            label3.TabIndex = 14;
            label3.Text = "Add New Receptionist";
            // 
            // panelAddRole
            // 
            panelAddRole.Controls.Add(label3);
            panelAddRole.Controls.Add(panelUpdateRecept);
            panelAddRole.Controls.Add(buttonPnlAddCancel);
            panelAddRole.Controls.Add(buttonPnlCreateUser);
            panelAddRole.Controls.Add(textBoxPnlAddEmail);
            panelAddRole.Controls.Add(TextBoxPnlAddName);
            panelAddRole.Controls.Add(labelPnlAddReceptEmail);
            panelAddRole.Controls.Add(labelPnlAddReceptName);
            panelAddRole.Location = new Point(208, 173);
            panelAddRole.Name = "panelAddRole";
            panelAddRole.Size = new Size(702, 317);
            panelAddRole.TabIndex = 29;
            panelAddRole.Visible = false;
            // 
            // panelUpdateRecept
            // 
            panelUpdateRecept.Controls.Add(label2);
            panelUpdateRecept.Controls.Add(buttonPnlEditCancel);
            panelUpdateRecept.Controls.Add(buttonPnlUpdate);
            panelUpdateRecept.Controls.Add(textBoxPnlUpdateEmail);
            panelUpdateRecept.Controls.Add(textBoxPnlUpdateName);
            panelUpdateRecept.Controls.Add(labelPnlUpdateReceptEmail);
            panelUpdateRecept.Controls.Add(labelPnlUpdateReceptName);
            panelUpdateRecept.Location = new Point(0, 0);
            panelUpdateRecept.Name = "panelUpdateRecept";
            panelUpdateRecept.Size = new Size(702, 323);
            panelUpdateRecept.TabIndex = 19;
            panelUpdateRecept.Visible = false;
            // 
            // textBoxPnlUpdateEmail
            // 
            textBoxPnlUpdateEmail.Location = new Point(330, 156);
            textBoxPnlUpdateEmail.Name = "textBoxPnlUpdateEmail";
            textBoxPnlUpdateEmail.Size = new Size(274, 31);
            textBoxPnlUpdateEmail.TabIndex = 8;
            // 
            // textBoxPnlUpdateName
            // 
            textBoxPnlUpdateName.Location = new Point(328, 93);
            textBoxPnlUpdateName.Name = "textBoxPnlUpdateName";
            textBoxPnlUpdateName.Size = new Size(274, 31);
            textBoxPnlUpdateName.TabIndex = 5;
            // 
            // labelPnlUpdateReceptEmail
            // 
            labelPnlUpdateReceptEmail.AutoSize = true;
            labelPnlUpdateReceptEmail.Location = new Point(144, 161);
            labelPnlUpdateReceptEmail.Name = "labelPnlUpdateReceptEmail";
            labelPnlUpdateReceptEmail.Size = new Size(155, 25);
            labelPnlUpdateReceptEmail.TabIndex = 3;
            labelPnlUpdateReceptEmail.Text = "Receptionist Email";
            // 
            // labelPnlUpdateReceptName
            // 
            labelPnlUpdateReceptName.AutoSize = true;
            labelPnlUpdateReceptName.Location = new Point(143, 99);
            labelPnlUpdateReceptName.Name = "labelPnlUpdateReceptName";
            labelPnlUpdateReceptName.Size = new Size(160, 25);
            labelPnlUpdateReceptName.TabIndex = 0;
            labelPnlUpdateReceptName.Text = "Receptionist Name";
            // 
            // buttonRoleList
            // 
            buttonRoleList.Location = new Point(28, 209);
            buttonRoleList.Name = "buttonRoleList";
            buttonRoleList.Size = new Size(128, 34);
            buttonRoleList.TabIndex = 30;
            buttonRoleList.Text = "Recept. List";
            buttonRoleList.UseVisualStyleBackColor = true;
            // 
            // buttonLogout
            // 
            buttonLogout.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonLogout.Location = new Point(854, 72);
            buttonLogout.Margin = new Padding(4);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(118, 36);
            buttonLogout.TabIndex = 27;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // buttonEditRole
            // 
            buttonEditRole.Location = new Point(28, 362);
            buttonEditRole.Name = "buttonEditRole";
            buttonEditRole.Size = new Size(128, 34);
            buttonEditRole.TabIndex = 26;
            buttonEditRole.Text = "Edit Recept.";
            buttonEditRole.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteRole
            // 
            buttonDeleteRole.Location = new Point(28, 312);
            buttonDeleteRole.Name = "buttonDeleteRole";
            buttonDeleteRole.Size = new Size(128, 34);
            buttonDeleteRole.TabIndex = 25;
            buttonDeleteRole.Text = "Delete Recept.";
            buttonDeleteRole.UseVisualStyleBackColor = true;
            // 
            // buttonAddRole
            // 
            buttonAddRole.Location = new Point(28, 262);
            buttonAddRole.Name = "buttonAddRole";
            buttonAddRole.Size = new Size(128, 34);
            buttonAddRole.TabIndex = 24;
            buttonAddRole.Text = "Add Recept.";
            buttonAddRole.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(374, 76);
            label1.Name = "label1";
            label1.Size = new Size(294, 32);
            label1.TabIndex = 23;
            label1.Text = "Receptionist Management";
            // 
            // loggedUserEmail
            // 
            loggedUserEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            loggedUserEmail.AutoSize = true;
            loggedUserEmail.Location = new Point(735, 77);
            loggedUserEmail.Margin = new Padding(4, 0, 4, 0);
            loggedUserEmail.Name = "loggedUserEmail";
            loggedUserEmail.Size = new Size(104, 25);
            loggedUserEmail.TabIndex = 28;
            loggedUserEmail.Text = "{User Email}";
            // 
            // ReceiptionistManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(panelAddRole);
            Controls.Add(buttonRoleList);
            Controls.Add(buttonLogout);
            Controls.Add(buttonEditRole);
            Controls.Add(buttonDeleteRole);
            Controls.Add(buttonAddRole);
            Controls.Add(label1);
            Controls.Add(loggedUserEmail);
            Name = "ReceiptionistManagement";
            Text = "ReceiptionistManagement";
            panelAddRole.ResumeLayout(false);
            panelAddRole.PerformLayout();
            panelUpdateRecept.ResumeLayout(false);
            panelUpdateRecept.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonPnlAddCancel;
        private Button buttonPnlCreateUser;
        private TextBox textBoxPnlAddEmail;
        private TextBox TextBoxPnlAddName;
        private Label labelPnlAddReceptEmail;
        private Label labelPnlAddReceptName;
        private Label label2;
        private Button buttonPnlEditCancel;
        private Button buttonPnlUpdate;
        private Label label3;
        private Panel panelAddRole;
        private Panel panelUpdateRecept;
        private TextBox textBoxPnlUpdateEmail;
        private TextBox textBoxPnlUpdateName;
        private Label labelPnlUpdateReceptEmail;
        private Label labelPnlUpdateReceptName;
        private Button buttonRoleList;
        private Button buttonLogout;
        private Button buttonEditRole;
        private Button buttonDeleteRole;
        private Button buttonAddRole;
        private Label label1;
        private Label loggedUserEmail;
    }
}