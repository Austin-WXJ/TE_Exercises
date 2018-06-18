using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSplitter
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalLineCount = 0;
            int maxFileWriteLength = 0;
            int fileWriteCount = 0;

            bool done = false;
            while (!done)
            {
                try
                {
                    Console.WriteLine("What is the name of the input file?\n(use file name FizzBuzz.txt or alices_adventures_in_wonderland.txt): ");
                    string inputFileName = Console.ReadLine();
                    string inputFileDirectory = Environment.CurrentDirectory;
                    string inputFilePath = Path.Combine(inputFileDirectory, inputFileName);
                    totalLineCount = File.ReadLines(inputFileName).Count();

                    string FileSpliterDirectory = inputFilePath.Substring(0 , (inputFilePath.Length-4));

                    if (Directory.Exists(FileSpliterDirectory))
                    {
                        DirectoryInfo di = new DirectoryInfo(FileSpliterDirectory);
                        foreach (FileInfo file in di.GetFiles())
                        {
                            file.Delete();
                        }
                    }
                    else
                    {
                        Directory.CreateDirectory(FileSpliterDirectory);
                    }


                    Console.WriteLine();

                    Console.WriteLine("How many lines of text (max) should there be in the split files? ");
                    maxFileWriteLength = int.Parse(Console.ReadLine());

                    fileWriteCount = (int)Math.Ceiling((decimal)totalLineCount / maxFileWriteLength);

                    Console.WriteLine($"The input file had " +
                        $"{totalLineCount} lines of text, " +
                        $"which will write to {fileWriteCount} files");

                    Console.WriteLine("**GENERATING OUTPUT FILES**");
                    Console.WriteLine();
                    Console.WriteLine($"WRITING TO: {FileSpliterDirectory}");
                    Console.Write("Press Enter To Continue: ");
                    Console.ReadLine();
                    Console.WriteLine();

                    using (StreamReader sr = new StreamReader(inputFileName))
                    {
                        for (int i = 1; i <= fileWriteCount; i++)
                        {
                            string outputFileName = $"{inputFileName}-{i}.txt";
                            string outputFilePath = Path.Combine(FileSpliterDirectory, outputFileName);

                            using (StreamWriter sw = new StreamWriter(outputFilePath, false))
                            {
                                Console.WriteLine($"Generating {outputFileName}");

                                for (int n = 1; n <= maxFileWriteLength; n++)
                                {
                                    string line = sr.ReadLine();
                                    sw.WriteLine(line);
                                }
                            }
                        }
                    }
                    done = true;
                }
                catch (IOException e)
                {
                    Console.WriteLine();
                    Console.WriteLine("Error reading the file");
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}


