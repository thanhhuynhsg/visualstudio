using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T145588_Test05_031616
{
    class Problem2
    {
       public static string SpellNumber(int number)
        {
            if (number == 0)
                return "zero";

            if (number < 0)
                return "minus " + SpellNumber(Math.Abs(number));

            string words = "";


            if ((number / 100) > 0)
            {
                words += SpellNumber(number / 100) + " hundred ";
                number %= 100;
            }

            if (number > 0)
            {

                String[] units = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                String[] tens = { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (number < 20)
                    words += units[number];
                else
                {
                    words += tens[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + units[number % 10];
                }
            }

            return words;
        }
		
    }
}
