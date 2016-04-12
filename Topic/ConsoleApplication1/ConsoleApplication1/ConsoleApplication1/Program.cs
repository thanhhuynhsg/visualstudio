using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            int n = int.Parse(input);

            for (int i = 0; i < n; i++)
            {
                Console.Write('*');
            }

            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine('*');
            }
            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i == j)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();

            }

        }
    }
}
