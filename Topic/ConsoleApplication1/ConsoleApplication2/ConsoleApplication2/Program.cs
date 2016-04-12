using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao 2 so cuoi ma so sinh vien cua ban");
            String input = Console.ReadLine();
            int n = int.Parse(input);

            int a = 0;
            int b = 100 + n;
            int f = b - a;

            while (f > 1) 
            {
                int c = (a + b) / 2;
                Console.WriteLine("Is your number bigger than: " + c);
                string input1 = Console.ReadLine();
                if (input1 == "Yes") {
                    a = c;
                }
                if (input1 == "No")
                {
                    b = c;
                }
                f = b - a;
            }
            Console.WriteLine("Co phai so cua ban la: " + a);
            string input2 = Console.ReadLine();
            if (input2 == "Yes") {
                Console.WriteLine("End.");
            }
            if (input2 == "No")
            {
                Console.WriteLine("Day la so cua ban: " +b);
                Console.WriteLine("End.");
            }

        }
    }
}
