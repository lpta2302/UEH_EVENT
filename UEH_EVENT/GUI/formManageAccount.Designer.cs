using static Constants;
using System.Windows.Forms;

namespace UEH_EVENT.GUI
{
    partial class formManageAccount

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
            btnHome = new Button();
            lstAccount = new ListView();
            clnSTT = new ColumnHeader();
            clnUsername = new ColumnHeader();
            clnPassword = new ColumnHeader();
            clnName = new ColumnHeader();
            clnAccType = new ColumnHeader();
            panel3 = new Panel();
            txtName = new TextBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            txtUsername = new TextBox();
            pictureBoxiconSearch = new PictureBox();
            label2 = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            cbbAccType = new ComboBox();
            btnCreate = new Button();
            lblAccountType = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            Navbar = new Panel();
            pictureBoxLogo = new PictureBox();
            panelTitle = new Panel();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxiconSearch).BeginInit();
            Navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // btnHome
            // 
            btnHome.Location = new Point(0, 0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(75, 23);
            btnHome.TabIndex = 0;
            // 
            // lstAccount
            // 
            lstAccount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lstAccount.BorderStyle = BorderStyle.FixedSingle;
            lstAccount.Columns.AddRange(new ColumnHeader[] { clnSTT, clnUsername, clnPassword, clnName, clnAccType });
            lstAccount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstAccount.FullRowSelect = true;
            lstAccount.Location = new Point(453, 422);
            lstAccount.Name = "lstAccount";
            lstAccount.Size = new Size(1235, 383);
            lstAccount.TabIndex = 22;
            lstAccount.UseCompatibleStateImageBehavior = false;
            lstAccount.View = View.Details;
            // 
            // clnSTT
            // 
            clnSTT.Text = "STT";
            clnSTT.Width = 200;
            // 
            // clnUsername
            // 
            clnUsername.Text = "Username";
            clnUsername.TextAlign = HorizontalAlignment.Center;
            clnUsername.Width = 240;
            // 
            // clnPassword
            // 
            clnPassword.Text = "Password";
            clnPassword.TextAlign = HorizontalAlignment.Center;
            clnPassword.Width = 240;
            // 
            // clnName
            // 
            clnName.Text = "Name";
            clnName.TextAlign = HorizontalAlignment.Center;
            clnName.Width = 240;
            // 
            // clnAccType
            // 
            clnAccType.Text = "Account Type";
            clnAccType.TextAlign = HorizontalAlignment.Center;
            clnAccType.Width = 240;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(txtName);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(450, 347);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(309, 49);
            panel3.TabIndex = 21;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(28, 16);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(211, 20);
            txtName.TabIndex = 13;
            txtName.Text = "Tìm kiếm theo tên";
            txtName.GotFocus += gotFocus;
            txtName.KeyDown += enterTrigger;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.iconSearch;
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(3, 16);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(19, 19);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtUsername);
            panel2.Controls.Add(pictureBoxiconSearch);
            panel2.Location = new Point(450, 227);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(309, 55);
            panel2.TabIndex = 20;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(28, 16);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(211, 20);
            txtUsername.TabIndex = 13;
            txtUsername.Text = "Tìm kiếm theo username";
            txtUsername.GotFocus += gotFocus;
            txtUsername.KeyDown += enterTrigger;
            // 
            // pictureBoxiconSearch
            // 
            pictureBoxiconSearch.Image = Properties.Resources.iconSearch;
            pictureBoxiconSearch.InitialImage = null;
            pictureBoxiconSearch.Location = new Point(3, 16);
            pictureBoxiconSearch.Margin = new Padding(3, 2, 3, 2);
            pictureBoxiconSearch.Name = "pictureBoxiconSearch";
            pictureBoxiconSearch.Size = new Size(19, 19);
            pictureBoxiconSearch.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxiconSearch.TabIndex = 5;
            pictureBoxiconSearch.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(943, 389);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 19;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.BackColor = Color.White;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.FromArgb(192, 0, 0);
            btnDelete.Location = new Point(1103, 51);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(203, 72);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "XÓA";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdate.BackColor = Color.FromArgb(34, 34, 34);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(1511, 52);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(177, 71);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "CẬP NHẬT";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cbbAccType
            // 
            cbbAccType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbAccType.FormattingEnabled = true;
            cbbAccType.Location = new Point(864, 354);
            cbbAccType.Name = "cbbAccType";
            cbbAccType.Size = new Size(189, 28);
            cbbAccType.TabIndex = 27;
            cbbAccType.SelectedIndexChanged += cbbAccType_SelectedIndexChanged;
            // 
            // btnCreate
            // 
            btnCreate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCreate.BackColor = Color.FromArgb(34, 34, 34);
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(1321, 53);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(175, 70);
            btnCreate.TabIndex = 28;
            btnCreate.Text = "TẠO";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // lblAccountType
            // 
            lblAccountType.AutoSize = true;
            lblAccountType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAccountType.Location = new Point(864, 306);
            lblAccountType.Name = "lblAccountType";
            lblAccountType.Size = new Size(134, 28);
            lblAccountType.TabIndex = 29;
            lblAccountType.Text = "Loại tài khoản";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(450, 177);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 30;
            label1.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(450, 298);
            label3.Name = "label3";
            label3.Size = new Size(127, 28);
            label3.TabIndex = 31;
            label3.Text = "Tên tài khoản";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 20.1428585F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(450, 52);
            label4.Name = "label4";
            label4.Size = new Size(344, 40);
            label4.TabIndex = 5;
            label4.Text = "MANAGE ACCOUNT";
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
            Navbar.TabIndex = 1;
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
            // panelTitle
            // 
            panelTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelTitle.CausesValidation = false;
            panelTitle.Location = new Point(602, 2);
            panelTitle.Margin = new Padding(2);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(876, 1834);
            panelTitle.TabIndex = 3;
            // 
            // formManageAccount
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1718, 983);
            Controls.Add(Navbar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(lblAccountType);
            Controls.Add(btnCreate);
            Controls.Add(cbbAccType);
            Controls.Add(lstAccount);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(2);
            Name = "formManageAccount";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Manage";
            WindowState = FormWindowState.Maximized;
            Load += formManagement_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxiconSearch).EndInit();
            Navbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnHome;
        private ListView lstAccount;
        private ColumnHeader clnSTT;
        private ColumnHeader clnUsername;
        private ColumnHeader clnPassword;
        private ColumnHeader clnName;
        private Panel panel3;
        private TextBox txtName;
        private PictureBox pictureBox2;
        private Panel panel2;
        private TextBox txtUsername;
        private PictureBox pictureBoxiconSearch;
        private Label label2;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnCreate;
        private DateTimePicker dateTimePicker1;
        private ComboBox cbbAccType;
        private Button button1;
        private Label lblAccountType;
        private ColumnHeader clnAccType;
        private Label label1;
        private Label label3;
        private Label label4;
        private Panel Navbar;
        private PictureBox pictureBoxLogo;
        private Panel panelTitle;
    }
}