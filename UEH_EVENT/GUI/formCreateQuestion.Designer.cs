namespace UEH_EVENT.GUI
{
    partial class formCreateQuestion
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
            lblQuestionNum = new Label();
            txtQuestion = new TextBox();
            txtA = new TextBox();
            btnBack = new Button();
            radD = new RadioButton();
            panel1 = new Panel();
            panel3 = new Panel();
            txtB = new TextBox();
            txtC = new TextBox();
            txtD = new TextBox();
            panel2 = new Panel();
            radA = new RadioButton();
            radB = new RadioButton();
            radC = new RadioButton();
            btnAdd = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblQuestionNum
            // 
            lblQuestionNum.BackColor = Color.Transparent;
            lblQuestionNum.Font = new Font("Arial", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuestionNum.Location = new Point(33, 141);
            lblQuestionNum.Name = "lblQuestionNum";
            lblQuestionNum.Size = new Size(127, 31);
            lblQuestionNum.TabIndex = 27;
            lblQuestionNum.Text = "CÂU HỎI";
            // 
            // txtQuestion
            // 
            txtQuestion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtQuestion.BackColor = Color.White;
            txtQuestion.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuestion.Location = new Point(159, 136);
            txtQuestion.Multiline = true;
            txtQuestion.Name = "txtQuestion";
            txtQuestion.Size = new Size(957, 71);
            txtQuestion.TabIndex = 33;
            // 
            // txtA
            // 
            txtA.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtA.Location = new Point(11, 14);
            txtA.Multiline = true;
            txtA.Name = "txtA";
            txtA.Size = new Size(893, 77);
            txtA.TabIndex = 35;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.WhiteSmoke;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Arial", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.DimGray;
            btnBack.Location = new Point(33, 47);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(127, 58);
            btnBack.TabIndex = 38;
            btnBack.Text = "QUAY LẠI";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // radD
            // 
            radD.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            radD.Location = new Point(13, 282);
            radD.Name = "radD";
            radD.Size = new Size(67, 61);
            radD.TabIndex = 41;
            radD.Tag = "3";
            radD.Text = "D";
            radD.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(33, 229);
            panel1.Name = "panel1";
            panel1.Size = new Size(1081, 417);
            panel1.TabIndex = 43;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtA);
            panel3.Controls.Add(txtB);
            panel3.Controls.Add(txtC);
            panel3.Controls.Add(txtD);
            panel3.Location = new Point(125, 31);
            panel3.Name = "panel3";
            panel3.Size = new Size(925, 370);
            panel3.TabIndex = 45;
            // 
            // txtB
            // 
            txtB.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtB.Location = new Point(11, 95);
            txtB.Multiline = true;
            txtB.Name = "txtB";
            txtB.Size = new Size(893, 77);
            txtB.TabIndex = 35;
            // 
            // txtC
            // 
            txtC.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtC.Location = new Point(11, 183);
            txtC.Multiline = true;
            txtC.Name = "txtC";
            txtC.Size = new Size(893, 84);
            txtC.TabIndex = 35;
            // 
            // txtD
            // 
            txtD.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtD.Location = new Point(11, 279);
            txtD.Multiline = true;
            txtD.Name = "txtD";
            txtD.Size = new Size(893, 76);
            txtD.TabIndex = 35;
            // 
            // panel2
            // 
            panel2.Controls.Add(radA);
            panel2.Controls.Add(radB);
            panel2.Controls.Add(radD);
            panel2.Controls.Add(radC);
            panel2.Location = new Point(24, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(96, 370);
            panel2.TabIndex = 44;
            // 
            // radA
            // 
            radA.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            radA.Location = new Point(13, 31);
            radA.Name = "radA";
            radA.Size = new Size(67, 62);
            radA.TabIndex = 41;
            radA.Tag = "0";
            radA.Text = "A";
            radA.UseVisualStyleBackColor = true;
            // 
            // radB
            // 
            radB.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            radB.Location = new Point(13, 119);
            radB.Name = "radB";
            radB.Size = new Size(67, 61);
            radB.TabIndex = 41;
            radB.Tag = "1";
            radB.Text = "B";
            radB.UseVisualStyleBackColor = true;
            // 
            // radC
            // 
            radC.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            radC.Location = new Point(13, 196);
            radC.Name = "radC";
            radC.Size = new Size(67, 61);
            radC.TabIndex = 41;
            radC.Tag = "2";
            radC.Text = "C";
            radC.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackColor = Color.Black;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Arial", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(959, 47);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(155, 58);
            btnAdd.TabIndex = 44;
            btnAdd.Text = "THÊM";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20.1428585F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(217, 49);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(318, 40);
            label1.TabIndex = 45;
            label1.Text = "CREAT QUESTION";
            // 
            // formCreateQuestion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1145, 655);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(btnBack);
            Controls.Add(txtQuestion);
            Controls.Add(lblQuestionNum);
            Controls.Add(panel1);
            Name = "formCreateQuestion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateQuestion";
            WindowState = FormWindowState.Maximized;
            Load += formCreateQuestion_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

#endregion
        private DataGridView dataGridView1;
        private ColumnHeader clnID;
        private ColumnHeader clnCauHoi;
        private ColumnHeader clnDapAn;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Label lblQuestionNum;
        private TextBox txtQuestion;
        private TextBox txtA;
        private Button btnBack;
        private RadioButton radD;
        private Panel panel1;
        private RadioButton radA;
        private TextBox txtD;
        private RadioButton radB;
        private TextBox txtC;
        private RadioButton radC;
        private TextBox txtB;
        private Button btnAdd;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
    }
}
