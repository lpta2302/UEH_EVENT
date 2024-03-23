namespace UEH_EVENT.GUI
{
    public partial class FormSearch : Form
    {
        private void ToggleNumericSearch(bool isOn)
        {
            rdoSearchThreshold.Enabled = cboFilter.Enabled = txtThreshold.Enabled = isOn;
            rdoSearchRange.Enabled = txtLowerBound.Enabled = txtUpperBound.Enabled = isOn;
        }

        private void ToggleTextSearch(bool isOn)
        {
            txtSearchKeyword.Enabled = isOn;
        }

        public FormSearch()
        {
            InitializeComponent();
        }

        private void FormSearch_Load(object sender, EventArgs e)
        {
            cboSearch.Items.AddRange(SearchUtil.GetDisplayClassNames());
            cboSearch.SelectedIndex = 0;
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            FormStats stats = new();
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
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string? selectedClass = SearchUtil.GetClassNameFromDisplay(cboSearch.SelectedItem.ToString()!);
            string? selectedProperty = cboProperties.SelectedItem.ToString();
            if (selectedClass != null && selectedProperty != null)
            {
                if (txtSearchKeyword.Enabled)
                {
                    dgvSearchResults.DataSource = Search.SearchString(selectedClass, selectedProperty, txtSearchKeyword.Text.Trim());
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
                        }
                    }
                }
            }
        }
    }
}