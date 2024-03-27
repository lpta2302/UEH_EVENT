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
    public partial class formLobbySight : Form
    {
        List<Sight> list = new List<Sight>();
        public formLobbySight()
        {
            InitializeComponent();
            list = Query.GetAllSight();
            HienThiSight();
            Constants.INavbar.CreateNavbar(this, Navbar);
        }

        private void formSight_Load(object sender, EventArgs e)
        {
        }

        private void HienThiSight()
        {

            // Vòng lặp qua từng Sight trong danh sách và thêm vào ListView
            for (int i = 0; i < list.Count; i++)
            {
                Sight sight = list[i];
                Button btnUpdate = new Button();
                Button btnDelete = new Button();
                Panel panel = new Panel();
                Label lblTenBai = new Label();
                Label lblThoiGian = new Label();

                panel.Controls.Add(btnUpdate);
                panel.Controls.Add(btnDelete);
                panel.Controls.Add(btnUpdate);
                panel.Controls.Add(lblTenBai);
                panel.Controls.Add(lblThoiGian);
                // 
                // button2
                // 
                btnUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
                btnUpdate.Location = new Point(952, 29);
                btnUpdate.Tag = i;
                btnUpdate.Click += btnUpdate_Click;
                btnUpdate.Size = new Size(106, 33);
                btnUpdate.TabIndex = 1;
                btnUpdate.Text = "Sửa";
                btnUpdate.UseVisualStyleBackColor = true;
                // 
                // button1
                // 
                btnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
                btnDelete.Location = new Point(812, 29);
                btnDelete.Tag = i;
                btnDelete.Click += btnDelete_Click;
                btnDelete.Size = new Size(106, 33);
                btnDelete.Text = "Xoá";
                btnDelete.UseVisualStyleBackColor = true;
                // 
                // panel2
                // 
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Location = new Point(21, 43);
                panel.Size = new Size(1080, 104);
                // 
                // lblTenBai
                // 
                lblTenBai.Font = new Font("Segoe UI", 14.2F, FontStyle.Bold, GraphicsUnit.Point);
                lblTenBai.Location = new Point(29, 13);
                lblTenBai.Size = new Size(454, 34);
                lblTenBai.TabIndex = 6;
                lblTenBai.Text = sight.Name;
                lblTenBai.TextAlign = ContentAlignment.MiddleLeft;
                // 
                // lblThoiGian
                // 
                lblThoiGian.Location = new Point(29, 62);
                lblThoiGian.Size = new Size(454, 24);
                lblThoiGian.TabIndex = 2;
                lblThoiGian.Text = sight.CreatedAt.ToString("dd/MM/yyyy");
                lblThoiGian.TextAlign = ContentAlignment.MiddleLeft;
                flowLayoutPanel1.Controls.Add(panel);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = (int)((Button)sender).Tag;
            flowLayoutPanel1.Controls.RemoveAt(index);
            Database.Delete<Sight>(list[index].Id);
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Hide();
            new formCreateSight(list[(int)((Button)sender).Tag]).ShowDialog();
            Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new formCreateSight();
            form.ShowDialog();
            Close();
        }
    }
}
