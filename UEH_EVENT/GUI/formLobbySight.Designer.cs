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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnAdd = new Button();
            lblThoiGian = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(326, 98);
            label1.Name = "label1";
            label1.Size = new Size(516, 60);
            label1.TabIndex = 2;
            label1.Text = "TẠO BÀI TRẮC NGHIỆM";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Dock = DockStyle.Left;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(285, 961);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(326, 307);
            label3.Name = "label3";
            label3.Size = new Size(322, 38);
            label3.TabIndex = 4;
            label3.Text = "Bài trắc nghiệm đã làm";
            // 
            // btnAdd
            // 
            btnAdd.BackgroundImage = Properties.Resources.add_outline_icon;
            btnAdd.BackgroundImageLayout = ImageLayout.Stretch;
            btnAdd.Location = new Point(1441, 92);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(79, 75);
            btnAdd.TabIndex = 5;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
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
            flowLayoutPanel1.Location = new Point(336, 396);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1154, 547);
            flowLayoutPanel1.TabIndex = 100;
            // 
            // formLobbySight
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 961);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "formLobbySight";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LobbySight";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            Load += formSight_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAdd;
        private Label lblThoiGian;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}