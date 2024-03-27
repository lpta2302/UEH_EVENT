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
            btnThem.BackColor = Color.Black;
            btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(1640, 355);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(161, 53);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Black;
            btnSua.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(1640, 436);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(161, 53);
            btnSua.TabIndex = 15;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Black;
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(1640, 512);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(161, 53);
            btnXoa.TabIndex = 16;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnTao
            // 
            btnTao.BackColor = Color.Black;
            btnTao.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnTao.ForeColor = Color.White;
            btnTao.Location = new Point(1397, 26);
            btnTao.Name = "btnTao";
            btnTao.Size = new Size(245, 77);
            btnTao.TabIndex = 17;
            btnTao.Text = "Tạo";
            btnTao.UseVisualStyleBackColor = false;
            btnTao.Click += btnTao_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Black;
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(57, 26);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(157, 57);
            btnThoat.TabIndex = 18;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtMoTa
            // 
            txtMoTa.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtMoTa.Location = new Point(433, 125);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(763, 163);
            txtMoTa.TabIndex = 23;
            txtMoTa.TextChanged += txtMoTa_TextChanged;
            // 
            // txtTenTN
            // 
            txtTenTN.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenTN.Location = new Point(433, 78);
            txtTenTN.Multiline = true;
            txtTenTN.Name = "txtTenTN";
            txtTenTN.Size = new Size(356, 41);
            txtTenTN.TabIndex = 22;
            txtTenTN.TextChanged += txtTenTN_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(258, 122);
            label7.Name = "label7";
            label7.Size = new Size(74, 31);
            label7.TabIndex = 21;
            label7.Text = "Mô tả";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(258, 76);
            label8.Name = "label8";
            label8.Size = new Size(121, 31);
            label8.TabIndex = 20;
            label8.Text = "Tên Bài TN";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { clnSTT, clnQuestion });
            listView1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            listView1.FullRowSelect = true;
            listView1.Location = new Point(23, 30);
            listView1.Name = "listView1";
            listView1.Size = new Size(1526, 424);
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
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(listView1);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 325);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1569, 460);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chi tiết";
            // 
            // formCreateSight
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1871, 797);
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
