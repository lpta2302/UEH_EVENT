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
    public partial class formSight : Form
    {
        Sight sight = new Sight();
        List<Sight> list = new List<Sight>();
        public formSight()
        {
            InitializeComponent();
        }

        private void formSight_Load(object sender, EventArgs e)
        {
            list = Query.GetAllSight();
            HienThiSight();
        }

        private void HienThiSight()
        {
            for (int i = 0; i < list.Count; i++)
            {
                Sight s = list[i];
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
                btnUpdate.Name = "btnUpdate"+i;
                btnUpdate.Size = new Size(106, 33);
                btnUpdate.TabIndex = 1;
                btnUpdate.Text = "Sửa";
                btnUpdate.UseVisualStyleBackColor = true;
                // 
                // button1
                // 
                btnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
                btnDelete.Location = new Point(812, 29);
                btnDelete.Name = "btnDelete"+i;
                btnDelete.Size = new Size(106, 33);
                btnDelete.TabIndex = 0;
                btnDelete.Text = "Xoá";
                btnDelete.UseVisualStyleBackColor = true;
                // 
                // panel2
                // 
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Location = new Point(21, 43);
                panel.Name = "panel2";
                panel.Size = new Size(1080, 104);
                panel.TabIndex = 2;
                // 
                // lblTenBai
                // 
                lblTenBai.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
                lblTenBai.Location = new Point(29, 13);
                lblTenBai.Name = "lblTenBai"+i;
                lblTenBai.Size = new Size(454, 34);
                lblTenBai.TabIndex = 6;
                lblTenBai.Text = sight.Name;
                lblTenBai.TextAlign = ContentAlignment.MiddleLeft;
                // 
                // lblThoiGian
                // 
                lblThoiGian.Location = new Point(29, 62);
                lblThoiGian.Name = "lblThoiGian"+i;
                lblThoiGian.Size = new Size(454, 24);
                lblThoiGian.TabIndex = 2;
                lblThoiGian.Text = sight.CreatedAt.ToString("dd/MM/yyyy");
                lblThoiGian.TextAlign = ContentAlignment.MiddleLeft;

                this.panel1.Controls.Add(panel);
            }
        }
    }
}
