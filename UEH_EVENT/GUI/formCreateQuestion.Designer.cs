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
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblQuestionNum
            // 
            lblQuestionNum.BackColor = Color.Transparent;
            lblQuestionNum.Font = new Font("Helvetica", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuestionNum.Location = new Point(50, 211);
            lblQuestionNum.Margin = new Padding(4, 0, 4, 0);
            lblQuestionNum.Name = "lblQuestionNum";
            lblQuestionNum.Size = new Size(191, 47);
            lblQuestionNum.TabIndex = 27;
            lblQuestionNum.Text = "CÂU HỎI";
            // 
            // txtQuestion
            // 
            txtQuestion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtQuestion.BackColor = Color.White;
            txtQuestion.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuestion.Location = new Point(238, 204);
            txtQuestion.Margin = new Padding(4);
            txtQuestion.Multiline = true;
            txtQuestion.Name = "txtQuestion";
            txtQuestion.Size = new Size(1433, 104);
            txtQuestion.TabIndex = 33;
            // 
            // txtA
            // 
            txtA.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtA.Location = new Point(16, 21);
            txtA.Margin = new Padding(4);
            txtA.Multiline = true;
            txtA.Name = "txtA";
            txtA.Size = new Size(1337, 114);
            txtA.TabIndex = 35;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.WhiteSmoke;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Helvetica", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.DimGray;
            btnBack.Location = new Point(50, 70);
            btnBack.Margin = new Padding(4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(191, 87);
            btnBack.TabIndex = 38;
            btnBack.Text = "QUAY LẠI";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // radD
            // 
            radD.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            radD.Location = new Point(20, 423);
            radD.Margin = new Padding(4);
            radD.Name = "radD";
            radD.Size = new Size(100, 92);
            radD.TabIndex = 41;
            radD.Text = "D";
            radD.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(50, 344);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1621, 626);
            panel1.TabIndex = 43;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtA);
            panel3.Controls.Add(txtB);
            panel3.Controls.Add(txtC);
            panel3.Controls.Add(txtD);
            panel3.Location = new Point(188, 46);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1388, 555);
            panel3.TabIndex = 45;
            // 
            // txtB
            // 
            txtB.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtB.Location = new Point(16, 143);
            txtB.Margin = new Padding(4);
            txtB.Multiline = true;
            txtB.Name = "txtB";
            txtB.Size = new Size(1337, 113);
            txtB.TabIndex = 35;
            // 
            // txtC
            // 
            txtC.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtC.Location = new Point(16, 274);
            txtC.Margin = new Padding(4);
            txtC.Multiline = true;
            txtC.Name = "txtC";
            txtC.Size = new Size(1337, 124);
            txtC.TabIndex = 35;
            // 
            // txtD
            // 
            txtD.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtD.Location = new Point(16, 419);
            txtD.Margin = new Padding(4);
            txtD.Multiline = true;
            txtD.Name = "txtD";
            txtD.Size = new Size(1337, 112);
            txtD.TabIndex = 35;
            // 
            // panel2
            // 
            panel2.Controls.Add(radioButton3);
            panel2.Controls.Add(radioButton2);
            panel2.Controls.Add(radD);
            panel2.Controls.Add(radioButton1);
            panel2.Location = new Point(36, 42);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(144, 555);
            panel2.TabIndex = 44;
            // 
            // radioButton3
            // 
            radioButton3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton3.Location = new Point(20, 46);
            radioButton3.Margin = new Padding(4);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(100, 93);
            radioButton3.TabIndex = 41;
            radioButton3.Text = "A";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton2.Location = new Point(20, 179);
            radioButton2.Margin = new Padding(4);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(100, 92);
            radioButton2.TabIndex = 41;
            radioButton2.Text = "B";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.Location = new Point(20, 294);
            radioButton1.Margin = new Padding(4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(100, 92);
            radioButton1.TabIndex = 41;
            radioButton1.Text = "C";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackColor = Color.Black;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Helvetica", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(1439, 70);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(232, 87);
            btnAdd.TabIndex = 44;
            btnAdd.Text = "THÊM";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Helvetica", 20.1428585F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(326, 73);
            label1.Name = "label1";
            label1.Size = new Size(445, 57);
            label1.TabIndex = 45;
            label1.Text = "CREAT QUESTION";
            // 
            // formCreateQuestion
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1718, 983);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(btnBack);
            Controls.Add(txtQuestion);
            Controls.Add(lblQuestionNum);
            Controls.Add(panel1);
            Margin = new Padding(4);
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
        private Label label1;
    }
}
