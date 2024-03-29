using Newtonsoft.Json;
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

namespace UEH_EVENT.GUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            GlobalData.reset();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtUsername.Text;
            string password = txtPassword.Text;

            //thực hiện tìm account tương ứng
            Account? currentAccount = Query.SignIn(email, password);

            if (currentAccount == null)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng, vui lòng nhập lại", "Đăng nhập thất bại", MessageBoxButtons.OK);
                return;
            }

            GlobalData.CurrentAccount = currentAccount;
            GlobalData.Init();

            Hide();
            new formGame().ShowDialog();
            Close();
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

 
    }
}
