namespace UEH_EVENT.GUI
{
    public partial class FormStats : Form
    {
        private readonly FormSearch form;
        private readonly string[] xSearch;
        private readonly int[] ySearch;
        private string[] xStats;
        private int[] yStats;
        private bool statsAvailable = true;

        private void LoadStats()
        {
            foreach (var label in tabPageSearchOther.Controls.OfType<Label>())
            {
                label?.Hide();
            }
            switch (form.SelectedClassValue)
            {
                case nameof(Sight):
                case nameof(SightHis):
                    int sightsCount = Stats.CountAllSights();
                    int sightsOver50Count = Stats.CountSightHisByPoint(50);
                    lblSights.Visible = lblSightsCount.Visible = true;
                    lblSightsCount.Text = sightsCount.ToString();
                    lblSightsOver50.Visible = lblSightsOver50Count.Visible = true;
                    lblSightsOver50Count.Text = sightsOver50Count.ToString();
                    xStats = new string[2] { "Trên 50", "Còn lại" };
                    yStats = new int[2] { sightsOver50Count, sightsCount - sightsOver50Count };
                    break;
                case nameof(Student):
                    int studentsCount = Stats.CountAllStudents();
                    int tPointOver50Count = Stats.CountStudentsByTPoints(50);
                    int tPointTier1Count = Stats.CountStudentsByTPoints(90, 100);
                    int tPointTier2Count = Stats.CountStudentsByTPoints(80, 89);
                    int tPointTier3Count = Stats.CountStudentsByTPoints(65, 79);
                    int tPointTier4Count = Stats.CountStudentsByTPoints(50, 64);
                    lblStudents.Visible = lblStudentsCount.Visible = true;
                    lblStudentsCount.Text = studentsCount.ToString();
                    lblTPointOver50.Visible = lblTPointOver50Count.Visible = true;
                    lblTPointOver50Count.Text = tPointOver50Count.ToString();
                    lblTPointTier1.Visible = lblTPointTier1Count.Visible = true;
                    lblTPointTier1Count.Text = tPointTier1Count.ToString();
                    lblTPointTier2.Visible = lblTPointTier2Count.Visible = true;
                    lblTPointTier2Count.Text = tPointTier2Count.ToString();
                    lblTPointTier3.Visible = lblTPointTier3Count.Visible = true;
                    lblTPointTier3Count.Text = tPointTier3Count.ToString();
                    lblTPointTier4.Visible = lblTPointTier4Count.Visible = true;
                    lblTPointTier4Count.Text = tPointTier4Count.ToString();
                    xStats = new string[5] { "Xuất sắc", "Tốt", "Khá", "Trung bình", "Còn lại" };
                    yStats = new int[5] { tPointTier1Count, tPointTier2Count, tPointTier3Count, tPointTier4Count, studentsCount - tPointOver50Count };
                    break;
                case nameof(PlayHis):
                    int playHisCount = Stats.CountAllPlayHis();
                    int playHisOver50Count = Stats.CountPlayHisByPoint(50);
                    lblPlayHis.Visible = lblPlayHisCount.Visible = true;
                    lblPlayHisCount.Text = playHisCount.ToString();
                    lblPlayHisOver50.Visible = lblPlayHisOver50Count.Visible = true;
                    lblPlayHisOver50Count.Text = playHisOver50Count.ToString();
                    xStats = new string[2] { "Trên 50", "Còn lại" };
                    yStats = new int[2] { playHisCount, playHisOver50Count };
                    break;
                case nameof(Account):
                    int accountsCount = Stats.CountAllAccounts();
                    int studentAccountsCount = Stats.CountAllAccountsByType(Constants.STUDENT_ACC);
                    int clubAccountsCount = Stats.CountAllAccountsByType(Constants.CLB_ACC);
                    int adminAccountsCount = Stats.CountAllAccountsByType(Constants.ADMIN_ACC);
                    lblAccounts.Visible = lblAccountsCount.Visible = true;
                    lblAccountsCount.Text = accountsCount.ToString();
                    lblStudentAccounts.Visible = lblStudentAccountsCount.Visible = true;
                    lblStudentAccountsCount.Text = studentAccountsCount.ToString();
                    lblClubAccounts.Visible = lblClubAccountsCount.Visible = true;
                    lblClubAccountsCount.Text = clubAccountsCount.ToString();
                    xStats = new string[3] { "Sinh viên", "CLB", "Quản trị viên" };
                    yStats = new int[3] { studentAccountsCount, clubAccountsCount, adminAccountsCount };
                    break;
                default:
                    statsAvailable = false;
                    break;
            }
            if (statsAvailable)
            {
                chartStatsOther.Series[0].Points.DataBindXY(xStats, yStats);
            }
        }

