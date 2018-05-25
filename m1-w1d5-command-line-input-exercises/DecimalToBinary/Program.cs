using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class Program
    {
        /*
        Write a command line program which prompts the user for a series of decimal integer values  
        and displays each decimal value as itself and its binary equivalent

        C:\Users> DecimalToBinary
        
        Please enter in a series of decimal values (separated by spaces): 460 8218 1 31313 987654321
        
        460 in binary is 111001100
        8218 in binary is 10000000011010
        1 in binary is 1
        31313 in binary is 111101001010001
        987654321 in binary is 111010110111100110100010110001

        Hint:
        int value = 8;
        string binary = Convert.ToString(value, 2);
        (from: https://stackoverflow.com/questions/2954962/convert-integer-to-binary-in-c-sharp)

        */

        static void Main(string[] args)
        {
            //take in string values to convert into binary
            Console.Write("Please enter in a series of decimal values (separated by spaces): ");
            string userString = Console.ReadLine();
            string[] stringArray = userString.Split(' ');

            int[] value = new int [stringArray.Length];
            for (int i = 0; i < stringArray.Length; i++)
            {
                value[i] = int.Parse(stringArray[i]);
            }


            //value = new int.Parse(userString); // loop the parse

            // need to loop through converting each member of the array
            string binary = Convert.ToString(value, 2);

            // loop to write lines stating the value entered by user and return the binary value
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine();
                Console.Read();
            }





        }
    }
}
