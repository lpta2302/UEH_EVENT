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
using static Constants;

namespace UEH_EVENT.GUI
{
    public partial class formUpdateProfile : Form
    {
        Account currentAccount;
        public formUpdateProfile()
        {
            InitializeComponent();
            currentAccount = GlobalData.CurrentAccount;
            Constants.INavbar.CreateNavbar(this, Navbar);
        }
        public formUpdateProfile(Account account)
        {
            InitializeComponent();
            currentAccount = account;
            Constants.INavbar.CreateNavbar(this, Navbar);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Xác nhận lại password");
                return;
            }

            if (txtConfirmPassword.Text.Length > 0)
                MessageBox.Show($"Tài khoản đã cập nhật", "Cập nhật tài khoản thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else return;
            Database.Update<Account>(currentAccount);
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            currentAccount.Password = txtPassword.Text;
        }

        private void formUpdateProfile_Load(object sender, EventArgs e)
        {
            lblAccType.Text = currentAccount.AccType;
            txtName.Text = currentAccount.Name;
            txtPassword.Text = currentAccount.Password;
            txtUsername.Text = currentAccount.Username;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            currentAccount.Name = txtName.Text;
        }
    }
}
