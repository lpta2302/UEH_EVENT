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
        int numberHeart = 3;
        #endregion
        #region Player valuable
        bool goLeft, goRight, hasKey, hasEnoughCoin, jumping;
        bool hasShovel;
        bool isOnGround;
        int jumpSpeed = 12;
        int force = 8;
        int playerSpeed = 10;
        int numberCoin = 0;
        bool touchFlatformUpLeft, touchFlatformUpRight, touchFlatformAbove;
        int timeDownMinute = 1;
        int timeDownSecond = 60;
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
        public void Reload()
        {
            picPlayer.Location = new System.Drawing.Point(12, 362);
        }
        public void HideHeart()
        {
            foreach (Control x in this.Controls)
            {
                if ((string)x.Tag == "heart" && x.Visible == true)
                {
                    x.Visible = false;
                    break;
                }
            }
        }
        private void frmPlayMario_Load(object sender, EventArgs e)
        {

        }
        private void tmGameLoad_Tick(object sender, EventArgs e)
        {
            VirussGo();
            if (isOnGround == false)
            {
                picPlayer.Top += jumpSpeed;
            }
            if (goLeft == true && picPlayer.Left > 10 && touchFlatformUpRight == false)
            {
                picPlayer.Left -= playerSpeed;
                touchFlatformUpLeft = false;
            }
            if (goRight == true && picPlayer.Left + (picPlayer.Width + 10) < this.ClientSize.Width && touchFlatformUpLeft == false)
            {
                picPlayer.Left += playerSpeed;
                touchFlatformUpRight = false;
            }
            if (jumping == true)
            {
                jumpSpeed = -12;
                force -= 1;
                isOnGround = false;
            }
            if (jumping == false && isOnGround == false)
            {
                foreach (Control x in this.Controls)
                {
                    if ((x is PictureBox) && (string)x.Tag == "flatform")
                    {
                        int distanceToFloor = x.Top - (picPlayer.Top + picPlayer.Height);
                        if (jumpSpeed < distanceToFloor)
                        {
                            jumpSpeed = distanceToFloor;
                        }
                        else
                        {
                            jumpSpeed = 12;
                        }
                    }
                }
            }
            if (jumping == true && force < 0)
            {
                jumping = false;
            }
            foreach (Control x in this.Controls)
            {
                if ((x is PictureBox) && (string)x.Tag == "flatform")
                {
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds) && jumping == false)
                    {
                        force = 8;
                        picPlayer.Top = x.Top - picPlayer.Height;
                        jumpSpeed = 0;
                        isOnGround = true;
                    }
                    //bug
                    if (!(picPlayer.Bounds.IntersectsWith(x.Bounds) && jumping == false))
                    {
                        isOnGround = false;
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
                if (x is PictureBox && (string)x.Tag == "shovel")
                {
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                    {
                        hasShovel = true;
                        picShovel.Visible = false;
                    }

                }
                if (x is PictureBox && (string)x.Tag == "hole")
                {
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds) && x.Visible == true && hasShovel)
                    {
                        picHole.Visible = false;
                    }
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds) && x.Visible == true && hasShovel == false)
                    {
                        Reload();
                        numberHeart -= 1;
                        HideHeart();
                    }
                }
                if (x is PictureBox && (string)x.Tag == "viruss")
                {
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                    {
                        picViruss.Visible = false;
                    }
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds) && x.Visible == true && hasShovel == false)
                    {
                        Reload();
                        numberHeart -= 1;
                        HideHeart();
                        picViruss.Visible = true;
                    }
                }
                if (x is PictureBox && (string)x.Tag == "fire")
                {
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds) && x.Visible == true && hasShovel)
                    {
                        x.Visible = false;
                    }
                    else if (picPlayer.Bounds.IntersectsWith(x.Bounds) && x.Visible == true && hasShovel == false)
                    {
                        Reload();
                        numberHeart -= 1;
                        HideHeart();
                    }
                }
                if (x is PictureBox && (string)x.Tag == "key")
                {
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds) && x.Visible == true && hasEnoughCoin)
                    {
                        x.Visible = false;
                        hasKey = true;
                    }
                }
                if (x is PictureBox && (string)x.Tag == "door")
                {
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds) && x.Visible == true && hasKey)
                    {
                        x.Visible = false;
                        MessageBox.Show("Win roi nha");
                        this.Close();
                    }
                }

            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "flatformUp")
                {
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds))
                    {
                        if (picPlayer.Left + picPlayer.Width >= x.Left)
                        {
                            touchFlatformUpLeft = true;
                        }
                        else if (picPlayer.Left <= x.Left + x.Width)
                        {
                            touchFlatformUpRight = true;
                        }
                    }
                }
            }
            if (numberHeart == 0)
            {
                picGameOver.Visible = true;
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
        private void SecondDown(int second)
        {
            second -= 1;
        }
        private void tmrLock_Tick(object sender, EventArgs e)
        {
            if (timeDownMinute >= 0)
            {
                if (timeDownSecond > 0)
                {
                    timeDownSecond -= 1;
                }
            }
            if (timeDownSecond == 0 && timeDownMinute > 0)
            {
                timeDownMinute -= 1;
                timeDownSecond = 59;
            }
            if (timeDownSecond == 0 && timeDownMinute == 0)
            {
                picGameOver.Visible = true;
                tmrLock.Stop();
            }
            if (timeDownSecond < 10)
            {
                lblLock.Text = "0" + timeDownMinute.ToString() + " : " + "0" + timeDownSecond.ToString();
            }
            else
            {
                lblLock.Text = "0" + timeDownMinute.ToString() + " : " + timeDownSecond.ToString();
            }
        }
    }
}
