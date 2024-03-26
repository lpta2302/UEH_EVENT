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
    public partial class formManageSight : Form
    {
        List<Sight> sights;
        private void LoadSightsListView()
        {
            int stt = 1;
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
        }

        private void lstAccount_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbCLB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblto_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Lặp qua tất cả các nút trong Controls của Form
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    Button button = (Button)control;
                    button.BackColor = Color.FromArgb(34, 34, 34); // Background màu 34,34,34
                    button.ForeColor = Color.White; // Foreground màu trắng
                    button.FlatStyle = FlatStyle.Flat; // Loại bỏ border
                    button.FlatAppearance.BorderSize = 0; // Đặt kích thước đường viền là 0
                }
            }
        }
        private void formManageSight_Load(object sender, EventArgs e)
        {
            sights = Query.GetAllSight();
            LoadSightsListView();
        }

        private void lblfrom_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
