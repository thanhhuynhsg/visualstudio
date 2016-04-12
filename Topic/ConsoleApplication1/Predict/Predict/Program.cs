using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predict
{
    class Program
    {
        static void Predict1(int STDnum)
        {
            int right = 100 + STDnum;
            int left = 0;
            int midle;
            int dem = 1;
            do
            {
                midle = (right - left) / 2 + left;
                if (midle == right + 1 && midle == left)
                {
                    Console.WriteLine("You think : " + midle + "?");
                    string output = Console.ReadLine();
                    break;
                }
                if (right == midle && midle == left + 1)
                {
                    Console.WriteLine("You think : " + right + "?");
                    string output = Console.ReadLine();
                    break;
                }

                Console.WriteLine("Q :" + dem + " Is your number bigger than : " + midle);
                string input = Console.ReadLine();
                if (input == "Yes")
                {
                    left = midle;


                }
                if (input == "No")
                {
                    right = midle;
                }

                dem++;
            }
            while (left <= right);
        }
        static void Main(string[] args)
        {
            Predict1(24);
        }
    
    }
}
