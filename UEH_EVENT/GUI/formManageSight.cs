using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UEH_EVENT.GUI
{
    public partial class formManageSight : Form
    {
        private List<Sight>? sights;
        private void LoadSightsListView()
        {
            lstSight.Items.Clear();
            int stt = 1;
            if (sights == null) return;

            foreach (var sight in sights)
            {
                ListViewItem item = new ListViewItem(stt.ToString());
                item.SubItems.Add(sight.Name);
                item.SubItems.Add(sight.CreatedBy?.Name ?? ""); // Tên người tạo, nếu sight.CreatedBy là null thì trả về chuỗi trống
                item.SubItems.Add(sight.CreatedAt.ToString("dd/MM/yyyy")); // Định dạng ngày tháng
                item.SubItems.Add(sight.Questions?.Count.ToString() ?? "0"); // Số lượng câu hỏi, nếu sight.Questions là null thì trả về "0"

                lstSight.Items.Add(item);
                stt++;
            }
        }
        public formManageSight()
        {
            InitializeComponent();
            Constants.INavbar.CreateNavbar(this, Navbar);
        }

        private void gotFocus(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void lstAccount_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbCLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).SelectedIndex != -1)
                search(sender);
        }
        private void formManageSight_Load(object sender, EventArgs e)
        {
            cbbCLB.Items.AddRange(Query.GetAccountsByType(Constants.CLB_ACC)?.Select<Account, string>(x => x.Name).ToArray());
            LoadSightsListView();
        }
        private void search(object sender)
        {
            if (sender is TextBox)
            {
                sights = Query.GetSightsByName(((TextBox)sender).Text);
            }
            else if (sender is ComboBox)
            {
                ComboBox comboBox = (ComboBox)sender;
                sights = Query.GetSightsByCreatedById(
                    Query.GetAccountByName((string)comboBox.SelectedItem)[0].Id
                );
            }
            if (sights != null)
            {
                LoadSightsListView();
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search(sender);
            }
        }

        private void cbbCLB_SelectedValueChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).SelectedValue != null)
                search(sender);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstSight.SelectedItems.Count == 0 || sights == null)
            {
                MessageBox.Show("Hãy chọn ít nhất một bài trắc nghiệm để thực hiện xoá", "Không tìm thấy bài trắc nghiệm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            sights.RemoveAt(lstSight.SelectedIndices[0]);
            LoadSightsListView();
            Database.Delete<Sight>(sights[lstSight.SelectedIndices[0]].Id);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (lstSight.SelectedIndices.Count == 0 || sights == null)
            {
                MessageBox.Show("Chọn một bài trắc nghiệm để làm thử");
                return;
            }
            Hide();
            new formDoingSight(sights[lstSight.SelectedIndices[0]].Id).ShowDialog();
            Close();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (lstSight.SelectedIndices.Count == 0 || sights == null)
            {
                MessageBox.Show("Chọn một bài trắc nghiệm để xem");
                return;
            }
            Hide();
            new formCreateSight(sights[lstSight.SelectedIndices[0]],true).ShowDialog();
            Close();
        }
    }
}
