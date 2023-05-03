namespace final_project
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogin = new Button();
            btnCreateAccount = new Button();
            label1 = new Label();
            label2 = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            lblUserName = new Label();
            lblPassword = new Label();
            lblLoginError = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(153, 330);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.Location = new Point(327, 330);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(169, 29);
            btnCreateAccount.TabIndex = 1;
            btnCreateAccount.Text = "create account";
            btnCreateAccount.UseVisualStyleBackColor = true;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 88);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 202);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(170, 85);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(292, 27);
            txtUserName.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(170, 199);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(292, 27);
            txtPassword.TabIndex = 5;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(540, 152);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(0, 20);
            lblUserName.TabIndex = 6;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(548, 196);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(0, 20);
            lblPassword.TabIndex = 7;
            // 
            // lblLoginError
            // 
            lblLoginError.AutoSize = true;
            lblLoginError.Location = new Point(247, 271);
            lblLoginError.Name = "lblLoginError";
            lblLoginError.Size = new Size(0, 20);
            lblLoginError.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 417);
            Controls.Add(lblLoginError);
            Controls.Add(lblPassword);
            Controls.Add(lblUserName);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCreateAccount);
            Controls.Add(btnLogin);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button btnLogin;
        private Button btnCreateAccount;
        private Label label1;
        private Label label2;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label lblUserName;
        private Label lblPassword;
        private Label lblLoginError;
    }
}