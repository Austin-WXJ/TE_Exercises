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
            int fileWriteCount = 0;
            bool fileRead = false;
            while (!fileRead)
            {
                try
                {
                    Console.WriteLine("What is the name of the input file?(please provide full path): ");
                    string fullPath = Console.ReadLine();
                    Console.WriteLine();
                    int totalLineCount = File.ReadLines(fullPath).Count();

                    Console.WriteLine("How many lines of text (max) should there be in the split files? ");
                    int maxFileWriteLength = int.Parse(Console.ReadLine());

                    fileWriteCount = (int)Math.Ceiling((decimal)totalLineCount / maxFileWriteLength);

                    Console.WriteLine($"The input file had " +
                        $"{totalLineCount} lines of text, " +
                        $"which will write to {fileWriteCount} files");
                    fileRead = true;
                }
                catch (IOException e)
                {
                    Console.WriteLine();
                    Console.WriteLine("Error reading the file");
                    Console.WriteLine(e.Message);
                }
            }
            //writefile
            for (int i = 0; i < fileW; i++)
            {

            }
        }
    }
}
