using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker
{
    public class QuizFileRead
    {
        public static void ReadFile()
        {
            string directory = Environment.CurrentDirectory;
            //string directory = (@"C:\Users\awarner\austinwarner-c-exercises\m1-w4d2-file-io-part1-exercises\QuizMaker");
            string fileName = "QuizQA.txt";

            string fullPath = Path.Combine(directory, fileName);
            List<QuizQuestion> questionList = new List<QuizQuestion>();

            try
            {
                using (StreamReader sr = new StreamReader(fullPath))
                {
                    while (!sr.EndOfStream)
                    {
                        string oneLongLine = sr.ReadLine();
                        string[] lineCollection = oneLongLine.Split('|');
                        foreach (var line in lineCollection)
                        {
                            QuizQuestion newQuestion = ParseQuestion(line);

                        }

                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error reading the file");
                Console.WriteLine(e.Message);
            }
            QuizQuestion ParseQuestion(string line)
            {
                QuizQuestion thisQuestion = null;

                if (line.ToUpper().Contains("QUESTION") || line.Contains("?"))
                {
                    thisQuestion.Question = line;
                }
                else
                {
                    thisQuestion.AvailableAnswers.Add(line);
                }
                return thisQuestion;
            }
        }
    }
}
