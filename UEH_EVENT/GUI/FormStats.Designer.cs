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
            lblSights = new Label();
            lblSightsCount = new Label();
            lblSightsOver50 = new Label();
            lblSightsOver50Count = new Label();
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
            lblPlayHisOver50Count = new Label();
            lblPlayHisOver50 = new Label();
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
            tabPageSearchOther = new TabPage();
            chartStatsOther = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tabStats.SuspendLayout();
            tabPageStatsSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartStatsSearch).BeginInit();
            tabPageSearchOther.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartStatsOther).BeginInit();
            SuspendLayout();
            // 
            // lblSights
            // 
            lblSights.AutoSize = true;
            lblSights.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSights.Location = new Point(39, 110);
            lblSights.Name = "lblSights";
            lblSights.Size = new Size(198, 21);
            lblSights.TabIndex = 0;
            lblSights.Text = "Tổng số bài trắc nghiệm:";
            lblSights.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSightsCount
            // 
            lblSightsCount.AutoSize = true;
            lblSightsCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSightsCount.Location = new Point(243, 110);
            lblSightsCount.Name = "lblSightsCount";
            lblSightsCount.Size = new Size(19, 21);
            lblSightsCount.TabIndex = 1;
            lblSightsCount.Text = "0";
            lblSightsCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSightsOver50
            // 
            lblSightsOver50.AutoSize = true;
            lblSightsOver50.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSightsOver50.Location = new Point(39, 141);
            lblSightsOver50.Name = "lblSightsOver50";
            lblSightsOver50.Size = new Size(104, 21);
            lblSightsOver50.TabIndex = 2;
            lblSightsOver50.Text = "Trên 50 điểm:";
            lblSightsOver50.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSightsOver50Count
            // 
            lblSightsOver50Count.AutoSize = true;
            lblSightsOver50Count.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSightsOver50Count.Location = new Point(243, 141);
            lblSightsOver50Count.Name = "lblSightsOver50Count";
            lblSightsOver50Count.Size = new Size(19, 21);
            lblSightsOver50Count.TabIndex = 3;
            lblSightsOver50Count.Text = "0";
            lblSightsOver50Count.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStudentsCount
            // 
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
            lblTPointTier4.AutoSize = true;
            lblTPointTier4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTPointTier4.Location = new Point(39, 199);
            lblTPointTier4.Name = "lblTPointTier4";
            lblTPointTier4.Size = new Size(121, 21);
            lblTPointTier4.TabIndex = 16;
            lblTPointTier4.Text = "Loại Trung bình:";
            lblTPointTier4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPlayHisOver50Count
            // 
            lblPlayHisOver50Count.AutoSize = true;
            lblPlayHisOver50Count.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlayHisOver50Count.Location = new Point(243, 141);
            lblPlayHisOver50Count.Name = "lblPlayHisOver50Count";
            lblPlayHisOver50Count.Size = new Size(19, 21);
            lblPlayHisOver50Count.TabIndex = 21;
            lblPlayHisOver50Count.Text = "0";
            lblPlayHisOver50Count.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPlayHisOver50
            // 
            lblPlayHisOver50.AutoSize = true;
            lblPlayHisOver50.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlayHisOver50.Location = new Point(39, 141);
            lblPlayHisOver50.Name = "lblPlayHisOver50";
            lblPlayHisOver50.Size = new Size(104, 21);
            lblPlayHisOver50.TabIndex = 20;
            lblPlayHisOver50.Text = "Trên 50 điểm:";
            lblPlayHisOver50.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPlayHisCount
            // 
            lblPlayHisCount.AutoSize = true;
            lblPlayHisCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlayHisCount.Location = new Point(243, 110);
            lblPlayHisCount.Name = "lblPlayHisCount";
            lblPlayHisCount.Size = new Size(19, 21);
            lblPlayHisCount.TabIndex = 19;
            lblPlayHisCount.Text = "0";
            lblPlayHisCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPlayHis
            // 
            lblPlayHis.AutoSize = true;
            lblPlayHis.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayHis.Location = new Point(39, 110);
            lblPlayHis.Name = "lblPlayHis";
            lblPlayHis.Size = new Size(146, 21);
            lblPlayHis.TabIndex = 18;
            lblPlayHis.Text = "Tổng số luợt chơi:";
            lblPlayHis.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblStudentAccountsCount
            // 
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
            tabStats.Controls.Add(tabPageStatsSearch);
            tabStats.Controls.Add(tabPageSearchOther);
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
            lblTotalCount.AutoSize = true;
            lblTotalCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalCount.Location = new Point(243, 110);
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new Size(19, 21);
            lblTotalCount.TabIndex = 31;
            lblTotalCount.Text = "0";
            lblTotalCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tabPageSearchOther
            // 
            tabPageSearchOther.Controls.Add(chartStatsOther);
            tabPageSearchOther.Controls.Add(lblSightsOver50Count);
            tabPageSearchOther.Controls.Add(lblTPointTier4Count);
            tabPageSearchOther.Controls.Add(lblClubAccountsCount);
            tabPageSearchOther.Controls.Add(lblTPointTier3Count);
            tabPageSearchOther.Controls.Add(lblTPointTier4);
            tabPageSearchOther.Controls.Add(lblTPointTier2Count);
            tabPageSearchOther.Controls.Add(lblSights);
            tabPageSearchOther.Controls.Add(lblTPointTier1Count);
            tabPageSearchOther.Controls.Add(lblTPointOver50Count);
            tabPageSearchOther.Controls.Add(lblClubAccounts);
            tabPageSearchOther.Controls.Add(lblStudentsCount);
            tabPageSearchOther.Controls.Add(lblTPointTier3);
            tabPageSearchOther.Controls.Add(lblSightsCount);
            tabPageSearchOther.Controls.Add(lblStudentAccountsCount);
            tabPageSearchOther.Controls.Add(lblTPointTier2);
            tabPageSearchOther.Controls.Add(lblSightsOver50);
            tabPageSearchOther.Controls.Add(lblStudentAccounts);
            tabPageSearchOther.Controls.Add(lblTPointTier1);
            tabPageSearchOther.Controls.Add(lblAccountsCount);
            tabPageSearchOther.Controls.Add(lblPlayHis);
            tabPageSearchOther.Controls.Add(lblTPointOver50);
            tabPageSearchOther.Controls.Add(lblAccounts);
            tabPageSearchOther.Controls.Add(lblPlayHisCount);
            tabPageSearchOther.Controls.Add(lblStudents);
            tabPageSearchOther.Controls.Add(lblPlayHisOver50);
            tabPageSearchOther.Controls.Add(lblPlayHisOver50Count);
            tabPageSearchOther.Location = new Point(4, 24);
            tabPageSearchOther.Name = "tabPageSearchOther";
            tabPageSearchOther.Padding = new Padding(3);
            tabPageSearchOther.Size = new Size(635, 272);
            tabPageSearchOther.TabIndex = 1;
            tabPageSearchOther.Text = "Theo mức/ngưỡng";
            tabPageSearchOther.UseVisualStyleBackColor = true;
            // 
            // chartStatsOther
            // 
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
            // FormStats
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 352);
            Controls.Add(tabStats);
            Controls.Add(btnClose);
            Name = "FormStats";
            Text = "Thống kê";
            Load += FormStats_Load;
            tabStats.ResumeLayout(false);
            tabPageStatsSearch.ResumeLayout(false);
            tabPageStatsSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartStatsSearch).EndInit();
            tabPageSearchOther.ResumeLayout(false);
            tabPageSearchOther.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartStatsOther).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblSights;
        private Label lblSightsCount;
        private Label lblSightsOver50;
        private Label lblSightsOver50Count;
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
        private Label lblPlayHisOver50Count;
        private Label lblPlayHisOver50;
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
        private TabPage tabPageSearchOther;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatsSearch;
        private Label lblMatchCount;
        private Label lblMatch;
        private Label lblTotal;
        private Label lblTotalCount;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatsOther;
    }
}