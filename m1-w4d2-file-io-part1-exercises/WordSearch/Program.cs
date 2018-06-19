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
            try
            {
                bool done = false;

                while (!done)
                {


                    Console.Write("What is the directory of text file to search? ");
                    string directory = Console.ReadLine();
                    //string directory = Environment.CurrentDirectory;
                    //string directory = (@"C:\Users\awarner\austinwarner-c-exercises\m1-w4d2-file-io-part1-exercises");

                    Console.Write("what is the file to be searched? ");
                    string fileName = Console.ReadLine();

                    //string fileName = ("alices_adventures_in_wonderland.txt");
                    Console.Write("What Word do you want to find? ");
                    string searchKey = Console.ReadLine();
                    Console.WriteLine();

                    Console.Write("is this search case insensitive?(Y/N): ");
                    string caseSearch = Console.ReadLine();
                    Console.WriteLine();
                    bool caseInsensitive = (caseSearch.ToUpper() == "Y");

                    string fullPath = Path.Combine(directory, fileName);

                    using (StreamReader sr = new StreamReader(fullPath))
                    {
                        int lineNumber = 0;
                        int keywordCount = 0;

                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            string line2 = "";
                            string searchKey2 = "";

                            if (caseInsensitive)
                            {
                                line2 = line.ToUpper();
                                searchKey2 = searchKey.ToUpper();
                            }
                            lineNumber++;

                            if (line.Contains(searchKey))
                            {
                                Console.WriteLine($"({lineNumber}) {line}");
                                keywordCount++;
                            }
                            else if (caseInsensitive && line2.Contains(searchKey2))
                            {
                                Console.WriteLine($"({lineNumber}) {line}");
                                keywordCount++;
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine($"\"{searchKey}\" was found {keywordCount} times.");
                    }
                    Console.WriteLine();
                    Console.Write("Perform another search?(Y/N): ");
                    string response = Console.ReadLine();

                    switch (response.ToUpper())
                    {
                        case "Y":
                            break;
                        case "N":
                            done = true;
                            break;
                    }
                    Console.Clear();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error reading the file");
                Console.WriteLine(e.Message);
            }
        }
    }
}

