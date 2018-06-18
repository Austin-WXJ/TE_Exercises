using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<QuizQuestion> thisQuiz = QuizFileRead.ReadFile();
            bool done = false;
            int correctAnswers = 0;
            int totalQuestions = 0;


            while (!done)
            {
                Console.Write("Welcome to Austins Quiz!\nPress Enter to begin");
                Console.ReadLine();
                Console.WriteLine();

                foreach (QuizQuestion question in thisQuiz)
                {
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine();
                    totalQuestions++;
                    Console.WriteLine(question.Question);
                    Console.WriteLine();
                    foreach (var choice in question.AvailableAnswers)
                    {
                        Console.WriteLine(choice);
                    }

                    Console.WriteLine();
                    Console.Write("Your Choice is: ");
                    bool parsed = int.TryParse(Console.ReadLine(), out int userChoice);
                    while (!parsed || (userChoice!= 1 && userChoice !=2 && userChoice !=3 && userChoice !=4))

                    {
                        Console.Write("not a valid Option, try again: ");
                        parsed = int.TryParse(Console.ReadLine(), out userChoice);
                    }

                    if (userChoice == int.Parse(question.CorrectAnswer))
                    {
                        correctAnswers++;
                        Console.WriteLine();
                        Console.WriteLine("Correct!");
                    }
                    if (userChoice != int.Parse(question.CorrectAnswer))
                    {
                        Console.WriteLine();
                        Console.WriteLine("That is incorrect, Womp Womp.");
                    }
                }

                Console.WriteLine($"You got {correctAnswers} answers(s) out of the total {totalQuestions} questions asked.");
                Console.ReadLine();
                done = true;
            }
        }
    }
}