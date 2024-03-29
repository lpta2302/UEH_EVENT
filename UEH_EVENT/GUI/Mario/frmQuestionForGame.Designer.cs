namespace UEH_EVENT.GUI.Mario
{
    partial class frmQuestionForGame
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
            lblQuestionContent = new Label();
            Container = new Panel();
            textBox1 = new TextBox();
            Container.SuspendLayout();
            SuspendLayout();
            // 
            // lblQuestionContent
            // 
            lblQuestionContent.BackColor = Color.Transparent;
            lblQuestionContent.FlatStyle = FlatStyle.Flat;
            lblQuestionContent.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuestionContent.ForeColor = Color.White;
            lblQuestionContent.Location = new Point(72, 144);
            lblQuestionContent.Name = "lblQuestionContent";
            lblQuestionContent.Size = new Size(262, 320);
            lblQuestionContent.TabIndex = 0;
            lblQuestionContent.Text = "Hello World";
            lblQuestionContent.TextAlign = ContentAlignment.TopCenter;
            // 
            // Container
            // 
            Container.BackColor = Color.Transparent;
            Container.BackgroundImage = Properties.Resources.phoneBlue;
            Container.BackgroundImageLayout = ImageLayout.Zoom;
            Container.Controls.Add(textBox1);
            Container.Controls.Add(lblQuestionContent);
            Container.Location = new Point(1, 0);
            Container.Name = "Container";
            Container.Size = new Size(421, 723);
            Container.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(72, 485);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(262, 69);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // frmQuestionForGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 720);
            Controls.Add(Container);
            Name = "frmQuestionForGame";
            Text = "Phone";
            Container.ResumeLayout(false);
            Container.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblQuestionContent;
        private Panel Container;
        private TextBox textBox1;
    }
}