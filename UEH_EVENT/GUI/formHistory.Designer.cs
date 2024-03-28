namespace UEH_EVENT.GUI
{
    partial class formHistory
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
            lstLslbtn = new ListView();
            clhMssv = new ColumnHeader();
            clhTen = new ColumnHeader();
            clhBaiTN = new ColumnHeader();
            clnTotalQuestion = new ColumnHeader();
            clhDiem = new ColumnHeader();
            lstLscndrl = new ListView();
            clhMssv1 = new ColumnHeader();
            clhName = new ColumnHeader();
            clhPoint = new ColumnHeader();
            clhTime = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            clnReason = new ColumnHeader();
            Navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // Navbar
            // 
            Navbar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Navbar.BackColor = Color.FromArgb(34, 34, 34);
            Navbar.Controls.Add(pictureBoxLogo);
            Navbar.Location = new Point(1, 1);
            Navbar.Margin = new Padding(2);
            Navbar.Name = "Navbar";
            Navbar.Size = new Size(271, 1025);
            Navbar.TabIndex = 46;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.Logo_Update_27_3;
            pictureBoxLogo.Location = new Point(0, 2);
            pictureBoxLogo.Margin = new Padding(2);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(269, 106);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 47;
            pictureBoxLogo.TabStop = false;
            // 
            // lstLslbtn
            // 
            lstLslbtn.Columns.AddRange(new ColumnHeader[] { clhMssv, clhTen, clhBaiTN, clnTotalQuestion, clhDiem });
            lstLslbtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstLslbtn.Location = new Point(328, 163);
            lstLslbtn.Name = "lstLslbtn";
            lstLslbtn.Size = new Size(926, 392);
            lstLslbtn.TabIndex = 47;
            lstLslbtn.UseCompatibleStateImageBehavior = false;
            lstLslbtn.View = View.Details;
            lstLslbtn.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // clhMssv
            // 
            clhMssv.Text = "MSSV";
            clhMssv.Width = 200;
            // 
            // clhTen
            // 
            clhTen.Text = "Họ và Tên";
            clhTen.Width = 200;
            // 
            // clhBaiTN
            // 
            clhBaiTN.Text = "Tên Bài TN";
            clhBaiTN.Width = 200;
            // 
            // clnTotalQuestion
            // 
            clnTotalQuestion.Text = "Tổng số câu";
            clnTotalQuestion.TextAlign = HorizontalAlignment.Center;
            clnTotalQuestion.Width = 150;
            // 
            // clhDiem
            // 
            clhDiem.Text = "Số câu đúng";
            clhDiem.TextAlign = HorizontalAlignment.Center;
            clhDiem.Width = 150;
            // 
            // lstLscndrl
            // 
            lstLscndrl.Columns.AddRange(new ColumnHeader[] { clhMssv1, clhName, clhPoint, clhTime, clnReason });
            lstLscndrl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstLscndrl.Location = new Point(329, 641);
            lstLscndrl.Name = "lstLscndrl";
            lstLscndrl.Size = new Size(925, 392);
            lstLscndrl.TabIndex = 48;
            lstLscndrl.UseCompatibleStateImageBehavior = false;
            lstLscndrl.View = View.Details;
            // 
            // clhMssv1
            // 
            clhMssv1.Text = "MSSV";
            clhMssv1.Width = 150;
            // 
            // clhName
            // 
            clhName.Text = "Họ và Tên";
            clhName.Width = 200;
            // 
            // clhPoint
            // 
            clhPoint.Text = "Điểm";
            clhPoint.TextAlign = HorizontalAlignment.Center;
            clhPoint.Width = 120;
            // 
            // clhTime
            // 
            clhTime.Text = "Ngày Cập Nhật";
            clhTime.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(328, 123);
            label1.Name = "label1";
            label1.Size = new Size(274, 28);
            label1.TabIndex = 49;
            label1.Text = "Lịch sử làm bài trắc nghiệm";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(328, 601);
            label2.Name = "label2";
            label2.Size = new Size(370, 28);
            label2.TabIndex = 50;
            label2.Text = "Lịch sử được cập nhật điểm rèn luyện";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(328, 47);
            label3.Name = "label3";
            label3.Size = new Size(302, 38);
            label3.TabIndex = 51;
            label3.Text = "LỊCH SỬ HOẠT ĐỘNG";
            // 
            // clnReason
            // 
            clnReason.Text = "Lí do";
            clnReason.Width = 300;
            // 
            // formHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1775, 1026);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstLscndrl);
            Controls.Add(lstLslbtn);
            Controls.Add(Navbar);
            Margin = new Padding(2);
            Name = "formHistory";
            Text = "History";
            WindowState = FormWindowState.Maximized;
            Load += formHistory_Load;
            Navbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Navbar;
        private PictureBox pictureBoxLogo;
        private ListView lstLslbtn;
        private ListView lstLscndrl;
        private Label label1;
        private Label label2;
        private ColumnHeader clhMssv;
        private ColumnHeader clhTen;
        private ColumnHeader clhBaiTN;
        private ColumnHeader clhDiem;
        private ColumnHeader clhMssv1;
        private ColumnHeader clhName;
        private ColumnHeader clhPoint;
        private ColumnHeader clhTime;
        private Label label3;
        private ColumnHeader clnTotalQuestion;
        private ColumnHeader clnReason;
    }
}