using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T145588_Home02_040416
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input integer number: ");
            String s1 = Console.ReadLine();
            int n = int.Parse(s1);

            Console.WriteLine(SpellNumber.SpellE(n));
            SpeakEnglish.speak(SpellNumber.SpellE(n));

            Console.WriteLine(SpellNumber.SpellV(n));
            SpeakVietnamese.speak(SpellNumber.SpellV(n));
        }
    }
}
