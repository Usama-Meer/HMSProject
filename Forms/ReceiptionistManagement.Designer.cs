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
            textBoxPnlAddName = new TextBox();
            labelPnlAddReceptEmail = new Label();
            labelPnlAddReceptName = new Label();
            label2 = new Label();
            buttonPnlEditCancel = new Button();
            buttonPnlUpdate = new Button();
            label3 = new Label();
            panelAddRecept = new Panel();
            panelUpdateRecept = new Panel();
            textBoxPnlUpdateEmail = new TextBox();
            textBoxPnlUpdateName = new TextBox();
            labelPnlUpdateReceptEmail = new Label();
            labelPnlUpdateReceptName = new Label();
            dataGridViewRecept = new DataGridView();
            buttonReceptList = new Button();
            buttonLogout = new Button();
            buttonEditRecept = new Button();
            buttonDeleteRecept = new Button();
            buttonReceptRole = new Button();
            label1 = new Label();
            loggedUserEmail = new Label();
            panelAddRecept.SuspendLayout();
            panelUpdateRecept.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecept).BeginInit();
            SuspendLayout();
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
            buttonPnlCreateUser.Click += buttonPanelCreate;
            // 
            // textBoxPnlAddEmail
            // 
            textBoxPnlAddEmail.Location = new Point(254, 107);
            textBoxPnlAddEmail.Margin = new Padding(2);
            textBoxPnlAddEmail.Name = "textBoxPnlAddEmail";
            textBoxPnlAddEmail.Size = new Size(220, 27);
            textBoxPnlAddEmail.TabIndex = 8;
            // 
            // textBoxPnlAddName
            // 
            textBoxPnlAddName.Location = new Point(254, 57);
            textBoxPnlAddName.Margin = new Padding(2);
            textBoxPnlAddName.Name = "textBoxPnlAddName";
            textBoxPnlAddName.Size = new Size(220, 27);
            textBoxPnlAddName.TabIndex = 5;
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
            buttonPnlEditCancel.Margin = new Padding(2);
            buttonPnlEditCancel.Name = "buttonPnlEditCancel";
            buttonPnlEditCancel.Size = new Size(90, 27);
            buttonPnlEditCancel.TabIndex = 13;
            buttonPnlEditCancel.Text = "Cancel";
            buttonPnlEditCancel.UseVisualStyleBackColor = true;
            buttonPnlEditCancel.Click += ReceiptionistManagement_Load;
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
            buttonPnlUpdate.Click += buttonPanelUpdate;
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
            // panelAddRecept
            // 
            panelAddRecept.Controls.Add(label3);
            panelAddRecept.Controls.Add(buttonPnlAddCancel);
            panelAddRecept.Controls.Add(buttonPnlCreateUser);
            panelAddRecept.Controls.Add(textBoxPnlAddEmail);
            panelAddRecept.Controls.Add(textBoxPnlAddName);
            panelAddRecept.Controls.Add(labelPnlAddReceptEmail);
            panelAddRecept.Controls.Add(labelPnlAddReceptName);
            panelAddRecept.Location = new Point(167, 135);
            panelAddRecept.Margin = new Padding(2);
            panelAddRecept.Name = "panelAddRecept";
            panelAddRecept.Size = new Size(562, 258);
            panelAddRecept.TabIndex = 29;
            panelAddRecept.Visible = false;
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
            panelUpdateRecept.Location = new Point(167, 135);
            panelUpdateRecept.Margin = new Padding(2);
            panelUpdateRecept.Name = "panelUpdateRecept";
            panelUpdateRecept.Size = new Size(562, 260);
            panelUpdateRecept.TabIndex = 19;
            panelUpdateRecept.Visible = false;
            // 
            // textBoxPnlUpdateEmail
            // 
            textBoxPnlUpdateEmail.Location = new Point(264, 125);
            textBoxPnlUpdateEmail.Margin = new Padding(2);
            textBoxPnlUpdateEmail.Name = "textBoxPnlUpdateEmail";
            textBoxPnlUpdateEmail.Size = new Size(220, 27);
            textBoxPnlUpdateEmail.TabIndex = 8;
            // 
            // textBoxPnlUpdateName
            // 
            textBoxPnlUpdateName.Location = new Point(262, 74);
            textBoxPnlUpdateName.Margin = new Padding(2);
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
            // dataGridViewRecept
            // 
            dataGridViewRecept.AllowUserToOrderColumns = true;
            dataGridViewRecept.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRecept.Location = new Point(167, 135);
            dataGridViewRecept.Name = "dataGridViewRecept";
            dataGridViewRecept.RowHeadersWidth = 51;
            dataGridViewRecept.Size = new Size(559, 258);
            dataGridViewRecept.TabIndex = 21;
            // 
            // buttonReceptList
            // 
            buttonReceptList.Location = new Point(22, 167);
            buttonReceptList.Margin = new Padding(2);
            buttonReceptList.Name = "buttonReceptList";
            buttonReceptList.Size = new Size(102, 27);
            buttonReceptList.TabIndex = 30;
            buttonReceptList.Text = "Recept. List";
            buttonReceptList.UseVisualStyleBackColor = true;
            buttonReceptList.Click += ReceiptionistManagement_Load;
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
            // buttonEditRecept
            // 
            buttonEditRecept.Location = new Point(22, 290);
            buttonEditRecept.Margin = new Padding(2);
            buttonEditRecept.Name = "buttonEditRecept";
            buttonEditRecept.Size = new Size(102, 27);
            buttonEditRecept.TabIndex = 26;
            buttonEditRecept.Text = "Edit Recept.";
            buttonEditRecept.UseVisualStyleBackColor = true;
            buttonEditRecept.Click += buttonEditRecept_Click;
            // 
            // buttonDeleteRecept
            // 
            buttonDeleteRecept.Location = new Point(22, 250);
            buttonDeleteRecept.Margin = new Padding(2);
            buttonDeleteRecept.Name = "buttonDeleteRecept";
            buttonDeleteRecept.Size = new Size(102, 27);
            buttonDeleteRecept.TabIndex = 25;
            buttonDeleteRecept.Text = "Delete Recept.";
            buttonDeleteRecept.UseVisualStyleBackColor = true;
            buttonDeleteRecept.Click += buttonDeleteRecept_Click;
            // 
            // buttonReceptRole
            // 
            buttonReceptRole.Location = new Point(22, 210);
            buttonReceptRole.Margin = new Padding(2);
            buttonReceptRole.Name = "buttonReceptRole";
            buttonReceptRole.Size = new Size(102, 27);
            buttonReceptRole.TabIndex = 24;
            buttonReceptRole.Text = "Add Recept.";
            buttonReceptRole.UseVisualStyleBackColor = true;
            buttonReceptRole.Click += buttonAddRecept_Click;
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
            // ReceiptionistManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelAddRecept);
            Controls.Add(panelUpdateRecept);
            Controls.Add(buttonReceptList);
            Controls.Add(buttonLogout);
            Controls.Add(buttonEditRecept);
            Controls.Add(buttonDeleteRecept);
            Controls.Add(buttonReceptRole);
            Controls.Add(label1);
            Controls.Add(loggedUserEmail);
            Controls.Add(dataGridViewRecept);
            Margin = new Padding(2);
            Name = "ReceiptionistManagement";
            Text = "ReceiptionistManagement";
            Load += ReceiptionistManagement_Load;
            panelAddRecept.ResumeLayout(false);
            panelAddRecept.PerformLayout();
            panelUpdateRecept.ResumeLayout(false);
            panelUpdateRecept.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecept).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonPnlAddCancel;
        private Button buttonPnlCreateUser;
        private TextBox textBoxPnlAddEmail;
        private TextBox textBoxPnlAddName;
        private Label labelPnlAddReceptEmail;
        private Label labelPnlAddReceptName;
        private Label label2;
        private Button buttonPnlEditCancel;
        private Button buttonPnlUpdate;
        private Label label3;
        private Panel panelAddRecept;
        private Panel panelUpdateRecept;
        private TextBox textBoxPnlUpdateEmail;
        private TextBox textBoxPnlUpdateName;
        private Label labelPnlUpdateReceptEmail;
        private Label labelPnlUpdateReceptName;
        private Button buttonReceptList;
        private Button buttonLogout;
        private Button buttonEditRecept;
        private Button buttonDeleteRecept;
        private Button buttonReceptRole;
        private Label label1;
        private Label loggedUserEmail;
        private DataGridView dataGridViewRecept;
    }
}