using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UEH_EVENT.GUI
{
    public partial class formDoingSight : Form
    {
        private Sight? sight;
        private List<Question>? questions;
        private int[] selectedAnswers;
        private int iCurrentQuestion;
        private int iGiay;
        public formDoingSight()
        {
            InitializeComponent();
        }
        public formDoingSight(int id)
        {
            InitializeComponent();
            sight = Query.GetSpecificSight(id);
        }
        private void loadQuestion()
        {
            Question curQuestion = questions[iCurrentQuestion];
            lblCauhoi.Text = "Câu hỏi " + (iCurrentQuestion + 1) + ":" + curQuestion.Content;
            lblB.Text = curQuestion.Answers[1].Content;
            lblC.Text = curQuestion.Answers[2].Content;
            lblD.Text = curQuestion.Answers[3].Content;
            lblA.Text = curQuestion.Answers[0].Content;


            if (selectedAnswers[iCurrentQuestion] != -1)
            {
                ((RadioButton)panelAnswer.Controls[selectedAnswers[iCurrentQuestion]]).Checked = true;
            }
            else
            {
                foreach (RadioButton item in panelAnswer.Controls)
                {
                    item.Checked = false;
                }
            }
        }
        private void InitData()
        {
            for (int i = 0; i < questions.Count; i++)
            {
                lstCauHoi.Items.Add($"\t{i+1}");
            }
        }
        private void ManHinhThi_Load(object sender, EventArgs e)
        {
            if (sight == null || sight.Questions == null || sight.Questions.Count == 0)
            {
                Console.WriteLine("Not Sight Found! Something went wrong!");
            }

            questions = sight?.Questions;
            if (questions == null) return;

            for (int i = 0; i < questions.Count; i++)
            {
                questions[i] = Query.GetQuestion(questions[i].Id);
            }
            selectedAnswers = new List<int>(new int[questions.Count]).Select(x => x = -1).ToArray();
            iCurrentQuestion = 0;


            loadQuestion();
            InitData();
            lstCauHoi.SelectedIndex = 0;
            //Thoi Gian
            iGiay = questions.Count * 60;
            this.timer1.Enabled = true;
            HienThiGio();
        }


        private void btnCauTruoc_Click(object sender, EventArgs e)
        {
            if (iCurrentQuestion == 0) return;

            iCurrentQuestion--;
            lstCauHoi.SelectedIndex = iCurrentQuestion;
            loadQuestion();
        }

        private void btnCauSau_Click(object sender, EventArgs e)
        {
            if (iCurrentQuestion + 1 == questions.Count) return;

            iCurrentQuestion++;
            lstCauHoi.SelectedIndex = iCurrentQuestion;
            loadQuestion();
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn kết thúc", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.timer1.Enabled = false;
            else
            {
                return;
            }
            Form form = new formScore(questions, selectedAnswers, sight.Id);
            Hide();
            form.ShowDialog();
            Close();
        }
        private void lstCauHoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCauHoi.SelectedIndex < 0) return;
            int x = Convert.ToInt32(lstCauHoi.SelectedIndex);
            iCurrentQuestion = x;
            loadQuestion();
        }

        private void HienThiGio()
        {
            TimeSpan timeSpan = TimeSpan.FromSeconds(iGiay);
            lblThoiGian.Text = timeSpan.ToString(@"mm\:ss");

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Application.DoEvents();

            iGiay--;

            if (iGiay == 0)
            {
                HienThiGio();
                this.timer1.Enabled = false;
                MessageBox.Show("Hết giờ.");
                Form form = new formScore(questions, selectedAnswers, sight.Id);
                Hide();
                form.ShowDialog();
                Close();
            }
            else if (lblThoiGian.Text=="01:00")
            {
                lblThoiGian.ForeColor= Color.Red;
                HienThiGio();
            }
            else
            {
                HienThiGio();
            }
        }

        private void UpdateAnswer(object sender, EventArgs e)
        {

            int index = -1;
            int.TryParse(((Control)sender).Name.Substring(3), out index);
            selectedAnswers[iCurrentQuestion] = index - 1;
            UpdateAnswerState(iCurrentQuestion);
        }
        private void UpdateAnswer(int index)
        {
            selectedAnswers[iCurrentQuestion] = index;
            UpdateAnswerState(iCurrentQuestion);
        }
        private string ConfigAnswer(int index)
        {
            string[] s = new[] { "A", "B", "C", "D" };
            return s[index];
        }
        private void UpdateAnswerState(int i)
        {
            if (selectedAnswers[i] != -1)
            {
                lstCauHoi.Items[i] = $"\t{i + 1}. {ConfigAnswer(selectedAnswers[i])}";
                // Đổi item trong listbox
            }
        }

        private void lblA_Click(object sender, EventArgs e)
        {
            rdo1.Checked = true;
            UpdateAnswer(0);
        }

        private void lblB_Click(object sender, EventArgs e)
        {
            rdo2.Checked = true;
            UpdateAnswer(1);

        }

        private void lblC_Click(object sender, EventArgs e)
        {
            rdo3.Checked = true;
            UpdateAnswer(2);

        }

        private void lblD_Click(object sender, EventArgs e)
        {
            rdo4.Checked = true;
            UpdateAnswer(3);

        }

        private void lblThoiGian_Click(object sender, EventArgs e)
        {

        }
    }
}
