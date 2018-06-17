using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker
{
    public class QuizQuestion : QuizFileRead
    {

        public string Question { get; set; }
        public List<string> AvailableAnswers { get; set; }
        public string CorrectAnswer { get; set; }

        public string FindAnswer()
        {
            string answer = null;

            foreach (string option in AvailableAnswers)
            {
                if (option.Contains('*'))
                {
                    CorrectAnswer = option;
                }
            }

            return answer;
        }
    }
}
