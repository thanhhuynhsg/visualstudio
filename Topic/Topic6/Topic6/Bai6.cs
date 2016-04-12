using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic6
{
    class Bai6
    {
        public static void cau6a() 
        {
             for (int i = 97; i < 123; i++) 
            {
               Console.Write((char)i + " ");
            }
            for (char c ='a'; c <='z'; c++)
            {
              Console.WriteLine(c);
            }
        }

       /* public static char ReadChar() 
        {
            Console.WriteLine("Nhap 1 ki tu: ");
            String str = Console.ReadKey().KeyChar;
            Char n = str[0];
            return n;
        }*/
        
        public static bool IsUpper(char n)
        {
            bool flag = false;
            int i = (int) n;
            if((n>=6*i) && (n<90))
           {
              flag=true;
           }
           return flag;
        }

       /* public Char ToUpper(char h) 
        {
            int i = (int)h;


        } */

    }
}
