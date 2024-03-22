namespace UEH_EVENT.GUI
{
    partial class formTrainingPoint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTrainingPoint));
            pictureBoxPoint = new PictureBox();
            Navbar = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnHome = new Button();
            panel2 = new Panel();
            btbSetting = new Button();
            panel3 = new Panel();
            btnGame = new Button();
            panel5 = new Panel();
            btnUpdate = new Button();
            panel4 = new Panel();
            btnTrainingpoint = new Button();
            panel6 = new Panel();
            btnManage = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPoint).BeginInit();
            Navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxPoint
            // 
            pictureBoxPoint.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxPoint.Image = Properties.Resources.Training_point;
            pictureBoxPoint.Location = new Point(335, 1);
            pictureBoxPoint.Margin = new Padding(3, 4, 3, 4);
            pictureBoxPoint.Name = "pictureBoxPoint";
            pictureBoxPoint.Size = new Size(1385, 982);
            pictureBoxPoint.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPoint.TabIndex = 2;
            pictureBoxPoint.TabStop = false;
            // 
            // Navbar
            // 
            Navbar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Navbar.BackColor = Color.FromArgb(34, 34, 34);
            Navbar.Controls.Add(pictureBox1);
            Navbar.Controls.Add(panel1);
            Navbar.Controls.Add(panel2);
            Navbar.Controls.Add(panel3);
            Navbar.Controls.Add(panel5);
            Navbar.Controls.Add(panel4);
            Navbar.Controls.Add(panel6);
            Navbar.Location = new Point(2, 2);
            Navbar.Name = "Navbar";
            Navbar.Size = new Size(331, 981);
            Navbar.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Brand_330x122;
            pictureBox1.Location = new Point(1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(330, 122);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnHome);
            panel1.Location = new Point(2, 128);
            panel1.Name = "panel1";
            panel1.Size = new Size(302, 68);
            panel1.TabIndex = 4;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(34, 34, 34);
            btnHome.BackgroundImageLayout = ImageLayout.None;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Helvetica", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome.ForeColor = Color.White;
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(-1, -13);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(20, 0, 0, 0);
            btnHome.Size = new Size(333, 92);
            btnHome.TabIndex = 5;
            btnHome.Text = "  HOME";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(btbSetting);
            panel2.Location = new Point(3, 473);
            panel2.Name = "panel2";
            panel2.Size = new Size(302, 68);
            panel2.TabIndex = 11;
            // 
            // btbSetting
            // 
            btbSetting.BackColor = Color.FromArgb(34, 34, 34);
            btbSetting.BackgroundImageLayout = ImageLayout.None;
            btbSetting.FlatStyle = FlatStyle.Popup;
            btbSetting.Font = new Font("Helvetica", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btbSetting.ForeColor = Color.White;
            btbSetting.Image = (Image)resources.GetObject("btbSetting.Image");
            btbSetting.ImageAlign = ContentAlignment.MiddleLeft;
            btbSetting.Location = new Point(0, -12);
            btbSetting.Name = "btbSetting";
            btbSetting.Padding = new Padding(20, 0, 0, 0);
            btbSetting.Size = new Size(333, 92);
            btbSetting.TabIndex = 5;
            btbSetting.Text = "  SETTING";
            btbSetting.TextAlign = ContentAlignment.MiddleLeft;
            btbSetting.TextImageRelation = TextImageRelation.ImageBeforeText;
            btbSetting.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnGame);
            panel3.Location = new Point(3, 202);
            panel3.Name = "panel3";
            panel3.Size = new Size(302, 68);
            panel3.TabIndex = 7;
            // 
            // btnGame
            // 
            btnGame.BackColor = Color.FromArgb(34, 34, 34);
            btnGame.BackgroundImageLayout = ImageLayout.None;
            btnGame.FlatStyle = FlatStyle.Popup;
            btnGame.Font = new Font("Helvetica", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGame.ForeColor = Color.White;
            btnGame.Image = (Image)resources.GetObject("btnGame.Image");
            btnGame.ImageAlign = ContentAlignment.MiddleLeft;
            btnGame.Location = new Point(0, -12);
            btnGame.Name = "btnGame";
            btnGame.Padding = new Padding(20, 0, 0, 0);
            btnGame.Size = new Size(333, 92);
            btnGame.TabIndex = 5;
            btnGame.Text = "  GAME";
            btnGame.TextAlign = ContentAlignment.MiddleLeft;
            btnGame.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGame.UseVisualStyleBackColor = false;
            btnGame.Click += btnGame_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnUpdate);
            panel5.Location = new Point(3, 405);
            panel5.Name = "panel5";
            panel5.Size = new Size(302, 68);
            panel5.TabIndex = 10;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(34, 34, 34);
            btnUpdate.BackgroundImageLayout = ImageLayout.None;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Helvetica", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Image = (Image)resources.GetObject("btnUpdate.Image");
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(0, -12);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Padding = new Padding(20, 0, 0, 0);
            btnUpdate.Size = new Size(333, 92);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "  UPDATE";
            btnUpdate.TextAlign = ContentAlignment.MiddleLeft;
            btnUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnTrainingpoint);
            panel4.Location = new Point(3, 270);
            panel4.Name = "panel4";
            panel4.Size = new Size(302, 68);
            panel4.TabIndex = 8;
            // 
            // btnTrainingpoint
            // 
            btnTrainingpoint.BackColor = Color.FromArgb(34, 34, 34);
            btnTrainingpoint.BackgroundImageLayout = ImageLayout.None;
            btnTrainingpoint.FlatStyle = FlatStyle.Popup;
            btnTrainingpoint.Font = new Font("Helvetica", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTrainingpoint.ForeColor = Color.White;
            btnTrainingpoint.Image = (Image)resources.GetObject("btnTrainingpoint.Image");
            btnTrainingpoint.ImageAlign = ContentAlignment.MiddleLeft;
            btnTrainingpoint.Location = new Point(0, -12);
            btnTrainingpoint.Name = "btnTrainingpoint";
            btnTrainingpoint.Padding = new Padding(20, 0, 0, 0);
            btnTrainingpoint.Size = new Size(333, 92);
            btnTrainingpoint.TabIndex = 5;
            btnTrainingpoint.Text = "  TRAINING POINTS";
            btnTrainingpoint.TextAlign = ContentAlignment.MiddleLeft;
            btnTrainingpoint.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTrainingpoint.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnManage);
            panel6.Location = new Point(3, 337);
            panel6.Name = "panel6";
            panel6.Size = new Size(302, 68);
            panel6.TabIndex = 9;
            // 
            // btnManage
            // 
            btnManage.BackColor = Color.FromArgb(34, 34, 34);
            btnManage.BackgroundImageLayout = ImageLayout.None;
            btnManage.FlatStyle = FlatStyle.Popup;
            btnManage.Font = new Font("Helvetica", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnManage.ForeColor = Color.White;
            btnManage.Image = (Image)resources.GetObject("btnManage.Image");
            btnManage.ImageAlign = ContentAlignment.MiddleLeft;
            btnManage.Location = new Point(0, -12);
            btnManage.Name = "btnManage";
            btnManage.Padding = new Padding(20, 0, 0, 0);
            btnManage.Size = new Size(333, 92);
            btnManage.TabIndex = 5;
            btnManage.Text = "  MANAGE";
            btnManage.TextAlign = ContentAlignment.MiddleLeft;
            btnManage.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnManage.UseVisualStyleBackColor = false;
            // 
            // formTrainingPoint
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1718, 983);
            Controls.Add(Navbar);
            Controls.Add(pictureBoxPoint);
            Margin = new Padding(3, 4, 3, 4);
            Name = "formTrainingPoint";
            Text = "FormTrainingPoint";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPoint).EndInit();
            Navbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxPoint;
        private Panel Navbar;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnHome;
        private Panel panel2;
        private Button btbSetting;
        private Panel panel3;
        private Button btnGame;
        private Panel panel5;
        private Button btnUpdate;
        private Panel panel4;
        private Button btnTrainingpoint;
        private Panel panel6;
        private Button btnManage;
    }
}