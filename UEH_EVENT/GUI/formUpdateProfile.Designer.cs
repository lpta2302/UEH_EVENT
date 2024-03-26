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
            lblAccType = new Label();
            label1 = new Label();
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
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.Location = new Point(305, 216);
            lblUsername.Margin = new Padding(2, 0, 2, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(87, 21);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(305, 244);
            txtUsername.Margin = new Padding(2);
            txtUsername.MaxLength = 200;
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(223, 29);
            txtUsername.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.Location = new Point(303, 279);
            lblPassword.Margin = new Padding(2, 0, 2, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(82, 21);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(305, 307);
            txtPassword.Margin = new Padding(2);
            txtPassword.MaxLength = 200;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(224, 29);
            txtPassword.TabIndex = 3;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(352, 280);
            lblName.Margin = new Padding(2, 0, 2, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(0, 15);
            lblName.TabIndex = 4;
            // 
            // lblnamer
            // 
            lblnamer.AutoSize = true;
            lblnamer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblnamer.Location = new Point(305, 342);
            lblnamer.Margin = new Padding(2, 0, 2, 0);
            lblnamer.Name = "lblnamer";
            lblnamer.Size = new Size(56, 21);
            lblnamer.TabIndex = 5;
            lblnamer.Text = "Name";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(34, 34, 34);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(305, 522);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(226, 30);
            btnSave.TabIndex = 30;
            btnSave.Text = "LƯU";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(305, 370);
            txtName.Margin = new Padding(2);
            txtName.MaxLength = 200;
            txtName.Name = "txtName";
            txtName.Size = new Size(224, 29);
            txtName.TabIndex = 31;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // lblAccType
            // 
            lblAccType.AutoSize = true;
            lblAccType.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAccType.ForeColor = Color.FromArgb(190, 0, 0);
            lblAccType.Location = new Point(438, 418);
            lblAccType.Margin = new Padding(2, 0, 2, 0);
            lblAccType.Name = "lblAccType";
            lblAccType.Size = new Size(56, 21);
            lblAccType.TabIndex = 32;
            lblAccType.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(306, 418);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(117, 21);
            label1.TabIndex = 33;
            label1.Text = "Account Type:";
            // 
            // formUpdateProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1509, 764);
            Controls.Add(label1);
            Controls.Add(lblAccType);
            Controls.Add(txtName);
            Controls.Add(btnSave);
            Controls.Add(lblnamer);
            Controls.Add(lblName);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Margin = new Padding(2);
            Name = "formUpdateProfile";
            Text = "formUpdateProfile";
            WindowState = FormWindowState.Maximized;
            Load += formUpdateProfile_Load;
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
        private Label lblAccType;
        private Label label1;
    }
}