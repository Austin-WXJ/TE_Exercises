using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempConvert
{
    class Program
    {
        /*
         The Fahrenheit to Celsius conversion formula is:
 	        Tc = (Tf - 32) / 1.8
 	        where 'Tc' is the temperature in Celsius, and 'Tf' is the temperature in Fahrenheit
 	
         The Celsius to Fahrenheit conversion formula is:
 	        Tf = Tc * 1.8 + 32
 	         
        Write a command line program which prompts a user to enter a temperature, and whether its in degrees (C)elsius or (F)arenheit.
        Convert the temperature to the opposite degrees, and display the old and new temperatures to the console.

         C:\Users> TempConvert
         Please enter the temperature: 58
         Is the temperature in (C)elcius, or (F)arenheit? F
         58F is 14C.
        
         */
        static void Main(string[] args)
        {
            double convertedTemperature = 0;
            string conversionUnit = "";

            Console.Write("Please enter the temperature: ");
            string userStringInput = Console.ReadLine();
            double temperatureToConvert = double.Parse(userStringInput);
            Console.WriteLine();
            Console.Write("Is the temperature in (C)elcius, or (F)arenheit? ");
            string unitOfMeasure = Console.ReadLine();

            switch (unitOfMeasure.ToLower())
            {
                case "f":
                    convertedTemperature = (temperatureToConvert - 32) / 1.8;
                    conversionUnit = "Celcius";
                    unitOfMeasure = "Fahrenheit";
                    break;
                case "c":
                    convertedTemperature = temperatureToConvert * 1.8 + 32;
                    conversionUnit = "Fahrenheit";
                    unitOfMeasure = "Celcius";
                    break;
                default:
                    Console.WriteLine("Please enter a valid choice");
                    Console.WriteLine();
                    break;
            }
            Console.WriteLine($"{temperatureToConvert} {unitOfMeasure} is {Math.Round(convertedTemperature, 2)} {conversionUnit}");
            Console.ReadLine();


        }
    }
}
