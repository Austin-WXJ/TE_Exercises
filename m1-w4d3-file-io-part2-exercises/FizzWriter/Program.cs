using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string directory = Environment.CurrentDirectory;
            string fileName = "FizzBuzz.txt";
            string fullPath = Path.Combine(directory, fileName);
            try
            {

                using (StreamWriter sw = new StreamWriter(fileName, false))
                {
                    for (int i = 1; i <= 300; i++)
                    {
                        string result = "";
                        if (i % 15 == 0)
                        {
                            result = "FizzBuzz";
                        }
                        else if (i % 5 == 0)
                        {
                            result = "Buzz";
                        }
                        else if (i % 3 == 0)
                        {
                            result = "Fizz";
                        }
                        else
                        {
                            result = i.ToString();
                        }
                        sw.WriteLine(result);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Unable to write to File");
                Console.WriteLine(e.Message);
            }
        }
    }
}
