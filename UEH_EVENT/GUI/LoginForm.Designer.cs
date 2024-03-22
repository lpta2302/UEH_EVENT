namespace UEH_EVENT.GUI
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblHaveaacount = new System.Windows.Forms.Label();
            this.tboxEmail = new System.Windows.Forms.TextBox();
            this.tboxPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnWithUEH = new System.Windows.Forms.Button();
            this.linklblSignUp = new System.Windows.Forms.LinkLabel();
            this.linklblForgot = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Futura PT Bold", 26.14285F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(127, 108);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(448, 78);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Welcome back";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Futura PT Book", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHeading.Location = new System.Drawing.Point(133, 200);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(564, 44);
            this.lblHeading.TabIndex = 1;
            this.lblHeading.Text = "Welcome back! Please enter your details.";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Futura PT Medium", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(135, 287);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(78, 35);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Futura PT Medium", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(134, 447);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(121, 35);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // lblHaveaacount
            // 
            this.lblHaveaacount.AutoSize = true;
            this.lblHaveaacount.Font = new System.Drawing.Font("Futura PT Book", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHaveaacount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHaveaacount.Location = new System.Drawing.Point(231, 832);
            this.lblHaveaacount.Name = "lblHaveaacount";
            this.lblHaveaacount.Size = new System.Drawing.Size(229, 35);
            this.lblHaveaacount.TabIndex = 5;
            this.lblHaveaacount.Text = "Don\'t have account?";
            // 
            // tboxEmail
            // 
            this.tboxEmail.BackColor = System.Drawing.SystemColors.Control;
            this.tboxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxEmail.Font = new System.Drawing.Font("Futura PT Book", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxEmail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tboxEmail.Location = new System.Drawing.Point(141, 336);
            this.tboxEmail.Multiline = true;
            this.tboxEmail.Name = "tboxEmail";
            this.tboxEmail.Size = new System.Drawing.Size(596, 65);
            this.tboxEmail.TabIndex = 7;
            // 
            // tboxPassword
            // 
            this.tboxPassword.BackColor = System.Drawing.SystemColors.Control;
            this.tboxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxPassword.Font = new System.Drawing.Font("Futura PT Book", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tboxPassword.Location = new System.Drawing.Point(140, 494);
            this.tboxPassword.Multiline = true;
            this.tboxPassword.Name = "tboxPassword";
            this.tboxPassword.Size = new System.Drawing.Size(596, 65);
            this.tboxPassword.TabIndex = 8;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Futura PT Medium", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(140, 659);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(596, 65);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnWithUEH
            // 
            this.btnWithUEH.Font = new System.Drawing.Font("Futura PT Medium", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithUEH.Location = new System.Drawing.Point(140, 744);
            this.btnWithUEH.Name = "btnWithUEH";
            this.btnWithUEH.Size = new System.Drawing.Size(596, 65);
            this.btnWithUEH.TabIndex = 10;
            this.btnWithUEH.Text = "Sign in with UEH Email";
            this.btnWithUEH.UseVisualStyleBackColor = true;
            // 
            // linklblSignUp
            // 
            this.linklblSignUp.AutoSize = true;
            this.linklblSignUp.Font = new System.Drawing.Font("Futura PT Bold", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblSignUp.LinkColor = System.Drawing.Color.Black;
            this.linklblSignUp.Location = new System.Drawing.Point(466, 834);
            this.linklblSignUp.Name = "linklblSignUp";
            this.linklblSignUp.Size = new System.Drawing.Size(207, 35);
            this.linklblSignUp.TabIndex = 11;
            this.linklblSignUp.TabStop = true;
            this.linklblSignUp.Text = "Sign up for free";
            // 
            // linklblForgot
            // 
            this.linklblForgot.AutoSize = true;
            this.linklblForgot.Font = new System.Drawing.Font("Futura PT Bold", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblForgot.LinkColor = System.Drawing.Color.Black;
            this.linklblForgot.Location = new System.Drawing.Point(135, 589);
            this.linklblForgot.Name = "linklblForgot";
            this.linklblForgot.Size = new System.Drawing.Size(229, 35);
            this.linklblForgot.TabIndex = 12;
            this.linklblForgot.TabStop = true;
            this.linklblForgot.Text = "Forgot password";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 1043);
            this.Controls.Add(this.linklblForgot);
            this.Controls.Add(this.linklblSignUp);
            this.Controls.Add(this.btnWithUEH);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tboxPassword);
            this.Controls.Add(this.tboxEmail);
            this.Controls.Add(this.lblHaveaacount);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.lblTitle);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblHaveaacount;
        private System.Windows.Forms.TextBox tboxEmail;
        private System.Windows.Forms.TextBox tboxPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnWithUEH;
        private System.Windows.Forms.LinkLabel linklblSignUp;
        private System.Windows.Forms.LinkLabel linklblForgot;
    }
}

