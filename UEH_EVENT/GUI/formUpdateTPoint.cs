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
    public partial class formUpdateTPoint : Form
    {
        private List<Student> students;
        public formUpdateTPoint()
        {

            InitializeComponent();
            Constants.INavbar.CreateNavbar(this, Navbar);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void formUpdateTPoint_Load(object sender, EventArgs e)
        {
            students = Query.GetAllStudent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtEnter.Text.Trim();
            if (string.IsNullOrEmpty(txtReason.Text))
            {
                MessageBox.Show("Vui lòng nhập lý do cập nhật điểm rèn luyện.");
                return;
            }

            if (comboBoxPoint.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn điểm cập nhật.");
                return;
            }

            bool found = false;

            var result = students.Where(s => s.Name.Contains(searchText) || s.Mssv.Contains(searchText)).ToList();

            lstStudent.Items.Clear();

            foreach (var student in result)
            {
                ListViewItem item = new ListViewItem(student.Mssv);
                item.SubItems.Add(student.Name);
                item.SubItems.Add(student.Batch);
                item.SubItems.Add(student.ClassId);
                lstStudent.Items.Add(item);

                found = true;
            }

            if (!found)
            {
                MessageBox.Show("Không tìm thấy sinh viên.");
            }
        }



        private void txtEnter_MouseEnter(object sender, EventArgs e)
        {
            txtEnter.Text = "";
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstStudent.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để cập nhật điểm.");
                return;
            }
            string studentid = lstStudent.SelectedItems[0].Text;
            int point = int.Parse(comboBoxPoint.SelectedItem.ToString());
            string content = txtReason.Text;
            TPointHis his = new TPointHis()
            {
                StudentId = studentid,
                Point = point,
                Content = content
            };

            try
            {
                Database.Insert<TPointHis>(his);
                MessageBox.Show("Cập nhật điểm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void panelFrame_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxReason_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
