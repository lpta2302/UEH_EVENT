using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UEH_EVENT.GUI.Mario
{
    public partial class frmPlayMario : Form
    {
        bool virussGoLeft = false;
        bool virussGoRight = true;
        public void VirussGo()
        {
            foreach (Control v in this.Controls)
            {
                if ((string)v.Tag == "viruss")
                {
                    PictureBox viruss = (PictureBox)v;
                    if (virussGoLeft)
                    {
                        viruss.Left -= 1;
                    }
                    else if (virussGoRight)
                    {
                        viruss.Left += 1;
                    }
                    foreach (Control others in this.Controls)
                    {
                        if (viruss.Bounds.IntersectsWith(others.Bounds))
                        {
                            if (others.Tag == "flatform")
                            {
                                virussGoRight = false;
                                virussGoLeft = true;
                            }
                            else if (others.Tag == "coin")
                            {
                                virussGoLeft = false;
                                virussGoRight = true;
                            }
                        }
                    }              
                }
            }
        }

        public frmPlayMario()
        {
            InitializeComponent();
        }
        private void frmPlayMario_Load(object sender, EventArgs e)
        {
            
        }
        private void tmGameLoad_Tick(object sender, EventArgs e)
        {
            VirussGo();
        }
    }
}
