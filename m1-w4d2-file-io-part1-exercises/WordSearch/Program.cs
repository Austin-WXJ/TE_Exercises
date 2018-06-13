using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Ask the user for the search string
            Console.Write("What Word do you want to find in Alice in Wonderland? ");
            string searchKey = Console.ReadLine();
            Console.WriteLine();

            Console.Write("is this search case sensitive?(Y/N): ");
            string caseSearch = Console.ReadLine();
            Console.WriteLine();

            switch (caseSearch.ToUpper())
            {
                case "Y":
                    searchKey = searchKey.ToUpper();
                    break;
                case"N":
                    break;
            }

            
            //string filePath = Console.ReadLine();
            //string directory = Environment.CurrentDirectory;
            string directory = (@"C:\Users\awarner\austinwarner-c-exercises\m1-w4d2-file-io-part1-exercises");

            //2. Ask the user for the file path
            //Console.Write("what is the file to be searched? ");
            //string fileName = Console.ReadLine();
            string fileName = ("alices_adventures_in_wonderland.txt");

            //3. Open the file
            string fullPath = Path.Combine(directory, fileName);

            //4. Loop through each line in the file
            //5. If the line contains the search string, print it out along with its line number
            try
            {
                using (StreamReader sr = new StreamReader(fullPath))
                {
                    int lineNumber = 0;
                    int keywordCount = 0;
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        lineNumber++;

                        if (line.Contains(searchKey))
                        {
                            Console.WriteLine($"({lineNumber}) {line}");
                            keywordCount++;
                        }
                    }
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine($"\"{searchKey}\" was found {keywordCount} times.");
                }

            }
            catch(IOException e)
            {
                Console.WriteLine("Error reading the file");
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
