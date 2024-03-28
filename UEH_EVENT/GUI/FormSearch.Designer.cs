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
            ((System.ComponentModel.ISupportInitialize)dgvSearchResults).BeginInit();
            SuspendLayout();
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(16, 12);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(116, 20);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Chọn đối tượng:";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(570, 7);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(86, 31);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Tìm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // cboSearch
            // 
            cboSearch.FormattingEnabled = true;
            cboSearch.Location = new Point(130, 7);
            cboSearch.Margin = new Padding(3, 4, 3, 4);
            cboSearch.Name = "cboSearch";
            cboSearch.Size = new Size(154, 28);
            cboSearch.TabIndex = 2;
            cboSearch.SelectedIndexChanged += cboSearch_SelectedIndexChanged;
            // 
            // dgvSearchResults
            // 
            dgvSearchResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSearchResults.Location = new Point(14, 129);
            dgvSearchResults.Margin = new Padding(3, 4, 3, 4);
            dgvSearchResults.Name = "dgvSearchResults";
            dgvSearchResults.RowHeadersWidth = 72;
            dgvSearchResults.RowTemplate.Height = 25;
            dgvSearchResults.Size = new Size(641, 299);
            dgvSearchResults.TabIndex = 3;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(570, 436);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(86, 31);
            btnExit.TabIndex = 4;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblSearchKeyword
            // 
            lblSearchKeyword.AutoSize = true;
            lblSearchKeyword.Location = new Point(64, 51);
            lblSearchKeyword.Name = "lblSearchKeyword";
            lblSearchKeyword.Size = new Size(65, 20);
            lblSearchKeyword.TabIndex = 6;
            lblSearchKeyword.Text = "Từ khóa:";
            // 
            // txtSearchKeyword
            // 
            txtSearchKeyword.Enabled = false;
            txtSearchKeyword.Location = new Point(130, 47);
            txtSearchKeyword.Margin = new Padding(3, 4, 3, 4);
            txtSearchKeyword.Name = "txtSearchKeyword";
            txtSearchKeyword.Size = new Size(154, 27);
            txtSearchKeyword.TabIndex = 7;
            txtSearchKeyword.TextChanged += txtSearchKeyword_TextChanged;
            // 
            // rdoSearchThreshold
            // 
            rdoSearchThreshold.AutoSize = true;
            rdoSearchThreshold.Enabled = false;
            rdoSearchThreshold.Location = new Point(290, 48);
            rdoSearchThreshold.Margin = new Padding(3, 4, 3, 4);
            rdoSearchThreshold.Name = "rdoSearchThreshold";
            rdoSearchThreshold.Size = new Size(148, 24);
            rdoSearchThreshold.TabIndex = 8;
            rdoSearchThreshold.TabStop = true;
            rdoSearchThreshold.Text = "Tìm theo ngưỡng:";
            rdoSearchThreshold.UseVisualStyleBackColor = true;
            // 
            // cboFilter
            // 
            cboFilter.Enabled = false;
            cboFilter.FormattingEnabled = true;
            cboFilter.Location = new Point(434, 45);
            cboFilter.Margin = new Padding(3, 4, 3, 4);
            cboFilter.Name = "cboFilter";
            cboFilter.Size = new Size(45, 28);
            cboFilter.TabIndex = 9;
            // 
            // txtThreshold
            // 
            txtThreshold.Enabled = false;
            txtThreshold.Location = new Point(487, 45);
            txtThreshold.Margin = new Padding(3, 4, 3, 4);
            txtThreshold.Name = "txtThreshold";
            txtThreshold.Size = new Size(75, 27);
            txtThreshold.TabIndex = 10;
            // 
            // rdoSearchRange
            // 
            rdoSearchRange.AutoSize = true;
            rdoSearchRange.Enabled = false;
            rdoSearchRange.Location = new Point(290, 87);
            rdoSearchRange.Margin = new Padding(3, 4, 3, 4);
            rdoSearchRange.Name = "rdoSearchRange";
            rdoSearchRange.Size = new Size(145, 24);
            rdoSearchRange.TabIndex = 11;
            rdoSearchRange.TabStop = true;
            rdoSearchRange.Text = "Tìm theo khoảng:";
            rdoSearchRange.UseVisualStyleBackColor = true;
            // 
            // txtLowerBound
            // 
            txtLowerBound.Enabled = false;
            txtLowerBound.Location = new Point(434, 85);
            txtLowerBound.Margin = new Padding(3, 4, 3, 4);
            txtLowerBound.Name = "txtLowerBound";
            txtLowerBound.Size = new Size(45, 27);
            txtLowerBound.TabIndex = 12;
            // 
            // txtUpperBound
            // 
            txtUpperBound.Enabled = false;
            txtUpperBound.Location = new Point(517, 85);
            txtUpperBound.Margin = new Padding(3, 4, 3, 4);
            txtUpperBound.Name = "txtUpperBound";
            txtUpperBound.Size = new Size(45, 27);
            txtUpperBound.TabIndex = 13;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Location = new Point(483, 91);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(34, 20);
            lblTo.TabIndex = 14;
            lblTo.Text = "đến";
            // 
            // btnStats
            // 
            btnStats.Location = new Point(569, 47);
            btnStats.Margin = new Padding(3, 4, 3, 4);
            btnStats.Name = "btnStats";
            btnStats.Size = new Size(86, 31);
            btnStats.TabIndex = 16;
            btnStats.Text = "Thống kê";
            btnStats.UseVisualStyleBackColor = true;
            btnStats.Click += btnStats_Click;
            // 
            // lblProperty
            // 
            lblProperty.AutoSize = true;
            lblProperty.Location = new Point(290, 12);
            lblProperty.Name = "lblProperty";
            lblProperty.Size = new Size(81, 20);
            lblProperty.TabIndex = 17;
            lblProperty.Text = "Thuộc tính:";
            // 
            // cboProperties
            // 
            cboProperties.FormattingEnabled = true;
            cboProperties.Location = new Point(374, 7);
            cboProperties.Margin = new Padding(3, 4, 3, 4);
            cboProperties.Name = "cboProperties";
            cboProperties.Size = new Size(188, 28);
            cboProperties.TabIndex = 18;
            cboProperties.SelectedIndexChanged += cboProperties_SelectedIndexChanged;
            // 
            // FormSearch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 700);
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
            Margin = new Padding(3, 4, 3, 4);
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
    }
}