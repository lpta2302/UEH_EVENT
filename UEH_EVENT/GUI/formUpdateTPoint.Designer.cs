namespace UEH_EVENT.GUI
{
    partial class formUpdateTPoint
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
            pictureBoxLogo = new PictureBox();
            panelTitle = new Panel();
            label1 = new Label();
            btnSearch = new Button();
            pictureBoxiconSearch = new PictureBox();
            panel2 = new Panel();
            txtEnter = new TextBox();
            panelFrame2 = new Panel();
            lstStudent = new ListView();
            clhldStudent = new ColumnHeader();
            clhName = new ColumnHeader();
            clhKhoa = new ColumnHeader();
            clhLop = new ColumnHeader();
            label2 = new Label();
            comboBoxPoint = new ComboBox();
            label4 = new Label();
            btnUpdate = new Button();
            pictureBox1 = new PictureBox();
            panel8 = new Panel();
            txtReason = new TextBox();
            Navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxiconSearch).BeginInit();
            panel2.SuspendLayout();
            panelFrame2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // Navbar
            // 
            Navbar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Navbar.BackColor = Color.FromArgb(34, 34, 34);
            Navbar.Controls.Add(pictureBoxLogo);
            Navbar.Controls.Add(panelTitle);
            Navbar.Location = new Point(1, 0);
            Navbar.Margin = new Padding(2, 2, 2, 2);
            Navbar.Name = "Navbar";
            Navbar.Size = new Size(267, 653);
            Navbar.TabIndex = 1;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.Logo_Update_27_3;
            pictureBoxLogo.Location = new Point(0, 0);
            pictureBoxLogo.Margin = new Padding(2, 2, 2, 2);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(267, 106);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 48;
            pictureBoxLogo.TabStop = false;
            // 
            // panelTitle
            // 
            panelTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelTitle.CausesValidation = false;
            panelTitle.Location = new Point(268, 2);
            panelTitle.Margin = new Padding(2, 2, 2, 2);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(876, 109);
            panelTitle.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(297, 37);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(360, 32);
            label1.TabIndex = 2;
            label1.Text = "UPDATE TRAINING POINT";
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.BackColor = Color.FromArgb(224, 224, 224);
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.Black;
            btnSearch.Location = new Point(966, 105);
            btnSearch.Margin = new Padding(2, 2, 2, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(154, 39);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // pictureBoxiconSearch
            // 
            pictureBoxiconSearch.Image = Properties.Resources.iconSearch;
            pictureBoxiconSearch.InitialImage = null;
            pictureBoxiconSearch.Location = new Point(12, 9);
            pictureBoxiconSearch.Margin = new Padding(2, 2, 2, 2);
            pictureBoxiconSearch.Name = "pictureBoxiconSearch";
            pictureBoxiconSearch.Size = new Size(21, 21);
            pictureBoxiconSearch.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxiconSearch.TabIndex = 5;
            pictureBoxiconSearch.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtEnter);
            panel2.Controls.Add(pictureBoxiconSearch);
            panel2.Location = new Point(297, 106);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(281, 40);
            panel2.TabIndex = 6;
            // 
            // txtEnter
            // 
            txtEnter.BorderStyle = BorderStyle.None;
            txtEnter.Location = new Point(37, 9);
            txtEnter.Margin = new Padding(2, 2, 2, 2);
            txtEnter.Multiline = true;
            txtEnter.Name = "txtEnter";
            txtEnter.Size = new Size(229, 21);
            txtEnter.TabIndex = 13;
            txtEnter.Text = "  Nhập tên hoặc mã số sinh viên";
            txtEnter.MouseEnter += txtEnter_MouseEnter;
            // 
            // panelFrame2
            // 
            panelFrame2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelFrame2.BackColor = Color.White;
            panelFrame2.Controls.Add(lstStudent);
            panelFrame2.Controls.Add(label2);
            panelFrame2.Location = new Point(297, 215);
            panelFrame2.Margin = new Padding(2, 2, 2, 2);
            panelFrame2.Name = "panelFrame2";
            panelFrame2.Size = new Size(823, 144);
            panelFrame2.TabIndex = 12;
            // 
            // lstStudent
            // 
            lstStudent.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lstStudent.Columns.AddRange(new ColumnHeader[] { clhldStudent, clhName, clhKhoa, clhLop });
            lstStudent.Font = new Font("Arial", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            lstStudent.FullRowSelect = true;
            lstStudent.Location = new Point(2, 2);
            lstStudent.Margin = new Padding(2, 2, 2, 2);
            lstStudent.Name = "lstStudent";
            lstStudent.Size = new Size(820, 141);
            lstStudent.TabIndex = 12;
            lstStudent.UseCompatibleStateImageBehavior = false;
            lstStudent.View = View.Details;
            lstStudent.SelectedIndexChanged += lstStudent_SelectedIndexChanged;
            // 
            // clhldStudent
            // 
            clhldStudent.Text = "MSSV";
            clhldStudent.Width = 400;
            // 
            // clhName
            // 
            clhName.Text = "Họ và Tên";
            clhName.Width = 400;
            // 
            // clhKhoa
            // 
            clhKhoa.Text = "Khóa";
            clhKhoa.Width = 200;
            // 
            // clhLop
            // 
            clhLop.Text = "Lớp";
            clhLop.Width = 240;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(675, 8);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 19);
            label2.TabIndex = 11;
            // 
            // comboBoxPoint
            // 
            comboBoxPoint.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxPoint.FormattingEnabled = true;
            comboBoxPoint.Items.AddRange(new object[] { "1", "2" });
            comboBoxPoint.Location = new Point(966, 168);
            comboBoxPoint.Margin = new Padding(2, 2, 2, 2);
            comboBoxPoint.Name = "comboBoxPoint";
            comboBoxPoint.Size = new Size(155, 28);
            comboBoxPoint.TabIndex = 13;
            comboBoxPoint.SelectedIndexChanged += comboBoxReason_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(757, 363);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 19);
            label4.TabIndex = 10;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdate.BackColor = Color.FromArgb(34, 34, 34);
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(966, 37);
            btnUpdate.Margin = new Padding(2, 2, 2, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(154, 39);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackgroundImage = Properties.Resources.UEH;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(297, 363);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(823, 270);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel8.BackColor = Color.White;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(txtReason);
            panel8.Location = new Point(594, 106);
            panel8.Margin = new Padding(2, 2, 2, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(353, 40);
            panel8.TabIndex = 15;
            // 
            // txtReason
            // 
            txtReason.BorderStyle = BorderStyle.None;
            txtReason.Location = new Point(9, 7);
            txtReason.Margin = new Padding(2, 2, 2, 2);
            txtReason.Multiline = true;
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(343, 31);
            txtReason.TabIndex = 13;
            txtReason.Text = "Lý do";
            // 
            // formUpdateTPoint
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1145, 653);
            Controls.Add(panel8);
            Controls.Add(btnUpdate);
            Controls.Add(panelFrame2);
            Controls.Add(comboBoxPoint);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(btnSearch);
            Controls.Add(label1);
            Controls.Add(Navbar);
            Controls.Add(pictureBox1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "formUpdateTPoint";
            Text = "formUpdateTPoint";
            WindowState = FormWindowState.Maximized;
            Load += formUpdateTPoint_Load;
            Navbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxiconSearch).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelFrame2.ResumeLayout(false);
            panelFrame2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Navbar;
        private Label label1;
        private Panel panelTitle;
        private Button btnSearch;
        private PictureBox pictureBoxiconSearch;
        private Panel panel2;
        private Panel panelFrame2;
        private Label label2;
        private Label label4;
        private ComboBox comboBoxPoint;
        private TextBox txtEnter;
        private Button btnUpdate;
        private PictureBox pictureBox1;
        private Panel panel8;
        private TextBox txtReason;
        private ListView lstStudent;
        private ColumnHeader clhldStudent;
        private ColumnHeader clhName;
        private ColumnHeader clhKhoa;
        private ColumnHeader clhLop;
        private PictureBox pictureBoxLogo;
    }
}