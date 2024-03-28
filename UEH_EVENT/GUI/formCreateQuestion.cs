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
        Sight CurrentSight;
        bool disable;
        private void disableAll()
        {
            btnAdd.Visible = false;
            txtA.Enabled = false;
            txtB.Enabled = false;
            txtC.Enabled = false;
            txtD.Enabled = false;
            radD.Enabled = false;
            radC.Enabled = false;
            radB.Enabled = false;
            radA.Enabled = false;
            btnAdd.Visible = false;
        }
        public formCreateQuestion(Sight CurrentSight)
        {
            InitializeComponent();
            this.CurrentSight = CurrentSight;
            //Load câu hỏi number
            lblQuestionNum.Text = $" Câu hỏi {CurrentSight.Questions.Count + 1}:";
        }
        public formCreateQuestion(Sight CurrentSight, int i, bool disable = false)
        {
            InitializeComponent();
            this.CurrentSight = CurrentSight;
            question = CurrentSight.Questions[i];

            txtQuestion.Text = question.Content;
            lblQuestionNum.Text = $"Câu hỏi {i+1}: ";
            btnAdd.Text = "Sửa";

            this.disable = disable;
            if (disable) disableAll();
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
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
           (disable ? new formCreateSight(CurrentSight,disable) : new formCreateSight()).ShowDialog();
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thêm câu hỏi này ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                //Add
                if (question == null)
                {
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
