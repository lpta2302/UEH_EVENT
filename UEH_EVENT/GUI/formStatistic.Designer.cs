namespace UEH_EVENT.GUI
{
    partial class formStatistic
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
            cboProperties = new ComboBox();
            lblProperty = new Label();
            btnStats = new Button();
            lblTo = new Label();
            txtUpperBound = new TextBox();
            txtLowerBound = new TextBox();
            rdoSearchRange = new RadioButton();
            txtThreshold = new TextBox();
            cboFilter = new ComboBox();
            rdoSearchThreshold = new RadioButton();
            txtSearchKeyword = new TextBox();
            lblSearchKeyword = new Label();
            btnExit = new Button();
            dgvSearchResults = new DataGridView();
            cboSearch = new ComboBox();
            btnSearch = new Button();
            lblSearch = new Label();
            chkSearchExact = new CheckBox();
            Navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSearchResults).BeginInit();
            SuspendLayout();
            // 
            // Navbar
            // 
            Navbar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Navbar.BackColor = Color.FromArgb(34, 34, 34);
            Navbar.Controls.Add(pictureBoxLogo);
            Navbar.Location = new Point(-3, 1);
            Navbar.Margin = new Padding(2);
            Navbar.Name = "Navbar";
            Navbar.Size = new Size(234, 490);
            Navbar.TabIndex = 1;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.Logo_Update_27_3;
            pictureBoxLogo.Location = new Point(0, 0);
            pictureBoxLogo.Margin = new Padding(2);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(235, 79);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 14;
            pictureBoxLogo.TabStop = false;
            // 
            // cboProperties
            // 
            cboProperties.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboProperties.FormattingEnabled = true;
            cboProperties.Location = new Point(371, 70);
            cboProperties.Name = "cboProperties";
            cboProperties.Size = new Size(280, 23);
            cboProperties.TabIndex = 35;
            cboProperties.SelectedIndexChanged += cboProperties_SelectedIndexChanged;
            // 
            // lblProperty
            // 
            lblProperty.AutoSize = true;
            lblProperty.Font = new Font("Arial", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            lblProperty.Location = new Point(256, 74);
            lblProperty.Name = "lblProperty";
            lblProperty.Size = new Size(79, 16);
            lblProperty.TabIndex = 34;
            lblProperty.Text = "Thuộc tính:";
            // 
            // btnStats
            // 
            btnStats.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnStats.BackColor = Color.FromArgb(34, 34, 34);
            btnStats.FlatStyle = FlatStyle.Flat;
            btnStats.Font = new Font("Arial", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            btnStats.ForeColor = Color.White;
            btnStats.Location = new Point(774, 22);
            btnStats.Name = "btnStats";
            btnStats.Size = new Size(99, 38);
            btnStats.TabIndex = 33;
            btnStats.Text = "THỐNG KÊ";
            btnStats.UseVisualStyleBackColor = false;
            btnStats.Click += btnStats_Click;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Font = new Font("Arial", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            lblTo.Location = new Point(474, 136);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(31, 16);
            lblTo.TabIndex = 32;
            lblTo.Text = "đến";
            // 
            // txtUpperBound
            // 
            txtUpperBound.Enabled = false;
            txtUpperBound.Location = new Point(526, 133);
            txtUpperBound.Multiline = true;
            txtUpperBound.Name = "txtUpperBound";
            txtUpperBound.Size = new Size(58, 26);
            txtUpperBound.TabIndex = 31;
            // 
            // txtLowerBound
            // 
            txtLowerBound.Enabled = false;
            txtLowerBound.Location = new Point(404, 133);
            txtLowerBound.Multiline = true;
            txtLowerBound.Name = "txtLowerBound";
            txtLowerBound.Size = new Size(52, 26);
            txtLowerBound.TabIndex = 30;
            // 
            // rdoSearchRange
            // 
            rdoSearchRange.AutoSize = true;
            rdoSearchRange.Enabled = false;
            rdoSearchRange.Font = new Font("Arial", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            rdoSearchRange.Location = new Point(256, 136);
            rdoSearchRange.Name = "rdoSearchRange";
            rdoSearchRange.Size = new Size(136, 20);
            rdoSearchRange.TabIndex = 29;
            rdoSearchRange.TabStop = true;
            rdoSearchRange.Text = "Tìm theo khoảng:";
            rdoSearchRange.UseVisualStyleBackColor = true;
            // 
            // txtThreshold
            // 
            txtThreshold.Enabled = false;
            txtThreshold.Location = new Point(457, 103);
            txtThreshold.Multiline = true;
            txtThreshold.Name = "txtThreshold";
            txtThreshold.Size = new Size(127, 21);
            txtThreshold.TabIndex = 28;
            // 
            // cboFilter
            // 
            cboFilter.Enabled = false;
            cboFilter.FormattingEnabled = true;
            cboFilter.Location = new Point(404, 103);
            cboFilter.Name = "cboFilter";
            cboFilter.Size = new Size(40, 23);
            cboFilter.TabIndex = 27;
            // 
            // rdoSearchThreshold
            // 
            rdoSearchThreshold.AutoSize = true;
            rdoSearchThreshold.Enabled = false;
            rdoSearchThreshold.Font = new Font("Arial", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            rdoSearchThreshold.Location = new Point(256, 106);
            rdoSearchThreshold.Name = "rdoSearchThreshold";
            rdoSearchThreshold.Size = new Size(139, 20);
            rdoSearchThreshold.TabIndex = 26;
            rdoSearchThreshold.TabStop = true;
            rdoSearchThreshold.Text = "Tìm theo ngưỡng:";
            rdoSearchThreshold.UseVisualStyleBackColor = true;
            // 
            // txtSearchKeyword
            // 
            txtSearchKeyword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearchKeyword.Enabled = false;
            txtSearchKeyword.Location = new Point(371, 46);
            txtSearchKeyword.Name = "txtSearchKeyword";
            txtSearchKeyword.Size = new Size(280, 23);
            txtSearchKeyword.TabIndex = 25;
            // 
            // lblSearchKeyword
            // 
            lblSearchKeyword.AutoSize = true;
            lblSearchKeyword.Font = new Font("Arial", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            lblSearchKeyword.Location = new Point(256, 49);
            lblSearchKeyword.Name = "lblSearchKeyword";
            lblSearchKeyword.Size = new Size(64, 16);
            lblSearchKeyword.TabIndex = 24;
            lblSearchKeyword.Text = "Từ khóa:";
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.White;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Arial", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.FromArgb(192, 0, 0);
            btnExit.Location = new Point(666, 22);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(102, 38);
            btnExit.TabIndex = 23;
            btnExit.Text = "THOÁT";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // dgvSearchResults
            // 
            dgvSearchResults.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSearchResults.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgvSearchResults.BorderStyle = BorderStyle.Fixed3D;
            dgvSearchResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSearchResults.Location = new Point(256, 176);
            dgvSearchResults.Name = "dgvSearchResults";
            dgvSearchResults.RowHeadersWidth = 72;
            dgvSearchResults.RowTemplate.Height = 25;
            dgvSearchResults.Size = new Size(724, 298);
            dgvSearchResults.TabIndex = 22;
            // 
            // cboSearch
            // 
            cboSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboSearch.FormattingEnabled = true;
            cboSearch.Location = new Point(371, 22);
            cboSearch.Name = "cboSearch";
            cboSearch.Size = new Size(280, 23);
            cboSearch.TabIndex = 21;
            cboSearch.SelectedIndexChanged += cboSearch_SelectedIndexChanged;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.BackColor = Color.FromArgb(34, 34, 34);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Arial", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(878, 22);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(102, 38);
            btnSearch.TabIndex = 20;
            btnSearch.Text = "TÌM";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Arial", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            lblSearch.Location = new Point(256, 24);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(110, 16);
            lblSearch.TabIndex = 19;
            lblSearch.Text = "Chọn đối tượng:";
            // 
            // chkSearchExact
            // 
            chkSearchExact.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkSearchExact.AutoSize = true;
            chkSearchExact.Font = new Font("Arial", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            chkSearchExact.Location = new Point(666, 72);
            chkSearchExact.Name = "chkSearchExact";
            chkSearchExact.Size = new Size(101, 20);
            chkSearchExact.TabIndex = 36;
            chkSearchExact.Text = "Nguyên văn";
            chkSearchExact.UseVisualStyleBackColor = true;
            // 
            // formStatistic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1002, 491);
            Controls.Add(chkSearchExact);
            Controls.Add(cboProperties);
            Controls.Add(lblProperty);
            Controls.Add(btnStats);
            Controls.Add(lblTo);
            Controls.Add(txtUpperBound);
            Controls.Add(txtLowerBound);
            Controls.Add(rdoSearchRange);
            Controls.Add(txtThreshold);
            Controls.Add(cboFilter);
            Controls.Add(rdoSearchThreshold);
            Controls.Add(txtSearchKeyword);
            Controls.Add(lblSearchKeyword);
            Controls.Add(btnExit);
            Controls.Add(dgvSearchResults);
            Controls.Add(cboSearch);
            Controls.Add(btnSearch);
            Controls.Add(lblSearch);
            Controls.Add(Navbar);
            Margin = new Padding(2);
            Name = "formStatistic";
            Text = "formStatistic";
            WindowState = FormWindowState.Maximized;
            Load += formStatistic_Load;
            Navbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSearchResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel Navbar;
        private PictureBox pictureBoxLogo;
        private ComboBox cboProperties;
        private Label lblProperty;
        private Button btnStats;
        private Label lblTo;
        private TextBox txtUpperBound;
        private TextBox txtLowerBound;
        private RadioButton rdoSearchRange;
        private TextBox txtThreshold;
        private ComboBox cboFilter;
        private RadioButton rdoSearchThreshold;
        private TextBox txtSearchKeyword;
        private Label lblSearchKeyword;
        private Button btnExit;
        private DataGridView dgvSearchResults;
        private ComboBox cboSearch;
        private Button btnSearch;
        private Label lblSearch;
        private CheckBox chkSearchExact;
    }
}