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
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Account acc = Query.GetAllAccount()[0];
            tboxEmail.Text = acc.Username;
            tboxPassword.Text = acc.Password;   
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = tboxEmail.Text;
            string password = tboxPassword.Text;

            Account? currentAccount = Query.SignIn(email, password);

            if (currentAccount == null) {
                Console.WriteLine("Not Found Account");
            }

            GlobalData.CurrentAccount = currentAccount;
            GlobalData.InitNavbar();

            Hide();
            new formHistory().ShowDialog();
            Close();
        }
    }
}
