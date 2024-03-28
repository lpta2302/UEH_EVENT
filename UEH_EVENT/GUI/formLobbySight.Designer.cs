namespace UEH_EVENT.GUI
{
    partial class formLobbySight
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
            label3 = new Label();
            lblThoiGian = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            Navbar = new Panel();
            pictureBoxLogo = new PictureBox();
            label4 = new Label();
            btnCreate = new Button();
            Navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(458, 164);
            label3.Name = "label3";
            label3.Size = new Size(424, 51);
            label3.TabIndex = 4;
            label3.Text = "Bài trắc nghiệm đã tạo";
            // 
            // lblThoiGian
            // 
            lblThoiGian.Location = new Point(0, 0);
            lblThoiGian.Name = "lblThoiGian";
            lblThoiGian.Size = new Size(100, 23);
            lblThoiGian.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(458, 243);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(2400, 421);
            flowLayoutPanel1.TabIndex = 100;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // Navbar
            // 
            Navbar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Navbar.BackColor = Color.FromArgb(34, 34, 34);
            Navbar.Controls.Add(pictureBoxLogo);
            Navbar.Location = new Point(-5, 1);
            Navbar.Name = "Navbar";
            Navbar.Size = new Size(407, 977);
            Navbar.TabIndex = 101;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.Logo_Update_27_3;
            pictureBoxLogo.Location = new Point(0, 3);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(404, 159);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 47;
            pictureBoxLogo.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Helvetica", 20.1428585F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(458, 58);
            label4.Name = "label4";
            label4.Size = new Size(373, 57);
            label4.TabIndex = 102;
            label4.Text = "CREATE SIGHT";
            // 
            // btnCreate
            // 
            btnCreate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCreate.BackColor = Color.FromArgb(34, 34, 34);
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(1498, 58);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(177, 71);
            btnCreate.TabIndex = 103;
            btnCreate.Text = "TẠO";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // formLobbySight
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1718, 979);
            Controls.Add(btnCreate);
            Controls.Add(label4);
            Controls.Add(Navbar);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label3);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "formLobbySight";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LobbySight";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            Load += formSight_Load;
            Navbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label lblThoiGian;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel Navbar;
        private PictureBox pictureBoxLogo;
        private Label label4;
        private Button btnCreate;
    }
}