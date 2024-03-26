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
            lstSight = new ListView();
            clnSTT = new ColumnHeader();
            clnName = new ColumnHeader();
            clnCreatedBy = new ColumnHeader();
            clnCreatedAt = new ColumnHeader();
            clnNumberOfQuestion = new ColumnHeader();
            panel3 = new Panel();
            txtName = new TextBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            btnDelete = new Button();
            Navbar = new Panel();
            pictureBoxHome = new PictureBox();
            pictureBox1 = new PictureBox();
            Home = new Panel();
            btnHomee = new Button();
            panel1 = new Panel();
            lblClb = new Label();
            btnTest = new Button();
            btnPreview = new Button();
            label1 = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            Navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Home.SuspendLayout();
            SuspendLayout();
            // 
            // cbbCLB
            // 
            cbbCLB.FormattingEnabled = true;
            cbbCLB.Location = new Point(536, 139);
            cbbCLB.Margin = new Padding(2);
            cbbCLB.Name = "cbbCLB";
            cbbCLB.Size = new Size(105, 23);
            cbbCLB.TabIndex = 39;
            cbbCLB.SelectedIndexChanged += cbbCLB_SelectedIndexChanged;
            cbbCLB.SelectedValueChanged += cbbCLB_SelectedValueChanged;
            // 
            // lstSight
            // 
            lstSight.Columns.AddRange(new ColumnHeader[] { clnSTT, clnName, clnCreatedBy, clnCreatedAt, clnNumberOfQuestion });
            lstSight.Location = new Point(190, 226);
            lstSight.Margin = new Padding(2);
            lstSight.MultiSelect = false;
            lstSight.Name = "lstSight";
            lstSight.Size = new Size(905, 231);
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
            panel3.Location = new Point(190, 140);
            panel3.Margin = new Padding(2, 1, 2, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(245, 31);
            panel3.TabIndex = 33;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Location = new Point(32, 7);
            txtName.Margin = new Padding(2, 1, 2, 1);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 16);
            txtName.TabIndex = 13;
            txtName.Text = "Nhập tên bài trắc nghiệm cần tìm";
            txtName.Click += gotFocus;
            txtName.GotFocus += gotFocus;
            txtName.KeyDown += txtName_KeyDown;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.iconSearch;
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(10, 7);
            pictureBox2.Margin = new Padding(2, 1, 2, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(18, 16);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(481, 142);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 31;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(199, 0, 0);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(1012, 174);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(83, 35);
            btnDelete.TabIndex = 29;
            btnDelete.Text = "XÓA";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // Navbar
            // 
            Navbar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Navbar.BackColor = Color.FromArgb(34, 34, 34);
            Navbar.Controls.Add(pictureBoxHome);
            Navbar.Controls.Add(pictureBox1);
            Navbar.Controls.Add(Home);
            Navbar.Controls.Add(panel1);
            Navbar.Location = new Point(1, 2);
            Navbar.Margin = new Padding(1);
            Navbar.Name = "Navbar";
            Navbar.Size = new Size(146, 631);
            Navbar.TabIndex = 28;
            // 
            // pictureBoxHome
            // 
            pictureBoxHome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxHome.Image = Properties.Resources.Home;
            pictureBoxHome.Location = new Point(108, -13);
            pictureBoxHome.Margin = new Padding(1);
            pictureBoxHome.Name = "pictureBoxHome";
            pictureBoxHome.Size = new Size(18, 1028);
            pictureBoxHome.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxHome.TabIndex = 1;
            pictureBoxHome.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Logo_396x163;
            pictureBox1.Enabled = false;
            pictureBox1.Location = new Point(0, 1);
            pictureBox1.Margin = new Padding(1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 56);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Home
            // 
            Home.Controls.Add(btnHomee);
            Home.Location = new Point(0, 58);
            Home.Margin = new Padding(1);
            Home.Name = "Home";
            Home.Size = new Size(146, 26);
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
            btnHomee.Location = new Point(0, -3);
            btnHomee.Margin = new Padding(1);
            btnHomee.Name = "btnHomee";
            btnHomee.Padding = new Padding(7, 0, 0, 0);
            btnHomee.Size = new Size(152, 32);
            btnHomee.TabIndex = 10;
            btnHomee.Text = "  HOME";
            btnHomee.TextAlign = ContentAlignment.MiddleLeft;
            btnHomee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHomee.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new Size(73, 34);
            panel1.TabIndex = 13;
            // 
            // lblClb
            // 
            lblClb.AutoSize = true;
            lblClb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblClb.Location = new Point(536, 112);
            lblClb.Margin = new Padding(2, 0, 2, 0);
            lblClb.Name = "lblClb";
            lblClb.Size = new Size(37, 21);
            lblClb.TabIndex = 40;
            lblClb.Text = "CLB";
            // 
            // btnTest
            // 
            btnTest.BackColor = Color.FromArgb(34, 34, 34);
            btnTest.FlatStyle = FlatStyle.Flat;
            btnTest.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTest.ForeColor = Color.White;
            btnTest.Location = new Point(900, 174);
            btnTest.Margin = new Padding(2);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(83, 35);
            btnTest.TabIndex = 41;
            btnTest.Text = "LÀM THỬ";
            btnTest.UseVisualStyleBackColor = false;
            // 
            // btnPreview
            // 
            btnPreview.BackColor = Color.FromArgb(34, 34, 34);
            btnPreview.FlatStyle = FlatStyle.Flat;
            btnPreview.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPreview.ForeColor = Color.White;
            btnPreview.Location = new Point(788, 174);
            btnPreview.Margin = new Padding(2);
            btnPreview.Name = "btnPreview";
            btnPreview.Size = new Size(83, 35);
            btnPreview.TabIndex = 42;
            btnPreview.Text = "XEM";
            btnPreview.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(190, 112);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(150, 21);
            label1.TabIndex = 43;
            label1.Text = "Tên Bài Trắc Nghiệm";
            // 
            // formManageSight
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1830, 639);
            Controls.Add(label1);
            Controls.Add(btnPreview);
            Controls.Add(btnTest);
            Controls.Add(lblClb);
            Controls.Add(cbbCLB);
            Controls.Add(lstSight);
            Controls.Add(panel3);
            Controls.Add(label2);
            Controls.Add(btnDelete);
            Controls.Add(Navbar);
            Margin = new Padding(2);
            Name = "formManageSight";
            WindowState = FormWindowState.Maximized;
            Load += formManageSight_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            Navbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Home.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbbCLB;
        private ListView lstSight;
        private ColumnHeader clnSTT;
        private ColumnHeader clnName;
        private Panel panel3;
        private TextBox txtName;
        private PictureBox pictureBox2;
        private Label label2;
        private Button btnDelete;
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
        private Button btnTest;
        private Button btnPreview;
        private Label label1;
    }
}