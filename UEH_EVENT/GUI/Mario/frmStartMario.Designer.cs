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
            bgwProcess = new System.ComponentModel.BackgroundWorker();
            pgbLoadMarioPlay = new ProgressBar();
            picMarioGif = new PictureBox();
            picSuperMario = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picButtonStart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMarioGif).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSuperMario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // picButtonStart
            // 
            picButtonStart.BackColor = Color.Transparent;
            picButtonStart.BackgroundImageLayout = ImageLayout.Stretch;
            picButtonStart.Image = Properties.Resources.startButtonfixed;
            picButtonStart.Location = new Point(268, 268);
            picButtonStart.Margin = new Padding(2, 2, 2, 2);
            picButtonStart.Name = "picButtonStart";
            picButtonStart.Size = new Size(120, 60);
            picButtonStart.SizeMode = PictureBoxSizeMode.StretchImage;
            picButtonStart.TabIndex = 0;
            picButtonStart.TabStop = false;
            picButtonStart.Click += picButtonStart_Click;
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
            pgbLoadMarioPlay.Location = new Point(88, 342);
            pgbLoadMarioPlay.Margin = new Padding(2, 2, 2, 2);
            pgbLoadMarioPlay.Name = "pgbLoadMarioPlay";
            pgbLoadMarioPlay.Size = new Size(486, 8);
            pgbLoadMarioPlay.TabIndex = 3;
            // 
            // picMarioGif
            // 
            picMarioGif.BackColor = Color.Transparent;
            picMarioGif.BackgroundImageLayout = ImageLayout.Stretch;
            picMarioGif.Image = Properties.Resources.miniMario;
            picMarioGif.Location = new Point(59, 242);
            picMarioGif.Margin = new Padding(2, 2, 2, 2);
            picMarioGif.Name = "picMarioGif";
            picMarioGif.Size = new Size(90, 96);
            picMarioGif.SizeMode = PictureBoxSizeMode.StretchImage;
            picMarioGif.TabIndex = 4;
            picMarioGif.TabStop = false;
            // 
            // picSuperMario
            // 
            picSuperMario.BackColor = Color.Transparent;
            picSuperMario.BackgroundImageLayout = ImageLayout.Stretch;
            picSuperMario.Image = Properties.Resources.supermario;
            picSuperMario.Location = new Point(248, 2);
            picSuperMario.Margin = new Padding(2, 2, 2, 2);
            picSuperMario.Name = "picSuperMario";
            picSuperMario.Size = new Size(149, 87);
            picSuperMario.SizeMode = PictureBoxSizeMode.StretchImage;
            picSuperMario.TabIndex = 6;
            picSuperMario.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.buttonCancel;
            pictureBox1.Location = new Point(11, 11);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // frmStartMario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BatDauBackGround;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(640, 360);
            Controls.Add(pictureBox1);
            Controls.Add(picSuperMario);
            Controls.Add(picMarioGif);
            Controls.Add(pgbLoadMarioPlay);
            Controls.Add(picButtonStart);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmStartMario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MARIO ";
            ((System.ComponentModel.ISupportInitialize)picButtonStart).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMarioGif).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSuperMario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picButtonStart;
        private System.ComponentModel.BackgroundWorker bgwProcess;
        private ProgressBar pgbLoadMarioPlay;
        private PictureBox picMarioGif;
        private PictureBox picSuperMario;
        private PictureBox pictureBox1;
    }
}