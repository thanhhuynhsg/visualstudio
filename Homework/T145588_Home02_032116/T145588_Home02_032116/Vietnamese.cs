using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T145588_Home02_032116
{
    class Vietnamese
    {
        public static string SpellNumber(Int64 number)
        {
            if (number == 0)
                return "khong";

            if (number < 0)
                return "am " + SpellNumber(Math.Abs(number));

            String[] donvi = { "khong", "mot", "hai", "ba", "bon", "nam", "sau", "bay", "tam", "chin", "muoi", "muoi mot", "muoi hai", "muoi ba", "muoi bon", "muoi lam", "muoi sau", "muoi bay", "muoi tam", "muoi chin" };
            String[] chuc = { "khong", "muoi", "hai muoi", "ba muoi", "bon muoi", "nam muoi", "sau muoi", "bay muoi", "tam muoi", "chin muoi" };

            string words = "";

            if ((number / 1000000000) > 0)
            {
                words += SpellNumber(number / 1000000000) + " ty ";
                number %= 1000000000;
            }

            if ((number / 1000000) > 0)
            {
                words += SpellNumber(number / 1000000) + " trieu ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += SpellNumber(number / 1000) + " ngan ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += SpellNumber(number / 100) + " tram ";
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
