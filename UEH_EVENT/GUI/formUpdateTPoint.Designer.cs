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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formUpdateTPoint));
            Navbar = new Panel();
            panelTitle = new Panel();
            pictureBoxLogo = new PictureBox();
            Home = new Panel();
            btnHomee = new Button();
            panel1 = new Panel();
            label1 = new Label();
            btnSearch = new Button();
            pictureBoxiconSearch = new PictureBox();
            panel2 = new Panel();
            txtEnter = new TextBox();
            panelFrame = new Panel();
            lblReason = new Label();
            lblName = new Label();
            lblPoint = new Label();
            lblMSSV = new Label();
            panelFrame2 = new Panel();
            label2 = new Label();
            comboBoxReason = new ComboBox();
            label4 = new Label();
            btnUpdate = new Button();
            pictureBox1 = new PictureBox();
            panel8 = new Panel();
            textBox8 = new TextBox();
            Navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            Home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxiconSearch).BeginInit();
            panel2.SuspendLayout();
            panelFrame.SuspendLayout();
            panelFrame2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // Navbar
            // 
            Navbar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Navbar.BackColor = Color.FromArgb(34, 34, 34);
            Navbar.Controls.Add(panelTitle);
            Navbar.Controls.Add(pictureBoxLogo);
            Navbar.Controls.Add(Home);
            Navbar.Controls.Add(panel1);
            Navbar.Location = new Point(1, 0);
            Navbar.Name = "Navbar";
            Navbar.Size = new Size(400, 980);
            Navbar.TabIndex = 1;
            // 
            Constants.INavbar.CreateNavbar(this, resources);
            // panelTitle
            // 
            panelTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelTitle.CausesValidation = false;
            panelTitle.Location = new Point(402, 3);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(1314, 163);
            panelTitle.TabIndex = 3;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.Logo_396x163;
            pictureBoxLogo.Location = new Point(0, 0);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(400, 159);
            pictureBoxLogo.TabIndex = 4;
            pictureBoxLogo.TabStop = false;
            pictureBoxLogo.Click += pictureBoxLogo_Click;
            // 
            // Home
            // 
            Home.Controls.Add(btnHomee);
            Home.Location = new Point(0, 168);
            Home.Name = "Home";
            Home.Size = new Size(400, 75);
            Home.TabIndex = 7;
            // 
            // btnHomee
            // 
            btnHomee.BackColor = Color.FromArgb(34, 34, 34);
            btnHomee.BackgroundImageLayout = ImageLayout.None;
            btnHomee.FlatStyle = FlatStyle.Flat;
            btnHomee.Font = new Font("Helvetica", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnHomee.ForeColor = Color.White;
            btnHomee.Image = (Image)resources.GetObject("btnHomee.Image");
            btnHomee.ImageAlign = ContentAlignment.MiddleLeft;
            btnHomee.Location = new Point(0, -9);
            btnHomee.Name = "btnHomee";
            btnHomee.Padding = new Padding(20, 0, 0, 0);
            btnHomee.Size = new Size(419, 92);
            btnHomee.TabIndex = 10;
            btnHomee.Text = "  HOME";
            btnHomee.TextAlign = ContentAlignment.MiddleLeft;
            btnHomee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHomee.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(396, 162);
            panel1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Helvetica", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(446, 55);
            label1.Name = "label1";
            label1.Size = new Size(475, 45);
            label1.TabIndex = 2;
            label1.Text = "UPDATE TRAINING POINT";
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.BackColor = Color.FromArgb(224, 224, 224);
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Helvetica", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.Black;
            btnSearch.Location = new Point(1449, 157);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(231, 59);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // pictureBoxiconSearch
            // 
            pictureBoxiconSearch.Image = Properties.Resources.iconSearch;
            pictureBoxiconSearch.InitialImage = null;
            pictureBoxiconSearch.Location = new Point(18, 13);
            pictureBoxiconSearch.Name = "pictureBoxiconSearch";
            pictureBoxiconSearch.Size = new Size(32, 32);
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
            panel2.Location = new Point(446, 159);
            panel2.Name = "panel2";
            panel2.Size = new Size(420, 59);
            panel2.TabIndex = 6;
            // 
            // txtEnter
            // 
            txtEnter.BorderStyle = BorderStyle.None;
            txtEnter.Location = new Point(56, 13);
            txtEnter.Multiline = true;
            txtEnter.Name = "txtEnter";
            txtEnter.Size = new Size(344, 32);
            txtEnter.TabIndex = 13;
            txtEnter.Text = "  Nhập tên hoặc mã số sinh viên";
            txtEnter.MouseEnter += txtEnter_MouseEnter;
            // 
            // panelFrame
            // 
            panelFrame.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelFrame.BackColor = Color.WhiteSmoke;
            panelFrame.Controls.Add(lblReason);
            panelFrame.Controls.Add(lblName);
            panelFrame.Controls.Add(lblPoint);
            panelFrame.Controls.Add(lblMSSV);
            panelFrame.Location = new Point(446, 316);
            panelFrame.Name = "panelFrame";
            panelFrame.Size = new Size(1234, 50);
            panelFrame.TabIndex = 7;
            // 
            // lblReason
            // 
            lblReason.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblReason.AutoSize = true;
            lblReason.Font = new Font("Helvetica", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            lblReason.Location = new Point(1012, 12);
            lblReason.Name = "lblReason";
            lblReason.Size = new Size(70, 28);
            lblReason.TabIndex = 11;
            lblReason.Text = "Lý do";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Helvetica", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(19, 12);
            lblName.Name = "lblName";
            lblName.Size = new Size(114, 28);
            lblName.TabIndex = 8;
            lblName.Text = "Họ và tên";
            // 
            // lblPoint
            // 
            lblPoint.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPoint.AutoSize = true;
            lblPoint.Font = new Font("Helvetica", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            lblPoint.Location = new Point(757, 12);
            lblPoint.Name = "lblPoint";
            lblPoint.Size = new Size(74, 28);
            lblPoint.TabIndex = 10;
            lblPoint.Text = "Điểm ";
            // 
            // lblMSSV
            // 
            lblMSSV.AutoSize = true;
            lblMSSV.Font = new Font("Helvetica", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            lblMSSV.Location = new Point(380, 12);
            lblMSSV.Name = "lblMSSV";
            lblMSSV.Size = new Size(80, 28);
            lblMSSV.TabIndex = 9;
            lblMSSV.Text = "MSSV";
            // 
            // panelFrame2
            // 
            panelFrame2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelFrame2.BackColor = Color.White;
            panelFrame2.Controls.Add(label2);
            panelFrame2.Location = new Point(446, 372);
            panelFrame2.Name = "panelFrame2";
            panelFrame2.Size = new Size(1234, 63);
            panelFrame2.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Helvetica", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1012, 12);
            label2.Name = "label2";
            label2.Size = new Size(0, 28);
            label2.TabIndex = 11;
            // 
            // comboBoxReason
            // 
            comboBoxReason.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxReason.FormattingEnabled = true;
            comboBoxReason.Items.AddRange(new object[] { "Game", "Quiz" });
            comboBoxReason.Location = new Point(813, 258);
            comboBoxReason.Name = "comboBoxReason";
            comboBoxReason.Size = new Size(53, 38);
            comboBoxReason.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Helvetica", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(1136, 545);
            label4.Name = "label4";
            label4.Size = new Size(0, 28);
            label4.TabIndex = 10;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdate.BackColor = Color.FromArgb(34, 34, 34);
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Helvetica", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(1449, 55);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(231, 59);
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
            pictureBox1.Location = new Point(446, 461);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1234, 489);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel8.BackColor = Color.White;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(textBox8);
            panel8.Location = new Point(891, 159);
            panel8.Name = "panel8";
            panel8.Size = new Size(529, 137);
            panel8.TabIndex = 15;
            // 
            // textBox8
            // 
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Location = new Point(13, 11);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(702, 107);
            textBox8.TabIndex = 13;
            textBox8.Text = "Lý do";
            // 
            // formUpdateTPoint
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1718, 979);
            Controls.Add(panel8);
            Controls.Add(btnUpdate);
            Controls.Add(panelFrame2);
            Controls.Add(comboBoxReason);
            Controls.Add(panelFrame);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(btnSearch);
            Controls.Add(label1);
            Controls.Add(Navbar);
            Controls.Add(pictureBox1);
            Name = "formUpdateTPoint";
            Text = "formUpdateTPoint";
            WindowState = FormWindowState.Maximized;
            Load += formUpdateTPoint_Load;
            Navbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            Home.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxiconSearch).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelFrame.ResumeLayout(false);
            panelFrame.PerformLayout();
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
        private PictureBox pictureBoxLogo;
        private Panel Home;
        private Button btnHomee;
        private Panel panel1;
        private Label label1;
        private Panel panelTitle;
        private Button btnSearch;
        private PictureBox pictureBoxiconSearch;
        private Panel panel2;
        private Panel panelFrame;
        private Label lblName;
        private Label lblMSSV;
        private Label lblPoint;
        private Label lblReason;
        private Panel panelFrame2;
        private Label label2;
        private Label label4;
        private ComboBox comboBoxReason;
        private TextBox txtEnter;
        private Button btnUpdate;
        private PictureBox pictureBox1;
        private Panel panel8;
        private TextBox textBox8;
    }
}