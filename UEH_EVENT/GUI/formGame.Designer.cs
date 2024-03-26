using static Constants;
using UEH_EVENT.Properties;
using UEH_EVENT.Utils;

namespace UEH_EVENT.GUI
{
    partial class formGame
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formGame));
            Navbar = new Panel();
            panelLogo = new Panel();
            panel2 = new Panel();
            Home = new Panel();
            btnHomee = new Button();
            label1 = new Label();
            panel3 = new Panel();
            panelGame = new Panel();
            panelPlay = new Panel();
            btnPlay = new Button();
            Navbar.SuspendLayout();
            Home.SuspendLayout();
            panel3.SuspendLayout();
            panelGame.SuspendLayout();
            panelPlay.SuspendLayout();
            SuspendLayout();
            // 
            // Navbar
            // 
            Constants.INavbar.CreateNavbar(this, resources);
            Navbar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Navbar.BackColor = Color.FromArgb(34, 34, 34);
            Navbar.Controls.Add(panelLogo);
            Navbar.Controls.Add(panel2);
            Navbar.Controls.Add(Home);
            Navbar.Location = new Point(3, 1);
            Navbar.Name = "Navbar";
            Navbar.Size = new Size(400, 981);
            Navbar.TabIndex = 1;
            Navbar.Paint += Navbar_Paint;
            // 
            // panelLogo
            // 
            panelLogo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelLogo.BackgroundImage = Resources.Logo_396x163;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(396, 163);
            panelLogo.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Location = new Point(402, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1314, 163);
            panel2.TabIndex = 2;
            // 
            // Home
            // 
            Home.Controls.Add(btnHomee);
            Home.Location = new Point(0, 185);
            Home.Name = "Home";
            Home.Size = new Size(400, 75);
            Home.TabIndex = 7;
            // 
            // btnHomee
            // 
            btnHomee.BackColor = Color.FromArgb(34, 34, 34);
            btnHomee.BackgroundImageLayout = ImageLayout.None;
            btnHomee.FlatStyle = FlatStyle.Flat;
            btnHomee.Font = new Font("Helvetica", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnHomee.ForeColor = Color.White;
            btnHomee.Image = (Image)resources.GetObject("btnHomee.Image");
            btnHomee.ImageAlign = ContentAlignment.MiddleLeft;
            btnHomee.Location = new Point(-2, -9);
            btnHomee.Name = "btnHomee";
            btnHomee.Padding = new Padding(20, 0, 0, 0);
            btnHomee.Size = new Size(402, 92);
            btnHomee.TabIndex = 10;
            btnHomee.Text = "  HOME";
            btnHomee.TextAlign = ContentAlignment.MiddleLeft;
            btnHomee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHomee.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Helvetica", 20.1428585F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(57, 60);
            label1.Name = "label1";
            label1.Size = new Size(677, 57);
            label1.TabIndex = 2;
            label1.Text = "GAME FOR TRAINING POINT";
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Location = new Point(402, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(1314, 166);
            panel3.TabIndex = 3;
            // 
            // panelGame
            // 
            panelGame.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelGame.BackgroundImage = Resources.Background_Game;
            panelGame.Controls.Add(panelPlay);
            panelGame.Location = new Point(402, 164);
            panelGame.Name = "panelGame";
            panelGame.Size = new Size(1314, 818);
            panelGame.TabIndex = 5;
            panelGame.Paint += panelGame_Paint;
            // 
            // panelPlay
            // 
            panelPlay.Anchor = AnchorStyles.Left;
            panelPlay.Controls.Add(btnPlay);
            panelPlay.Location = new Point(623, 249);
            panelPlay.Name = "panelPlay";
            panelPlay.Size = new Size(237, 80);
            panelPlay.TabIndex = 1;
            // 
            // btnPlay
            // 
            btnPlay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnPlay.FlatStyle = FlatStyle.Flat;
            btnPlay.Font = new Font("Helvetica", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            btnPlay.Location = new Point(-35, -11);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(313, 101);
            btnPlay.TabIndex = 0;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            // 
            // formGame
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(1718, 983);
            Controls.Add(panelGame);
            Controls.Add(panel3);
            Controls.Add(Navbar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "formGame";
            StartPosition = FormStartPosition.CenterParent;
            Text = "formGame";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            Navbar.ResumeLayout(false);
            Home.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelGame.ResumeLayout(false);
            panelPlay.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Navbar;
        private Panel panel2;
        private Panel Home;
        private Button btnHomee;
        private Label label1;
        private Panel panel3;
        private Panel panelLogo;
        private Panel panelGame;
        private Button btnPlay;
        private Panel panelPlay;
    }
}