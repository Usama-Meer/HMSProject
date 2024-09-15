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
            panelReceptList = new Panel();
            dataGridViewRecept = new DataGridView();
            panelAddRole.SuspendLayout();
            panelUpdateRecept.SuspendLayout();
            panelReceptList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecept).BeginInit();
            SuspendLayout();
            // 
            // buttonPnlAddCancel
            // 
            buttonPnlAddCancel.Location = new Point(196, 206);
            buttonPnlAddCancel.Margin = new Padding(2, 2, 2, 2);
            buttonPnlAddCancel.Name = "buttonPnlAddCancel";
            buttonPnlAddCancel.Size = new Size(90, 27);
            buttonPnlAddCancel.TabIndex = 13;
            buttonPnlAddCancel.Text = "Cancel";
            buttonPnlAddCancel.UseVisualStyleBackColor = true;
            // 
            // buttonPnlCreateUser
            // 
            buttonPnlCreateUser.Location = new Point(298, 206);
            buttonPnlCreateUser.Margin = new Padding(2, 2, 2, 2);
            buttonPnlCreateUser.Name = "buttonPnlCreateUser";
            buttonPnlCreateUser.Size = new Size(90, 27);
            buttonPnlCreateUser.TabIndex = 12;
            buttonPnlCreateUser.Text = "Create";
            buttonPnlCreateUser.UseVisualStyleBackColor = true;
            // 
            // textBoxPnlAddEmail
            // 
            textBoxPnlAddEmail.Location = new Point(254, 107);
            textBoxPnlAddEmail.Margin = new Padding(2, 2, 2, 2);
            textBoxPnlAddEmail.Name = "textBoxPnlAddEmail";
            textBoxPnlAddEmail.Size = new Size(220, 27);
            textBoxPnlAddEmail.TabIndex = 8;
            // 
            // TextBoxPnlAddName
            // 
            TextBoxPnlAddName.Location = new Point(254, 57);
            TextBoxPnlAddName.Margin = new Padding(2, 2, 2, 2);
            TextBoxPnlAddName.Name = "TextBoxPnlAddName";
            TextBoxPnlAddName.Size = new Size(220, 27);
            TextBoxPnlAddName.TabIndex = 5;
            // 
            // labelPnlAddReceptEmail
            // 
            labelPnlAddReceptEmail.AutoSize = true;
            labelPnlAddReceptEmail.Location = new Point(114, 107);
            labelPnlAddReceptEmail.Margin = new Padding(2, 0, 2, 0);
            labelPnlAddReceptEmail.Name = "labelPnlAddReceptEmail";
            labelPnlAddReceptEmail.Size = new Size(132, 20);
            labelPnlAddReceptEmail.TabIndex = 3;
            labelPnlAddReceptEmail.Text = "Receptionist Email";
            // 
            // labelPnlAddReceptName
            // 
            labelPnlAddReceptName.AutoSize = true;
            labelPnlAddReceptName.Location = new Point(113, 58);
            labelPnlAddReceptName.Margin = new Padding(2, 0, 2, 0);
            labelPnlAddReceptName.Name = "labelPnlAddReceptName";
            labelPnlAddReceptName.Size = new Size(135, 20);
            labelPnlAddReceptName.TabIndex = 0;
            labelPnlAddReceptName.Text = "Receptionist Name";
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
            buttonPnlEditCancel.Margin = new Padding(2, 2, 2, 2);
            buttonPnlEditCancel.Name = "buttonPnlEditCancel";
            buttonPnlEditCancel.Size = new Size(90, 27);
            buttonPnlEditCancel.TabIndex = 13;
            buttonPnlEditCancel.Text = "Cancel";
            buttonPnlEditCancel.UseVisualStyleBackColor = true;
            // 
            // buttonPnlUpdate
            // 
            buttonPnlUpdate.Location = new Point(294, 202);
            buttonPnlUpdate.Margin = new Padding(2, 2, 2, 2);
            buttonPnlUpdate.Name = "buttonPnlUpdate";
            buttonPnlUpdate.Size = new Size(90, 27);
            buttonPnlUpdate.TabIndex = 12;
            buttonPnlUpdate.Text = "Update";
            buttonPnlUpdate.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(222, 14);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(178, 23);
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
            panelAddRole.Location = new Point(166, 138);
            panelAddRole.Margin = new Padding(2, 2, 2, 2);
            panelAddRole.Name = "panelAddRole";
            panelAddRole.Size = new Size(562, 254);
            panelAddRole.TabIndex = 29;
            panelAddRole.Visible = false;
            // 
            // panelUpdateRecept
            // 
            panelUpdateRecept.Controls.Add(panelReceptList);
            panelUpdateRecept.Controls.Add(label2);
            panelUpdateRecept.Controls.Add(buttonPnlEditCancel);
            panelUpdateRecept.Controls.Add(buttonPnlUpdate);
            panelUpdateRecept.Controls.Add(textBoxPnlUpdateEmail);
            panelUpdateRecept.Controls.Add(textBoxPnlUpdateName);
            panelUpdateRecept.Controls.Add(labelPnlUpdateReceptEmail);
            panelUpdateRecept.Controls.Add(labelPnlUpdateReceptName);
            panelUpdateRecept.Location = new Point(0, 0);
            panelUpdateRecept.Margin = new Padding(2, 2, 2, 2);
            panelUpdateRecept.Name = "panelUpdateRecept";
            panelUpdateRecept.Size = new Size(562, 258);
            panelUpdateRecept.TabIndex = 19;
            panelUpdateRecept.Visible = false;
            // 
            // textBoxPnlUpdateEmail
            // 
            textBoxPnlUpdateEmail.Location = new Point(264, 125);
            textBoxPnlUpdateEmail.Margin = new Padding(2, 2, 2, 2);
            textBoxPnlUpdateEmail.Name = "textBoxPnlUpdateEmail";
            textBoxPnlUpdateEmail.Size = new Size(220, 27);
            textBoxPnlUpdateEmail.TabIndex = 8;
            // 
            // textBoxPnlUpdateName
            // 
            textBoxPnlUpdateName.Location = new Point(262, 74);
            textBoxPnlUpdateName.Margin = new Padding(2, 2, 2, 2);
            textBoxPnlUpdateName.Name = "textBoxPnlUpdateName";
            textBoxPnlUpdateName.Size = new Size(220, 27);
            textBoxPnlUpdateName.TabIndex = 5;
            // 
            // labelPnlUpdateReceptEmail
            // 
            labelPnlUpdateReceptEmail.AutoSize = true;
            labelPnlUpdateReceptEmail.Location = new Point(115, 129);
            labelPnlUpdateReceptEmail.Margin = new Padding(2, 0, 2, 0);
            labelPnlUpdateReceptEmail.Name = "labelPnlUpdateReceptEmail";
            labelPnlUpdateReceptEmail.Size = new Size(132, 20);
            labelPnlUpdateReceptEmail.TabIndex = 3;
            labelPnlUpdateReceptEmail.Text = "Receptionist Email";
            // 
            // labelPnlUpdateReceptName
            // 
            labelPnlUpdateReceptName.AutoSize = true;
            labelPnlUpdateReceptName.Location = new Point(114, 79);
            labelPnlUpdateReceptName.Margin = new Padding(2, 0, 2, 0);
            labelPnlUpdateReceptName.Name = "labelPnlUpdateReceptName";
            labelPnlUpdateReceptName.Size = new Size(135, 20);
            labelPnlUpdateReceptName.TabIndex = 0;
            labelPnlUpdateReceptName.Text = "Receptionist Name";
            // 
            // buttonRoleList
            // 
            buttonRoleList.Location = new Point(22, 167);
            buttonRoleList.Margin = new Padding(2, 2, 2, 2);
            buttonRoleList.Name = "buttonRoleList";
            buttonRoleList.Size = new Size(102, 27);
            buttonRoleList.TabIndex = 30;
            buttonRoleList.Text = "Recept. List";
            buttonRoleList.UseVisualStyleBackColor = true;
            // 
            // buttonLogout
            // 
            buttonLogout.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonLogout.Location = new Point(683, 58);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(94, 29);
            buttonLogout.TabIndex = 27;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // buttonEditRole
            // 
            buttonEditRole.Location = new Point(22, 290);
            buttonEditRole.Margin = new Padding(2, 2, 2, 2);
            buttonEditRole.Name = "buttonEditRole";
            buttonEditRole.Size = new Size(102, 27);
            buttonEditRole.TabIndex = 26;
            buttonEditRole.Text = "Edit Recept.";
            buttonEditRole.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteRole
            // 
            buttonDeleteRole.Location = new Point(22, 250);
            buttonDeleteRole.Margin = new Padding(2, 2, 2, 2);
            buttonDeleteRole.Name = "buttonDeleteRole";
            buttonDeleteRole.Size = new Size(102, 27);
            buttonDeleteRole.TabIndex = 25;
            buttonDeleteRole.Text = "Delete Recept.";
            buttonDeleteRole.UseVisualStyleBackColor = true;
            // 
            // buttonAddRole
            // 
            buttonAddRole.Location = new Point(22, 210);
            buttonAddRole.Margin = new Padding(2, 2, 2, 2);
            buttonAddRole.Name = "buttonAddRole";
            buttonAddRole.Size = new Size(102, 27);
            buttonAddRole.TabIndex = 24;
            buttonAddRole.Text = "Add Recept.";
            buttonAddRole.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(299, 61);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(240, 28);
            label1.TabIndex = 23;
            label1.Text = "Receptionist Management";
            // 
            // loggedUserEmail
            // 
            loggedUserEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            loggedUserEmail.AutoSize = true;
            loggedUserEmail.Location = new Point(588, 62);
            loggedUserEmail.Name = "loggedUserEmail";
            loggedUserEmail.Size = new Size(89, 20);
            loggedUserEmail.TabIndex = 28;
            loggedUserEmail.Text = "{User Email}";
            // 
            // panelReceptList
            // 
            panelReceptList.Controls.Add(dataGridViewRecept);
            panelReceptList.Location = new Point(2, 0);
            panelReceptList.Margin = new Padding(2);
            panelReceptList.Name = "panelReceptList";
            panelReceptList.Size = new Size(562, 258);
            panelReceptList.TabIndex = 31;
            panelReceptList.Visible = false;
            // 
            // dataGridViewRecept
            // 
            dataGridViewRecept.AllowUserToOrderColumns = true;
            dataGridViewRecept.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRecept.Location = new Point(17, 3);
            dataGridViewRecept.Name = "dataGridViewRecept";
            dataGridViewRecept.RowHeadersWidth = 51;
            dataGridViewRecept.Size = new Size(559, 258);
            dataGridViewRecept.TabIndex = 21;
            // 
            // ReceiptionistManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelAddRole);
            Controls.Add(buttonRoleList);
            Controls.Add(buttonLogout);
            Controls.Add(buttonEditRole);
            Controls.Add(buttonDeleteRole);
            Controls.Add(buttonAddRole);
            Controls.Add(label1);
            Controls.Add(loggedUserEmail);
            Margin = new Padding(2, 2, 2, 2);
            Name = "ReceiptionistManagement";
            Text = "ReceiptionistManagement";
            panelAddRole.ResumeLayout(false);
            panelAddRole.PerformLayout();
            panelUpdateRecept.ResumeLayout(false);
            panelUpdateRecept.PerformLayout();
            panelReceptList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecept).EndInit();
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
        private Panel panelReceptList;
        private DataGridView dataGridViewRecept;
    }
}