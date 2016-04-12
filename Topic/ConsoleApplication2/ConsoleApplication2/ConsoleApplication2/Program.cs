using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        //Nhập vào 1 mảng
        static void InputData(int[] arr)
        {
          
            for (int i=0; i<arr.Length; i++)
            {
                Console.Write("Input number " + (i+1) + " :");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }

        static bool number5(int[] arr)
        {
            bool flag = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 5)
                {
                    flag = true;
                }
            }
            return flag;
        }
        static bool number5or6(int[] arr)
        {
            bool flag = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 5 || arr[i] ==6)
                {
                    flag = true;
                }
            }
            return flag;
        }
        static bool number5and6(int[] arr)
        {
            bool flag1 = false;
            bool flag2 = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 5)
                {
                    flag1 = true;
                }
                if (arr[i] == 6)
                {
                    flag2 = true;
                }
            }
            if (flag1 == true && flag2 == true ) 
            {
                return true;
            }
            else {
                return false;
            }

        }
        static int count5(int[] arr) 
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 5)
                {
                    count++;
                }
            }
            return count;
        }
        static int count5or6(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 5 || arr[i] == 6)
                {
                    count++;
                }
            }
            return count;
        }
        static int sum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            return sum;
        }

        static void a(int n) {
            for (int i = 0; i < n; i++) {
                Console.WriteLine("*");
            }
        }

        static void b(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void j(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");

                    }
                } Console.WriteLine();
            } 
        }

        static void g(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 1 || j == n || i == j)
                        Console.Write("*");
                    else
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
        }

        static void i(int n) 
        {
        }

        static void Main(string[] args)
        {
            int[] dk = new int[] {1,2,3,4, 10};
            //InputData(dk);
            Console.WriteLine(sum(dk));
            Console.Write("Input H =");
            int i = int.Parse(Console.ReadLine());
            a(i);
            b(i);
        }
    }
}
