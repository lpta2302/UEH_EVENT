using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.Identity.Client.NativeInterop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;
using static System.Reflection.Metadata.BlobBuilder;

namespace UEH_EVENT.GUI.Mario
{
    public partial class frmPlayMario : Form
    {
        #region var
        public List<PictureBox> WorldBricks { get; set; } = new List<PictureBox>();
        public List<PictureBox> WorldNotBrick { get; set; } = new List<PictureBox>();


        #endregion
        #region Item valuable
        bool virussGoLeft = false;
        bool virussGoRight = true;
        int numberHeart = 3;
        int numberShovel = 0;
        bool enoughShvel = false;
        #endregion

        #region Player movement
        Boolean Player_Jump = false;
        Boolean Player_Left = false;
        Boolean Player_Right = false;
        Boolean LastDirRight = true;
        Boolean GameOn = true;
        int Gravity = 20;
        int Force = 0;
        int Speed_Movement = 5;
        int Speed_Jump = 5;
        int Speed_Fall = 5;
        #endregion

        #region Player valuable
        bool goLeft, goRight, hasKey;
        bool hasEnoughShovel;
        int score = 0;
        int timeUpMinute = 0;
        int timeUpSecond = 0;
        #endregion
        #region Boolean Functions, "Check Collision"

        public Boolean OutsideWorldFrame(PictureBox tar)
        {
            if (tar.Location.X < 0) //Is it outside of the left side?
                return true;
            if (tar.Location.X > WorldFrame.Width)  //... right side?
                return true;
            if (tar.Location.Y + tar.Height > WorldFrame.Height - 3)
                return true;                        //Or above the WorldFrame?
            foreach (PictureBox Obj in WorldBricks)
            {
                if (Obj != null)
                {   //Or, intersecting with any world object
                    if (tar.Bounds.IntersectsWith(Obj.Bounds))
                        return true;
                }
            }
            return false;
        }
        public Boolean InAirNoCollision(PictureBox tar)
        {
            if (!OutsideWorldFrame(tar))
            {
                foreach (PictureBox Obj in WorldBricks)
                {
                    //if (!tar.Bounds.IntersectsWith(Obj.Bounds))
                    if (!Collision_Top(tar))
                    {
                        if (tar.Location.Y < WorldFrame.Width)
                        {   //And it's not under ground for some reason
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        public Boolean Collision_Top(PictureBox tar)
        {
            foreach (PictureBox ob in WorldBricks)
            {
                if (ob != null)
                {
                    PictureBox temp1 = new PictureBox();
                    temp1.Bounds = ob.Bounds;
                    temp1.SetBounds(temp1.Location.X, temp1.Location.Y - 1, temp1.Width, 1);
                    if (tar.Bounds.IntersectsWith(temp1.Bounds))
                        return true;
                }
            }
            return false;
        }

        public Boolean Collision_Bottom(PictureBox tar)
        {
            foreach (PictureBox ob in WorldBricks)
            {
                if (ob != null)
                {
                    PictureBox temp1 = new PictureBox();
                    temp1.Bounds = ob.Bounds;
                    temp1.SetBounds(temp1.Location.X, temp1.Location.Y + temp1.Height, temp1.Width, 1);
                    if (tar.Bounds.IntersectsWith(temp1.Bounds))
                        return true;
                }
            }
            return false;
        }

        public Boolean Collision_Left(PictureBox tar)
        {
            foreach (PictureBox ob in WorldBricks)
            {
                if (ob != null)
                {
                    PictureBox temp1 = new PictureBox();
                    temp1.Bounds = ob.Bounds;
                    temp1.SetBounds(temp1.Location.X - 1, temp1.Location.Y + 1, 1, temp1.Height - 1);
                    if (tar.Bounds.IntersectsWith(temp1.Bounds))
                        return true;
                }
            }
            return false;
        }
        public Boolean Collision_Right(PictureBox tar)
        {
            foreach (PictureBox ob in WorldBricks)
            {
                if (ob != null)
                {
                    PictureBox temp2 = new PictureBox();
                    temp2.Bounds = ob.Bounds;
                    temp2.SetBounds(temp2.Location.X + temp2.Width, temp2.Location.Y + 1, 1, temp2.Height - 1);
                    if (tar.Bounds.IntersectsWith(temp2.Bounds))
                        return true;
                }
            }
            return false;
        }
        #endregion
        public void VirussGo()
        {
            if (virussGoRight == true)
            {
                picViruss2.Left += 2;
            }
            if (virussGoLeft == true)
            {
                picViruss2.Left -= 2;
            }
            if (picViruss2.Location.X >= 286)
            {
                virussGoRight = false;
                virussGoLeft = true;
            }
            if (picViruss2.Location.X <= 102)
            {
                virussGoRight = true;
                virussGoLeft = false;
            }
        }
        public void PlayAudio()
        {
            foreach (Control x in WorldNotBrick)
            {
                switch ((string)x.Tag)
                {
                    case "hole":
                        if (picPlayer.Bounds.IntersectsWith(x.Bounds) && x.Visible == true && hasEnoughShovel == false)
                        {
                            goto case "fire";
                        }
                        break;
                    case "fire":
                    case "viruss":
                        if (picPlayer.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                        {
                            using (var stream = Properties.Resources.Aaaaaa)
                            {
                                using (var player = new SoundPlayer(stream))
                                {
                                    player.Play();
                                }
                            }
                        }
                        break;
                    case "coin":
                    case "key":
                        if (picPlayer.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                        {
                            using (var stream = Properties.Resources.getCoin)
                            {
                                using (var player = new SoundPlayer(stream))
                                {
                                    player.Play();
                                }
                            }

                        }
                        break;
                }
            }
        }
        public void StopTimer()
        {
            tmrGameLoad.Stop();
            //tmrGameLoad_Tick.Stop();
            tmrGravity.Stop();
            tmrJump.Stop();
            tmrLock.Stop();
            //tmrLock_Tick.Stop();
        }
        public frmPlayMario()
        {
            InitializeComponent();
            //PlaySOundTrackPlayGame();
        }
        public void Reload()
        {
            picPlayer.Location = new System.Drawing.Point(84, 700);
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
            foreach (var control in this.WorldFrame.Controls)
            {
                if (control is PictureBox)
                {
                    PictureBox pictureBox = (PictureBox)control;
                    if (pictureBox.Tag == null) continue;
                    if (((string)pictureBox.Tag).StartsWith("flatform"))
                    {
                        WorldBricks.Add(pictureBox);
                    }
                    else
                        WorldNotBrick.Add(pictureBox);
                }
            }

        }
        private void timer_Jump_Tick(object sender, EventArgs e)
        {
            if (GameOn)
            {
                if (Player_Right && picPlayer.Right <= WorldFrame.Width - 3 && !Collision_Left(picPlayer))
                {
                    picPlayer.Left += Speed_Movement; //Moves right
                }
                if (Player_Left && picPlayer.Location.X >= 3 && !Collision_Right(picPlayer))
                {
                    picPlayer.Left -= Speed_Movement; //Moves left
                }
            }
            else
            {
                Player_Right = false;
                Player_Left = false;
            }

            if (Force > 0)
            {
                if (Collision_Bottom(picPlayer))
                {   //ktr đập đầu
                    Force = 0;
                }
                else
                {   //nhảy
                    Force--;
                    picPlayer.Top -= Speed_Jump;
                }
            }
            else
            {
                Player_Jump = false;
            }
        }
        private void timer_Gravity_Tick(object sender, EventArgs e)
        {
            if (!Player_Jump && picPlayer.Location.Y + picPlayer.Height < WorldFrame.Height - 2 && !Collision_Top(picPlayer))
            {
                picPlayer.Top += Speed_Fall; //Player falls
            }

            if (!Player_Jump && picPlayer.Location.Y + picPlayer.Height > WorldFrame.Height - 1)
            {
                picPlayer.Top--;
            }
        }
        private void tmrGameLoad_Tick(object sender, EventArgs e)
        {
            VirussGo();
            PlayAudio();
            lblScore.Text = "Score: " + score;
            foreach (PictureBox x in WorldNotBrick)
            {
                if (x.Tag != null && (string)x.Tag == "player")
                {
                    x.BringToFront();
                }
                if (x.Tag != null && (string)x.Tag == "coin")
                {
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                    {
                        x.Visible = false;
                        score += 5;
                        //SoundPlayer pl = new SoundPlayer(@"D:\Subject\Desktop Application Development\project4\UEH_EVENT\sound\getCoin.wav");
                        //pl.Play();
                    }
                }
                if (x.Tag != null && (string)x.Tag == "shovel")
                {
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                    {
                        numberShovel += 1;
                        x.Visible = false;
                        break;
                    }
                }
                if (numberShovel == 3)
                {
                    hasEnoughShovel = true;
                }
                if (x.Tag != null && (string)x.Tag == "hole")
                {
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds) && x.Visible == true && hasEnoughShovel == true)
                    {
                        picHole.Visible = false;
                    }
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds) && x.Visible == true && hasEnoughShovel == false)
                    {
                        Reload();
                        numberHeart -= 1;
                        HideHeart();
                    }
                }
                if (x.Tag != null && (string)x.Tag == "viruss")
                {
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                    {
                        //SoundPlayer pl = new SoundPlayer(@"D:\Subject\Desktop Application Development\project4\UEH_EVENT\sound\Aaaaaa.wav");
                        //pl.Play();
                        Reload();
                        numberHeart -= 1;
                        HideHeart();
                    }
                }
                if (x.Tag != null && (string)x.Tag == "fire")
                {
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                    {
                        // SoundPlayer pl = new SoundPlayer(@"D:\Subject\Desktop Application Development\project4\UEH_EVENT\sound\Aaaaaa.wav");
                        //pl.Play();
                        Reload();
                        numberHeart -= 1;
                        HideHeart();
                    }
                }
                if (x.Tag != null && (string)x.Tag == "key")
                {
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                    {
                        x.Visible = false;
                        hasKey = true;
                    }
                }
                if (x.Tag != null && (string)x.Tag == "door")
                {
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds) && x.Visible == true && hasKey)
                    {
                        //SoundPlayer pl = new SoundPlayer(@"D:\Subject\Desktop Application Development\project4\UEH_EVENT\sound\soundWin2.wav");
                        //pl.Play();
                        x.Visible = false;
                        MessageBox.Show("Win roi nha");
                        StopTimer();
                    }
                }
            }
            if (numberHeart == 0)
            {
                picGameOver.Visible = true;
                GameOn = false;
                StopTimer();
                //SoundPlayer pl = new SoundPlayer(@"D:\Subject\Desktop Application Development\project4\UEH_EVENT\sound\soundLoss.wav");
                //pl.Play();                                                            
            }
        }
        private void frmPlayMario_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (GameOn)
                    {
                        if (LastDirRight)
                        {

                            picPlayer.Image = Properties.Resources.MarioPlayLeft;
                            LastDirRight = false;
                        }
                        Player_Left = true;
                    }
                    break;
                case Keys.Right:
                    if (GameOn)
                    {
                        if (!LastDirRight)
                        {

                            picPlayer.Image = Properties.Resources.MarioPlay;
                            LastDirRight = true;
                        }
                        Player_Right = true;
                    }
                    break;
                case Keys.Space:
                    if (!Player_Jump && !InAirNoCollision(picPlayer))
                    {
                        picPlayer.Top -= Speed_Jump;
                        Force = Gravity;
                        Player_Jump = true;
                    }
                    break;
            }
        }
        private void frmPlayMario_KeyUp(object sender, KeyEventArgs e)
        {
            if (GameOn)
            {
                switch (e.KeyCode)
                {
                    case Keys.Left:
                        LastDirRight = false;
                        //On Left Key press UP
                        Player_Left = false;                    //Doesnt move left anymore
                        break;
                    case Keys.Right:
                        LastDirRight = true;

                        Player_Right = false;
                        break;
                }
            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        private void tmrLock_Tick(object sender, EventArgs e)
        {
            timeUpSecond += 1;
            if (timeUpSecond == 60)
            {
                timeUpMinute += 1;
                timeUpSecond = 0;
            }
            if (timeUpMinute < 10 && timeUpSecond < 10)
            {
                lblLock2.Text = "0" + timeUpMinute + " : " + "0" + timeUpSecond;
            }
            else if (timeUpMinute >= 10 && timeUpSecond < 10)
            {
                lblLock2.Text = timeUpMinute + " : " + "0" + timeUpSecond;
            }
            else
            {
                lblLock2.Text = "0" + timeUpMinute + " : " + timeUpSecond;
            }
        }
        public void PlaySOundTrackPlayGame()
        {
            using (var stream = Properties.Resources.soundTrackPlayGame)
            {
                using (var player = new SoundPlayer(stream))
                {
                    player.PlayLooping();
                }
            }
        }
        private void tmrSoundTrack_Tick(object sender, EventArgs e)
        {

        }

        private void WorldFrame_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
