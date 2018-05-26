using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        /*
         The Fibonacci numbers are the integers in the following sequence:  
	        0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, ...
         By definition, the first two numbers in the Fibonacci sequence are 0 and 1, and each subsequent number is the sum of the previous two.
 
         Write a command line program which prompts the user for an integer value and display the Fibonacci sequence leading up to that number.
  
         C:\Users> Fiboncci
         Please enter the Fibonacci number: 25
         
         0, 1, 1, 2, 3, 5, 8, 13, 21
         */
        static void Main(string[] args)
        {
            Console.Write("Please enter the Fibonacci number: ");
            string userInputEndFibonacci = Console.ReadLine();
            Console.WriteLine();
            int fibonacciSequenceEnd = int.Parse(userInputEndFibonacci);

            int fibonacci = 0;
            int number1 = 0;
            int number2 = 1;
 
            fibonacci = number1 + number2;
            Console.Write($"{number1}, {number2}");

            for (int count = 0; fibonacci < fibonacciSequenceEnd; count++)
            {
                Console.Write($", {fibonacci}");
                number1 = number2;
                number2 = fibonacci;
                fibonacci = number1 + number2;
            }
            Console.ReadLine();
        }
    }
}
