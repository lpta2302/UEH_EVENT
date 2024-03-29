using Newtonsoft.Json;
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
      
        public static Sight? CurrentSight { get; set; }
        public static Account? CurrentAccount {  get; set; }

        public static INavbar? Navbar { get; set; }

        public static void Init()
        {
            if (CurrentAccount == null) return;
            string type = CurrentAccount.AccType;
            if (type.Equals(STUDENT_ACC)) Navbar = new StudentNavbar();
            if (type.Equals(ADMIN_ACC)) Navbar = new AdminNavbar();
            if (type.Equals(CLB_ACC)) Navbar = new ClbNavbar();

            if (CurrentAccount.SightSession != null)
            {
                CurrentSight = JsonConvert.DeserializeObject<Sight>(CurrentAccount.SightSession);
                if (CurrentSight == null && CurrentAccount.AccType == CLB_ACC)
                {
                    CurrentSight = new Sight()
                    {
                        CreatedById = CurrentAccount.Id
                    };
                }
            }
            else
            {
                CurrentSight = new Sight()
                {
                    CreatedById = CurrentAccount.Id
                };
            }
        }
        public static void reset()
        {
            CurrentAccount = null;
            CurrentSight = null;
        }

    }
}
