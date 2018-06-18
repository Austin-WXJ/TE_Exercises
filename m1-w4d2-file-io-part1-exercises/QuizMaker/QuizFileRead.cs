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
        public static List<QuizQuestion> ReadFile()
        {
            //string directory = Environment.CurrentDirectory;
            string directory = (@"C:\Users\awarner\austinwarner-c-exercises\m1-w4d2-file-io-part1-exercises\QuizMaker");
            string fileName = "QuizQA.txt";

            string fullPath = Path.Combine(directory, fileName);
            List<QuizQuestion> questionList = new List<QuizQuestion>();

            try
            {
                using (StreamReader sr = new StreamReader(fullPath))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] lineCollection = sr.ReadLine().Split('|');

                        QuizQuestion eachQuestion = new QuizQuestion();

                        foreach (var line in lineCollection)
                        {

                            if (line.ToUpper().Contains("QUESTION") || line.Contains("?"))
                            {
                                eachQuestion.Question = line;
                            }
                            else if (line.Contains("*"))
                            {
                                string hideAnswer = line.Replace("*", "");
                                eachQuestion.AvailableAnswers.Add(hideAnswer);
                                eachQuestion.CorrectAnswer = line.Substring(0, 1);
                            }
                            else
                            {
                                eachQuestion.AvailableAnswers.Add(line);
                            }
                        }
                        questionList.Add(eachQuestion);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error reading the file");
                Console.WriteLine(e.Message);
            }
            return questionList;
        }
    }
}
