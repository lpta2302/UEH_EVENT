using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UEH_EVENT.BL;

namespace UEH_EVENT.GUI
{
    public partial class formScore : Form
    {
        private List<Question> questions;
        private int[] selectedAnswers;
        private HandleSIghtScore handler;
        private int sightId;
        public formScore(List<Question> questions, int[] selectedAnswers, int sightId)
        {
            InitializeComponent();
            this.questions = questions;
            this.selectedAnswers = selectedAnswers;
            handler = new HandleSIghtScore(questions, selectedAnswers);
            this.sightId = sightId;
        }

        private void formScore_Load(object sender, EventArgs e)
        {
            txtDung.Text = handler.NumTrue.ToString();
            txtSai.Text = handler.NumWrong.ToString();
            txtTong.Text = handler.NumDone.ToString() + "/" + questions.Count;
            Database.Insert<SightHis>(new SightHis("31221020084",sightId,handler.NumTrue));
        }

        private void txtTong_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form form = new ();
        }
    }
}
