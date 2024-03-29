namespace UEH_EVENT.GUI
{
    public partial class FormStats : Form
    {
        private readonly formStatistic form;
        private readonly string[] xSearch;
        private readonly int[] ySearch;
        private string[] xStats;
        private int[] yStats;
        private bool statsSearchAvailable = true, statsOtherAvailable = true;

        private void LoadSightStats()
        {
            int sightsCount = Stats.CountAllSights();
            int sightHisCount = Stats.CountAllSightHis();
            lblSight.Visible = lblSightCount.Visible = true;
            lblSightCount.Text = sightsCount.ToString();
            lblSightHisClone.Visible = lblSightHisCountClone.Visible = true;
            lblSightHisCountClone.Text = sightHisCount.ToString();
            List<string> xStatsList = new();
            List<int> yStatsList = new();
            foreach (var sight in Query.GetAllSight())
            {
                xStatsList.Add($"ID {sight.Id}");
                yStatsList.Add(Stats.CountAllSightHis(sight.Id));
            }
            xStats = xStatsList.ToArray();
            yStats = yStatsList.ToArray();
        }

        private void LoadSightHisStats(int sightId = 0)
        {
            int sightHisCount = Stats.CountAllSightHis(sightId);
            int sightHisTier1Count = Stats.CountSightHisByPoint(81, 100, sightId);
            int sightHisTier2Count = Stats.CountSightHisByPoint(61, 80, sightId);
            int sightHisTier3Count = Stats.CountSightHisByPoint(40, 60, sightId);
            int sightHisTier4Count = Stats.CountSightHisByPoint(20, 39, sightId);
            int sightHisTier5Count = Stats.CountSightHisByPoint(0, 19, sightId);
            lblSightHis.Visible = lblSightHisCount.Visible = true;
            lblSightHisCount.Text = sightHisCount.ToString();
            lblSightHisTier1.Visible = lblSightHisTier1Count.Visible = true;
            lblSightHisTier1Count.Text = sightHisTier1Count.ToString();
            lblSightHisTier2.Visible = lblSightHisTier2Count.Visible = true;
            lblSightHisTier2Count.Text = sightHisTier2Count.ToString();
            lblSightHisTier3.Visible = lblSightHisTier3Count.Visible = true;
            lblSightHisTier3Count.Text = sightHisTier3Count.ToString();
            lblSightHisTier4.Visible = lblSightHisTier4Count.Visible = true;
            lblSightHisTier4Count.Text = sightHisTier4Count.ToString();
            lblSightHisTier5.Visible = lblSightHisTier5Count.Visible = true;
            lblSightHisTier5Count.Text = sightHisTier5Count.ToString();
            xStats = new string[5] { "81 - 100", "61 - 80", "40 - 60", "20 - 39", "0 - 19" };
            yStats = new int[5] { sightHisTier1Count, sightHisTier2Count, sightHisTier3Count, sightHisTier4Count, sightHisTier5Count };
        }

        private void LoadStudentStats()
        {
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
        }

        private void LoadGameStats()
        {
            int gameCount = Stats.CountAllGames();
            int playHisCount = Stats.CountAllPlayHis();
            lblGame.Visible = lblGameCount.Visible = true;
            lblGameCount.Text = gameCount.ToString();
            lblPlayHisClone.Visible = lblPlayHisCountClone.Visible = true;
            lblPlayHisCountClone.Text = playHisCount.ToString();
            List<string> xStatsList = new();
            List<int> yStatsList = new();
            foreach (var game in Query.GetAllGame())
            {
                xStatsList.Add($"ID {game.Id}");
                yStatsList.Add(Stats.CountAllPlayHis(game.Id));
            }
            xStats = xStatsList.ToArray();
            yStats = yStatsList.ToArray();
        }

        private void LoadPlayHisStats(int gameId = 0)
        {
            int playHisCount = Stats.CountAllPlayHis(gameId);
            int playHisTier1Count = Stats.CountPlayHisByPoint(81, 100, gameId);
            int playHisTier2Count = Stats.CountPlayHisByPoint(61, 80, gameId);
            int playHisTier3Count = Stats.CountPlayHisByPoint(40, 60, gameId);
            int playHisTier4Count = Stats.CountPlayHisByPoint(20, 39, gameId);
            int playHisTier5Count = Stats.CountPlayHisByPoint(0, 19, gameId);
            lblPlayHis.Visible = lblPlayHisCount.Visible = true;
            lblPlayHisCount.Text = playHisCount.ToString();
            lblPlayHisTier1.Visible = lblPlayHisTier1Count.Visible = true;
            lblPlayHisTier1Count.Text = playHisTier1Count.ToString();
            lblPlayHisTier2.Visible = lblPlayHisTier2Count.Visible = true;
            lblPlayHisTier2Count.Text = playHisTier2Count.ToString();
            lblPlayHisTier3.Visible = lblPlayHisTier3Count.Visible = true;
            lblPlayHisTier3Count.Text = playHisTier3Count.ToString();
            lblPlayHisTier4.Visible = lblPlayHisTier4Count.Visible = true;
            lblPlayHisTier4Count.Text = playHisTier4Count.ToString();
            lblPlayHisTier5.Visible = lblPlayHisTier5Count.Visible = true;
            lblPlayHisTier5Count.Text = playHisTier5Count.ToString();
            xStats = new string[5] { "81 - 100", "61 - 80", "40 - 60", "20 - 39", "0 - 19" };
            yStats = new int[5] { playHisTier1Count, playHisTier2Count, playHisTier3Count, playHisTier4Count, playHisTier5Count };
        }

        private void LoadAccountStats()
        {
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
        }

        private void LoadTPointHisStats()
        {
            int tPointHisCount = Stats.CountAllTPointHis();
            int tPointPlusTwoCount = Stats.CountTPointHisFilter(2);
            int tPointPlusOneCount = Stats.CountTPointHisFilter(1);
            lblTPointHis.Visible = lblTPointHisCount.Visible = true;
            lblTPointHisCount.Text = tPointHisCount.ToString();
            lblTPointPlusTwo.Visible = lblTPointPlusTwoCount.Visible = true;
            lblTPointPlusTwoCount.Text = tPointPlusTwoCount.ToString();
            lblTPointPlusOne.Visible = lblTPointPlusOneCount.Visible = true;
            lblTPointPlusOneCount.Text = tPointPlusOneCount.ToString();
            xStats = new string[2] { "+ 2", "+ 1" };
            yStats = new int[2] { tPointPlusTwoCount, tPointPlusOneCount };
        }

        private void LoadStats()
        {
            foreach (var label in tabPageStatsOther.Controls.OfType<Label>())
            {
                label?.Hide();
                cboSelect.Hide();
            }
            switch (form.SelectedClassValue)
            {
                case nameof(Sight):
                    LoadSightStats();
                    break;
                case nameof(SightHis):
                    cboSelect.Visible = true;
                    cboSelect.Items.Add("All");
                    foreach (var sight in Query.GetAllSight())
                    {
                        cboSelect.Items.Add(sight.Id);
                    }
                    cboSelect.SelectedIndex = 0;
                    LoadSightHisStats(0);
                    break;
                case nameof(Student):
                    LoadStudentStats();
                    break;
                case nameof(Game):
                    LoadGameStats();
                    break;
                case nameof(PlayHis):
                    cboSelect.Visible = true;
                    cboSelect.Items.Add("All");
                    foreach (var game in Query.GetAllGame())
                    {
                        cboSelect.Items.Add(game.Id);
                    }
                    cboSelect.SelectedIndex = 0;
                    LoadPlayHisStats(0);
                    break;
                case nameof(Account):
                    LoadAccountStats();
                    break;
                case nameof(TPointHis):
                    LoadTPointHisStats();
                    break;
                default:
                    statsOtherAvailable = false;
                    break;
            }
        }

        private void CheckSearchDataAvailable()
        {
            if (statsSearchAvailable)
            {
                chartStatsSearch.Series[0].Points.DataBindXY(xSearch, ySearch);
                chartStatsSearch.Series[0].IsValueShownAsLabel = true;
            }
            else
            {
                MessageBox.Show("Không có dữ liệu tìm kiếm.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (statsOtherAvailable)
                {
                    tabStats.SelectedTab = tabPageStatsOther;
                }
                else
                {
                    Close();
                }
            }
        }

        private void CheckOtherStatsAvailable()
        {
            if (statsOtherAvailable)
            {
                chartStatsOther.Series[0].Points.DataBindXY(xStats, yStats);
                chartStatsOther.Series[0].IsValueShownAsLabel = true;
            }
            else
            {
                MessageBox.Show("Không có dữ liệu thống kê khác.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (statsSearchAvailable)
                {
                    tabStats.SelectedTab = tabPageStatsSearch;
                }
                else
                {
                    Close();
                }
            }
        }

        public FormStats(formStatistic frm)
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
            bool isExactSearch = form.IsExactSearch;
            int threshold = form.Threshold, lowerBound = form.IntLowerBound, upperBound = form.IntUpperBound;
            int countOfAll = 0, countMatchKeyword = 0, countMetThreshold = 0, countInRange = 0;
            if (selClass != null && selProperty != null)
            {
                countOfAll = (int)SearchUtil.StaticCallGenericVarType(nameof(Stats), selClass, nameof(Stats.CountAll), null, null)!;
                if (keyword != null)
                {
                    if (isExactSearch)
                    {
                        countMatchKeyword = (int)SearchUtil.StaticCallGenericVarType(nameof(Stats), selClass, nameof(Stats.CountFilterString), new[] { typeof(string), typeof(string) }, new[] { selProperty, keyword })!;
                        xSearch[0] = $"Trùng \"{keyword}\""; xSearch[1] = "Còn lại";
                        lblMatch.Text = $"Trùng từ khóa \"{keyword}\":";
                    }
                    else
                    {
                        countMatchKeyword = Stats.CountFilterContainsString(selClass, selProperty, keyword);
                        xSearch[0] = $"Chứa \"{keyword}\""; xSearch[1] = "Còn lại";
                        lblMatch.Text = $"Chứa từ khóa \"{keyword}\":";
                    }
                    ySearch[0] = countMatchKeyword; ySearch[1] = countOfAll - countMatchKeyword;
                    lblMatchCount.Text = countMatchKeyword.ToString();
                }
                else if (filter != null && threshold != int.MinValue)
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
                else if (lowerBound != int.MinValue && upperBound != int.MaxValue)
                {
                    countInRange = Stats.CountFilterInt(selClass, selProperty, lowerBound, upperBound);
                    xSearch[0] = $"{lowerBound}-{upperBound}"; xSearch[1] = "Còn lại";
                    ySearch[0] = countInRange; ySearch[1] = countOfAll - countInRange;
                    lblMatch.Text = $"Trong khoảng {lowerBound}-{upperBound}:";
                    lblMatchCount.Text = countInRange.ToString();
                }
                else
                {
                    statsSearchAvailable = false;
                }
            }
            lblTotalCount.Text = countOfAll.ToString();
            CheckSearchDataAvailable();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tabStats_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabStats.SelectedTab == tabPageStatsSearch)
            {
                CheckSearchDataAvailable();
            }
            if (tabStats.SelectedTab == tabPageStatsOther)
            {
                CheckOtherStatsAvailable();
            }
        }

        private void cboSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (form.SelectedClassValue)
            {
                case nameof(SightHis):
                    if (cboSelect.SelectedIndex == 0)
                    {
                        LoadSightHisStats();
                    }
                    else
                    {
                        LoadSightHisStats((int)cboSelect.SelectedItem);
                    }
                    break;
                case nameof(PlayHis):
                    if (cboSelect.SelectedIndex == 0)
                    {
                        LoadPlayHisStats();
                    }
                    else
                    {
                        LoadPlayHisStats((int)cboSelect.SelectedItem);
                    }
                    break;
                default:
                    break;
            }
            chartStatsOther.Series[0].Points.DataBindXY(xStats, yStats);
            chartStatsOther.Series[0].IsValueShownAsLabel = true;
        }
    }
}