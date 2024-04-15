using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.Identity.Client.NativeInterop;
using Newtonsoft.Json;
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
using UEH_EVENT.Utils;
using static System.Formats.Asn1.AsnWriter;
using static System.Reflection.Metadata.BlobBuilder;

namespace UEH_EVENT.GUI.Mario
{
    public partial class frmPlayMario : Form
    {
        private class Data
        {
            public Boolean Player_Jump {get;set;}
            public Boolean Player_Left  {get;set;}
            public Boolean Player_Right {get;set;}
            public Boolean LastDirRight {get;set;}
            public int Force {get;set;}
            public Point Location { get; set; }
            public int NumberHeart { get;set;}
            public int NumberShovel { get;set;}
            public List<bool> Visibles { get;set;}
            public Data(bool player_Jump, bool player_Left, bool player_Right, bool lastDirRight, int force, Point location, int numberHeart, int numberShovel
                , List<bool> visibles)
            {
                Player_Jump = player_Jump;
                Player_Left = player_Left;
                Player_Right = player_Right;
                LastDirRight = lastDirRight;
                Force = force;
                Location = location;
                NumberHeart = numberHeart;
                NumberShovel = numberShovel;
                Visibles = visibles;
            }
        }
        #region var
        public List<PictureBox> WorldBricks { get; set; } = new List<PictureBox>();
        public List<PictureBox> WorldNotBrick { get; set; } = new List<PictureBox>();


        #endregion
        #region Item valuable
        bool virussGoLeft = false;
        bool virussGoRight = true;
        public List<PictureBox> hearts = new List<PictureBox>();
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
        bool hasKey;
        bool hasEnoughShovel;
        int score = 10000;
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
                    temp1.SetBounds(temp1.Location.X, temp1.Location.Y + temp1.Height + 1, temp1.Width, 1);
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
                    temp1.SetBounds(temp1.Location.X - 1, temp1.Location.Y + 2, 1, temp1.Height - 1);
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
            if (picViruss2.Location.X >= 427)
            {
                virussGoRight = false;
                virussGoLeft = true;
            }
            if (picViruss2.Location.X <= 267)
            {
                virussGoRight = true;
                virussGoLeft = false;
            }
        }
        public void PlaySound(Stream soundStream)
        {
            using (var stream = soundStream)
            {
                using (var player = new SoundPlayer(stream))
                {
                    player.Play();
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
            picPlayer.Location = new Point(67, 558);
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
            foreach (Control control in this.WorldFrame.Controls)
            {
                if (control is PictureBox)
                {
                    PictureBox pictureBox = (PictureBox)control;
                    if (pictureBox.Tag == null) continue;
                    if (((string)pictureBox.Tag).StartsWith("flatform"))
                    {
                        WorldBricks.Add(pictureBox);
                    }
                    else if((string)pictureBox.Tag == "heart")
                    {
                        hearts.Add(pictureBox);
                        WorldNotBrick.Add(pictureBox);
                    }
                    else
                        WorldNotBrick.Add(pictureBox);
                }
            }
            if (GlobalData.CurrentAccount.GameSession != null)
            {
                Data data = JsonConvert.DeserializeObject<Data>(GlobalData.CurrentAccount.GameSession);
                Player_Jump = data.Player_Jump;
                Player_Left = data.Player_Left;
                Player_Right = data.Player_Right;
                LastDirRight = data.LastDirRight;
                Force = data.Force;
                picPlayer.Location = data.Location;
                numberHeart = data.NumberHeart;
                numberShovel = data.NumberShovel;
                for (int i=0;i<WorldNotBrick.Count;i++)
                {
                    WorldNotBrick[i].Visible = data.Visibles[i];
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
            //PlayAudio();
            lblScore.Text = "Score: " + score;
            foreach (PictureBox x in WorldNotBrick)
            {
                if (x.Tag != null && (string)x.Tag == "player")
                {
                    x.BringToFront();
                }
                if (x.Tag != null && (string)x.Tag == "phone")
                {
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                    {
                        x.Visible = false;
                        score += 5;
                    }
                }
                if (x.Tag != null && (string)x.Tag == "shovel")
                {
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                    {
                        numberShovel += 1;
                        x.Visible = false;
                        PlaySound(Properties.Resources.getCoin);
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
                        PlaySound(Properties.Resources.Aaaaaa);
                        Reload();
                        numberHeart -= 1;
                        hearts[numberHeart].Visible = false;
                        
                        HideHeart();
                    }
                }
                if (x.Tag != null && (string)x.Tag == "viruss")
                {
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                    {
                        PlaySound(Properties.Resources.Aaaaaa);
                        Reload();
                        numberHeart -= 1;
                        hearts[numberHeart].Visible = false;
                        
                        HideHeart();
                    }
                }
                if (x.Tag != null && (string)x.Tag == "fire")
                {
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                    {
                        PlaySound(Properties.Resources.Aaaaaa);
                        Reload();
                        numberHeart -= 1;
                        hearts[numberHeart].Visible = false;
                        
                        HideHeart();
                    }
                }
                if (x.Tag != null && (string)x.Tag == "key")
                {
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                    {
                        PlaySound(Properties.Resources.getCoin);
                        x.Visible = false;
                        hasKey = true;
                    }
                }
                if (x.Tag != null && (string)x.Tag == "door")
                {
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds) && x.Visible == true && hasKey)
                    {
                        PlaySound(Properties.Resources.soundWin2);

                        x.Visible = false;
                        MessageBox.Show("Win roi nha");
                        StopTimer();
                        Database.Insert<PlayHis>(new PlayHis()
                        {
                            StudentId = Query.GetStudentById(GlobalData.CurrentAccount.StudentId).Mssv,
                            GameId = 1,
                            Point = score
                        });
                        Hide();
                        new formGame().ShowDialog();
                        Close();
                    }
                }
            }
            if (numberHeart == 0)
            {
                picGameOver.Visible = true;
                picGameOver.Location = new System.Drawing.Point(280, 120);

                GameOn = false;
                StopTimer();
                PlaySound(Properties.Resources.soundLoss);
                Thread.Sleep(3000);
                Hide();
                new formGame().ShowDialog();
                Close();
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
            score--;
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

        private void picEndGame_Click(object sender, EventArgs e)
        {
            List<bool> visibles = new List<bool>();
            foreach (Control item in WorldNotBrick)
            {
                visibles.Add(item.Visible);
            }
            Data data = new Data(
                Player_Jump,
                Player_Left,
                Player_Right,
                LastDirRight,
                Force,
                picPlayer.Location,
                numberHeart,
                numberShovel,
                visibles
            );
            string json = JsonConvert.SerializeObject(data, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
            GlobalData.CurrentAccount.GameSession = json;
            Database.Update<Account>(GlobalData.CurrentAccount);
            Hide();
            new formGame().ShowDialog();
            Close();
        }
    }
}
