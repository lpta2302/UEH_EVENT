using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UEH_EVENT.GUI.Mario
{
    public partial class frmPlayMario : Form
    {
        #region Item valuable
        bool virussGoLeft = false;
        bool virussGoRight = true;
        #endregion
        #region Player valuable
        bool goLeft, goRight, hasKey, hasEnoughCoin, jumping;
        int jumpSpeed = 10;
        int force = 8;
        int playerSpeed = 10;
        int numberCoin = 0;
        #endregion
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
            picPlayer.Top += jumpSpeed;
            if (goLeft == true && picPlayer.Left > 10)
            {
                picPlayer.Left -= playerSpeed;
            }
            if (goRight == true && picPlayer.Left + (picPlayer.Width + 10) < this.ClientSize.Width)
            {
                picPlayer.Left += playerSpeed;
            }
            if (jumping == true)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }
            if (jumping == true && force < 0)
            {
                jumping = false;
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "flatform")
                {
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds) && jumping == false)
                    {
                        force = 8;
                        picPlayer.Top = x.Top - picPlayer.Height;
                        jumpSpeed = 0;
                    }

                }
                if (x is PictureBox && (string)x.Tag == "player")
                {
                    x.BringToFront();
                }
                if (x is PictureBox && (string)x.Tag == "coin")
                {
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                    {
                        x.Visible = false;
                        numberCoin += 1;
                    }
                }
                if (numberCoin == 6)
                {
                    hasEnoughCoin = true;
                }
            }
        }
        private void frmPlayMario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
            }
        }
        private void frmPlayMario_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (jumping == true)
            {
                jumping = false;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
