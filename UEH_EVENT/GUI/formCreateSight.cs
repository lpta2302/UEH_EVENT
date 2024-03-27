using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using UEH_EVENT.Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UEH_EVENT.GUI
{
    public partial class formCreateSight : Form
    {
        Sight CurrentSight = GlobalData.CurrentSight;
        private void initForm()
        {

            for (int i = 0; i < CurrentSight.Questions.Count; i++)
            {
                ListViewItem item1 = new ListViewItem((i+1).ToString());
                item1.SubItems.Add($"{CurrentSight.Questions[i].Content}"); // Thêm giá trị cho cột thứ hai (Subitem)
                listView1.Items.Add(item1);

                /*ListViewItem item2 =new ListViewItem();
                item2.SubItems.Add($"{CurrentSight.Questions[i].Content}");
                listView1.Items.Add(item2);
                */

            }
        }
        public formCreateSight()
        {
            InitializeComponent();
            txtTenTN.Text=CurrentSight.Name;
            txtMoTa.Text=CurrentSight.Preview;
        }
        public formCreateSight(Sight CurrentSight)
        {
            InitializeComponent();
            this.CurrentSight = Query.GetSpecificSight(CurrentSight.Id);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Hide();
            new formCreateQuestion().ShowDialog();
            Close();
        }

        private void formCreateSight_Load(object sender, EventArgs e)
        {
            if (CurrentSight == null) return;
            txtTenTN.Text = CurrentSight.Name;
            txtMoTa.Text = CurrentSight.Preview;
            for (int i = 0; i < CurrentSight.Questions.Count; i++)
            {
                string[] row = new string[] { "" + (i + 1), CurrentSight.Questions[i].Content };
                ListViewItem listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
            }

        }
        private void btnSua_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedIndices.Count != 0)
            {
                new formCreateQuestion(listView1.SelectedIndices[0]).ShowDialog();
                return;
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            if(txtTenTN.Text != "")
            {
                MessageBox.Show("Tên bài trắc nghiệm không được để trống!","Thêm thất bại",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (CurrentSight.Questions.Count > 0)
            {
                MessageBox.Show("Bài trắc nghiệm phải có ít nhất 1 câu hỏi", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CurrentSight.Name = txtTenTN.Text;
            CurrentSight.Preview = txtMoTa.Text;
            Database.Insert<Sight>(CurrentSight);
            MessageBox.Show("Thêm thành công", "Thông báo");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá câu hỏi này ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].Selected)
                    {
                        listView1.Items[i].Remove();
                        i--;
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bài trắc nghiệm chưa được lưu, bạn có muốn lưu phiên làm việc không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string json = JsonConvert.SerializeObject(CurrentSight, Formatting.Indented);
                GlobalData.CurrentAccount.SightHis = json;
            }
            else
            {
                CurrentSight = null;
            }

            Hide();
            Form form = new formLobbySight();
            form.ShowDialog();
            Close();
        }

        private void txtTenTN_TextChanged(object sender, EventArgs e)
        {
            CurrentSight.Name = txtTenTN.Text;
        }

        private void txtMoTa_TextChanged(object sender, EventArgs e)
        {
            CurrentSight.Preview= txtMoTa.Text;
        }
    }
}
