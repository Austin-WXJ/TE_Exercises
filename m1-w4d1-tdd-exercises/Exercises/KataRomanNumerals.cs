using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataRomanNumerals
    {

        string[] roman =
        {"M","CM","D","CD","C","XC","L","XL","X","IX","V","IV","I" };

        int[] arabic =
        { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1};

        //Method 1
        public string ConvertToRomanNumeral(int n)
        {

            string result = "";

            for (int i = 0; i < arabic.Length; i++)
            {
                if (n >= arabic[i])
                {
                    result += roman[i];
                    n -= arabic[i];
                }
            }

            return result;
        }

        //Method 2
        public int ConvertRomanToArabic(string str)
        {
            int result = 0;
            str = str.ToUpper();

            for (int i = 0; i < str.Length; i++)
            {
                int charOfStr = charToInt(str[i]);

                if (i + 1 < str.Length)
                {
                    int nextChar = charToInt(str[i + 1]);

                    if (charOfStr >= nextChar)
                    {
                        result += charOfStr;
                    }
                    else
                    {
                        result += (nextChar - charOfStr);
                        i++;
                    }
                }
                else
                {
                    result += charOfStr;
                    break;
                }
            }
            return result;


        }

        public int charToInt(char c)
        {
            int result = 0;
            if (c == 'M')
            {
                result = 1000;
            }
            else if (c == 'D')
            {
                result = 500;
            }
            else if (c == 'C')
            {
                result = 100;
            }
            else if (c == 'L')
            {
                result = 50;
            }
            else if (c == 'X')
            {
                result = 10;
            }
            else if (c == 'V')
            {
                result = 5;
            }
            else if (c == 'I')
            {
                result = 1;
            }
            return result;
        }
    }

}