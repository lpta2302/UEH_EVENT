namespace UEH_EVENT.GUI
{
    partial class formCreateAccount
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
            label1 = new Label();
            txtConfirmPassword = new TextBox();
            btnCreate = new Button();
            lblConfirmPassword = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtName = new TextBox();
            lbl_name = new Label();
            cbbAccType = new ComboBox();
            txtUsername = new TextBox();
            label2 = new Label();
            panelContainer = new Panel();
            label4 = new Label();
            btnBack = new Button();
            Navbar = new Panel();
            pictureBoxLogo = new PictureBox();
            panelContainer.SuspendLayout();
            Navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(941, 564);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(146, 28);
            label1.TabIndex = 43;
            label1.Text = "Account Type:";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirmPassword.Location = new Point(26, 338);
            txtConfirmPassword.Margin = new Padding(2, 3, 2, 3);
            txtConfirmPassword.MaxLength = 200;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(275, 34);
            txtConfirmPassword.TabIndex = 38;
            txtConfirmPassword.Tag = "Confirm Password";
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(34, 34, 34);
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(915, 685);
            btnCreate.Margin = new Padding(2, 3, 2, 3);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(332, 57);
            btnCreate.TabIndex = 40;
            btnCreate.Text = "TẠO";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblConfirmPassword.Location = new Point(26, 307);
            lblConfirmPassword.Margin = new Padding(2, 0, 2, 0);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(183, 28);
            lblConfirmPassword.TabIndex = 39;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(26, 249);
            txtPassword.Margin = new Padding(2, 3, 2, 3);
            txtPassword.MaxLength = 200;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(275, 34);
            txtPassword.TabIndex = 37;
            txtPassword.Tag = "Password";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.Location = new Point(941, 376);
            lblPassword.Margin = new Padding(2, 0, 2, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(101, 28);
            lblPassword.TabIndex = 36;
            lblPassword.Text = "Password";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(26, 56);
            txtName.Margin = new Padding(2, 3, 2, 3);
            txtName.MaxLength = 200;
            txtName.Name = "txtName";
            txtName.Size = new Size(275, 34);
            txtName.TabIndex = 35;
            txtName.Tag = "Tên";
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_name.Location = new Point(941, 188);
            lbl_name.Margin = new Padding(2, 0, 2, 0);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(68, 28);
            lbl_name.TabIndex = 34;
            lbl_name.Text = "Name";
            // 
            // cbbAccType
            // 
            cbbAccType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbAccType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbAccType.FormattingEnabled = true;
            cbbAccType.ItemHeight = 28;
            cbbAccType.Location = new Point(26, 439);
            cbbAccType.Name = "cbbAccType";
            cbbAccType.Size = new Size(275, 36);
            cbbAccType.TabIndex = 44;
            cbbAccType.Tag = "Loại tài khoản";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(26, 156);
            txtUsername.Margin = new Padding(2, 3, 2, 3);
            txtUsername.MaxLength = 200;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(275, 34);
            txtUsername.TabIndex = 36;
            txtUsername.Tag = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(941, 282);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 45;
            label2.Text = "Username";
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.White;
            panelContainer.Controls.Add(txtName);
            panelContainer.Controls.Add(txtUsername);
            panelContainer.Controls.Add(txtPassword);
            panelContainer.Controls.Add(txtConfirmPassword);
            panelContainer.Controls.Add(cbbAccType);
            panelContainer.Controls.Add(lblConfirmPassword);
            panelContainer.Location = new Point(915, 172);
            panelContainer.Margin = new Padding(3, 2, 3, 2);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(332, 493);
            panelContainer.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 20.1428585F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(915, 69);
            label4.Name = "label4";
            label4.Size = new Size(332, 40);
            label4.TabIndex = 48;
            label4.Text = "CREATE ACCOUNT";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(34, 34, 34);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(364, 27);
            btnBack.Margin = new Padding(2, 3, 2, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(158, 51);
            btnBack.TabIndex = 41;
            btnBack.Text = "QUAY LẠI";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // Navbar
            // 
            Navbar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Navbar.BackColor = Color.FromArgb(34, 34, 34);
            Navbar.Controls.Add(pictureBoxLogo);
            Navbar.Location = new Point(-3, 1);
            Navbar.Margin = new Padding(2);
            Navbar.Name = "Navbar";
            Navbar.Size = new Size(267, 984);
            Navbar.TabIndex = 50;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.Logo_Update_27_3;
            pictureBoxLogo.InitialImage = null;
            pictureBoxLogo.Location = new Point(0, 3);
            pictureBoxLogo.Margin = new Padding(2);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(267, 105);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 4;
            pictureBoxLogo.TabStop = false;
            // 
            // formCreateAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1840, 822);
            Controls.Add(Navbar);
            Controls.Add(btnBack);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCreate);
            Controls.Add(lblPassword);
            Controls.Add(lbl_name);
            Controls.Add(panelContainer);
            Name = "formCreateAccount";
            Text = "CreateAccount";
            WindowState = FormWindowState.Maximized;
            Load += formCreateAccount_Load;
            panelContainer.ResumeLayout(false);
            panelContainer.PerformLayout();
            Navbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtConfirmPassword;
        private Button btnCreate;
        private Label lblConfirmPassword;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtName;
        private Label lbl_name;
        private ComboBox cbbAccType;
        private TextBox txtUsername;
        private Label label2;
        private Panel panelContainer;
        private Label label4;
        private Button btnBack;
        private Panel Navbar;
        private PictureBox pictureBoxLogo;
    }
}