namespace UEH_EVENT.GUI
{
    partial class FormStats
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            lblSightHis = new Label();
            lblSightHisCount = new Label();
            lblSightHisTier1 = new Label();
            lblSightHisTier1Count = new Label();
            lblStudentsCount = new Label();
            lblStudents = new Label();
            lblTPointOver50Count = new Label();
            lblTPointOver50 = new Label();
            lblTPointTier1Count = new Label();
            lblTPointTier1 = new Label();
            lblTPointTier2Count = new Label();
            lblTPointTier2 = new Label();
            lblTPointTier3Count = new Label();
            lblTPointTier3 = new Label();
            lblTPointTier4Count = new Label();
            lblTPointTier4 = new Label();
            lblPlayHisCount = new Label();
            lblPlayHis = new Label();
            lblStudentAccountsCount = new Label();
            lblStudentAccounts = new Label();
            lblAccountsCount = new Label();
            lblAccounts = new Label();
            lblClubAccountsCount = new Label();
            lblClubAccounts = new Label();
            btnClose = new Button();
            tabStats = new TabControl();
            tabPageStatsSearch = new TabPage();
            lblMatchCount = new Label();
            chartStatsSearch = new System.Windows.Forms.DataVisualization.Charting.Chart();
            lblMatch = new Label();
            lblTotal = new Label();
            lblTotalCount = new Label();
            tabPageStatsOther = new TabPage();
            lblTPointHisCount = new Label();
            lblTPointHis = new Label();
            lblTPointPlusOneCount = new Label();
            lblTPointPlusOne = new Label();
            lblTPointPlusTwoCount = new Label();
            lblTPointPlusTwo = new Label();
            lblPlayHisTier5Count = new Label();
            lblPlayHisTier5 = new Label();
            lblPlayHisTier4Count = new Label();
            lblPlayHisTier4 = new Label();
            lblPlayHisTier3Count = new Label();
            lblPlayHisTier3 = new Label();
            lblPlayHisTier2Count = new Label();
            lblPlayHisTier2 = new Label();
            lblPlayHisTier1Count = new Label();
            lblPlayHisTier1 = new Label();
            lblSightHisTier5Count = new Label();
            lblSightHisTier5 = new Label();
            lblSightHisTier4Count = new Label();
            lblSightHisTier4 = new Label();
            lblSightHisTier3Count = new Label();
            lblSightHisTier3 = new Label();
            lblSightHisTier2Count = new Label();
            lblSightHisTier2 = new Label();
            lblSightHisCountClone = new Label();
            lblSightHisClone = new Label();
            lblSightCount = new Label();
            lblSight = new Label();
            chartStatsOther = new System.Windows.Forms.DataVisualization.Charting.Chart();
            cboSelect = new ComboBox();
            lblGameCount = new Label();
            lblGame = new Label();
            lblPlayHisCountClone = new Label();
            lblPlayHisClone = new Label();
            tabStats.SuspendLayout();
            tabPageStatsSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartStatsSearch).BeginInit();
            tabPageStatsOther.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartStatsOther).BeginInit();
            SuspendLayout();
            // 
            // lblSightHis
            // 
            lblSightHis.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblSightHis.AutoSize = true;
            lblSightHis.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSightHis.Location = new Point(41, 50);
            lblSightHis.Name = "lblSightHis";
            lblSightHis.Size = new Size(171, 21);
            lblSightHis.TabIndex = 0;
            lblSightHis.Text = "Tổng số lượt làm bài:";
            lblSightHis.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSightHisCount
            // 
            lblSightHisCount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblSightHisCount.AutoSize = true;
            lblSightHisCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSightHisCount.Location = new Point(243, 50);
            lblSightHisCount.Name = "lblSightHisCount";
            lblSightHisCount.Size = new Size(19, 21);
            lblSightHisCount.TabIndex = 1;
            lblSightHisCount.Text = "0";
            lblSightHisCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSightHisTier1
            // 
            lblSightHisTier1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblSightHisTier1.AutoSize = true;
            lblSightHisTier1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSightHisTier1.Location = new Point(41, 80);
            lblSightHisTier1.Name = "lblSightHisTier1";
            lblSightHisTier1.Size = new Size(111, 21);
            lblSightHisTier1.TabIndex = 2;
            lblSightHisTier1.Text = "81 - 100 điểm:";
            lblSightHisTier1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSightHisTier1Count
            // 
            lblSightHisTier1Count.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblSightHisTier1Count.AutoSize = true;
            lblSightHisTier1Count.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSightHisTier1Count.Location = new Point(243, 80);
            lblSightHisTier1Count.Name = "lblSightHisTier1Count";
            lblSightHisTier1Count.Size = new Size(19, 21);
            lblSightHisTier1Count.TabIndex = 3;
            lblSightHisTier1Count.Text = "0";
            lblSightHisTier1Count.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStudentsCount
            // 
            lblStudentsCount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblStudentsCount.AutoSize = true;
            lblStudentsCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStudentsCount.Location = new Point(243, 49);
            lblStudentsCount.Name = "lblStudentsCount";
            lblStudentsCount.Size = new Size(19, 21);
            lblStudentsCount.TabIndex = 7;
            lblStudentsCount.Text = "0";
            lblStudentsCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStudents
            // 
            lblStudents.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblStudents.AutoSize = true;
            lblStudents.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblStudents.Location = new Point(39, 49);
            lblStudents.Name = "lblStudents";
            lblStudents.Size = new Size(147, 21);
            lblStudents.TabIndex = 6;
            lblStudents.Text = "Tổng số sinh viên:";
            lblStudents.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTPointOver50Count
            // 
            lblTPointOver50Count.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblTPointOver50Count.AutoSize = true;
            lblTPointOver50Count.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTPointOver50Count.Location = new Point(243, 79);
            lblTPointOver50Count.Name = "lblTPointOver50Count";
            lblTPointOver50Count.Size = new Size(19, 21);
            lblTPointOver50Count.TabIndex = 9;
            lblTPointOver50Count.Text = "0";
            lblTPointOver50Count.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTPointOver50
            // 
            lblTPointOver50.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblTPointOver50.AutoSize = true;
            lblTPointOver50.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTPointOver50.Location = new Point(39, 79);
            lblTPointOver50.Name = "lblTPointOver50";
            lblTPointOver50.Size = new Size(173, 21);
            lblTPointOver50.TabIndex = 8;
            lblTPointOver50.Text = "Điểm rèn luyện trên 50:";
            lblTPointOver50.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTPointTier1Count
            // 
            lblTPointTier1Count.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblTPointTier1Count.AutoSize = true;
            lblTPointTier1Count.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTPointTier1Count.Location = new Point(243, 109);
            lblTPointTier1Count.Name = "lblTPointTier1Count";
            lblTPointTier1Count.Size = new Size(19, 21);
            lblTPointTier1Count.TabIndex = 11;
            lblTPointTier1Count.Text = "0";
            lblTPointTier1Count.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTPointTier1
            // 
            lblTPointTier1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblTPointTier1.AutoSize = true;
            lblTPointTier1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTPointTier1.Location = new Point(39, 109);
            lblTPointTier1.Name = "lblTPointTier1";
            lblTPointTier1.Size = new Size(103, 21);
            lblTPointTier1.TabIndex = 10;
            lblTPointTier1.Text = "Loại Xuất sắc:";
            lblTPointTier1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTPointTier2Count
            // 
            lblTPointTier2Count.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblTPointTier2Count.AutoSize = true;
            lblTPointTier2Count.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTPointTier2Count.Location = new Point(243, 139);
            lblTPointTier2Count.Name = "lblTPointTier2Count";
            lblTPointTier2Count.Size = new Size(19, 21);
            lblTPointTier2Count.TabIndex = 13;
            lblTPointTier2Count.Text = "0";
            lblTPointTier2Count.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTPointTier2
            // 
            lblTPointTier2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblTPointTier2.AutoSize = true;
            lblTPointTier2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTPointTier2.Location = new Point(39, 139);
            lblTPointTier2.Name = "lblTPointTier2";
            lblTPointTier2.Size = new Size(68, 21);
            lblTPointTier2.TabIndex = 12;
            lblTPointTier2.Text = "Loại Tốt:";
            lblTPointTier2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTPointTier3Count
            // 
            lblTPointTier3Count.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblTPointTier3Count.AutoSize = true;
            lblTPointTier3Count.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTPointTier3Count.Location = new Point(243, 169);
            lblTPointTier3Count.Name = "lblTPointTier3Count";
            lblTPointTier3Count.Size = new Size(19, 21);
            lblTPointTier3Count.TabIndex = 15;
            lblTPointTier3Count.Text = "0";
            lblTPointTier3Count.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTPointTier3
            // 
            lblTPointTier3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblTPointTier3.AutoSize = true;
            lblTPointTier3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTPointTier3.Location = new Point(39, 169);
            lblTPointTier3.Name = "lblTPointTier3";
            lblTPointTier3.Size = new Size(72, 21);
            lblTPointTier3.TabIndex = 14;
            lblTPointTier3.Text = "Loại Khá:";
            lblTPointTier3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTPointTier4Count
            // 
            lblTPointTier4Count.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblTPointTier4Count.AutoSize = true;
            lblTPointTier4Count.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTPointTier4Count.Location = new Point(243, 199);
            lblTPointTier4Count.Name = "lblTPointTier4Count";
            lblTPointTier4Count.Size = new Size(19, 21);
            lblTPointTier4Count.TabIndex = 17;
            lblTPointTier4Count.Text = "0";
            lblTPointTier4Count.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTPointTier4
            // 
            lblTPointTier4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblTPointTier4.AutoSize = true;
            lblTPointTier4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTPointTier4.Location = new Point(39, 199);
            lblTPointTier4.Name = "lblTPointTier4";
            lblTPointTier4.Size = new Size(121, 21);
            lblTPointTier4.TabIndex = 16;
            lblTPointTier4.Text = "Loại Trung bình:";
            lblTPointTier4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPlayHisCount
            // 
            lblPlayHisCount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblPlayHisCount.AutoSize = true;
            lblPlayHisCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlayHisCount.Location = new Point(243, 50);
            lblPlayHisCount.Name = "lblPlayHisCount";
            lblPlayHisCount.Size = new Size(19, 21);
            lblPlayHisCount.TabIndex = 19;
            lblPlayHisCount.Text = "0";
            lblPlayHisCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPlayHis
            // 
            lblPlayHis.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblPlayHis.AutoSize = true;
            lblPlayHis.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayHis.Location = new Point(39, 50);
            lblPlayHis.Name = "lblPlayHis";
            lblPlayHis.Size = new Size(146, 21);
            lblPlayHis.TabIndex = 18;
            lblPlayHis.Text = "Tổng số luợt chơi:";
            lblPlayHis.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblStudentAccountsCount
            // 
            lblStudentAccountsCount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblStudentAccountsCount.AutoSize = true;
            lblStudentAccountsCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStudentAccountsCount.Location = new Point(243, 125);
            lblStudentAccountsCount.Name = "lblStudentAccountsCount";
            lblStudentAccountsCount.Size = new Size(19, 21);
            lblStudentAccountsCount.TabIndex = 25;
            lblStudentAccountsCount.Text = "0";
            lblStudentAccountsCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStudentAccounts
            // 
            lblStudentAccounts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblStudentAccounts.AutoSize = true;
            lblStudentAccounts.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStudentAccounts.Location = new Point(39, 125);
            lblStudentAccounts.Name = "lblStudentAccounts";
            lblStudentAccounts.Size = new Size(165, 21);
            lblStudentAccounts.TabIndex = 24;
            lblStudentAccounts.Text = "Số tài khoản sinh viên:";
            lblStudentAccounts.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblAccountsCount
            // 
            lblAccountsCount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblAccountsCount.AutoSize = true;
            lblAccountsCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAccountsCount.Location = new Point(243, 94);
            lblAccountsCount.Name = "lblAccountsCount";
            lblAccountsCount.Size = new Size(19, 21);
            lblAccountsCount.TabIndex = 23;
            lblAccountsCount.Text = "0";
            lblAccountsCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAccounts
            // 
            lblAccounts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblAccounts.AutoSize = true;
            lblAccounts.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAccounts.Location = new Point(39, 94);
            lblAccounts.Name = "lblAccounts";
            lblAccounts.Size = new Size(150, 21);
            lblAccounts.TabIndex = 22;
            lblAccounts.Text = "Tổng số tài khoản:";
            lblAccounts.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblClubAccountsCount
            // 
            lblClubAccountsCount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblClubAccountsCount.AutoSize = true;
            lblClubAccountsCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblClubAccountsCount.Location = new Point(243, 156);
            lblClubAccountsCount.Name = "lblClubAccountsCount";
            lblClubAccountsCount.Size = new Size(19, 21);
            lblClubAccountsCount.TabIndex = 27;
            lblClubAccountsCount.Text = "0";
            lblClubAccountsCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblClubAccounts
            // 
            lblClubAccounts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblClubAccounts.AutoSize = true;
            lblClubAccounts.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblClubAccounts.Location = new Point(39, 156);
            lblClubAccounts.Name = "lblClubAccounts";
            lblClubAccounts.Size = new Size(130, 21);
            lblClubAccounts.TabIndex = 26;
            lblClubAccounts.Text = "Số tài khoản CLB:";
            lblClubAccounts.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.Location = new Point(576, 318);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 28;
            btnClose.Text = "Thoát";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // tabStats
            // 
            tabStats.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabStats.Controls.Add(tabPageStatsSearch);
            tabStats.Controls.Add(tabPageStatsOther);
            tabStats.Location = new Point(12, 12);
            tabStats.Name = "tabStats";
            tabStats.SelectedIndex = 0;
            tabStats.Size = new Size(643, 300);
            tabStats.TabIndex = 29;
            tabStats.SelectedIndexChanged += tabStats_SelectedIndexChanged;
            // 
            // tabPageStatsSearch
            // 
            tabPageStatsSearch.Controls.Add(lblMatchCount);
            tabPageStatsSearch.Controls.Add(chartStatsSearch);
            tabPageStatsSearch.Controls.Add(lblMatch);
            tabPageStatsSearch.Controls.Add(lblTotal);
            tabPageStatsSearch.Controls.Add(lblTotalCount);
            tabPageStatsSearch.Location = new Point(4, 24);
            tabPageStatsSearch.Name = "tabPageStatsSearch";
            tabPageStatsSearch.Padding = new Padding(3);
            tabPageStatsSearch.Size = new Size(635, 272);
            tabPageStatsSearch.TabIndex = 0;
            tabPageStatsSearch.Text = "Theo tìm kiếm";
            tabPageStatsSearch.UseVisualStyleBackColor = true;
            // 
            // lblMatchCount
            // 
            lblMatchCount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblMatchCount.AutoSize = true;
            lblMatchCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMatchCount.Location = new Point(243, 141);
            lblMatchCount.Name = "lblMatchCount";
            lblMatchCount.Size = new Size(19, 21);
            lblMatchCount.TabIndex = 33;
            lblMatchCount.Text = "0";
            lblMatchCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // chartStatsSearch
            // 
            chartStatsSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            chartArea1.Name = "StatsChartArea";
            chartStatsSearch.ChartAreas.Add(chartArea1);
            legend1.Name = "StatsChartLegend";
            chartStatsSearch.Legends.Add(legend1);
            chartStatsSearch.Location = new Point(298, 6);
            chartStatsSearch.Name = "chartStatsSearch";
            series1.ChartArea = "StatsChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "StatsChartLegend";
            series1.Name = "StatsSeries";
            chartStatsSearch.Series.Add(series1);
            chartStatsSearch.Size = new Size(330, 260);
            chartStatsSearch.TabIndex = 0;
            chartStatsSearch.Text = "Biểu đồ";
            // 
            // lblMatch
            // 
            lblMatch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblMatch.AutoSize = true;
            lblMatch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMatch.Location = new Point(39, 141);
            lblMatch.Name = "lblMatch";
            lblMatch.Size = new Size(190, 21);
            lblMatch.TabIndex = 32;
            lblMatch.Text = "Trùng/thuộc mức/khoảng:";
            lblMatch.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(39, 110);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(95, 21);
            lblTotal.TabIndex = 30;
            lblTotal.Text = "Tổng cộng:";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotalCount
            // 
            lblTotalCount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotalCount.AutoSize = true;
            lblTotalCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalCount.Location = new Point(243, 110);
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new Size(19, 21);
            lblTotalCount.TabIndex = 31;
            lblTotalCount.Text = "0";
            lblTotalCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tabPageStatsOther
            // 
            tabPageStatsOther.Controls.Add(lblPlayHisCountClone);
            tabPageStatsOther.Controls.Add(lblPlayHisClone);
            tabPageStatsOther.Controls.Add(lblGameCount);
            tabPageStatsOther.Controls.Add(lblGame);
            tabPageStatsOther.Controls.Add(lblTPointHisCount);
            tabPageStatsOther.Controls.Add(lblTPointHis);
            tabPageStatsOther.Controls.Add(lblTPointPlusOneCount);
            tabPageStatsOther.Controls.Add(lblTPointPlusOne);
            tabPageStatsOther.Controls.Add(lblTPointPlusTwoCount);
            tabPageStatsOther.Controls.Add(lblTPointPlusTwo);
            tabPageStatsOther.Controls.Add(lblPlayHisCount);
            tabPageStatsOther.Controls.Add(lblPlayHis);
            tabPageStatsOther.Controls.Add(lblPlayHisTier5Count);
            tabPageStatsOther.Controls.Add(lblPlayHisTier5);
            tabPageStatsOther.Controls.Add(lblPlayHisTier4Count);
            tabPageStatsOther.Controls.Add(lblPlayHisTier4);
            tabPageStatsOther.Controls.Add(lblPlayHisTier3Count);
            tabPageStatsOther.Controls.Add(lblPlayHisTier3);
            tabPageStatsOther.Controls.Add(lblPlayHisTier2Count);
            tabPageStatsOther.Controls.Add(lblPlayHisTier2);
            tabPageStatsOther.Controls.Add(lblPlayHisTier1Count);
            tabPageStatsOther.Controls.Add(lblPlayHisTier1);
            tabPageStatsOther.Controls.Add(lblSightHisTier5Count);
            tabPageStatsOther.Controls.Add(lblSightHisTier5);
            tabPageStatsOther.Controls.Add(lblSightHisTier4Count);
            tabPageStatsOther.Controls.Add(lblSightHisTier4);
            tabPageStatsOther.Controls.Add(lblSightHisTier3Count);
            tabPageStatsOther.Controls.Add(lblSightHisTier3);
            tabPageStatsOther.Controls.Add(lblSightHisTier2Count);
            tabPageStatsOther.Controls.Add(lblSightHisTier2);
            tabPageStatsOther.Controls.Add(lblSightHisTier1Count);
            tabPageStatsOther.Controls.Add(lblSightHisTier1);
            tabPageStatsOther.Controls.Add(lblSightHisCount);
            tabPageStatsOther.Controls.Add(lblSightHis);
            tabPageStatsOther.Controls.Add(lblSightHisCountClone);
            tabPageStatsOther.Controls.Add(lblSightHisClone);
            tabPageStatsOther.Controls.Add(lblSightCount);
            tabPageStatsOther.Controls.Add(lblSight);
            tabPageStatsOther.Controls.Add(chartStatsOther);
            tabPageStatsOther.Controls.Add(lblTPointTier4Count);
            tabPageStatsOther.Controls.Add(lblClubAccountsCount);
            tabPageStatsOther.Controls.Add(lblTPointTier3Count);
            tabPageStatsOther.Controls.Add(lblTPointTier4);
            tabPageStatsOther.Controls.Add(lblTPointTier2Count);
            tabPageStatsOther.Controls.Add(lblTPointTier1Count);
            tabPageStatsOther.Controls.Add(lblTPointOver50Count);
            tabPageStatsOther.Controls.Add(lblClubAccounts);
            tabPageStatsOther.Controls.Add(lblStudentsCount);
            tabPageStatsOther.Controls.Add(lblTPointTier3);
            tabPageStatsOther.Controls.Add(lblStudentAccountsCount);
            tabPageStatsOther.Controls.Add(lblTPointTier2);
            tabPageStatsOther.Controls.Add(lblStudentAccounts);
            tabPageStatsOther.Controls.Add(lblTPointTier1);
            tabPageStatsOther.Controls.Add(lblAccountsCount);
            tabPageStatsOther.Controls.Add(lblTPointOver50);
            tabPageStatsOther.Controls.Add(lblAccounts);
            tabPageStatsOther.Controls.Add(lblStudents);
            tabPageStatsOther.Location = new Point(4, 24);
            tabPageStatsOther.Name = "tabPageStatsOther";
            tabPageStatsOther.Padding = new Padding(3);
            tabPageStatsOther.Size = new Size(635, 272);
            tabPageStatsOther.TabIndex = 1;
            tabPageStatsOther.Text = "Theo mức/ngưỡng";
            tabPageStatsOther.UseVisualStyleBackColor = true;
            // 
            // lblTPointHisCount
            // 
            lblTPointHisCount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblTPointHisCount.AutoSize = true;
            lblTPointHisCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTPointHisCount.Location = new Point(243, 96);
            lblTPointHisCount.Name = "lblTPointHisCount";
            lblTPointHisCount.Size = new Size(19, 21);
            lblTPointHisCount.TabIndex = 53;
            lblTPointHisCount.Text = "0";
            lblTPointHisCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTPointHis
            // 
            lblTPointHis.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblTPointHis.AutoSize = true;
            lblTPointHis.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTPointHis.Location = new Point(39, 96);
            lblTPointHis.Name = "lblTPointHis";
            lblTPointHis.Size = new Size(194, 21);
            lblTPointHis.TabIndex = 52;
            lblTPointHis.Text = "Tổng số luợt cộng điểm:";
            lblTPointHis.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTPointPlusOneCount
            // 
            lblTPointPlusOneCount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblTPointPlusOneCount.AutoSize = true;
            lblTPointPlusOneCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTPointPlusOneCount.Location = new Point(243, 155);
            lblTPointPlusOneCount.Name = "lblTPointPlusOneCount";
            lblTPointPlusOneCount.Size = new Size(19, 21);
            lblTPointPlusOneCount.TabIndex = 57;
            lblTPointPlusOneCount.Text = "0";
            lblTPointPlusOneCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTPointPlusOne
            // 
            lblTPointPlusOne.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblTPointPlusOne.AutoSize = true;
            lblTPointPlusOne.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTPointPlusOne.Location = new Point(39, 155);
            lblTPointPlusOne.Name = "lblTPointPlusOne";
            lblTPointPlusOne.Size = new Size(72, 21);
            lblTPointPlusOne.TabIndex = 56;
            lblTPointPlusOne.Text = "+1 điểm:";
            lblTPointPlusOne.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTPointPlusTwoCount
            // 
            lblTPointPlusTwoCount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblTPointPlusTwoCount.AutoSize = true;
            lblTPointPlusTwoCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTPointPlusTwoCount.Location = new Point(243, 125);
            lblTPointPlusTwoCount.Name = "lblTPointPlusTwoCount";
            lblTPointPlusTwoCount.Size = new Size(19, 21);
            lblTPointPlusTwoCount.TabIndex = 55;
            lblTPointPlusTwoCount.Text = "0";
            lblTPointPlusTwoCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTPointPlusTwo
            // 
            lblTPointPlusTwo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblTPointPlusTwo.AutoSize = true;
            lblTPointPlusTwo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTPointPlusTwo.Location = new Point(39, 125);
            lblTPointPlusTwo.Name = "lblTPointPlusTwo";
            lblTPointPlusTwo.Size = new Size(72, 21);
            lblTPointPlusTwo.TabIndex = 54;
            lblTPointPlusTwo.Text = "+2 điểm:";
            lblTPointPlusTwo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPlayHisTier5Count
            // 
            lblPlayHisTier5Count.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblPlayHisTier5Count.AutoSize = true;
            lblPlayHisTier5Count.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlayHisTier5Count.Location = new Point(243, 199);
            lblPlayHisTier5Count.Name = "lblPlayHisTier5Count";
            lblPlayHisTier5Count.Size = new Size(19, 21);
            lblPlayHisTier5Count.TabIndex = 51;
            lblPlayHisTier5Count.Text = "0";
            lblPlayHisTier5Count.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPlayHisTier5
            // 
            lblPlayHisTier5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblPlayHisTier5.AutoSize = true;
            lblPlayHisTier5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlayHisTier5.Location = new Point(39, 199);
            lblPlayHisTier5.Name = "lblPlayHisTier5";
            lblPlayHisTier5.Size = new Size(93, 21);
            lblPlayHisTier5.TabIndex = 50;
            lblPlayHisTier5.Text = "0 - 19 điểm:";
            lblPlayHisTier5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPlayHisTier4Count
            // 
            lblPlayHisTier4Count.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblPlayHisTier4Count.AutoSize = true;
            lblPlayHisTier4Count.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlayHisTier4Count.Location = new Point(243, 169);
            lblPlayHisTier4Count.Name = "lblPlayHisTier4Count";
            lblPlayHisTier4Count.Size = new Size(19, 21);
            lblPlayHisTier4Count.TabIndex = 49;
            lblPlayHisTier4Count.Text = "0";
            lblPlayHisTier4Count.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPlayHisTier4
            // 
            lblPlayHisTier4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblPlayHisTier4.AutoSize = true;
            lblPlayHisTier4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlayHisTier4.Location = new Point(39, 169);
            lblPlayHisTier4.Name = "lblPlayHisTier4";
            lblPlayHisTier4.Size = new Size(102, 21);
            lblPlayHisTier4.TabIndex = 48;
            lblPlayHisTier4.Text = "20 - 39 điểm:";
            lblPlayHisTier4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPlayHisTier3Count
            // 
            lblPlayHisTier3Count.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblPlayHisTier3Count.AutoSize = true;
            lblPlayHisTier3Count.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlayHisTier3Count.Location = new Point(243, 139);
            lblPlayHisTier3Count.Name = "lblPlayHisTier3Count";
            lblPlayHisTier3Count.Size = new Size(19, 21);
            lblPlayHisTier3Count.TabIndex = 47;
            lblPlayHisTier3Count.Text = "0";
            lblPlayHisTier3Count.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPlayHisTier3
            // 
            lblPlayHisTier3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblPlayHisTier3.AutoSize = true;
            lblPlayHisTier3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlayHisTier3.Location = new Point(39, 139);
            lblPlayHisTier3.Name = "lblPlayHisTier3";
            lblPlayHisTier3.Size = new Size(102, 21);
            lblPlayHisTier3.TabIndex = 46;
            lblPlayHisTier3.Text = "40 - 60 điểm:";
            lblPlayHisTier3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPlayHisTier2Count
            // 
            lblPlayHisTier2Count.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblPlayHisTier2Count.AutoSize = true;
            lblPlayHisTier2Count.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlayHisTier2Count.Location = new Point(243, 109);
            lblPlayHisTier2Count.Name = "lblPlayHisTier2Count";
            lblPlayHisTier2Count.Size = new Size(19, 21);
            lblPlayHisTier2Count.TabIndex = 45;
            lblPlayHisTier2Count.Text = "0";
            lblPlayHisTier2Count.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPlayHisTier2
            // 
            lblPlayHisTier2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblPlayHisTier2.AutoSize = true;
            lblPlayHisTier2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlayHisTier2.Location = new Point(39, 109);
            lblPlayHisTier2.Name = "lblPlayHisTier2";
            lblPlayHisTier2.Size = new Size(102, 21);
            lblPlayHisTier2.TabIndex = 44;
            lblPlayHisTier2.Text = "61 - 80 điểm:";
            lblPlayHisTier2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPlayHisTier1Count
            // 
            lblPlayHisTier1Count.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblPlayHisTier1Count.AutoSize = true;
            lblPlayHisTier1Count.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlayHisTier1Count.Location = new Point(243, 79);
            lblPlayHisTier1Count.Name = "lblPlayHisTier1Count";
            lblPlayHisTier1Count.Size = new Size(19, 21);
            lblPlayHisTier1Count.TabIndex = 43;
            lblPlayHisTier1Count.Text = "0";
            lblPlayHisTier1Count.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPlayHisTier1
            // 
            lblPlayHisTier1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblPlayHisTier1.AutoSize = true;
            lblPlayHisTier1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlayHisTier1.Location = new Point(39, 79);
            lblPlayHisTier1.Name = "lblPlayHisTier1";
            lblPlayHisTier1.Size = new Size(111, 21);
            lblPlayHisTier1.TabIndex = 42;
            lblPlayHisTier1.Text = "81 - 100 điểm:";
            lblPlayHisTier1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSightHisTier5Count
            // 
            lblSightHisTier5Count.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblSightHisTier5Count.AutoSize = true;
            lblSightHisTier5Count.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSightHisTier5Count.Location = new Point(243, 200);
            lblSightHisTier5Count.Name = "lblSightHisTier5Count";
            lblSightHisTier5Count.Size = new Size(19, 21);
            lblSightHisTier5Count.TabIndex = 39;
            lblSightHisTier5Count.Text = "0";
            lblSightHisTier5Count.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSightHisTier5
            // 
            lblSightHisTier5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblSightHisTier5.AutoSize = true;
            lblSightHisTier5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSightHisTier5.Location = new Point(41, 200);
            lblSightHisTier5.Name = "lblSightHisTier5";
            lblSightHisTier5.Size = new Size(93, 21);
            lblSightHisTier5.TabIndex = 38;
            lblSightHisTier5.Text = "0 - 19 điểm:";
            lblSightHisTier5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSightHisTier4Count
            // 
            lblSightHisTier4Count.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblSightHisTier4Count.AutoSize = true;
            lblSightHisTier4Count.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSightHisTier4Count.Location = new Point(243, 170);
            lblSightHisTier4Count.Name = "lblSightHisTier4Count";
            lblSightHisTier4Count.Size = new Size(19, 21);
            lblSightHisTier4Count.TabIndex = 37;
            lblSightHisTier4Count.Text = "0";
            lblSightHisTier4Count.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSightHisTier4
            // 
            lblSightHisTier4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblSightHisTier4.AutoSize = true;
            lblSightHisTier4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSightHisTier4.Location = new Point(41, 170);
            lblSightHisTier4.Name = "lblSightHisTier4";
            lblSightHisTier4.Size = new Size(102, 21);
            lblSightHisTier4.TabIndex = 36;
            lblSightHisTier4.Text = "20 - 39 điểm:";
            lblSightHisTier4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSightHisTier3Count
            // 
            lblSightHisTier3Count.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblSightHisTier3Count.AutoSize = true;
            lblSightHisTier3Count.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSightHisTier3Count.Location = new Point(243, 140);
            lblSightHisTier3Count.Name = "lblSightHisTier3Count";
            lblSightHisTier3Count.Size = new Size(19, 21);
            lblSightHisTier3Count.TabIndex = 35;
            lblSightHisTier3Count.Text = "0";
            lblSightHisTier3Count.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSightHisTier3
            // 
            lblSightHisTier3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblSightHisTier3.AutoSize = true;
            lblSightHisTier3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSightHisTier3.Location = new Point(41, 140);
            lblSightHisTier3.Name = "lblSightHisTier3";
            lblSightHisTier3.Size = new Size(102, 21);
            lblSightHisTier3.TabIndex = 34;
            lblSightHisTier3.Text = "40 - 60 điểm:";
            lblSightHisTier3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSightHisTier2Count
            // 
            lblSightHisTier2Count.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblSightHisTier2Count.AutoSize = true;
            lblSightHisTier2Count.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSightHisTier2Count.Location = new Point(243, 110);
            lblSightHisTier2Count.Name = "lblSightHisTier2Count";
            lblSightHisTier2Count.Size = new Size(19, 21);
            lblSightHisTier2Count.TabIndex = 33;
            lblSightHisTier2Count.Text = "0";
            lblSightHisTier2Count.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSightHisTier2
            // 
            lblSightHisTier2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblSightHisTier2.AutoSize = true;
            lblSightHisTier2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSightHisTier2.Location = new Point(41, 110);
            lblSightHisTier2.Name = "lblSightHisTier2";
            lblSightHisTier2.Size = new Size(102, 21);
            lblSightHisTier2.TabIndex = 32;
            lblSightHisTier2.Text = "61 - 80 điểm:";
            lblSightHisTier2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSightHisCountClone
            // 
            lblSightHisCountClone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblSightHisCountClone.AutoSize = true;
            lblSightHisCountClone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSightHisCountClone.Location = new Point(243, 139);
            lblSightHisCountClone.Name = "lblSightHisCountClone";
            lblSightHisCountClone.Size = new Size(19, 21);
            lblSightHisCountClone.TabIndex = 31;
            lblSightHisCountClone.Text = "0";
            lblSightHisCountClone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSightHisClone
            // 
            lblSightHisClone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblSightHisClone.AutoSize = true;
            lblSightHisClone.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSightHisClone.Location = new Point(39, 139);
            lblSightHisClone.Name = "lblSightHisClone";
            lblSightHisClone.Size = new Size(171, 21);
            lblSightHisClone.TabIndex = 30;
            lblSightHisClone.Text = "Tổng số lượt làm bài:";
            lblSightHisClone.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSightCount
            // 
            lblSightCount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblSightCount.AutoSize = true;
            lblSightCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSightCount.Location = new Point(243, 109);
            lblSightCount.Name = "lblSightCount";
            lblSightCount.Size = new Size(19, 21);
            lblSightCount.TabIndex = 29;
            lblSightCount.Text = "0";
            lblSightCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSight
            // 
            lblSight.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblSight.AutoSize = true;
            lblSight.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSight.Location = new Point(39, 109);
            lblSight.Name = "lblSight";
            lblSight.Size = new Size(198, 21);
            lblSight.TabIndex = 28;
            lblSight.Text = "Tổng số bài trắc nghiệm:";
            lblSight.TextAlign = ContentAlignment.MiddleRight;
            // 
            // chartStatsOther
            // 
            chartStatsOther.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            chartArea2.Name = "StatsChartArea";
            chartStatsOther.ChartAreas.Add(chartArea2);
            legend2.Name = "StatsChartLegend";
            chartStatsOther.Legends.Add(legend2);
            chartStatsOther.Location = new Point(298, 6);
            chartStatsOther.Name = "chartStatsOther";
            series2.ChartArea = "StatsChartArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "StatsChartLegend";
            series2.Name = "StatsSeries";
            chartStatsOther.Series.Add(series2);
            chartStatsOther.Size = new Size(330, 260);
            chartStatsOther.TabIndex = 1;
            chartStatsOther.Text = "Biểu đồ";
            // 
            // cboSelect
            // 
            cboSelect.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cboSelect.FormattingEnabled = true;
            cboSelect.Location = new Point(16, 318);
            cboSelect.Name = "cboSelect";
            cboSelect.Size = new Size(121, 23);
            cboSelect.TabIndex = 30;
            cboSelect.SelectedIndexChanged += cboSelect_SelectedIndexChanged;
            // 
            // lblGameCount
            // 
            lblGameCount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblGameCount.AutoSize = true;
            lblGameCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblGameCount.Location = new Point(243, 109);
            lblGameCount.Name = "lblGameCount";
            lblGameCount.Size = new Size(19, 21);
            lblGameCount.TabIndex = 59;
            lblGameCount.Text = "0";
            lblGameCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblGame
            // 
            lblGame.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblGame.AutoSize = true;
            lblGame.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblGame.Location = new Point(39, 109);
            lblGame.Name = "lblGame";
            lblGame.Size = new Size(137, 21);
            lblGame.TabIndex = 58;
            lblGame.Text = "Tổng số trò chơi:";
            lblGame.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPlayHisCountClone
            // 
            lblPlayHisCountClone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblPlayHisCountClone.AutoSize = true;
            lblPlayHisCountClone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlayHisCountClone.Location = new Point(243, 139);
            lblPlayHisCountClone.Name = "lblPlayHisCountClone";
            lblPlayHisCountClone.Size = new Size(19, 21);
            lblPlayHisCountClone.TabIndex = 61;
            lblPlayHisCountClone.Text = "0";
            lblPlayHisCountClone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPlayHisClone
            // 
            lblPlayHisClone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblPlayHisClone.AutoSize = true;
            lblPlayHisClone.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayHisClone.Location = new Point(39, 139);
            lblPlayHisClone.Name = "lblPlayHisClone";
            lblPlayHisClone.Size = new Size(147, 21);
            lblPlayHisClone.TabIndex = 60;
            lblPlayHisClone.Text = "Tổng số lượt chơi:";
            lblPlayHisClone.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FormStats
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 352);
            Controls.Add(cboSelect);
            Controls.Add(tabStats);
            Controls.Add(btnClose);
            MinimumSize = new Size(681, 391);
            Name = "FormStats";
            Text = "Thống kê";
            Load += FormStats_Load;
            tabStats.ResumeLayout(false);
            tabPageStatsSearch.ResumeLayout(false);
            tabPageStatsSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartStatsSearch).EndInit();
            tabPageStatsOther.ResumeLayout(false);
            tabPageStatsOther.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartStatsOther).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblSightHis;
        private Label lblSightHisCount;
        private Label lblSightHisTier1;
        private Label lblSightHisTier1Count;
        private Label lblStudentsCount;
        private Label lblStudents;
        private Label lblTPointOver50Count;
        private Label lblTPointOver50;
        private Label lblTPointTier1Count;
        private Label lblTPointTier1;
        private Label lblTPointTier2Count;
        private Label lblTPointTier2;
        private Label lblTPointTier3Count;
        private Label lblTPointTier3;
        private Label lblTPointTier4Count;
        private Label lblTPointTier4;
        private Label lblPlayHisCount;
        private Label lblPlayHis;
        private Label lblStudentAccountsCount;
        private Label lblStudentAccounts;
        private Label lblAccountsCount;
        private Label lblAccounts;
        private Label lblClubAccountsCount;
        private Label lblClubAccounts;
        private Button btnClose;
        private TabControl tabStats;
        private TabPage tabPageStatsSearch;
        private TabPage tabPageStatsOther;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatsSearch;
        private Label lblMatchCount;
        private Label lblMatch;
        private Label lblTotal;
        private Label lblTotalCount;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatsOther;
        private Label lblSightHisCountClone;
        private Label lblSightHisClone;
        private Label lblSightCount;
        private Label lblSight;
        private Label lblSightHisTier2Count;
        private Label lblSightHisTier2;
        private Label lblSightHisTier5Count;
        private Label lblSightHisTier5;
        private Label lblSightHisTier4Count;
        private Label lblSightHisTier4;
        private Label lblSightHisTier3Count;
        private Label lblSightHisTier3;
        private ComboBox cboSelect;
        private Label lblPlayHisTier2;
        private Label lblPlayHisTier3;
        private Label lblPlayHisTier4;
        private Label lblPlayHisTier5;
        private Label lblPlayHisTier1Count;
        private Label lblPlayHisTier2Count;
        private Label lblPlayHisTier3Count;
        private Label lblPlayHisTier4Count;
        private Label lblPlayHisTier5Count;
        private Label lblPlayHisTier1;
        private Label lblTPointHisCount;
        private Label lblTPointHis;
        private Label lblTPointPlusOneCount;
        private Label lblTPointPlusOne;
        private Label lblTPointPlusTwoCount;
        private Label lblTPointPlusTwo;
        private Label lblPlayHisCountClone;
        private Label lblPlayHisClone;
        private Label lblGameCount;
        private Label lblGame;
    }
}