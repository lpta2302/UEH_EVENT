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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnAdd = new Button();
            lblThoiGian = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(474, 409);
            panel1.Name = "panel1";
            panel1.Size = new Size(1175, 531);
            panel1.TabIndex = 1;
            // 
            // button2
            // 

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(474, 124);
            label1.Name = "label1";
            label1.Size = new Size(553, 62);
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
            label2.Size = new Size(408, 961);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(474, 329);
            label3.Name = "label3";
            label3.Size = new Size(322, 38);
            label3.TabIndex = 4;
            label3.Text = "Bài trắc nghiệm đã làm";
            // 
            // btnAdd
            // 
            btnAdd.BackgroundImage = Properties.Resources._953211_200;
            btnAdd.BackgroundImageLayout = ImageLayout.Stretch;
            btnAdd.Location = new Point(1582, 111);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(117, 89);
            btnAdd.TabIndex = 5;
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // lblTenBai
            // 
            // 
            // lblThoiGian
            // 
            lblThoiGian.Location = new Point(0, 0);
            lblThoiGian.Name = "lblThoiGian";
            lblThoiGian.Size = new Size(100, 23);
            lblThoiGian.TabIndex = 0;
            // 
            // formSight
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 961);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "formSight";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formSight";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            Load += formSight_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAdd;
        private Label lblThoiGian;
    }
}