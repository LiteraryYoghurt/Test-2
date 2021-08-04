using System;

namespace Roman_Numeral_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] numbers = new int[5];
            numbers[0] = FromRoman("I");
            numbers[1] = FromRoman("VI");
            numbers[2] = FromRoman("XX");
            numbers[3] = FromRoman("IX");
            numbers[4] = FromRoman("XXVII");

            foreach (int val in numbers)
            {
                Console.WriteLine(val);
            }
            */

            string[] numerals = new string[5];
            numerals[0] = ToRoman(20);
            numerals[1] = ToRoman(9);
            numerals[2] = ToRoman(14);
            numerals[3] = ToRoman(33);
            numerals[4] = ToRoman(40);

            foreach (string val in numerals)
            {
                Console.WriteLine(val);
            }
        }



        static string ToRoman(int input)
        {
            string romanNumerals = "";

            int divideL = input / 50;

            if (divideL == 1)
            {
                romanNumerals += "L";
            }

            int remainderL = input % 50;

            if (remainderL != 0)
            {
                if (remainderL / 10 == 4)
                {
                    romanNumerals += "XL";
                }

                else
                {
                    for (int j = remainderL; j > 0; j = j - 10)
                    // could I do this without int j?
                    {
                        romanNumerals += "X";
                    }


                }


            }

            int remainderX = remainderL % 10;

            if (remainderX == 0)
            {
                // then use the return prompt to state the finished roman numeral
                // 'return ...' something with 'input.ToString'(?)
            }

            else if (remainderX == 9)
            {
                romanNumerals += "IX";
            }

            else if (remainderX == 4)
            {
                romanNumerals += "IV";
            }

            else if (remainderX / 5 == 1)
            {
                romanNumerals += "V";
            }

            else
            {
                int remainderV = remainderX % 5;

                for (int j = remainderV; j > 0; j--)
                {
                    romanNumerals += "I";
                }

                return romanNumerals;
            }
        }
    }
}
