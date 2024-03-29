using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UEH_EVENT.Utils;

namespace UEH_EVENT.GUI
{
    public partial class formHistory : Form
    {
        private List<SightHis> sightHises;
        private List<TPointHis> tPointsHises;
        public formHistory()
        {
            InitializeComponent();
            Constants.INavbar.CreateNavbar(this, Navbar);
        }

        private void formHistory_Load(object sender, EventArgs e)
        {
            sightHises = Query.GetSightHisByStudentId(GlobalData.CurrentAccount.StudentId);
            tPointsHises = Query.GetTPointHisByStudentId(GlobalData.CurrentAccount.StudentId);
            Student st = GlobalData.CurrentAccount.Student;

            foreach (var sightHis in sightHises)
            {
                Sight s = Query.GetSpecificSight(sightHis.SightId);

                ListViewItem item = new ListViewItem(sightHis.StudentId);
                item.SubItems.Add(st.Name);
                item.SubItems.Add(s.Name);
                item.SubItems.Add(s.Questions.Count.ToString());
                item.SubItems.Add(sightHis.Point.ToString());
                lstLslbtn.Items.Add(item);
            }
            foreach (var tPointHis in tPointsHises)
            {
                ListViewItem item = new ListViewItem(tPointHis.StudentId);
                item.SubItems.Add(st.Name);
                item.SubItems.Add(tPointHis.Point.ToString());
                item.SubItems.Add(tPointHis.CreatedAt.ToString("dd/MM/yyyy"));
                item.SubItems.Add(tPointHis.Content);
                lstLscndrl.Items.Add(item);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
