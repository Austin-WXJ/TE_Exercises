using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearConvert
{
    class Program
    {
        /*
         The foot to meter conversion formula is:
 	        m = f * 0.3048
 	
         The meter to foot conversion formula is:
 	        f = m * 3.2808399
 	
         Write a command line program which prompts a user to enter a length, and whether the measurement is in (m)eters or (f)eet.
         Convert the length to the opposite measurement, and display the old and new measurements to the console.
  
         C:\Users> LinearConvert
         Please enter the length: 58
         Is the measurement in (m)eter, or (f)eet? f
         58f is 17m.
         */

        static void Main(string[] args)
        {
            double convertedMeasure = 0;
            string conversionUnit = "";

            Console.Write("Please enter a length to convert: ");
            string userStringInput = Console.ReadLine();
            double numberToConvert = double.Parse(userStringInput);
            Console.WriteLine();
            Console.Write("Is the measurement in (m)eter, or (f)eet? ");
            string unitOfMeasure = Console.ReadLine();

            switch (unitOfMeasure)
            {
                case "m":
                case "M":
                    convertedMeasure = numberToConvert * 3.2808399;
                    conversionUnit = "feet";
                    unitOfMeasure = "meters";
                    break;
                case "f":
                case "F":
                    convertedMeasure = numberToConvert / 3.2808399;
                    conversionUnit = "meters";
                    unitOfMeasure = "feet";
                    break;
                default:
                    Console.WriteLine("Please enter a valid choice");
                    Console.WriteLine();
                    break;
            }
            Console.WriteLine($"{numberToConvert} {unitOfMeasure} is {Math.Round(convertedMeasure, 2)} {conversionUnit}");
            Console.ReadLine();

        }
    }
}
