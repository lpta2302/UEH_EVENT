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
            flowLayoutPanel1 = new FlowLayoutPanel();
            Navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(297, 45);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(400, 32);
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
            btnAdd.Location = new Point(1069, 39);
            btnAdd.Margin = new Padding(2, 2, 2, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(47, 47);
            btnAdd.TabIndex = 4;
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // Navbar
            // 
            Navbar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Navbar.BackColor = Color.FromArgb(34, 34, 34);
            Navbar.Controls.Add(pictureBoxLogo);
            Navbar.Controls.Add(panelTitle);
            Navbar.Location = new Point(-3, 1);
            Navbar.Margin = new Padding(2, 2, 2, 2);
            Navbar.Name = "Navbar";
            Navbar.Size = new Size(271, 653);
            Navbar.TabIndex = 46;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.Logo_Update_27_3;
            pictureBoxLogo.Location = new Point(0, 3);
            pictureBoxLogo.Margin = new Padding(2, 2, 2, 2);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(269, 105);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 4;
            pictureBoxLogo.TabStop = false;
            // 
            // panelTitle
            // 
            panelTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelTitle.CausesValidation = false;
            panelTitle.Location = new Point(811, 2);
            panelTitle.Margin = new Padding(2, 2, 2, 2);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(876, 2453);
            panelTitle.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.Location = new Point(297, 106);
            flowLayoutPanel1.Margin = new Padding(2, 2, 2, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1867, 309);
            flowLayoutPanel1.TabIndex = 101;
            // 
            // formSight
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1145, 653);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(Navbar);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "formSight";
            Text = " ";
            WindowState = FormWindowState.Maximized;
            Navbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnAdd;
        private Panel Navbar;
        private PictureBox pictureBoxLogo;
        private Panel panelTitle;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}