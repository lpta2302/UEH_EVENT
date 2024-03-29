using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEH_EVENT.BL
{
    internal class HandleSightScore
    {
        public int NumWrong {  get; }
        public int NumTrue { get; }
        public int NumDone {  get; }
        public HandleSightScore(List<Question> questions, int[] selected)
        {
            NumDone = questions.Count;
            for (int i = 0; i < questions.Count; i++)
            {
                if (selected[i] == -1)
                    NumDone--;
                else if (questions[i].Answers[selected[i]].IsKeyAnswer)
                    NumTrue++;
            }
            NumWrong = questions.Count - NumTrue;
        }

    }
}
