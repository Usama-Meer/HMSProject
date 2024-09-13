namespace HMSProject.Forms
{
    partial class LoginForm
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
            buttonLogin = new Button();
            labelPassword = new Label();
            labelEmail = new Label();
            HMS = new Label();
            textBoxPassword = new TextBox();
            textBoxEmail = new TextBox();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(358, 277);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(94, 29);
            buttonLogin.TabIndex = 11;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += LoginButton_Click;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(271, 210);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(70, 20);
            labelPassword.TabIndex = 10;
            labelPassword.Text = "Password";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(271, 166);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(46, 20);
            labelEmail.TabIndex = 9;
            labelEmail.Text = "Email";
            // 
            // HMS
            // 
            HMS.AutoSize = true;
            HMS.Font = new Font("Segoe UI", 14F);
            HMS.Location = new Point(233, 77);
            HMS.Name = "HMS";
            HMS.Size = new Size(334, 32);
            HMS.TabIndex = 8;
            HMS.Text = "Hospital Management System";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(377, 203);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(169, 27);
            textBoxPassword.TabIndex = 7;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(377, 159);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(169, 27);
            textBoxEmail.TabIndex = 6;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonLogin);
            Controls.Add(labelPassword);
            Controls.Add(labelEmail);
            Controls.Add(HMS);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEmail);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogin;
        private Label labelPassword;
        private Label labelEmail;
        private Label HMS;
        private TextBox textBoxPassword;
        private TextBox textBoxEmail;
    }
}