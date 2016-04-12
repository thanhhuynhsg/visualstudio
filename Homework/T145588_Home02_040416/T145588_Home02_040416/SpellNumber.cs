using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T145588_Home02_040416
{
    class SpellNumber
    {
        //Spell English
        public static string SpellE(int number)
        {
            if (number == 0)
                return "zero";

            if (number < 0)
                return "minus " + SpellE(Math.Abs(number));

            String[] units = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            String[] tens = { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            string words = "";

            if ((number / 1000000000) > 0)
            {
                words += SpellE(number / 1000000000) + " billion ";
                number %= 1000000000;
            }

            if ((number / 1000000) > 0)
            {
                words += SpellE(number / 1000000) + " million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += SpellE(number / 1000) + " thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += SpellE(number / 100) + " hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "and ";

                if (number < 20)
                    words += units[number];
                else
                {
                    words += tens[number / 10];
                    if ((number % 10) > 0)
                        words += " " + units[number % 10];
                }
            }
            return words;
        }

        //Spell Vietnamese
        public static string SpellV(int number)
        {
            if (number == 0)
                return "khong";

            if (number < 0)
                return "am " + SpellV(Math.Abs(number));

            String[] donvi = { "khong", "mot", "hai", "ba", "bon", "nam", "sau", "bay", "tam", "chin", "muoi", "muoi mot", "muoi hai", "muoi ba", "muoi bon", "muoi lam", "muoi sau", "muoi bay", "muoi tam", "muoi chin" };
            String[] chuc = { "khong", "muoi", "hai muo'i", "ba muo'i", "bon muo'i", "nam muo'i", "sau muo'i", "bay muo'i", "tam muo'i", "chin muo'i" };

            string words = "";

            if ((number / 1000000000) > 0)
            {
                words += SpellV(number / 1000000000) + " ty ";
                number %= 1000000000;
            }

            if ((number / 1000000) > 0)
            {
                words += SpellV(number / 1000000) + " trieu ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += SpellV(number / 1000) + " ngan ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += SpellV(number / 100) + " tram ";
                number %= 100;
            }

            if (number > 0)
            {
                if (number < 20)
                    words += donvi[number];
                else
                {
                    words += chuc[number / 10];
                    if ((number % 10) > 0)
                        words += " " + donvi[number % 10];
                }
            }
            return words;
        }
    }
}
