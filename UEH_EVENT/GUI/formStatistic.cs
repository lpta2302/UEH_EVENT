using UEH_EVENT.Utils;

namespace UEH_EVENT.GUI
{
    public partial class formStatistic : Form
    {
        public formStatistic()
        {
            InitializeComponent();
            Constants.INavbar.CreateNavbar(this, Navbar);
        }
        public string? SelectedClassValue { get; set; }
        public string? SelectedPropertyValue { get; set; }
        public string? SearchKeyword { get; set; }
        public bool IsExactSearch { get; set; }
        public string? ThresholdFilter { get; set; }
        public int Threshold { get; set; }
        public int IntLowerBound { get; set; }
        public int IntUpperBound { get; set; }

        private void ToggleNumericSearch(bool isOn)
        {
            rdoSearchThreshold.Enabled = cboFilter.Enabled = txtThreshold.Enabled = isOn;
            rdoSearchRange.Enabled = txtLowerBound.Enabled = txtUpperBound.Enabled = isOn;
        }

        private void ToggleTextSearch(bool isOn)
        {
            txtSearchKeyword.Enabled = chkSearchExact.Enabled = isOn;
        }

        private void ToggleStatsButton()
        {
            if (cboSearch.SelectedIndex == 0 || cboProperties.SelectedIndex == 0)
            {
                btnStats.Enabled = false;
            }
            else
            {
                btnStats.Enabled = true;
            }
        }

        private void formStatistic_Load(object sender, EventArgs e)
        {
            if (GlobalData.CurrentAccount?.AccType == Constants.ADMIN_ACC)
            {
                cboSearch.Items.AddRange(SearchUtil.GetDisplayClassNames());
            }
            if (GlobalData.CurrentAccount?.AccType == Constants.CLB_ACC)
            {
                foreach (var name in SearchUtil.GetDisplayClassNames())
                {
                    if (name == Constants.CLASS_NAMES[nameof(Account)])
                    {
                        continue;
                    }
                    else
                    {
                        cboSearch.Items.Add(name);
                    }
                }
            }
            cboSearch.SelectedIndex = 0;
            ToggleStatsButton();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            SelectedClassValue = SearchUtil.GetClassNameFromDisplay(cboSearch.SelectedItem.ToString()!);
            SelectedPropertyValue = cboProperties.SelectedItem.ToString();
            if (txtSearchKeyword.Enabled)
            {
                SearchKeyword = txtSearchKeyword.Text;
            }
            else
            {
                SearchKeyword = null;
            }
            if (chkSearchExact.Enabled)
            {
                IsExactSearch = chkSearchExact.Checked;
            }
            if (rdoSearchThreshold.Enabled && rdoSearchThreshold.Checked)
            {
                ThresholdFilter = cboFilter.SelectedIndex != 0 ? cboFilter.SelectedItem.ToString() : null;
                Threshold = int.TryParse(txtThreshold.Text, out int threshold) ? threshold : int.MinValue;
            }
            else
            {
                ThresholdFilter = null;
                Threshold = int.MinValue;
            }
            if (rdoSearchRange.Enabled && rdoSearchRange.Checked)
            {
                IntLowerBound = int.TryParse(txtLowerBound.Text, out int lowerBound) ? lowerBound : int.MinValue;
                IntUpperBound = int.TryParse(txtUpperBound.Text, out int upperBound) ? upperBound : int.MaxValue;
            }
            else
            {
                IntLowerBound = int.MinValue;
                IntUpperBound = int.MaxValue;
            }
            FormStats stats = new(this);
            stats.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboProperties.Items.Clear();
            string? selectedClass = SearchUtil.GetClassNameFromDisplay(cboSearch.SelectedItem.ToString()!);
            if (selectedClass != null)
            {
                cboProperties.Items.AddRange(SearchUtil.GetPropertyNamesFromClass(selectedClass));
                dgvSearchResults.DataSource = Search.QueryAll(selectedClass);
            }
            cboProperties.SelectedIndex = 0;
            ToggleStatsButton();
        }

        private void cboProperties_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? selectedClass = SearchUtil.GetClassNameFromDisplay(cboSearch.SelectedItem.ToString()!);
            string? selectedProperty = cboProperties.SelectedItem.ToString();
            Type? propType = null;
            if (selectedClass != null && selectedProperty != null)
            {
                propType = SearchUtil.GetTypeOfProperty(selectedClass, selectedProperty);
            }
            if (propType == typeof(int))
            {
                ToggleNumericSearch(true);
                ToggleTextSearch(false);
                cboFilter.Items.Clear(); cboFilter.Items.AddRange(new[] { "(select)", ">", "=", "<", ">=", "<=" });
                cboFilter.SelectedIndex = 0;
            }
            else if (propType == typeof(string))
            {
                ToggleNumericSearch(false);
                ToggleTextSearch(true);
            }
            else
            {
                ToggleNumericSearch(false);
                ToggleTextSearch(false);
            }
            ToggleStatsButton();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string? selectedClass = SearchUtil.GetClassNameFromDisplay(cboSearch.SelectedItem.ToString()!);
            string? selectedProperty = cboProperties.SelectedItem.ToString();
            if (selectedClass != null && selectedProperty != null)
            {
                if (txtSearchKeyword.Enabled)
                {
                    dgvSearchResults.DataSource = SearchWildcard.SearchWithWildcard(selectedClass, selectedProperty, txtSearchKeyword.Text.Trim(), chkSearchExact.Checked);
                }
                else
                {
                    if (rdoSearchThreshold.Checked)
                    {
                        if (int.TryParse(txtThreshold.Text, out int threshold))
                        {
                            switch (cboFilter.SelectedItem.ToString())
                            {
                                case ">":
                                case "=":
                                case "<":
                                    dgvSearchResults.DataSource = Search.SearchInt(selectedClass, selectedProperty, Convert.ToChar(cboFilter.SelectedItem), threshold);
                                    break;
                                case ">=":
                                case "<=":
                                    dgvSearchResults.DataSource = Search.SearchInt(selectedClass, selectedProperty, cboFilter.SelectedItem.ToString()!, threshold);
                                    break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Số đã nhập không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtThreshold.Text = string.Empty;
                        }
                    }
                    if (rdoSearchRange.Checked)
                    {
                        if (int.TryParse(txtLowerBound.Text, out int lowerBound) && int.TryParse(txtUpperBound.Text, out int upperBound))
                        {
                            dgvSearchResults.DataSource = Search.SearchInt(selectedClass, selectedProperty, lowerBound, upperBound);
                        }
                        else
                        {
                            MessageBox.Show("Số đã nhập không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtLowerBound.Text = txtUpperBound.Text = string.Empty;
                        }
                    }
                }
            }
        }
    }
}
