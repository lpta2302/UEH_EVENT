using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UEH_EVENT.GUI;
using UEH_EVENT.Utils;

namespace UEH_EVENT.BL
{
    internal class SignIn
    {
        public SignIn() { 
            
        }
        public void Login(string email,string password)
        {
            //thực hiện tìm account tương ứng
            Account? currentAccount = Query.SignIn(email, password);

            if (currentAccount == null)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng, vui lòng nhập lại", "Đăng nhập thất bại", MessageBoxButtons.OK);
                return;
            }

            GlobalData.CurrentAccount = currentAccount;
            GlobalData.Init();
        }
    }
}
