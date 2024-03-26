namespace UEH_EVENT.GUI
{
    partial class formUpdateProfile
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
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblName = new Label();
            lblnamer = new Label();
            btnSave = new Button();
            txtName = new TextBox();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.Location = new Point(43, 47);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(111, 30);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(43, 75);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(1042, 33);
            txtUsername.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(43, 136);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(103, 30);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(40, 164);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(1045, 33);
            txtPassword.TabIndex = 3;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(119, 212);
            lblName.Name = "lblName";
            lblName.Size = new Size(0, 25);
            lblName.TabIndex = 4;
            // 
            // lblnamer
            // 
            lblnamer.AutoSize = true;
            lblnamer.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblnamer.Location = new Point(43, 222);
            lblnamer.Name = "lblnamer";
            lblnamer.Size = new Size(71, 30);
            lblnamer.TabIndex = 5;
            lblnamer.Text = "Name";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(34, 34, 34);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(1135, 385);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(125, 59);
            btnSave.TabIndex = 30;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnDelete_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(40, 250);
            txtName.Name = "txtName";
            txtName.Size = new Size(1045, 33);
            txtName.TabIndex = 31;
            // 
            // formUpdateProfile
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1782, 755);
            Controls.Add(txtName);
            Controls.Add(btnSave);
            Controls.Add(lblnamer);
            Controls.Add(lblName);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Name = "formUpdateProfile";
            Text = "formUpdateProfile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblName;
        private Label lblnamer;
        private Button btnSave;
        private TextBox txtName;
    }
}