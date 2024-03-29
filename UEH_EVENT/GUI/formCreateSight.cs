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
        private Sight? CurrentSight;
        bool disable = false;
        private void disableAll()
        {
            txtMoTa.Enabled = false;
            txtTenTN.Enabled = false;
            btnSua.Visible = false;
            btnThem.Visible = false;
            btnXoa.Visible = false;
            btnTao.Text = "Xem";
        }
        public formCreateSight()
        {
            InitializeComponent();
            CurrentSight = GlobalData.CurrentSight;
        }
        public formCreateSight(Sight CurrentSight, bool disable = false)
        {
            InitializeComponent();

            this.disable = disable;
            this.CurrentSight = CurrentSight;

            for(int i=0;i< CurrentSight.Questions.Count; i++)
            {

                CurrentSight.Questions[i] = Query.GetQuestion(CurrentSight.Questions[i].Id);
            }
            if (disable)
            {
                disableAll();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Hide();
            new formCreateQuestion(CurrentSight).ShowDialog();
            Close();
        }

        private void formCreateSight_Load(object sender, EventArgs e)
        {
            if (CurrentSight == null) return;

            txtTenTN.Text = CurrentSight.Name;
            txtMoTa.Text = CurrentSight.Preview;

            if (CurrentSight.Questions == null) return;

            for (int i = 0; i < CurrentSight.Questions.Count; i++)
            {
                ListViewItem listViewItem = new ListViewItem($"{(i + 1)}");
                listViewItem.SubItems.Add(CurrentSight.Questions[i].Content);
                listView1.Items.Add(listViewItem);
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedIndices.Count != 0 && CurrentSight.Questions != null)
            {
                Hide();
                new formCreateQuestion(CurrentSight,listView1.SelectedIndices[0]).ShowDialog();
                Close();
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            if (disable)
            {
                Hide();
                new formCreateQuestion(CurrentSight, listView1.SelectedIndices[0], disable).ShowDialog();
                Close();
                return;
            }
            if(txtTenTN.Text == "")
            {
                MessageBox.Show("Tên bài trắc nghiệm không được để trống!","Thêm thất bại",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (CurrentSight!.Questions?.Count == 0)
            {
                MessageBox.Show("Bài trắc nghiệm phải có ít nhất 1 câu hỏi", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CurrentSight.Name = txtTenTN.Text;
            CurrentSight.Preview = txtMoTa.Text;
            Database.Insert<Sight>(CurrentSight);
            GlobalData.CurrentSight = null;
            GlobalData.CurrentAccount.SightSession = null;
            Database.Update<Account>(GlobalData.CurrentAccount);
            MessageBox.Show("Thêm thành công", "Thông báo");
            Hide();
            Form form = GlobalData.CurrentAccount.AccType == Constants.CLB_ACC ? new formLobbySight() : new formManageSight();
            form.ShowDialog();
            Close();
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
            //Nếu là tài khoản chỉ được xem
            if(GlobalData.CurrentAccount.AccType == Constants.ADMIN_ACC)
            {
                Hide();
                new formManageSight().ShowDialog();
                Close();
                return;
            }

            //Nếu CurrentSight không có và đảm bảo là đang thêm mới
            if (GlobalData.CurrentSight == null || GlobalData.CurrentSight.Id != CurrentSight.Id) return;

            if (MessageBox.Show("Bài trắc nghiệm chưa được lưu, bạn có muốn lưu phiên làm việc không?", "Thông báo", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //string json = JsonConvert.SerializeObject(CurrentSight, Formatting.Indented);
                string json = JsonConvert.SerializeObject(CurrentSight, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
                GlobalData.CurrentAccount.SightSession = json;
                Database.Update<Account>(GlobalData.CurrentAccount);
            }
            else
            {
                CurrentSight = null;
            }

            Hide();
            Form form = GlobalData.CurrentAccount.AccType == Constants.CLB_ACC ? new formLobbySight() : new formManageSight();
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
