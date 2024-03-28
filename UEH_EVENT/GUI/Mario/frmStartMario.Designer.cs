namespace UEH_EVENT.GUI.Mario
{
    partial class frmStartMario
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
            picButtonStart = new PictureBox();
            picButtonInstall = new PictureBox();
            picButtonDiscription = new PictureBox();
            bgwProcess = new System.ComponentModel.BackgroundWorker();
            pgbLoadMarioPlay = new ProgressBar();
            picMarioGif = new PictureBox();
            picButtonCancel = new PictureBox();
            picSuperMario = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picButtonStart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picButtonInstall).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picButtonDiscription).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMarioGif).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picButtonCancel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSuperMario).BeginInit();
            SuspendLayout();
            // 
            // picButtonStart
            // 
            picButtonStart.BackColor = Color.Transparent;
            picButtonStart.BackgroundImageLayout = ImageLayout.Stretch;
            picButtonStart.Image = Properties.Resources.startButtonfixed;
            picButtonStart.Location = new Point(335, 335);
            picButtonStart.Name = "picButtonStart";
            picButtonStart.Size = new Size(150, 75);
            picButtonStart.SizeMode = PictureBoxSizeMode.StretchImage;
            picButtonStart.TabIndex = 0;
            picButtonStart.TabStop = false;
            picButtonStart.Click += picButtonStart_Click;
            // 
            // picButtonInstall
            // 
            picButtonInstall.BackColor = Color.Transparent;
            picButtonInstall.BackgroundImageLayout = ImageLayout.Stretch;
            picButtonInstall.Image = Properties.Resources.buttoncaidatl;
            picButtonInstall.Location = new Point(247, 358);
            picButtonInstall.Name = "picButtonInstall";
            picButtonInstall.Size = new Size(70, 52);
            picButtonInstall.SizeMode = PictureBoxSizeMode.StretchImage;
            picButtonInstall.TabIndex = 1;
            picButtonInstall.TabStop = false;
            // 
            // picButtonDiscription
            // 
            picButtonDiscription.BackColor = Color.Transparent;
            picButtonDiscription.BackgroundImageLayout = ImageLayout.Stretch;
            picButtonDiscription.Image = Properties.Resources.button3gach;
            picButtonDiscription.Location = new Point(500, 358);
            picButtonDiscription.Name = "picButtonDiscription";
            picButtonDiscription.Size = new Size(70, 52);
            picButtonDiscription.SizeMode = PictureBoxSizeMode.StretchImage;
            picButtonDiscription.TabIndex = 2;
            picButtonDiscription.TabStop = false;
            picButtonDiscription.Click += picButtonDiscription_Click;
            // 
            // bgwProcess
            // 
            bgwProcess.WorkerReportsProgress = true;
            bgwProcess.WorkerSupportsCancellation = true;
            bgwProcess.DoWork += bgwProcess_DoWork;
            bgwProcess.ProgressChanged += bgwProcess_ProgressChanged;
            bgwProcess.RunWorkerCompleted += bgwProcess_RunWorkerCompleted;
            // 
            // pgbLoadMarioPlay
            // 
            pgbLoadMarioPlay.Location = new Point(110, 428);
            pgbLoadMarioPlay.Name = "pgbLoadMarioPlay";
            pgbLoadMarioPlay.Size = new Size(607, 10);
            pgbLoadMarioPlay.TabIndex = 3;
            // 
            // picMarioGif
            // 
            picMarioGif.BackColor = Color.Transparent;
            picMarioGif.BackgroundImageLayout = ImageLayout.Stretch;
            picMarioGif.Image = Properties.Resources.miniMario;
            picMarioGif.Location = new Point(74, 302);
            picMarioGif.Name = "picMarioGif";
            picMarioGif.Size = new Size(112, 120);
            picMarioGif.SizeMode = PictureBoxSizeMode.StretchImage;
            picMarioGif.TabIndex = 4;
            picMarioGif.TabStop = false;
            // 
            // picButtonCancel
            // 
            picButtonCancel.BackColor = Color.Transparent;
            picButtonCancel.BackgroundImageLayout = ImageLayout.Stretch;
            picButtonCancel.Image = Properties.Resources.buttonCancel;
            picButtonCancel.Location = new Point(723, 403);
            picButtonCancel.Name = "picButtonCancel";
            picButtonCancel.Size = new Size(44, 35);
            picButtonCancel.SizeMode = PictureBoxSizeMode.StretchImage;
            picButtonCancel.TabIndex = 5;
            picButtonCancel.TabStop = false;
            picButtonCancel.Visible = false;
            picButtonCancel.Click += picButtonCancel_Click;
            // 
            // picSuperMario
            // 
            picSuperMario.BackColor = Color.Transparent;
            picSuperMario.BackgroundImageLayout = ImageLayout.Stretch;
            picSuperMario.Image = Properties.Resources.supermario;
            picSuperMario.Location = new Point(310, 3);
            picSuperMario.Name = "picSuperMario";
            picSuperMario.Size = new Size(186, 109);
            picSuperMario.SizeMode = PictureBoxSizeMode.StretchImage;
            picSuperMario.TabIndex = 6;
            picSuperMario.TabStop = false;
            // 
            // frmStartMario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BatDauBackGround;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(picSuperMario);
            Controls.Add(picButtonCancel);
            Controls.Add(picMarioGif);
            Controls.Add(pgbLoadMarioPlay);
            Controls.Add(picButtonDiscription);
            Controls.Add(picButtonInstall);
            Controls.Add(picButtonStart);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmStartMario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MARIO ";
            ((System.ComponentModel.ISupportInitialize)picButtonStart).EndInit();
            ((System.ComponentModel.ISupportInitialize)picButtonInstall).EndInit();
            ((System.ComponentModel.ISupportInitialize)picButtonDiscription).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMarioGif).EndInit();
            ((System.ComponentModel.ISupportInitialize)picButtonCancel).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSuperMario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picButtonStart;
        private PictureBox picButtonInstall;
        private PictureBox picButtonDiscription;
        private System.ComponentModel.BackgroundWorker bgwProcess;
        private ProgressBar pgbLoadMarioPlay;
        private PictureBox picMarioGif;
        private PictureBox picButtonCancel;
        private PictureBox picSuperMario;
    }
}