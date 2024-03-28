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
            Navbar = new Panel();
            pictureBoxLogo = new PictureBox();
            panelTitle = new Panel();
            label4 = new Label();
            Navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
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
            lblUsername.Location = new Point(485, 189);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(148, 38);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(485, 245);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.MaxLength = 200;
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(381, 45);
            txtUsername.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.Location = new Point(481, 315);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(139, 38);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(485, 371);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.MaxLength = 200;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(383, 45);
            txtPassword.TabIndex = 3;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(565, 317);
            lblName.Name = "lblName";
            lblName.Size = new Size(0, 30);
            lblName.TabIndex = 4;
            // 
            // lblnamer
            // 
            lblnamer.AutoSize = true;
            lblnamer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblnamer.Location = new Point(485, 441);
            lblnamer.Name = "lblnamer";
            lblnamer.Size = new Size(95, 38);
            lblnamer.TabIndex = 5;
            lblnamer.Text = "Name";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(34, 34, 34);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(1417, 55);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(254, 74);
            btnSave.TabIndex = 30;
            btnSave.Text = "LƯU";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(485, 497);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.MaxLength = 200;
            txtName.Name = "txtName";
            txtName.Size = new Size(383, 45);
            txtName.TabIndex = 31;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // lblAccType
            // 
            lblAccType.AutoSize = true;
            lblAccType.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAccType.ForeColor = Color.FromArgb(190, 0, 0);
            lblAccType.Location = new Point(713, 593);
            lblAccType.Name = "lblAccType";
            lblAccType.Size = new Size(95, 38);
            lblAccType.TabIndex = 32;
            lblAccType.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(487, 593);
            label1.Name = "label1";
            label1.Size = new Size(203, 38);
            label1.TabIndex = 33;
            label1.Text = "Account Type:";
            // 
            // Navbar
            // 
            Navbar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Navbar.BackColor = Color.FromArgb(34, 34, 34);
            Navbar.Controls.Add(pictureBoxLogo);
            Navbar.Controls.Add(panelTitle);
            Navbar.Location = new Point(2, 0);
            Navbar.Name = "Navbar";
            Navbar.Size = new Size(400, 979);
            Navbar.TabIndex = 34;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.Logo_Update_27_3;
            pictureBoxLogo.Location = new Point(0, 0);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(400, 159);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 48;
            pictureBoxLogo.TabStop = false;
            // 
            // panelTitle
            // 
            panelTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelTitle.CausesValidation = false;
            panelTitle.Location = new Point(602, 3);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(1314, 1042);
            panelTitle.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Helvetica", 20.1428585F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(464, 59);
            label4.Name = "label4";
            label4.Size = new Size(433, 57);
            label4.TabIndex = 35;
            label4.Text = "UPDATE PROFILE";
            // 
            // formUpdateProfile
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1718, 979);
            Controls.Add(label4);
            Controls.Add(Navbar);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "formUpdateProfile";
            Text = "formUpdateProfile";
            WindowState = FormWindowState.Maximized;
            Load += formUpdateProfile_Load;
            Navbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
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
        private Panel Navbar;
        private PictureBox pictureBoxLogo;
        private Panel panelTitle;
        private Label label4;
    }
}