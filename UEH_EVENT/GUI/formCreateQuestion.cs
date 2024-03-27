using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UEH_EVENT.Utils;

namespace UEH_EVENT.GUI
{
    public partial class formCreateQuestion : Form
    {
        Question question;
        public formCreateQuestion()
        {
            InitializeComponent();
            lblQuestionNum.Text = $" Câu hỏi {(GlobalData.CurrentSight.Questions.Count + 1)}:";
        }
        public formCreateQuestion(int i)
        {
            InitializeComponent();
            question = GlobalData.CurrentSight.Questions[i];

            txtQuestion.Text = GlobalData.CurrentSight.Questions[i].Content;
            lblQuestionNum.Text = $"Câu hỏi {i+1}: ";
        }
        private void formCreateQuestion_Load(object sender, EventArgs e)
        {
               
            if (question != null)
            {
                for(int i = 0;i<question.Answers.Count;i++)
                {
                    ((RadioButton)panel2.Controls[i]).Checked = question.Answers[i].IsKeyAnswer;
                    panel3.Controls[i].Text = question.Answers[i].Content;
                }
                btnAdd.Text = "Sửa";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            new formCreateSight().ShowDialog();
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thêm câu hỏi này ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                //Add
                if (question == null) {
                List<Answer> answerList = new List<Answer>();
                for (int i = 0; i < panel2.Controls.Count; i++)
                {
                    answerList.Add(
                    new Answer()
                    {
                        IsKeyAnswer = ((RadioButton)panel2.Controls[i]).Checked,
                        Content = panel3.Controls[i].Text
                    });
                }
                GlobalData.CurrentSight.Questions.Add(
                    new Question()
                    {
                        Content = txtQuestion.Text,
                        Answers = answerList
                    }
                );
                lblQuestionNum.Text = $"Câu hỏi {GlobalData.CurrentSight.Questions.Count + 1}:";
            }
            //Update
            else
            {
                for (int i = 0; i < panel2.Controls.Count; i++)
                {
                    question.Answers[i].Content = panel3.Controls[i].Text;
                    question.Answers[i].IsKeyAnswer = ((RadioButton)panel2.Controls[i]).Checked;
                    
                }
                question.Content = txtQuestion.Text;

            }
            Hide();
            new formCreateSight().ShowDialog();
            Close();
        }
    }
}
