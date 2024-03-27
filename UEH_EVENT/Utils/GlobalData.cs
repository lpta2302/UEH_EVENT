using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Constants;

namespace UEH_EVENT.Utils
{
    internal class GlobalData
    {
        public static Account CurrentAccount {  get; set; }

        public static INavbar Navbar { get; set; }

        public static void InitNavbar()
        {
            if (CurrentAccount == null) return;
            //string type = CurrentAccount.AccType;
            string type = Constants.CLB_ACC;
            if (type.Equals(STUDENT_ACC)) Navbar = new StudentNavbar();
            if (type.Equals(ADMIN_ACC)) Navbar = new AdminNavbar();
            if (type.Equals(CLB_ACC)) Navbar = new ClbNavbar();
        }
    }
}
