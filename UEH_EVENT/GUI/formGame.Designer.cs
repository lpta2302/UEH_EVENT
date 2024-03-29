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
            label1 = new Label();
            panel3 = new Panel();
            panelGame = new Panel();
            panelPlay = new Panel();
            btnPlay = new Button();
            Navbar = new Panel();
            pictureBoxLogo = new PictureBox();
            panelTitle = new Panel();
            panel3.SuspendLayout();
            panelGame.SuspendLayout();
            panelPlay.SuspendLayout();
            Navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20.1428585F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(38, 40);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(484, 40);
            label1.TabIndex = 2;
            label1.Text = "GAME FOR TRAINING POINT";
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Location = new Point(268, 1);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(876, 111);
            panel3.TabIndex = 3;
            // 
            // panelGame
            // 
            panelGame.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelGame.BackgroundImage = Resources.Background_Game;
            panelGame.Controls.Add(panelPlay);
            panelGame.Location = new Point(268, 109);
            panelGame.Margin = new Padding(2);
            panelGame.Name = "panelGame";
            panelGame.Size = new Size(876, 545);
            panelGame.TabIndex = 5;
            panelGame.Paint += panelGame_Paint;
            // 
            // panelPlay
            // 
            panelPlay.Anchor = AnchorStyles.Left;
            panelPlay.Controls.Add(btnPlay);
            panelPlay.Location = new Point(372, 209);
            panelPlay.Margin = new Padding(2);
            panelPlay.Name = "panelPlay";
            panelPlay.Size = new Size(158, 53);
            panelPlay.TabIndex = 1;
            // 
            // btnPlay
            // 
            btnPlay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnPlay.FlatStyle = FlatStyle.Flat;
            btnPlay.Font = new Font("Arial", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            btnPlay.Location = new Point(1, 1);
            btnPlay.Margin = new Padding(2);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(154, 51);
            btnPlay.TabIndex = 0;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // Navbar
            // 
            Navbar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Navbar.BackColor = Color.FromArgb(34, 34, 34);
            Navbar.Controls.Add(pictureBoxLogo);
            Navbar.Controls.Add(panelTitle);
            Navbar.Location = new Point(-3, 1);
            Navbar.Margin = new Padding(2);
            Navbar.Name = "Navbar";
            Navbar.Size = new Size(271, 653);
            Navbar.TabIndex = 45;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Resources.Logo_Update_27_3;
            pictureBoxLogo.Location = new Point(2, 3);
            pictureBoxLogo.Margin = new Padding(2);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(269, 106);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 4;
            pictureBoxLogo.TabStop = false;
            // 
            // panelTitle
            // 
            panelTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelTitle.CausesValidation = false;
            panelTitle.Location = new Point(673, 2);
            panelTitle.Margin = new Padding(2);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(876, 1867);
            panelTitle.TabIndex = 3;
            // 
            // formGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(1145, 655);
            Controls.Add(Navbar);
            Controls.Add(panelGame);
            Controls.Add(panel3);
            Margin = new Padding(2, 3, 2, 3);
            Name = "formGame";
            StartPosition = FormStartPosition.CenterParent;
            Text = "formGame";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelGame.ResumeLayout(false);
            panelPlay.ResumeLayout(false);
            Navbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Panel panel3;
        private Panel panelGame;
        private Panel panelPlay;
        private Panel Navbar;
        private PictureBox pictureBoxLogo;
        private Panel panelTitle;
        private Button btnPlay;
    }
}