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
            panelSearch = new Panel();
            txtName = new TextBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            btnDelete = new Button();
            lblClb = new Label();
            btnTest = new Button();
            btnPreview = new Button();
            label1 = new Label();
            Navbar = new Panel();
            pictureBoxLogo = new PictureBox();
            panelTitle = new Panel();
            label4 = new Label();
            panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            Navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // cbbCLB
            // 
            cbbCLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbCLB.FormattingEnabled = true;
            cbbCLB.Location = new Point(787, 215);
            cbbCLB.Margin = new Padding(2, 3, 2, 3);
            cbbCLB.Name = "cbbCLB";
            cbbCLB.Size = new Size(119, 36);
            cbbCLB.TabIndex = 39;
            cbbCLB.SelectedIndexChanged += cbbCLB_SelectedIndexChanged;
            cbbCLB.SelectedValueChanged += cbbCLB_SelectedValueChanged;
            // 
            // lstSight
            // 
            lstSight.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lstSight.BorderStyle = BorderStyle.FixedSingle;
            lstSight.Columns.AddRange(new ColumnHeader[] { clnSTT, clnName, clnCreatedBy, clnCreatedAt, clnNumberOfQuestion });
            lstSight.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstSight.FullRowSelect = true;
            lstSight.Location = new Point(302, 273);
            lstSight.Margin = new Padding(2, 3, 2, 3);
            lstSight.MultiSelect = false;
            lstSight.Name = "lstSight";
            lstSight.Size = new Size(824, 307);
            lstSight.TabIndex = 34;
            lstSight.UseCompatibleStateImageBehavior = false;
            lstSight.View = View.Details;
            lstSight.SelectedIndexChanged += lstAccount_SelectedIndexChanged;
            // 
            // clnSTT
            // 
            clnSTT.Text = "STT";
            clnSTT.Width = 250;
            // 
            // clnName
            // 
            clnName.Text = "Tên Bài TN";
            clnName.TextAlign = HorizontalAlignment.Center;
            clnName.Width = 250;
            // 
            // clnCreatedBy
            // 
            clnCreatedBy.Text = "Tạo Bởi";
            clnCreatedBy.TextAlign = HorizontalAlignment.Center;
            clnCreatedBy.Width = 200;
            // 
            // clnCreatedAt
            // 
            clnCreatedAt.Text = "Ngày Tạo";
            clnCreatedAt.TextAlign = HorizontalAlignment.Center;
            clnCreatedAt.Width = 250;
            // 
            // clnNumberOfQuestion
            // 
            clnNumberOfQuestion.Text = "Số Câu hỏi";
            clnNumberOfQuestion.TextAlign = HorizontalAlignment.Center;
            clnNumberOfQuestion.Width = 250;
            // 
            // panelSearch
            // 
            panelSearch.BackColor = Color.White;
            panelSearch.BorderStyle = BorderStyle.FixedSingle;
            panelSearch.Controls.Add(txtName);
            panelSearch.Controls.Add(pictureBox2);
            panelSearch.Location = new Point(308, 215);
            panelSearch.Margin = new Padding(2, 1, 2, 1);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(324, 41);
            panelSearch.TabIndex = 33;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Location = new Point(37, 9);
            txtName.Margin = new Padding(2, 1, 2, 1);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(229, 21);
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
            pictureBox2.Location = new Point(11, 9);
            pictureBox2.Margin = new Padding(2, 1, 2, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(21, 21);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(808, 219);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 31;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.BackColor = Color.White;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.FromArgb(192, 0, 0);
            btnDelete.Location = new Point(647, 37);
            btnDelete.Margin = new Padding(2, 3, 2, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(159, 77);
            btnDelete.TabIndex = 29;
            btnDelete.Text = "XÓA";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblClb
            // 
            lblClb.AutoSize = true;
            lblClb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblClb.Location = new Point(729, 215);
            lblClb.Margin = new Padding(2, 0, 2, 0);
            lblClb.Name = "lblClb";
            lblClb.Size = new Size(44, 28);
            lblClb.TabIndex = 40;
            lblClb.Text = "CLB";
            // 
            // btnTest
            // 
            btnTest.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTest.BackColor = Color.FromArgb(34, 34, 34);
            btnTest.FlatStyle = FlatStyle.Flat;
            btnTest.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTest.ForeColor = Color.White;
            btnTest.Location = new Point(813, 37);
            btnTest.Margin = new Padding(2, 3, 2, 3);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(159, 77);
            btnTest.TabIndex = 41;
            btnTest.Text = "LÀM THỬ";
            btnTest.UseVisualStyleBackColor = false;
            btnTest.Click += btnTest_Click;
            // 
            // btnPreview
            // 
            btnPreview.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPreview.BackColor = Color.FromArgb(34, 34, 34);
            btnPreview.FlatStyle = FlatStyle.Flat;
            btnPreview.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPreview.ForeColor = Color.White;
            btnPreview.Location = new Point(976, 37);
            btnPreview.Margin = new Padding(2, 3, 2, 3);
            btnPreview.Name = "btnPreview";
            btnPreview.Size = new Size(149, 77);
            btnPreview.TabIndex = 42;
            btnPreview.Text = "XEM";
            btnPreview.UseVisualStyleBackColor = false;
            btnPreview.Click += btnPreview_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(308, 171);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(186, 28);
            label1.TabIndex = 43;
            label1.Text = "Tên Bài Trắc Nghiệm";
            // 
            // Navbar
            // 
            Navbar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Navbar.BackColor = Color.FromArgb(34, 34, 34);
            Navbar.Controls.Add(pictureBoxLogo);
            Navbar.Controls.Add(panelTitle);
            Navbar.Location = new Point(-3, 1);
            Navbar.Margin = new Padding(2);
            Navbar.Name = "Navbar";
            Navbar.Size = new Size(267, 653);
            Navbar.TabIndex = 44;
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
            panelTitle.Location = new Point(535, 2);
            panelTitle.Margin = new Padding(2);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(876, 1281);
            panelTitle.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 20.1428585F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(308, 37);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(279, 40);
            label4.TabIndex = 45;
            label4.Text = "MANAGE SIGHT";
            // 
            // formManageSight
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1145, 655);
            Controls.Add(label4);
            Controls.Add(Navbar);
            Controls.Add(label1);
            Controls.Add(btnPreview);
            Controls.Add(btnTest);
            Controls.Add(lblClb);
            Controls.Add(cbbCLB);
            Controls.Add(lstSight);
            Controls.Add(panelSearch);
            Controls.Add(label2);
            Controls.Add(btnDelete);
            Margin = new Padding(2, 3, 2, 3);
            Name = "formManageSight";
            WindowState = FormWindowState.Maximized;
            Load += formManageSight_Load;
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            Navbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbbCLB;
        private ListView lstSight;
        private ColumnHeader clnSTT;
        private ColumnHeader clnName;
        private Panel panelSearch;
        private TextBox txtName;
        private PictureBox pictureBox2;
        private Label label2;
        private Button btnDelete;
        private ColumnHeader clnCreatedBy;
        private ColumnHeader clnCreatedAt;
        private Label lblClb;
        private ColumnHeader clnNumberOfQuestion;
        private Button btnTest;
        private Button btnPreview;
        private Label label1;
        private Panel Navbar;
        private PictureBox pictureBoxLogo;
        private Panel panelTitle;
        private Label label4;
    }
}