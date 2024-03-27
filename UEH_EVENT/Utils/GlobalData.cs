using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEH_EVENT.Utils
{
    internal class GlobalData
    {
        public static Account CurrentAccount { get; set; } = new Account();
        public static Sight CurrentSight {get;set;}
        static GlobalData()
        {
            CurrentSight = new Sight();
        }
    }
}
