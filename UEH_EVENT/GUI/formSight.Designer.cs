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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSight));
            btnHomee = new Button();
            pictureBoxLogo = new PictureBox();
            Navbar = new Panel();
            panelTitle = new Panel();
            Home = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            Navbar.SuspendLayout();
            Home.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
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
            btnHomee.Location = new Point(0, -9);
            btnHomee.Name = "btnHomee";
            btnHomee.Padding = new Padding(20, 0, 0, 0);
            btnHomee.Size = new Size(419, 92);
            btnHomee.TabIndex = 10;
            btnHomee.Text = "  HOME";
            btnHomee.TextAlign = ContentAlignment.MiddleLeft;
            btnHomee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHomee.UseVisualStyleBackColor = false;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackgroundImage = Properties.Resources.Logo_396x163;
            pictureBoxLogo.Location = new Point(0, 0);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(400, 159);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 4;
            pictureBoxLogo.TabStop = false;
            // 
            // Navbar
            // 
            Navbar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Navbar.BackColor = Color.FromArgb(34, 34, 34);
            Navbar.Controls.Add(panelTitle);
            Navbar.Controls.Add(Home);
            Navbar.Controls.Add(panel1);
            Navbar.Location = new Point(1, 0);
            Navbar.Name = "Navbar";
            Navbar.Size = new Size(400, 980);
            Navbar.TabIndex = 2;
            // 
            // panelTitle
            // 
            panelTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelTitle.CausesValidation = false;
            panelTitle.Location = new Point(602, 3);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(1314, 1043);
            panelTitle.TabIndex = 3;
            // 
            // Home
            // 
            Home.Controls.Add(btnHomee);
            Home.Location = new Point(0, 168);
            Home.Name = "Home";
            Home.Size = new Size(400, 75);
            Home.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBoxLogo);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(396, 162);
            panel1.TabIndex = 13;
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
            // formSight
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1718, 979);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(Navbar);
            Name = "formSight";
            Text = " ";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            Navbar.ResumeLayout(false);
            Home.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHomee;
        private PictureBox pictureBoxLogo;
        private Panel Navbar;
        private Panel panelTitle;
        private Panel Home;
        private Panel panel1;
        private Label label1;
        private Button btnAdd;
    }
}