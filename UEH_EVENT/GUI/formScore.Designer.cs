namespace UEH_EVENT.GUI
{
    partial class formScore
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
            lblTong = new Label();
            lblDung = new Label();
            lblSai = new Label();
            txtTong = new TextBox();
            txtDung = new TextBox();
            txtSai = new TextBox();
            lblTieuDe = new Label();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblTong
            // 
            lblTong.AutoSize = true;
            lblTong.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTong.Location = new Point(187, 147);
            lblTong.Margin = new Padding(4, 0, 4, 0);
            lblTong.Name = "lblTong";
            lblTong.Size = new Size(306, 41);
            lblTong.TabIndex = 0;
            lblTong.Text = "Tổng số câu làm bài:";
            // 
            // lblDung
            // 
            lblDung.AutoSize = true;
            lblDung.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblDung.Location = new Point(187, 247);
            lblDung.Margin = new Padding(4, 0, 4, 0);
            lblDung.Name = "lblDung";
            lblDung.Size = new Size(279, 41);
            lblDung.TabIndex = 1;
            lblDung.Text = "Tổng số câu Đúng:";
            // 
            // lblSai
            // 
            lblSai.AutoSize = true;
            lblSai.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblSai.Location = new Point(187, 356);
            lblSai.Margin = new Padding(4, 0, 4, 0);
            lblSai.Name = "lblSai";
            lblSai.Size = new Size(244, 41);
            lblSai.TabIndex = 2;
            lblSai.Text = "Tổng số câu Sai:";
            // 
            // txtTong
            // 
            txtTong.BackColor = Color.White;
            txtTong.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            txtTong.Location = new Point(579, 144);
            txtTong.Margin = new Padding(4);
            txtTong.Multiline = true;
            txtTong.Name = "txtTong";
            txtTong.ReadOnly = true;
            txtTong.Size = new Size(111, 69);
            txtTong.TabIndex = 3;
            txtTong.TextAlign = HorizontalAlignment.Center;
            txtTong.TextChanged += txtTong_TextChanged;
            // 
            // txtDung
            // 
            txtDung.BackColor = Color.White;
            txtDung.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            txtDung.ForeColor = SystemColors.MenuHighlight;
            txtDung.Location = new Point(579, 244);
            txtDung.Margin = new Padding(4);
            txtDung.Multiline = true;
            txtDung.Name = "txtDung";
            txtDung.ReadOnly = true;
            txtDung.Size = new Size(111, 69);
            txtDung.TabIndex = 4;
            txtDung.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSai
            // 
            txtSai.BackColor = Color.White;
            txtSai.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            txtSai.ForeColor = Color.Red;
            txtSai.Location = new Point(579, 353);
            txtSai.Margin = new Padding(4);
            txtSai.Multiline = true;
            txtSai.Name = "txtSai";
            txtSai.ReadOnly = true;
            txtSai.Size = new Size(111, 69);
            txtSai.TabIndex = 5;
            txtSai.TextAlign = HorizontalAlignment.Center;
            // 
            // lblTieuDe
            // 
            lblTieuDe.BackColor = Color.White;
            lblTieuDe.Dock = DockStyle.Top;
            lblTieuDe.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTieuDe.Location = new Point(0, 0);
            lblTieuDe.Margin = new Padding(4, 0, 4, 0);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(872, 113);
            lblTieuDe.TabIndex = 6;
            lblTieuDe.Text = "Kết Quả Thi";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveCaptionText;
            btnBack.BackgroundImageLayout = ImageLayout.Stretch;
            btnBack.ForeColor = SystemColors.Control;
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(163, 62);
            btnBack.TabIndex = 8;
            btnBack.Text = "Trở lại";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // formScore
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(872, 528);
            Controls.Add(btnBack);
            Controls.Add(lblTieuDe);
            Controls.Add(txtSai);
            Controls.Add(txtDung);
            Controls.Add(txtTong);
            Controls.Add(lblSai);
            Controls.Add(lblDung);
            Controls.Add(lblTong);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "formScore";
            Text = "formScore";
            Load += formScore_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTong;
        private Label lblDung;
        private Label lblSai;
        private TextBox txtTong;
        private TextBox txtDung;
        private TextBox txtSai;
        private Label lblTieuDe;
        private Button btnBack;
    }
}