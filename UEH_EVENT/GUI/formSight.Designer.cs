namespace UEH_EVENT.GUI
{
    partial class formSight
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
            btnAdd = new Button();
            Navbar = new Panel();
            pictureBoxLogo = new PictureBox();
            panelTitle = new Panel();
            panel1 = new Panel();
            panelStart = new Panel();
            btnPlay = new Button();
            Navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panel1.SuspendLayout();
            panelStart.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Helvetica", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(445, 75);
            label1.Name = "label1";
            label1.Size = new Size(527, 45);
            label1.TabIndex = 3;
            label1.Text = "SIGHT FOR TRAINING POINT";
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackgroundImageLayout = ImageLayout.None;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Image = Properties.Resources.iconAdd;
            btnAdd.Location = new Point(1575, 67);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(70, 70);
            btnAdd.TabIndex = 4;
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // Navbar
            // 
            Navbar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Navbar.BackColor = Color.FromArgb(34, 34, 34);
            Navbar.Controls.Add(pictureBoxLogo);
            Navbar.Controls.Add(panelTitle);
            Navbar.Location = new Point(2, 0);
            Navbar.Name = "Navbar";
            Navbar.Size = new Size(407, 979);
            Navbar.TabIndex = 46;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.Logo_Update_27_3;
            pictureBoxLogo.Location = new Point(0, 4);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(404, 158);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 4;
            pictureBoxLogo.TabStop = false;
            // 
            // panelTitle
            // 
            panelTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelTitle.CausesValidation = false;
            panelTitle.Location = new Point(1216, 3);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(1314, 3679);
            panelTitle.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Background_Guiz3;
            panel1.Controls.Add(panelStart);
            panel1.Location = new Point(412, 161);
            panel1.Name = "panel1";
            panel1.Size = new Size(1314, 818);
            panel1.TabIndex = 47;
            panel1.Paint += panel1_Paint;
            // 
            // panelStart
            // 
            panelStart.Anchor = AnchorStyles.Left;
            panelStart.Controls.Add(btnPlay);
            panelStart.Location = new Point(628, 648);
            panelStart.Name = "panelStart";
            panelStart.Size = new Size(237, 80);
            panelStart.TabIndex = 2;
            // 
            // btnPlay
            // 
            btnPlay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnPlay.FlatStyle = FlatStyle.Flat;
            btnPlay.Font = new Font("Helvetica", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            btnPlay.Location = new Point(-58, -11);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(350, 101);
            btnPlay.TabIndex = 0;
            btnPlay.Text = "Start";
            btnPlay.UseVisualStyleBackColor = true;
            // 
            // formSight
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1718, 979);
            Controls.Add(panel1);
            Controls.Add(Navbar);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Name = "formSight";
            Text = " ";
            WindowState = FormWindowState.Maximized;
            Navbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panel1.ResumeLayout(false);
            panelStart.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnAdd;
        private Panel Navbar;
        private PictureBox pictureBoxLogo;
        private Panel panelTitle;
        private Panel panel1;
        private Panel panelStart;
        private Button btnPlay;
    }
}