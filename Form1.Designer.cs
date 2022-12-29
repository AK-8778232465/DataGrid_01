namespace DataGrid
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnResetPass = new System.Windows.Forms.Button();
            this.txtForgotMail = new System.Windows.Forms.TextBox();
            this.txtVerifyCode = new System.Windows.Forms.TextBox();
            this.lblForgotMail = new System.Windows.Forms.Label();
            this.lblVerifyCode = new System.Windows.Forms.Label();
            this.btnGetCode = new System.Windows.Forms.Button();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.btnShowPass = new System.Windows.Forms.Button();
            this.btnReseted = new System.Windows.Forms.Button();
            this.btnVerifyCode = new System.Windows.Forms.Button();
            this.GroupReset = new System.Windows.Forms.GroupBox();
            this.GroupVerify = new System.Windows.Forms.GroupBox();
            this.lblVerifyStatus = new System.Windows.Forms.Label();
            this.GroupLogin = new System.Windows.Forms.GroupBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.GroupRegister = new System.Windows.Forms.GroupBox();
            this.txtEmpreg = new System.Windows.Forms.TextBox();
            this.txtFnamereg = new System.Windows.Forms.TextBox();
            this.txtUnamereg = new System.Windows.Forms.TextBox();
            this.txtPasswordreg = new System.Windows.Forms.TextBox();
            this.txtEmailreg = new System.Windows.Forms.TextBox();
            this.lblEmpreg = new System.Windows.Forms.Label();
            this.lblFnamereg = new System.Windows.Forms.Label();
            this.lblUnamereg = new System.Windows.Forms.Label();
            this.lblPasswordreg = new System.Windows.Forms.Label();
            this.lblEmailreg = new System.Windows.Forms.Label();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.GroupReset.SuspendLayout();
            this.GroupVerify.SuspendLayout();
            this.GroupLogin.SuspendLayout();
            this.GroupRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(107, 45);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(140, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(107, 82);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(140, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(23, 48);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(67, 13);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Employee ID";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(37, 85);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(57, 126);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnResetPass
            // 
            this.btnResetPass.Location = new System.Drawing.Point(152, 126);
            this.btnResetPass.Name = "btnResetPass";
            this.btnResetPass.Size = new System.Drawing.Size(105, 23);
            this.btnResetPass.TabIndex = 6;
            this.btnResetPass.Text = "Reset Password";
            this.btnResetPass.UseVisualStyleBackColor = false;
            this.btnResetPass.Click += new System.EventHandler(this.btnResetPass_Click);
            // 
            // txtForgotMail
            // 
            this.txtForgotMail.Location = new System.Drawing.Point(21, 86);
            this.txtForgotMail.Name = "txtForgotMail";
            this.txtForgotMail.Size = new System.Drawing.Size(175, 20);
            this.txtForgotMail.TabIndex = 7;
            // 
            // txtVerifyCode
            // 
            this.txtVerifyCode.Location = new System.Drawing.Point(21, 125);
            this.txtVerifyCode.Name = "txtVerifyCode";
            this.txtVerifyCode.Size = new System.Drawing.Size(175, 20);
            this.txtVerifyCode.TabIndex = 8;
            // 
            // lblForgotMail
            // 
            this.lblForgotMail.AutoSize = true;
            this.lblForgotMail.Location = new System.Drawing.Point(18, 66);
            this.lblForgotMail.Name = "lblForgotMail";
            this.lblForgotMail.Size = new System.Drawing.Size(141, 17);
            this.lblForgotMail.TabIndex = 9;
            this.lblForgotMail.Text = "Enter Registered Email ID :";
            this.lblForgotMail.UseCompatibleTextRendering = true;
            // 
            // lblVerifyCode
            // 
            this.lblVerifyCode.AutoSize = true;
            this.lblVerifyCode.Location = new System.Drawing.Point(18, 109);
            this.lblVerifyCode.Name = "lblVerifyCode";
            this.lblVerifyCode.Size = new System.Drawing.Size(64, 17);
            this.lblVerifyCode.TabIndex = 10;
            this.lblVerifyCode.Text = "Enter OTP :";
            this.lblVerifyCode.UseCompatibleTextRendering = true;
            // 
            // btnGetCode
            // 
            this.btnGetCode.Location = new System.Drawing.Point(202, 86);
            this.btnGetCode.Name = "btnGetCode";
            this.btnGetCode.Size = new System.Drawing.Size(75, 23);
            this.btnGetCode.TabIndex = 11;
            this.btnGetCode.Text = "Get Code";
            this.btnGetCode.UseCompatibleTextRendering = true;
            this.btnGetCode.UseVisualStyleBackColor = true;
            this.btnGetCode.Click += new System.EventHandler(this.btnGetCode_Click);
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(96, 63);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(168, 20);
            this.txtNewPass.TabIndex = 12;
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(96, 99);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(168, 20);
            this.txtConfirm.TabIndex = 13;
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Location = new System.Drawing.Point(12, 66);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(78, 13);
            this.lblNewPass.TabIndex = 14;
            this.lblNewPass.Text = "New Password";
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Location = new System.Drawing.Point(48, 102);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(42, 13);
            this.lblConfirm.TabIndex = 15;
            this.lblConfirm.Text = "Confirm";
            // 
            // btnShowPass
            // 
            this.btnShowPass.Location = new System.Drawing.Point(270, 63);
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.Size = new System.Drawing.Size(15, 18);
            this.btnShowPass.TabIndex = 16;
            this.btnShowPass.UseVisualStyleBackColor = true;
            this.btnShowPass.Visible = false;
            // 
            // btnReseted
            // 
            this.btnReseted.Location = new System.Drawing.Point(96, 134);
            this.btnReseted.Name = "btnReseted";
            this.btnReseted.Size = new System.Drawing.Size(75, 23);
            this.btnReseted.TabIndex = 17;
            this.btnReseted.Text = "Reset";
            this.btnReseted.UseVisualStyleBackColor = true;
            this.btnReseted.Click += new System.EventHandler(this.btnReseted_Click);
            // 
            // btnVerifyCode
            // 
            this.btnVerifyCode.Location = new System.Drawing.Point(202, 123);
            this.btnVerifyCode.Name = "btnVerifyCode";
            this.btnVerifyCode.Size = new System.Drawing.Size(75, 23);
            this.btnVerifyCode.TabIndex = 18;
            this.btnVerifyCode.Text = "Verify";
            this.btnVerifyCode.UseCompatibleTextRendering = true;
            this.btnVerifyCode.UseVisualStyleBackColor = true;
            this.btnVerifyCode.Click += new System.EventHandler(this.btnVerifyCode_Click);
            // 
            // GroupReset
            // 
            this.GroupReset.Controls.Add(this.lblNewPass);
            this.GroupReset.Controls.Add(this.txtNewPass);
            this.GroupReset.Controls.Add(this.btnReseted);
            this.GroupReset.Controls.Add(this.btnShowPass);
            this.GroupReset.Controls.Add(this.txtConfirm);
            this.GroupReset.Controls.Add(this.lblConfirm);
            this.GroupReset.Location = new System.Drawing.Point(27, 22);
            this.GroupReset.Name = "GroupReset";
            this.GroupReset.Size = new System.Drawing.Size(300, 200);
            this.GroupReset.TabIndex = 19;
            this.GroupReset.TabStop = false;
            this.GroupReset.Text = "Password Reset";
            this.GroupReset.Visible = false;
            // 
            // GroupVerify
            // 
            this.GroupVerify.Controls.Add(this.lblVerifyStatus);
            this.GroupVerify.Controls.Add(this.txtVerifyCode);
            this.GroupVerify.Controls.Add(this.lblVerifyCode);
            this.GroupVerify.Controls.Add(this.btnVerifyCode);
            this.GroupVerify.Controls.Add(this.txtForgotMail);
            this.GroupVerify.Controls.Add(this.btnGetCode);
            this.GroupVerify.Controls.Add(this.lblForgotMail);
            this.GroupVerify.Location = new System.Drawing.Point(27, 22);
            this.GroupVerify.Name = "GroupVerify";
            this.GroupVerify.Size = new System.Drawing.Size(300, 200);
            this.GroupVerify.TabIndex = 20;
            this.GroupVerify.TabStop = false;
            this.GroupVerify.Text = "Verify";
            this.GroupVerify.Visible = false;
            // 
            // lblVerifyStatus
            // 
            this.lblVerifyStatus.AutoSize = true;
            this.lblVerifyStatus.Location = new System.Drawing.Point(31, 165);
            this.lblVerifyStatus.Name = "lblVerifyStatus";
            this.lblVerifyStatus.Size = new System.Drawing.Size(0, 13);
            this.lblVerifyStatus.TabIndex = 22;
            this.lblVerifyStatus.Visible = false;
            // 
            // GroupLogin
            // 
            this.GroupLogin.Controls.Add(this.btnRegister);
            this.GroupLogin.Controls.Add(this.lblResult);
            this.GroupLogin.Controls.Add(this.txtPassword);
            this.GroupLogin.Controls.Add(this.txtUsername);
            this.GroupLogin.Controls.Add(this.lblUsername);
            this.GroupLogin.Controls.Add(this.btnResetPass);
            this.GroupLogin.Controls.Add(this.lblPassword);
            this.GroupLogin.Controls.Add(this.btnLogin);
            this.GroupLogin.Location = new System.Drawing.Point(27, 22);
            this.GroupLogin.Name = "GroupLogin";
            this.GroupLogin.Size = new System.Drawing.Size(300, 200);
            this.GroupLogin.TabIndex = 21;
            this.GroupLogin.TabStop = false;
            this.GroupLogin.Text = "Login";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(107, 163);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(68, 16);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 5;
            this.lblResult.Visible = false;
            // 
            // GroupRegister
            // 
            this.GroupRegister.Controls.Add(this.btnBack);
            this.GroupRegister.Controls.Add(this.btnCreateAccount);
            this.GroupRegister.Controls.Add(this.lblEmailreg);
            this.GroupRegister.Controls.Add(this.lblPasswordreg);
            this.GroupRegister.Controls.Add(this.lblUnamereg);
            this.GroupRegister.Controls.Add(this.lblFnamereg);
            this.GroupRegister.Controls.Add(this.lblEmpreg);
            this.GroupRegister.Controls.Add(this.txtEmailreg);
            this.GroupRegister.Controls.Add(this.txtPasswordreg);
            this.GroupRegister.Controls.Add(this.txtUnamereg);
            this.GroupRegister.Controls.Add(this.txtFnamereg);
            this.GroupRegister.Controls.Add(this.txtEmpreg);
            this.GroupRegister.Location = new System.Drawing.Point(27, 22);
            this.GroupRegister.Name = "GroupRegister";
            this.GroupRegister.Size = new System.Drawing.Size(300, 200);
            this.GroupRegister.TabIndex = 22;
            this.GroupRegister.TabStop = false;
            this.GroupRegister.Text = "Register";
            this.GroupRegister.Visible = false;
            // 
            // txtEmpreg
            // 
            this.txtEmpreg.Location = new System.Drawing.Point(133, 19);
            this.txtEmpreg.Name = "txtEmpreg";
            this.txtEmpreg.Size = new System.Drawing.Size(131, 20);
            this.txtEmpreg.TabIndex = 0;
            // 
            // txtFnamereg
            // 
            this.txtFnamereg.Location = new System.Drawing.Point(133, 48);
            this.txtFnamereg.Name = "txtFnamereg";
            this.txtFnamereg.Size = new System.Drawing.Size(131, 20);
            this.txtFnamereg.TabIndex = 1;
            // 
            // txtUnamereg
            // 
            this.txtUnamereg.Location = new System.Drawing.Point(133, 78);
            this.txtUnamereg.Name = "txtUnamereg";
            this.txtUnamereg.Size = new System.Drawing.Size(131, 20);
            this.txtUnamereg.TabIndex = 2;
            // 
            // txtPasswordreg
            // 
            this.txtPasswordreg.Location = new System.Drawing.Point(133, 109);
            this.txtPasswordreg.Name = "txtPasswordreg";
            this.txtPasswordreg.Size = new System.Drawing.Size(131, 20);
            this.txtPasswordreg.TabIndex = 3;
            // 
            // txtEmailreg
            // 
            this.txtEmailreg.Location = new System.Drawing.Point(133, 138);
            this.txtEmailreg.Name = "txtEmailreg";
            this.txtEmailreg.Size = new System.Drawing.Size(131, 20);
            this.txtEmailreg.TabIndex = 4;
            // 
            // lblEmpreg
            // 
            this.lblEmpreg.AutoSize = true;
            this.lblEmpreg.Location = new System.Drawing.Point(37, 22);
            this.lblEmpreg.Name = "lblEmpreg";
            this.lblEmpreg.Size = new System.Drawing.Size(67, 13);
            this.lblEmpreg.TabIndex = 5;
            this.lblEmpreg.Text = "Employee ID";
            // 
            // lblFnamereg
            // 
            this.lblFnamereg.AutoSize = true;
            this.lblFnamereg.Location = new System.Drawing.Point(47, 55);
            this.lblFnamereg.Name = "lblFnamereg";
            this.lblFnamereg.Size = new System.Drawing.Size(54, 13);
            this.lblFnamereg.TabIndex = 6;
            this.lblFnamereg.Text = "Full Name";
            // 
            // lblUnamereg
            // 
            this.lblUnamereg.AutoSize = true;
            this.lblUnamereg.Location = new System.Drawing.Point(46, 83);
            this.lblUnamereg.Name = "lblUnamereg";
            this.lblUnamereg.Size = new System.Drawing.Size(55, 13);
            this.lblUnamereg.TabIndex = 7;
            this.lblUnamereg.Text = "Username";
            // 
            // lblPasswordreg
            // 
            this.lblPasswordreg.AutoSize = true;
            this.lblPasswordreg.Location = new System.Drawing.Point(46, 112);
            this.lblPasswordreg.Name = "lblPasswordreg";
            this.lblPasswordreg.Size = new System.Drawing.Size(53, 13);
            this.lblPasswordreg.TabIndex = 8;
            this.lblPasswordreg.Text = "Password";
            // 
            // lblEmailreg
            // 
            this.lblEmailreg.AutoSize = true;
            this.lblEmailreg.Location = new System.Drawing.Point(53, 141);
            this.lblEmailreg.Name = "lblEmailreg";
            this.lblEmailreg.Size = new System.Drawing.Size(46, 13);
            this.lblEmailreg.TabIndex = 9;
            this.lblEmailreg.Text = "Email ID";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(133, 171);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(99, 23);
            this.btnCreateAccount.TabIndex = 10;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(7, 171);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(45, 23);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(354, 249);
            this.Controls.Add(this.GroupRegister);
            this.Controls.Add(this.GroupLogin);
            this.Controls.Add(this.GroupVerify);
            this.Controls.Add(this.GroupReset);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SharpData";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupReset.ResumeLayout(false);
            this.GroupReset.PerformLayout();
            this.GroupVerify.ResumeLayout(false);
            this.GroupVerify.PerformLayout();
            this.GroupLogin.ResumeLayout(false);
            this.GroupLogin.PerformLayout();
            this.GroupRegister.ResumeLayout(false);
            this.GroupRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnResetPass;
        private System.Windows.Forms.TextBox txtForgotMail;
        private System.Windows.Forms.TextBox txtVerifyCode;
        private System.Windows.Forms.Label lblForgotMail;
        private System.Windows.Forms.Label lblVerifyCode;
        private System.Windows.Forms.Button btnGetCode;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.Button btnShowPass;
        private System.Windows.Forms.Button btnReseted;
        private System.Windows.Forms.Button btnVerifyCode;
        private System.Windows.Forms.GroupBox GroupReset;
        private System.Windows.Forms.GroupBox GroupVerify;
        private System.Windows.Forms.GroupBox GroupLogin;
        private System.Windows.Forms.Label lblVerifyStatus;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.GroupBox GroupRegister;
        private System.Windows.Forms.Label lblEmailreg;
        private System.Windows.Forms.Label lblPasswordreg;
        private System.Windows.Forms.Label lblUnamereg;
        private System.Windows.Forms.Label lblFnamereg;
        private System.Windows.Forms.Label lblEmpreg;
        private System.Windows.Forms.TextBox txtEmailreg;
        private System.Windows.Forms.TextBox txtPasswordreg;
        private System.Windows.Forms.TextBox txtUnamereg;
        private System.Windows.Forms.TextBox txtFnamereg;
        private System.Windows.Forms.TextBox txtEmpreg;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCreateAccount;
    }
}

