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
    public partial class formCreateAccount : Form
    {
        string[] accTypes = new[] { Constants.CLB_ACC, Constants.ADMIN_ACC };
        public formCreateAccount()
        {
            InitializeComponent();
            Constants.INavbar.CreateNavbar(this, Navbar);
        }

        private void formCreateAccount_Load(object sender, EventArgs e)
        {
            cbbAccType.Items.AddRange(accTypes);
        }
        private void reset()
        {
            foreach (Control c in panelContainer.Controls)
            {
                c.Text = string.Empty;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Xác nhận lại password");
                return;
            }
            foreach (var c in panelContainer.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = (TextBox)c;
                    if (textBox.Text.Length > 0) continue;
                    MessageBox.Show($"{textBox.Tag} không được để trống", "Tạo tài khoản không thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (c is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)c;
                    if (comboBox.SelectedIndex != -1) continue;
                    MessageBox.Show($"{comboBox.Tag} không được để trống", "Tạo tài khoản không thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            Account acc = new Account()
            {
                AccType = accTypes[cbbAccType.SelectedIndex],
                Name = txtName.Text,
                Username = txtUsername.Text,
                Password = txtPassword.Text,
            };
            Database.Insert<Account>(acc);
            MessageBox.Show("Tạo thành công");
            reset();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            new formManageAccount().ShowDialog();
            Close();
        }
    }
}
