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
            pictureBoxGame = new PictureBox();
            Navbar = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGame).BeginInit();
            Navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxGame
            // 
            pictureBoxGame.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxGame.Image = Resources.Game;
            pictureBoxGame.Location = new Point(334, 1);
            pictureBoxGame.Margin = new Padding(3, 4, 3, 4);
            pictureBoxGame.Name = "pictureBoxGame";
            pictureBoxGame.Size = new Size(1384, 982);
            pictureBoxGame.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxGame.TabIndex = 3;
            pictureBoxGame.TabStop = false;
            // 
            // Navbar
            // 
            Navbar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Navbar.BackColor = Color.FromArgb(34, 34, 34);
            Navbar.Controls.Add(pictureBox1);
            Navbar.Location = new Point(3, 2);
            Navbar.Name = "Navbar";
            Navbar.Size = new Size(331, 981);
            Navbar.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resources.Brand_330x122;
            pictureBox1.Location = new Point(1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(330, 122);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // formGame
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1718, 983);
            Controls.Add(Navbar);
            Controls.Add(pictureBoxGame);
            Margin = new Padding(3, 4, 3, 4);
            Name = "formGame";
            StartPosition = FormStartPosition.CenterParent;
            Text = "formGame";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBoxGame).EndInit();
            Navbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxGame;
        private Panel Navbar;
        private PictureBox pictureBox1;
    }
}