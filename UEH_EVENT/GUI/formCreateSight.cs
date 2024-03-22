using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UEH_EVENT.GUI
{
    public partial class formCreateSight : Form
    {
        Sight CurrentSight = GlobalData.CurrentSight;
        public formCreateSight()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Hide();
            new formCreateQuestion().ShowDialog();
            Close();
        }

        private void formCreateSight_Load(object sender, EventArgs e)
        {
            txtTenTN.Focus();
            for (int i = 0; i < CurrentSight.Questions.Count; i++)
            {
                string[] row = new string[] { "" + (i + 1), CurrentSight.Questions[i].Content };
                ListViewItem listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
            }

        }
        private void btnSua_Click(object sender, EventArgs e)
        {

            Hide();
            if (listView1.SelectedIndices.Count != 0)
            {
                new formCreateQuestion(listView1.SelectedIndices[0]).ShowDialog();
                return;
            }
            Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count == 0)
            {
                return;
            }

            new formCreateQuestion(listView1.SelectedIndices[0]).ShowDialog();
            Close();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            if (txtTenTN.Text != "" && CurrentSight.Questions.Count > 0)
            {
                CurrentSight.Name = txtTenTN.Text;
                CurrentSight.Preview = txtMoTa.Text;
                Database.Insert<Sight>(CurrentSight);
            }
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

        }
    }
}
