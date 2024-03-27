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
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            btnAdd = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblQuestionNum
            // 
            lblQuestionNum.BackColor = Color.Transparent;
            lblQuestionNum.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuestionNum.Location = new Point(67, 177);
            lblQuestionNum.Name = "lblQuestionNum";
            lblQuestionNum.Size = new Size(202, 41);
            lblQuestionNum.TabIndex = 27;
            lblQuestionNum.Text = "Câu hỏi:";
            // 
            // txtQuestion
            // 
            txtQuestion.BackColor = Color.White;
            txtQuestion.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuestion.Location = new Point(67, 248);
            txtQuestion.Multiline = true;
            txtQuestion.Name = "txtQuestion";
            txtQuestion.Size = new Size(622, 247);
            txtQuestion.TabIndex = 33;
            // 
            // txtA
            // 
            txtA.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtA.Location = new Point(11, 15);
            txtA.Multiline = true;
            txtA.Name = "txtA";
            txtA.Size = new Size(774, 106);
            txtA.TabIndex = 35;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Black;
            btnBack.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(57, 30);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(166, 70);
            btnBack.TabIndex = 38;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // radD
            // 
            radD.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            radD.Location = new Point(13, 539);
            radD.Name = "radD";
            radD.Size = new Size(67, 61);
            radD.TabIndex = 41;
            radD.Text = "D";
            radD.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(734, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(1060, 684);
            panel1.TabIndex = 43;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtA);
            panel3.Controls.Add(txtB);
            panel3.Controls.Add(txtC);
            panel3.Controls.Add(txtD);
            panel3.Location = new Point(171, 28);
            panel3.Name = "panel3";
            panel3.Size = new Size(867, 643);
            panel3.TabIndex = 45;
            // 
            // txtB
            // 
            txtB.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtB.Location = new Point(11, 196);
            txtB.Multiline = true;
            txtB.Name = "txtB";
            txtB.Size = new Size(774, 109);
            txtB.TabIndex = 35;
            // 
            // txtC
            // 
            txtC.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtC.Location = new Point(11, 357);
            txtC.Multiline = true;
            txtC.Name = "txtC";
            txtC.Size = new Size(774, 109);
            txtC.TabIndex = 35;
            // 
            // txtD
            // 
            txtD.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtD.Location = new Point(11, 519);
            txtD.Multiline = true;
            txtD.Name = "txtD";
            txtD.Size = new Size(774, 109);
            txtD.TabIndex = 35;
            // 
            // panel2
            // 
            panel2.Controls.Add(radioButton3);
            panel2.Controls.Add(radioButton2);
            panel2.Controls.Add(radD);
            panel2.Controls.Add(radioButton1);
            panel2.Location = new Point(45, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(96, 643);
            panel2.TabIndex = 44;
            // 
            // radioButton3
            // 
            radioButton3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton3.Location = new Point(13, 31);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(67, 62);
            radioButton3.TabIndex = 41;
            radioButton3.Text = "A";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton2.Location = new Point(13, 210);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(67, 61);
            radioButton2.TabIndex = 41;
            radioButton2.Text = "B";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.Location = new Point(13, 368);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(67, 61);
            radioButton1.TabIndex = 41;
            radioButton1.Text = "C";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Black;
            btnAdd.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(67, 591);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(183, 65);
            btnAdd.TabIndex = 44;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // formCreateQuestion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1806, 754);
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
        private RadioButton radioButton3;
        private TextBox txtD;
        private RadioButton radioButton2;
        private TextBox txtC;
        private RadioButton radioButton1;
        private TextBox txtB;
        private Button btnAdd;
        private Panel panel2;
        private Panel panel3;
    }
}
