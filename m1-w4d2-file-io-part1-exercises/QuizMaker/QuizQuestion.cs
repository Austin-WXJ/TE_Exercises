using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker
{
    public class QuizQuestion
    {

        public string Question { get; set; }
        public List<string> AvailableAnswers { get; set; }
        public string CorrectAnswer { get; set; }

        public QuizQuestion()
        {
            AvailableAnswers = new List<string>();
        }
    }
}
