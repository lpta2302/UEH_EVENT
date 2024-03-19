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

        public static INavbar Navbar
        {
            get; set
            {

            }
        }
    }
}
