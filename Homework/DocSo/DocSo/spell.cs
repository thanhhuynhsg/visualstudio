using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocSo
{
    class spell
    {   
        //Spell English
        public static string SpellNumber(Int64 number)
        {
            if (number == 0)
                return "zero";

            if (number < 0)
                return "minus " + SpellNumber(Math.Abs(number));

            string words = "";

            if ((number / 1000000000) > 0)
            {
                words += SpellNumber(number / 1000000000) + " billion ";
                number %= 1000000000;
            }

            if ((number / 1000000) > 0)
            {
                words += SpellNumber(number / 1000000) + " million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += SpellNumber(number / 1000) + " thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += SpellNumber(number / 100) + " hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "and ";

                var units = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tens = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

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
        public static string Numberv(Int64 number)
        {
            if (number == 0)
                return "khong";

            if (number < 0)
                return "am " + Numberv(Math.Abs(number));

            String[] donvi = { "khong", "mot", "hai", "ba", "bon", "nam", "sau", "bay", "tam", "chin", "muoi", "muoi mot", "muoi hai", "muoi ba", "muoi bon", "muoi lam", "muoi sau", "muoi bay", "muoi tam", "muoi chin" };
            String[] chuc = { "khong", "muoi", "hai muoi", "ba muoi", "bon muoi", "nam muoi", "sau muoi", "bay muoi", "tam muoi", "chin muoi" };

            string words = "";

            if ((number / 1000000000) > 0)
            {
                words += Numberv(number / 1000000000) + " ty ";
                number %= 1000000000;
            }

            if ((number / 1000000) > 0)
            {
                words += Numberv(number / 1000000) + " trieu ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += Numberv(number / 1000) + " ngan ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += Numberv(number / 100) + " tram ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "le ";

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
