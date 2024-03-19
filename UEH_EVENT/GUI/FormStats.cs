using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UEH_EVENT.GUI
{
    public partial class FormStats : Form
    {
        public FormStats()
        {
            InitializeComponent();
        }

        private void FormStats_Load(object sender, EventArgs e)
        {
            lblSightsCount.Text = Stats.CountAllSights().ToString();
            lblSightsOver50Count.Text = Stats.CountSightHisByPoint(50).ToString();

            lblStudentsCount.Text = Stats.CountAllStudents().ToString();

            lblTPointOver50Count.Text = Stats.CountStudentsByTPoints(50).ToString();
            lblTPointTier1Count.Text = Stats.CountStudentsByTPoints(90, 100).ToString();
            lblTPointTier2Count.Text = Stats.CountStudentsByTPoints(80, 89).ToString();
            lblTPointTier3Count.Text = Stats.CountStudentsByTPoints(65, 79).ToString();
            lblTPointTier4Count.Text = Stats.CountStudentsByTPoints(50, 64).ToString();

            lblPlayHisCount.Text = Stats.CountAllPlayHis().ToString();
            lblPlayHisOver50Count.Text = Stats.CountPlayHisByPoint(50).ToString();

            lblAccountsCount.Text = Stats.CountAllAccounts().ToString();
            lblStudentAccountsCount.Text = Stats.CountAllAccountsByType(Constants.STUDENT_ACC).ToString();
            lblClubAccountsCount.Text = Stats.CountAllAccountsByType(Constants.CLB_ACC).ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
