using UEH_EVENT.Utils;
using static Constants;

namespace UEH_EVENT.GUI
{
    partial class formHomepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formHomepage));
            Navbar = new Panel();
            pictureBoxHome = new PictureBox();
            pictureBox1 = new PictureBox();
            Home = new Panel();
            btnHomee = new Button();
            panel1 = new Panel();
            btnHome = new Button();
            Navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Home.SuspendLayout();
            SuspendLayout();
            // 
            // Navbar
            // 
            Constants.INavbar.CreateNavbar(this, resources); 
            Navbar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Navbar.BackColor = Color.FromArgb(34, 34, 34);
            Navbar.Controls.Add(pictureBoxHome);
            Navbar.Controls.Add(pictureBox1);
            Navbar.Controls.Add(Home);
            Navbar.Controls.Add(panel1);
            Navbar.Location = new Point(0, 1);
            Navbar.Margin = new Padding(2);
            Navbar.Name = "Navbar";
            Navbar.Size = new Size(229, 801);
            Navbar.TabIndex = 0;
            // 
            // pictureBoxHome
            // 
            pictureBoxHome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxHome.Image = Properties.Resources.Home;
            pictureBoxHome.Location = new Point(170, -22);
            pictureBoxHome.Margin = new Padding(2);
            pictureBoxHome.Name = "pictureBoxHome";
            pictureBoxHome.Size = new Size(0, 772);
            pictureBoxHome.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxHome.TabIndex = 1;
            pictureBoxHome.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Logo_396x163;
            pictureBox1.Enabled = false;
            pictureBox1.Location = new Point(0, 2);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(226, 93);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Home
            // 
            Home.Controls.Add(btnHomee);
            Home.Location = new Point(0, 96);
            Home.Margin = new Padding(2);
            Home.Name = "Home";
            Home.Size = new Size(229, 43);
            Home.TabIndex = 7;
            // 
            // btnHomee
            // 
            btnHomee.BackColor = Color.FromArgb(34, 34, 34);
            btnHomee.BackgroundImageLayout = ImageLayout.None;
            btnHomee.FlatStyle = FlatStyle.Flat;
            btnHomee.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnHomee.ForeColor = Color.White;
            btnHomee.Image = (Image)resources.GetObject("btnHomee.Image");
            btnHomee.ImageAlign = ContentAlignment.MiddleLeft;
            btnHomee.Location = new Point(0, -5);
            btnHomee.Margin = new Padding(2);
            btnHomee.Name = "btnHomee";
            btnHomee.Padding = new Padding(11, 0, 0, 0);
            btnHomee.Size = new Size(239, 53);
            btnHomee.TabIndex = 10;
            btnHomee.Text = "  HOME";
            btnHomee.TextAlign = ContentAlignment.MiddleLeft;
            btnHomee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHomee.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(114, 57);
            panel1.TabIndex = 13;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(0, 0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(75, 23);
            btnHome.TabIndex = 0;
            // 
            // formHomepage
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1847, 803);
            Controls.Add(Navbar);
            Margin = new Padding(2);
            Name = "formHomepage";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Homepage";
            WindowState = FormWindowState.Maximized;
            Load += Homepage_Load;
            Navbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Home.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        /*private List<Panel> navItems;
        private List<Button> navButtons ;*/
        private Panel Navbar;
        private Panel panel1;
        private Button btnHome;
        private Panel Home;
        private PictureBox pictureBox1;
        private PictureBox pictureBoxHome;
        private Button btnHomee;
    }
}