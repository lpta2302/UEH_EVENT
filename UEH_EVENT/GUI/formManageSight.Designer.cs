namespace UEH_EVENT.GUI
{
    partial class formManageSight
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
            cbbCLB = new ComboBox();
            lblto = new Label();
            lblfrom = new Label();
            dpTo = new DateTimePicker();
            dpFrom = new DateTimePicker();
            lstSight = new ListView();
            clnSTT = new ColumnHeader();
            clnName = new ColumnHeader();
            clnCreatedBy = new ColumnHeader();
            clnCreatedAt = new ColumnHeader();
            clnNumberOfQuestion = new ColumnHeader();
            panel3 = new Panel();
            txtName = new TextBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            txtUsername = new TextBox();
            pictureBoxiconSearch = new PictureBox();
            label2 = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            Navbar = new Panel();
            pictureBoxHome = new PictureBox();
            pictureBox1 = new PictureBox();
            Home = new Panel();
            btnHomee = new Button();
            panel1 = new Panel();
            lblClb = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxiconSearch).BeginInit();
            Navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Home.SuspendLayout();
            SuspendLayout();
            // 
            // cbbCLB
            // 
            cbbCLB.FormattingEnabled = true;
            cbbCLB.Location = new Point(367, 311);
            cbbCLB.Name = "cbbCLB";
            cbbCLB.Size = new Size(163, 33);
            cbbCLB.TabIndex = 39;
            cbbCLB.SelectedIndexChanged += cbbCLB_SelectedIndexChanged;
            // 
            // lblto
            // 
            lblto.AutoSize = true;
            lblto.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblto.Location = new Point(1497, 81);
            lblto.Name = "lblto";
            lblto.Size = new Size(33, 30);
            lblto.TabIndex = 38;
            lblto.Text = "to";
            lblto.Click += lblto_Click;
            // 
            // lblfrom
            // 
            lblfrom.AutoSize = true;
            lblfrom.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblfrom.Location = new Point(1254, 81);
            lblfrom.Name = "lblfrom";
            lblfrom.Size = new Size(60, 30);
            lblfrom.TabIndex = 37;
            lblfrom.Text = "from";
            lblfrom.Click += lblfrom_Click;
            // 
            // dpTo
            // 
            dpTo.Location = new Point(1497, 126);
            dpTo.MaxDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dpTo.Name = "dpTo";
            dpTo.Size = new Size(200, 33);
            dpTo.TabIndex = 36;
            dpTo.Value = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // dpFrom
            // 
            dpFrom.Location = new Point(1254, 126);
            dpFrom.Name = "dpFrom";
            dpFrom.Size = new Size(200, 33);
            dpFrom.TabIndex = 35;
            dpFrom.Value = new DateTime(2024, 5, 3, 0, 0, 0, 0);
            // 
            // lstSight
            // 
            lstSight.Columns.AddRange(new ColumnHeader[] { clnSTT, clnName, clnCreatedBy, clnCreatedAt, clnNumberOfQuestion });
            lstSight.Location = new Point(367, 378);
            lstSight.Name = "lstSight";
            lstSight.Size = new Size(1052, 383);
            lstSight.TabIndex = 34;
            lstSight.UseCompatibleStateImageBehavior = false;
            lstSight.View = View.Details;
            lstSight.SelectedIndexChanged += lstAccount_SelectedIndexChanged;
            // 
            // clnSTT
            // 
            clnSTT.Text = "STT";
            clnSTT.Width = 100;
            // 
            // clnName
            // 
            clnName.Text = "Tên Bài TN";
            clnName.Width = 200;
            // 
            // clnCreatedBy
            // 
            clnCreatedBy.Text = "Tạo Bởi";
            clnCreatedBy.Width = 200;
            // 
            // clnCreatedAt
            // 
            clnCreatedAt.Text = "Ngày Tạo";
            clnCreatedAt.Width = 200;
            // 
            // clnNumberOfQuestion
            // 
            clnNumberOfQuestion.Text = "Số Câu hỏi";
            clnNumberOfQuestion.Width = 200;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(txtName);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(367, 181);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(670, 50);
            panel3.TabIndex = 33;
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
            panel2.Location = new Point(367, 88);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(670, 50);
            panel2.TabIndex = 32;
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
            label2.Location = new Point(825, 250);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 31;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(34, 34, 34);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(1288, 216);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(131, 59);
            btnDelete.TabIndex = 29;
            btnDelete.Text = "XÓA";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(34, 34, 34);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(1524, 216);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(131, 59);
            btnUpdate.TabIndex = 30;
            btnUpdate.Text = "CẬP NHẬT";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Navbar
            // 
            Navbar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Navbar.BackColor = Color.FromArgb(34, 34, 34);
            Navbar.Controls.Add(pictureBoxHome);
            Navbar.Controls.Add(pictureBox1);
            Navbar.Controls.Add(Home);
            Navbar.Controls.Add(panel1);
            Navbar.Location = new Point(1, 3);
            Navbar.Margin = new Padding(2);
            Navbar.Name = "Navbar";
            Navbar.Size = new Size(229, 790);
            Navbar.TabIndex = 28;
            // 
            // pictureBoxHome
            // 
            pictureBoxHome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxHome.Image = Properties.Resources.Home;
            pictureBoxHome.Location = new Point(170, -22);
            pictureBoxHome.Margin = new Padding(2);
            pictureBoxHome.Name = "pictureBoxHome";
            pictureBoxHome.Size = new Size(29, 1451);
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
            // lblClb
            // 
            lblClb.AutoSize = true;
            lblClb.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblClb.Location = new Point(367, 259);
            lblClb.Name = "lblClb";
            lblClb.Size = new Size(50, 30);
            lblClb.TabIndex = 40;
            lblClb.Text = "CLB";
            // 
            // formManageSight
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1773, 804);
            Controls.Add(lblClb);
            Controls.Add(cbbCLB);
            Controls.Add(lblto);
            Controls.Add(lblfrom);
            Controls.Add(dpTo);
            Controls.Add(dpFrom);
            Controls.Add(lstSight);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(Navbar);
            Name = "formManageSight";
            Load += formManageSight_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxiconSearch).EndInit();
            Navbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Home.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbbCLB;
        private Label lblto;
        private Label lblfrom;
        private DateTimePicker dpTo;
        private DateTimePicker dpFrom;
        private ListView lstSight;
        private ColumnHeader clnSTT;
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
        private Panel Navbar;
        private PictureBox pictureBoxHome;
        private PictureBox pictureBox1;
        private Panel Home;
        private Button btnHomee;
        private Panel panel1;
        private ColumnHeader clnCreatedBy;
        private ColumnHeader clnCreatedAt;
        private Label lblClb;
        private ColumnHeader clnNumberOfQuestion;
    }
}