namespace UEH_EVENT.GUI.Mario
{
    partial class frmPlayMario
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
            picPlayer = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picPlayer).BeginInit();
            SuspendLayout();
            // 
            // picPlayer
            // 
            picPlayer.BackColor = Color.Transparent;
            picPlayer.BackgroundImageLayout = ImageLayout.Stretch;
            picPlayer.Image = Properties.Resources.MarioPlay;
            picPlayer.Location = new Point(23, 459);
            picPlayer.Name = "picPlayer";
            picPlayer.Size = new Size(36, 65);
            picPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
            picPlayer.TabIndex = 0;
            picPlayer.TabStop = false;
            // 
            // frmPlayMario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ForestBackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(956, 575);
            Controls.Add(picPlayer);
            DoubleBuffered = true;
            Name = "frmPlayMario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MARIO";
            ((System.ComponentModel.ISupportInitialize)picPlayer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picPlayer;
    }
}