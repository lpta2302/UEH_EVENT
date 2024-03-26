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
            Navbar = new Panel();
            pictureBoxHome = new PictureBox();
            pictureBox1 = new PictureBox();
            Home = new Panel();
            btnHomee = new Button();
            panel1 = new Panel();
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
            comboBox1 = new ComboBox();
            btnCreate = new Button();
            lblAccountType = new Label();
            Navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Home.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxiconSearch).BeginInit();
            SuspendLayout();
            // 
            // Navbar
            // 
            Navbar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Navbar.BackColor = Color.FromArgb(34, 34, 34);
            Navbar.Controls.Add(pictureBoxHome);
            Navbar.Controls.Add(pictureBox1);
            Navbar.Controls.Add(Home);
            Navbar.Controls.Add(panel1);
            Navbar.Location = new Point(0, 1);
            Navbar.Margin = new Padding(2);
            Navbar.Name = "Navbar";
            Navbar.Size = new Size(229, 790);
            Navbar.TabIndex = 0;
            // 
            // pictureBoxHome
            // 
            pictureBoxHome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxHome.Image = Properties.Resources.Home;
            pictureBoxHome.Location = new Point(170, -22);
            pictureBoxHome.Margin = new Padding(2);
            pictureBoxHome.Name = "pictureBoxHome";
            pictureBoxHome.Size = new Size(0, 761);
            pictureBoxHome.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxHome.TabIndex = 1;
            pictureBoxHome.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Logo_396x163;
            pictureBox1.Enabled = false;
            pictureBox1.Location = new Point(0, 2);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(226, 93);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Home
            // 
            Home.Controls.Add(btnHomee);
            Home.Location = new Point(0, 96);
            Home.Margin = new Padding(2);
            Home.Name = "Home";
            Home.Size = new Size(229, 43);
            Home.TabIndex = 7;
            // 
            // btnHomee
            // 
            btnHomee.BackColor = Color.FromArgb(34, 34, 34);
            btnHomee.BackgroundImageLayout = ImageLayout.None;
            btnHomee.FlatStyle = FlatStyle.Flat;
            btnHomee.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnHomee.ForeColor = Color.White;
            btnHomee.ImageAlign = ContentAlignment.MiddleLeft;
            btnHomee.Location = new Point(0, -5);
            btnHomee.Margin = new Padding(2);
            btnHomee.Name = "btnHomee";
            btnHomee.Padding = new Padding(11, 0, 0, 0);
            btnHomee.Size = new Size(239, 53);
            btnHomee.TabIndex = 10;
            btnHomee.Text = "  HOME";
            btnHomee.TextAlign = ContentAlignment.MiddleLeft;
            btnHomee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHomee.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(114, 57);
            panel1.TabIndex = 13;
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
            lstAccount.Columns.AddRange(new ColumnHeader[] { clnSTT, clnUsername, clnPassword, clnName, clnAccType });
            lstAccount.Location = new Point(313, 334);
            lstAccount.Name = "lstAccount";
            lstAccount.Size = new Size(1052, 383);
            lstAccount.TabIndex = 22;
            lstAccount.UseCompatibleStateImageBehavior = false;
            lstAccount.View = View.Details;
            lstAccount.SelectedIndexChanged += lstAccount_SelectedIndexChanged;
            // 
            // clnSTT
            // 
            clnSTT.Text = "STT";
            clnSTT.Width = 200;
            // 
            // clnUsername
            // 
            clnUsername.Text = "Username";
            clnUsername.Width = 200;
            // 
            // clnPassword
            // 
            clnPassword.Text = "Password";
            clnPassword.Width = 200;
            // 
            // clnName
            // 
            clnName.Text = "Name";
            clnName.Width = 200;
            // 
            // clnAccType
            // 
            clnAccType.Text = "AccType";
            clnAccType.Width = 200;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(txtName);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(366, 179);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(774, 50);
            panel3.TabIndex = 21;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Location = new Point(51, 11);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(315, 27);
            txtName.TabIndex = 13;
            txtName.Text = "Nhập name";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.iconSearch;
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(16, 11);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtUsername);
            panel2.Controls.Add(pictureBoxiconSearch);
            panel2.Location = new Point(366, 86);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(774, 50);
            panel2.TabIndex = 20;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Location = new Point(51, 11);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(315, 27);
            txtUsername.TabIndex = 13;
            txtUsername.Text = "Nhập username";
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // pictureBoxiconSearch
            // 
            pictureBoxiconSearch.Image = Properties.Resources.iconSearch;
            pictureBoxiconSearch.InitialImage = null;
            pictureBoxiconSearch.Location = new Point(16, 11);
            pictureBoxiconSearch.Margin = new Padding(3, 2, 3, 2);
            pictureBoxiconSearch.Name = "pictureBoxiconSearch";
            pictureBoxiconSearch.Size = new Size(29, 27);
            pictureBoxiconSearch.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxiconSearch.TabIndex = 5;
            pictureBoxiconSearch.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(824, 248);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 19;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(34, 34, 34);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(1431, 214);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(162, 59);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "XÓA";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(34, 34, 34);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(1612, 214);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(162, 59);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "CẬP NHẬT";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1430, 164);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(163, 33);
            comboBox1.TabIndex = 27;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(34, 34, 34);
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(1262, 214);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(162, 59);
            btnCreate.TabIndex = 28;
            btnCreate.Text = "TẠO";
            btnCreate.UseVisualStyleBackColor = false;
            // 
            // lblAccountType
            // 
            lblAccountType.AutoSize = true;
            lblAccountType.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblAccountType.Location = new Point(1431, 115);
            lblAccountType.Name = "lblAccountType";
            lblAccountType.Size = new Size(146, 30);
            lblAccountType.TabIndex = 29;
            lblAccountType.Text = "Loại tài khoản";
            // 
            // formManageAccount
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1799, 792);
            Controls.Add(lblAccountType);
            Controls.Add(btnCreate);
            Controls.Add(comboBox1);
            Controls.Add(lstAccount);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(Navbar);
            Margin = new Padding(2);
            Name = "formManageAccount";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Homepage";
            Load += formManagement_Load;
            Navbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Home.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxiconSearch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        /*private List<Panel> navItems;
        private List<Button> navButtons ;*/
        private Panel Navbar;
        private Panel panel1;
        private Button btnHome;
        private Panel Home;
        private PictureBox pictureBox1;
        private PictureBox pictureBoxHome;
        private Button btnHomee;
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
        private ComboBox comboBox1;
        private Button button1;
        private Label lblAccountType;
        private ColumnHeader clnAccType;
    }
}