        public FormStats(FormSearch frm)
        {
            form = frm;
            xSearch = xStats = new string[2];
            ySearch = yStats = new int[2];
            InitializeComponent();
        }

        private void FormStats_Load(object sender, EventArgs e)
        {
            LoadStats();
            string? selClass = form.SelectedClassValue, selProperty = form.SelectedPropertyValue, keyword = form.SearchKeyword, filter = form.ThresholdFilter;
            int threshold = form.Threshold, lowerBound = form.IntLowerBound, upperBound = form.IntUpperBound;
            int countOfAll = 0, countMatchKeyword = 0, countMetThreshold = 0, countInRange = 0;
            if (selClass != null && selProperty != null)
            {
                countOfAll = (int)SearchUtil.StaticCallGenericVarType(nameof(Stats), selClass, nameof(Stats.CountAll), null, null)!;
                if (keyword != null)
                {
                    countMatchKeyword = (int)SearchUtil.StaticCallGenericVarType(nameof(Stats), selClass, nameof(Stats.CountFilterString), new[] { typeof(string), typeof(string) }, new[] { selProperty, keyword })!;
                    xSearch[0] = $"\"{keyword}\""; xSearch[1] = "Còn lại";
                    ySearch[0] = countMatchKeyword; ySearch[1] = countOfAll - countMatchKeyword;
                    lblMatch.Text = $"Trùng từ khóa \"{keyword}\":";
                    lblMatchCount.Text = countMatchKeyword.ToString();
                }
                if (filter != null && threshold != int.MinValue)
                {
                    object[]? parameters = default;
                    switch (filter.Length)
                    {
                        case 1:
                            parameters = new[] { selProperty as object, Convert.ToChar(filter), threshold };
                            countMetThreshold = (int)SearchUtil.StaticCallGenericVarType(nameof(Stats), selClass, nameof(Stats.CountFilterInt), new[] { typeof(string), typeof(char), typeof(int) }, parameters)!;
                            break;
                        case 2:
                            parameters = new[] { selProperty as object, filter, threshold };
                            countMetThreshold = (int)SearchUtil.StaticCallGenericVarType(nameof(Stats), selClass, nameof(Stats.CountFilterInt), new[] { typeof(string), typeof(string), typeof(int) }, parameters)!;
                            break;
                        default:
                            break;
                    }
                    xSearch[0] = $"{filter} {threshold}"; xSearch[1] = "Còn lại";
                    ySearch[0] = countMetThreshold; ySearch[1] = countOfAll - countMetThreshold;
                    lblMatch.Text = $"Đạt ngưỡng {filter} {threshold}:";
                    lblMatchCount.Text = countMetThreshold.ToString();
                }
                if (lowerBound != int.MinValue && upperBound != int.MaxValue)
                {
                    countInRange = Stats.CountFilterInt(selClass, selProperty, lowerBound, upperBound);
                    xSearch[0] = $"{lowerBound}-{upperBound}"; xSearch[1] = "Còn lại";
                    ySearch[0] = countInRange; ySearch[1] = countOfAll - countInRange;
                    lblMatch.Text = $"Trong khoảng {lowerBound}-{upperBound}:";
                    lblMatchCount.Text = countInRange.ToString();
                }
            }
            lblTotalCount.Text = countOfAll.ToString();
            chartStatsSearch.Series[0].Points.DataBindXY(xSearch, ySearch);
            chartStatsSearch.Legends[0].Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tabStats_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabStats.SelectedTab == tabPageSearchOther)
            {
                if (statsAvailable)
                {
                    chartStatsOther.Series[0].Points.DataBindXY(xStats, yStats);
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tabStats.SelectedTab = tabPageStatsSearch;
                }
            }
        }
    }
}