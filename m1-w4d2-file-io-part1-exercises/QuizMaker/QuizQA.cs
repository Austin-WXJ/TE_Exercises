using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker
{
    public static class QuizQA
    {
        public static void ReadFile()
        {
            string directory = (@"C:\Users\awarner\austinwarner-c-exercises\m1-w4d2-file-io-part1-exercises\QuizMaker");
            string fileName = "QuizQA.csv";

            string fullPath = Path.Combine(directory, fileName);
            List<string> questionList = new List<string>();

            try
            {
                using (StreamReader sr = new StreamReader(fullPath))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();

                        string[] questions = line.Split('|', ',');
                        questionList.AddRange(questions);
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("Error reading the file");
                Console.WriteLine(e.Message);
            }
            foreach (string question in questionList)
            {
                Console.WriteLine(question);
            }
            Console.ReadLine();
        }
    }
}
