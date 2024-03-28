namespace UEH_EVENT.GUI
{
    partial class FormSearch
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
            lblSearch = new Label();
            btnSearch = new Button();
            cboSearch = new ComboBox();
            dgvSearchResults = new DataGridView();
            btnExit = new Button();
            lblSearchKeyword = new Label();
            txtSearchKeyword = new TextBox();
            rdoSearchThreshold = new RadioButton();
            cboFilter = new ComboBox();
            txtThreshold = new TextBox();
            rdoSearchRange = new RadioButton();
            txtLowerBound = new TextBox();
            txtUpperBound = new TextBox();
            lblTo = new Label();
            btnStats = new Button();
            lblProperty = new Label();
            cboProperties = new ComboBox();
            chkSearchExact = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvSearchResults).BeginInit();
            SuspendLayout();
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(24, 18);
            lblSearch.Margin = new Padding(5, 0, 5, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(164, 30);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Chọn đối tượng:";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(855, 10);
            btnSearch.Margin = new Padding(5, 6, 5, 6);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(129, 46);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Tìm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // cboSearch
            // 
            cboSearch.FormattingEnabled = true;
            cboSearch.Location = new Point(195, 10);
            cboSearch.Margin = new Padding(5, 6, 5, 6);
            cboSearch.Name = "cboSearch";
            cboSearch.Size = new Size(229, 38);
            cboSearch.TabIndex = 2;
            cboSearch.SelectedIndexChanged += cboSearch_SelectedIndexChanged;
            // 
            // dgvSearchResults
            // 
            dgvSearchResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSearchResults.Location = new Point(21, 194);
            dgvSearchResults.Margin = new Padding(5, 6, 5, 6);
            dgvSearchResults.Name = "dgvSearchResults";
            dgvSearchResults.RowHeadersWidth = 72;
            dgvSearchResults.RowTemplate.Height = 25;
            dgvSearchResults.Size = new Size(962, 448);
            dgvSearchResults.TabIndex = 3;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(855, 654);
            btnExit.Margin = new Padding(5, 6, 5, 6);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(129, 46);
            btnExit.TabIndex = 4;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblSearchKeyword
            // 
            lblSearchKeyword.AutoSize = true;
            lblSearchKeyword.Location = new Point(96, 76);
            lblSearchKeyword.Margin = new Padding(5, 0, 5, 0);
            lblSearchKeyword.Name = "lblSearchKeyword";
            lblSearchKeyword.Size = new Size(92, 30);
            lblSearchKeyword.TabIndex = 6;
            lblSearchKeyword.Text = "Từ khóa:";
            // 
            // txtSearchKeyword
            // 
            txtSearchKeyword.Enabled = false;
            txtSearchKeyword.Location = new Point(195, 70);
            txtSearchKeyword.Margin = new Padding(5, 6, 5, 6);
            txtSearchKeyword.Name = "txtSearchKeyword";
            txtSearchKeyword.Size = new Size(229, 35);
            txtSearchKeyword.TabIndex = 7;
            // 
            // rdoSearchThreshold
            // 
            rdoSearchThreshold.AutoSize = true;
            rdoSearchThreshold.Enabled = false;
            rdoSearchThreshold.Location = new Point(435, 72);
            rdoSearchThreshold.Margin = new Padding(5, 6, 5, 6);
            rdoSearchThreshold.Name = "rdoSearchThreshold";
            rdoSearchThreshold.Size = new Size(204, 34);
            rdoSearchThreshold.TabIndex = 8;
            rdoSearchThreshold.TabStop = true;
            rdoSearchThreshold.Text = "Tìm theo ngưỡng:";
            rdoSearchThreshold.UseVisualStyleBackColor = true;
            // 
            // cboFilter
            // 
            cboFilter.Enabled = false;
            cboFilter.FormattingEnabled = true;
            cboFilter.Location = new Point(651, 68);
            cboFilter.Margin = new Padding(5, 6, 5, 6);
            cboFilter.Name = "cboFilter";
            cboFilter.Size = new Size(66, 38);
            cboFilter.TabIndex = 9;
            // 
            // txtThreshold
            // 
            txtThreshold.Enabled = false;
            txtThreshold.Location = new Point(730, 68);
            txtThreshold.Margin = new Padding(5, 6, 5, 6);
            txtThreshold.Name = "txtThreshold";
            txtThreshold.Size = new Size(110, 35);
            txtThreshold.TabIndex = 10;
            // 
            // rdoSearchRange
            // 
            rdoSearchRange.AutoSize = true;
            rdoSearchRange.Enabled = false;
            rdoSearchRange.Location = new Point(435, 130);
            rdoSearchRange.Margin = new Padding(5, 6, 5, 6);
            rdoSearchRange.Name = "rdoSearchRange";
            rdoSearchRange.Size = new Size(200, 34);
            rdoSearchRange.TabIndex = 11;
            rdoSearchRange.TabStop = true;
            rdoSearchRange.Text = "Tìm theo khoảng:";
            rdoSearchRange.UseVisualStyleBackColor = true;
            // 
            // txtLowerBound
            // 
            txtLowerBound.Enabled = false;
            txtLowerBound.Location = new Point(651, 128);
            txtLowerBound.Margin = new Padding(5, 6, 5, 6);
            txtLowerBound.Name = "txtLowerBound";
            txtLowerBound.Size = new Size(66, 35);
            txtLowerBound.TabIndex = 12;
            // 
            // txtUpperBound
            // 
            txtUpperBound.Enabled = false;
            txtUpperBound.Location = new Point(775, 128);
            txtUpperBound.Margin = new Padding(5, 6, 5, 6);
            txtUpperBound.Name = "txtUpperBound";
            txtUpperBound.Size = new Size(66, 35);
            txtUpperBound.TabIndex = 13;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Location = new Point(725, 136);
            lblTo.Margin = new Padding(5, 0, 5, 0);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(48, 30);
            lblTo.TabIndex = 14;
            lblTo.Text = "đến";
            // 
            // btnStats
            // 
            btnStats.Location = new Point(854, 70);
            btnStats.Margin = new Padding(5, 6, 5, 6);
            btnStats.Name = "btnStats";
            btnStats.Size = new Size(129, 46);
            btnStats.TabIndex = 16;
            btnStats.Text = "Thống kê";
            btnStats.UseVisualStyleBackColor = true;
            btnStats.Click += btnStats_Click;
            // 
            // lblProperty
            // 
            lblProperty.AutoSize = true;
            lblProperty.Location = new Point(435, 18);
            lblProperty.Margin = new Padding(5, 0, 5, 0);
            lblProperty.Name = "lblProperty";
            lblProperty.Size = new Size(117, 30);
            lblProperty.TabIndex = 17;
            lblProperty.Text = "Thuộc tính:";
            // 
            // cboProperties
            // 
            cboProperties.FormattingEnabled = true;
            cboProperties.Location = new Point(561, 10);
            cboProperties.Margin = new Padding(5, 6, 5, 6);
            cboProperties.Name = "cboProperties";
            cboProperties.Size = new Size(280, 38);
            cboProperties.TabIndex = 18;
            cboProperties.SelectedIndexChanged += cboProperties_SelectedIndexChanged;
            // 
            // chkSearchExact
            // 
            chkSearchExact.AutoSize = true;
            chkSearchExact.Enabled = false;
            chkSearchExact.Location = new Point(158, 66);
            chkSearchExact.Name = "chkSearchExact";
            chkSearchExact.Size = new Size(90, 19);
            chkSearchExact.TabIndex = 19;
            chkSearchExact.Text = "Nguyên văn";
            chkSearchExact.UseVisualStyleBackColor = true;
            // 
            // FormSearch
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 362);
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
            Margin = new Padding(5, 6, 5, 6);
            Name = "FormSearch";
            Text = "Tìm kiếm";
            Load += FormSearch_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSearchResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSearch;
        private Button btnSearch;
        private ComboBox cboSearch;
        private DataGridView dgvSearchResults;
        private Button btnExit;
        private Label lblSearchKeyword;
        private TextBox txtSearchKeyword;
        private RadioButton rdoSearchThreshold;
        private ComboBox cboFilter;
        private TextBox txtThreshold;
        private RadioButton rdoSearchRange;
        private TextBox txtLowerBound;
        private TextBox txtUpperBound;
        private Label lblTo;
        private Button btnStats;
        private Label lblProperty;
        private ComboBox cboProperties;
        private CheckBox chkSearchExact;
    }
}