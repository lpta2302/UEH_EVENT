namespace UEH_EVENT.GUI
{
    partial class formDoingSight
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
            components = new System.ComponentModel.Container();
            bindingSource1 = new BindingSource(components);
            btnCauSau = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            lstCauHoi = new ListBox();
            btnKetThuc = new Button();
            grpAnswers = new Panel();
            panelAnswer = new Panel();
            rdo1 = new RadioButton();
            rdo2 = new RadioButton();
            rdo3 = new RadioButton();
            rdo4 = new RadioButton();
            lblD = new Label();
            lblC = new Label();
            lblB = new Label();
            lblA = new Label();
            lblCauhoi = new Label();
            lblThoiGian = new Label();
            btnCauTruoc = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            grpAnswers.SuspendLayout();
            panelAnswer.SuspendLayout();
            SuspendLayout();
            // 
            // btnCauSau
            // 
            btnCauSau.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCauSau.BackColor = Color.WhiteSmoke;
            btnCauSau.FlatStyle = FlatStyle.Flat;
            btnCauSau.Font = new Font("Arial", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            btnCauSau.ForeColor = SystemColors.ActiveCaptionText;
            btnCauSau.Location = new Point(711, 563);
            btnCauSau.Name = "btnCauSau";
            btnCauSau.Size = new Size(139, 53);
            btnCauSau.TabIndex = 1;
            btnCauSau.Text = "CÂU SAU";
            btnCauSau.UseVisualStyleBackColor = false;
            btnCauSau.Click += btnCauSau_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // lstCauHoi
            // 
            lstCauHoi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lstCauHoi.BackColor = Color.WhiteSmoke;
            lstCauHoi.BorderStyle = BorderStyle.FixedSingle;
            lstCauHoi.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lstCauHoi.ForeColor = Color.Green;
            lstCauHoi.FormattingEnabled = true;
            lstCauHoi.ItemHeight = 30;
            lstCauHoi.Location = new Point(875, 149);
            lstCauHoi.Name = "lstCauHoi";
            lstCauHoi.Size = new Size(244, 392);
            lstCauHoi.TabIndex = 12;
            lstCauHoi.SelectedIndexChanged += lstCauHoi_SelectedIndexChanged;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnKetThuc.BackColor = Color.MistyRose;
            btnKetThuc.FlatStyle = FlatStyle.Flat;
            btnKetThuc.Font = new Font("Arial", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            btnKetThuc.ForeColor = Color.FromArgb(192, 0, 0);
            btnKetThuc.Location = new Point(877, 563);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(243, 53);
            btnKetThuc.TabIndex = 13;
            btnKetThuc.Text = "KẾT THÚC";
            btnKetThuc.UseVisualStyleBackColor = false;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // grpAnswers
            // 
            grpAnswers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpAnswers.BackColor = Color.WhiteSmoke;
            grpAnswers.Controls.Add(panelAnswer);
            grpAnswers.Controls.Add(lblD);
            grpAnswers.Controls.Add(lblC);
            grpAnswers.Controls.Add(lblB);
            grpAnswers.Controls.Add(lblA);
            grpAnswers.Location = new Point(32, 171);
            grpAnswers.Name = "grpAnswers";
            grpAnswers.Size = new Size(819, 373);
            grpAnswers.TabIndex = 10;
            // 
            // panelAnswer
            // 
            panelAnswer.Controls.Add(rdo1);
            panelAnswer.Controls.Add(rdo2);
            panelAnswer.Controls.Add(rdo3);
            panelAnswer.Controls.Add(rdo4);
            panelAnswer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            panelAnswer.ForeColor = Color.Black;
            panelAnswer.Location = new Point(8, 14);
            panelAnswer.Name = "panelAnswer";
            panelAnswer.Size = new Size(73, 345);
            panelAnswer.TabIndex = 14;
            // 
            // rdo1
            // 
            rdo1.AutoSize = true;
            rdo1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            rdo1.ForeColor = Color.Black;
            rdo1.Location = new Point(9, 13);
            rdo1.Name = "rdo1";
            rdo1.Size = new Size(51, 35);
            rdo1.TabIndex = 17;
            rdo1.TabStop = true;
            rdo1.Text = "A";
            rdo1.UseVisualStyleBackColor = true;
            rdo1.Click += UpdateAnswer;
            // 
            // rdo2
            // 
            rdo2.AutoSize = true;
            rdo2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            rdo2.ForeColor = Color.Black;
            rdo2.Location = new Point(10, 104);
            rdo2.Name = "rdo2";
            rdo2.Size = new Size(50, 35);
            rdo2.TabIndex = 0;
            rdo2.TabStop = true;
            rdo2.Text = "B";
            rdo2.UseVisualStyleBackColor = true;
            rdo2.Click += UpdateAnswer;
            // 
            // rdo3
            // 
            rdo3.AutoSize = true;
            rdo3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            rdo3.ForeColor = Color.Black;
            rdo3.Location = new Point(9, 194);
            rdo3.Name = "rdo3";
            rdo3.Size = new Size(49, 35);
            rdo3.TabIndex = 16;
            rdo3.TabStop = true;
            rdo3.Text = "C";
            rdo3.UseVisualStyleBackColor = true;
            rdo3.Click += UpdateAnswer;
            // 
            // rdo4
            // 
            rdo4.AutoSize = true;
            rdo4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            rdo4.ForeColor = Color.Black;
            rdo4.Location = new Point(10, 287);
            rdo4.Name = "rdo4";
            rdo4.Size = new Size(52, 35);
            rdo4.TabIndex = 15;
            rdo4.TabStop = true;
            rdo4.Text = "D";
            rdo4.UseVisualStyleBackColor = true;
            rdo4.Click += UpdateAnswer;
            // 
            // lblD
            // 
            lblD.BackColor = Color.WhiteSmoke;
            lblD.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblD.ForeColor = Color.Black;
            lblD.Location = new Point(88, 301);
            lblD.Name = "lblD";
            lblD.Size = new Size(659, 63);
            lblD.TabIndex = 3;
            lblD.Click += lblD_Click;
            // 
            // lblC
            // 
            lblC.BackColor = Color.WhiteSmoke;
            lblC.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblC.ForeColor = Color.Black;
            lblC.Location = new Point(87, 208);
            lblC.Name = "lblC";
            lblC.Size = new Size(661, 60);
            lblC.TabIndex = 2;
            lblC.Click += lblC_Click;
            // 
            // lblB
            // 
            lblB.BackColor = Color.WhiteSmoke;
            lblB.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblB.ForeColor = Color.Black;
            lblB.Location = new Point(88, 118);
            lblB.Name = "lblB";
            lblB.Size = new Size(659, 65);
            lblB.TabIndex = 1;
            lblB.Click += lblB_Click;
            // 
            // lblA
            // 
            lblA.BackColor = Color.WhiteSmoke;
            lblA.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblA.ForeColor = Color.Black;
            lblA.Location = new Point(87, 27);
            lblA.Name = "lblA";
            lblA.Size = new Size(661, 64);
            lblA.TabIndex = 0;
            lblA.Click += lblA_Click;
            // 
            // lblCauhoi
            // 
            lblCauhoi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCauhoi.BackColor = Color.WhiteSmoke;
            lblCauhoi.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCauhoi.ForeColor = Color.Black;
            lblCauhoi.Location = new Point(32, 56);
            lblCauhoi.Name = "lblCauhoi";
            lblCauhoi.Size = new Size(819, 91);
            lblCauhoi.TabIndex = 14;
            // 
            // lblThoiGian
            // 
            lblThoiGian.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblThoiGian.BackColor = Color.WhiteSmoke;
            lblThoiGian.FlatStyle = FlatStyle.System;
            lblThoiGian.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblThoiGian.ForeColor = Color.FromArgb(64, 64, 64);
            lblThoiGian.Location = new Point(875, 56);
            lblThoiGian.Name = "lblThoiGian";
            lblThoiGian.Size = new Size(244, 91);
            lblThoiGian.TabIndex = 15;
            lblThoiGian.TextAlign = ContentAlignment.MiddleCenter;
            lblThoiGian.Click += lblThoiGian_Click;
            // 
            // btnCauTruoc
            // 
            btnCauTruoc.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCauTruoc.BackColor = Color.WhiteSmoke;
            btnCauTruoc.FlatStyle = FlatStyle.Flat;
            btnCauTruoc.Font = new Font("Arial", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            btnCauTruoc.ForeColor = Color.Black;
            btnCauTruoc.Location = new Point(32, 563);
            btnCauTruoc.Name = "btnCauTruoc";
            btnCauTruoc.Size = new Size(139, 53);
            btnCauTruoc.TabIndex = 0;
            btnCauTruoc.Text = "CÂU TRƯỚC";
            btnCauTruoc.UseVisualStyleBackColor = false;
            btnCauTruoc.Click += btnCauTruoc_Click;
            // 
            // formDoingSight
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1145, 655);
            Controls.Add(btnCauTruoc);
            Controls.Add(btnCauSau);
            Controls.Add(lblThoiGian);
            Controls.Add(lblCauhoi);
            Controls.Add(btnKetThuc);
            Controls.Add(lstCauHoi);
            Controls.Add(grpAnswers);
            ForeColor = Color.Red;
            Name = "formDoingSight";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManHinhThi";
            WindowState = FormWindowState.Maximized;
            Load += ManHinhThi_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            grpAnswers.ResumeLayout(false);
            panelAnswer.ResumeLayout(false);
            panelAnswer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox lstCauHoi;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.Button btnCauSau;
        private System.Windows.Forms.Panel grpAnswers;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblD;
        private Panel panelAnswer;
        private RadioButton rdo2;
        private RadioButton rdo4;
        private RadioButton rdo3;
        private RadioButton rdo1;
        private Label lblCauhoi;
        private Label lblThoiGian;
        private Button btnCauTruoc;
    }


}