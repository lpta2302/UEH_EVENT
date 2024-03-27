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
    public partial class formHistory : Form
    {
        public formHistory()
        {
            InitializeComponent();
            Constants.INavbar.CreateNavbar(this, Navbar);
        }
    }
}
