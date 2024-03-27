namespace UEH_EVENT.GUI
{
    partial class formCreateSight
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
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnTao = new Button();
            btnThoat = new Button();
            txtMoTa = new TextBox();
            txtTenTN = new TextBox();
            label7 = new Label();
            label8 = new Label();
            listView1 = new ListView();
            clnSTT = new ColumnHeader();
            clnQuestion = new ColumnHeader();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThem.BackColor = Color.Gainsboro;
            btnThem.Font = new Font("Helvetica", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.Black;
            btnThem.Location = new Point(1443, 237);
            btnThem.Margin = new Padding(4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(217, 71);
            btnThem.TabIndex = 12;
            btnThem.Text = "THÊM";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSua.BackColor = Color.Gainsboro;
            btnSua.Font = new Font("Helvetica", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.ForeColor = Color.Black;
            btnSua.Location = new Point(1212, 237);
            btnSua.Margin = new Padding(4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(202, 71);
            btnSua.TabIndex = 15;
            btnSua.Text = "SỬA";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXoa.BackColor = Color.Gainsboro;
            btnXoa.Font = new Font("Helvetica", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.ForeColor = Color.Black;
            btnXoa.Location = new Point(966, 237);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(225, 71);
            btnXoa.TabIndex = 16;
            btnXoa.Text = "XÓA";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnTao
            // 
            btnTao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTao.BackColor = Color.Black;
            btnTao.FlatStyle = FlatStyle.Flat;
            btnTao.Font = new Font("Helvetica", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            btnTao.ForeColor = Color.White;
            btnTao.Location = new Point(1443, 56);
            btnTao.Margin = new Padding(4);
            btnTao.Name = "btnTao";
            btnTao.Size = new Size(217, 71);
            btnTao.TabIndex = 17;
            btnTao.Text = "TẠO";
            btnTao.UseVisualStyleBackColor = false;
            btnTao.Click += btnTao_Click;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThoat.BackColor = Color.White;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.ForeColor = Color.FromArgb(192, 0, 0);
            btnThoat.Location = new Point(1239, 56);
            btnThoat.Margin = new Padding(4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(191, 71);
            btnThoat.TabIndex = 18;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtMoTa
            // 
            txtMoTa.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtMoTa.Location = new Point(272, 117);
            txtMoTa.Margin = new Padding(4);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(824, 55);
            txtMoTa.TabIndex = 23;
            txtMoTa.TextChanged += txtMoTa_TextChanged;
            // 
            // txtTenTN
            // 
            txtTenTN.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenTN.Location = new Point(272, 45);
            txtTenTN.Margin = new Padding(4);
            txtTenTN.Multiline = true;
            txtTenTN.Name = "txtTenTN";
            txtTenTN.Size = new Size(824, 60);
            txtTenTN.TabIndex = 22;
            txtTenTN.TextChanged += txtTenTN_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Helvetica", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(51, 134);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(120, 38);
            label7.TabIndex = 21;
            label7.Text = "MÔ TẢ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Helvetica", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(51, 56);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(197, 38);
            label8.TabIndex = 20;
            label8.Text = "TÊN BÀI TN";
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.Columns.AddRange(new ColumnHeader[] { clnSTT, clnQuestion });
            listView1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            listView1.FullRowSelect = true;
            listView1.Location = new Point(34, 45);
            listView1.Margin = new Padding(4);
            listView1.Name = "listView1";
            listView1.Size = new Size(1529, 541);
            listView1.TabIndex = 24;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // clnSTT
            // 
            clnSTT.Text = "STT";
            // 
            // clnQuestion
            // 
            clnQuestion.Text = "Câu Hỏi";
            clnQuestion.Width = 500;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(listView1);
            groupBox1.Font = new Font("Helvetica", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(64, 341);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1596, 614);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chi tiết";
            // 
            // formCreateSight
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1718, 983);
            Controls.Add(groupBox1);
            Controls.Add(txtMoTa);
            Controls.Add(txtTenTN);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(btnThoat);
            Controls.Add(btnTao);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Margin = new Padding(4);
            Name = "formCreateSight";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            WindowState = FormWindowState.Maximized;
            Load += formCreateSight_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnTao;
        private Button btnThoat;
        private DataGridView dataGridView1;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label7;
        private Label label8;
        private ListView listView1;
        private GroupBox groupBox1;
        private ColumnHeader clnID;
        private ColumnHeader clnCauHoi;
        private ColumnHeader clnDapAn;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader clnSTT;
        private ColumnHeader clnQuestion;
        private TextBox txtMoTa;
        private TextBox txtTenTN;
    }
}
