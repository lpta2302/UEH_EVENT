﻿namespace UEH_EVENT.GUI
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
            lblTitle = new Label();
            lblHeading = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            tboxEmail = new TextBox();
            tboxPassword = new TextBox();
            btnLogin = new Button();
            linklblForgot = new LinkLabel();
            panel8 = new Panel();
            panel1 = new Panel();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 26.14285F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(92, 90);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(321, 52);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Welcome back";
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Microsoft Sans Serif", 14.14286F, FontStyle.Regular, GraphicsUnit.Point);
            lblHeading.ForeColor = SystemColors.ControlDarkDark;
            lblHeading.Location = new Point(97, 167);
            lblHeading.Margin = new Padding(2, 0, 2, 0);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(455, 29);
            lblHeading.TabIndex = 1;
            lblHeading.Text = "Welcome back! Please enter your details.";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 11.14286F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(98, 239);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(105, 24);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Microsoft Sans Serif", 11.14286F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.Location = new Point(97, 372);
            lblPassword.Margin = new Padding(2, 0, 2, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(100, 24);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // tboxEmail
            // 
            tboxEmail.BackColor = Color.White;
            tboxEmail.BorderStyle = BorderStyle.None;
            tboxEmail.Font = new Font("Microsoft Sans Serif", 14.14286F, FontStyle.Regular, GraphicsUnit.Point);
            tboxEmail.ForeColor = Color.Black;
            tboxEmail.Location = new Point(8, 13);
            tboxEmail.Margin = new Padding(10, 2, 2, 2);
            tboxEmail.Name = "tboxEmail";
            tboxEmail.Size = new Size(434, 27);
            tboxEmail.TabIndex = 7;
            // 
            // tboxPassword
            // 
            tboxPassword.BackColor = Color.White;
            tboxPassword.BorderStyle = BorderStyle.None;
            tboxPassword.Font = new Font("Microsoft Sans Serif", 14.14286F, FontStyle.Regular, GraphicsUnit.Point);
            tboxPassword.ForeColor = Color.Black;
            tboxPassword.Location = new Point(106, 423);
            tboxPassword.Margin = new Padding(10, 2, 2, 2);
            tboxPassword.Name = "tboxPassword";
            tboxPassword.Size = new Size(434, 27);
            tboxPassword.TabIndex = 8;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(64, 64, 64);
            btnLogin.BackgroundImageLayout = ImageLayout.Center;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Microsoft Sans Serif", 11.14286F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(102, 549);
            btnLogin.Margin = new Padding(2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(433, 54);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // linklblForgot
            // 
            linklblForgot.AutoSize = true;
            linklblForgot.Font = new Font("Microsoft Sans Serif", 11.14286F, FontStyle.Bold, GraphicsUnit.Point);
            linklblForgot.LinkColor = Color.Black;
            linklblForgot.Location = new Point(98, 491);
            linklblForgot.Margin = new Padding(2, 0, 2, 0);
            linklblForgot.Name = "linklblForgot";
            linklblForgot.Size = new Size(166, 24);
            linklblForgot.TabIndex = 12;
            linklblForgot.TabStop = true;
            linklblForgot.Text = "Forgot password";
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel8.BackColor = Color.White;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(tboxEmail);
            panel8.Location = new Point(98, 274);
            panel8.Margin = new Padding(2);
            panel8.Name = "panel8";
            panel8.Size = new Size(454, 62);
            panel8.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(98, 406);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(454, 62);
            panel1.TabIndex = 17;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(654, 687);
            Controls.Add(linklblForgot);
            Controls.Add(btnLogin);
            Controls.Add(tboxPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(lblHeading);
            Controls.Add(lblTitle);
            Controls.Add(panel8);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += Form1_Load;
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tboxEmail;
        private System.Windows.Forms.TextBox tboxPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel linklblForgot;
        private Panel panel8;
        private Panel panel1;
    }
}

