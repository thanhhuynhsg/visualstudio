using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic5_Classes
{
    class Program
    {
        static  Account acount = new Account();
      
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ban muon nhap bao nhieu tien");
            int n = int.Parse(Console.ReadLine());
            acount.deposit(n);
            Console.WriteLine("Ban muon rut bao nhiu tien");
            int a = int.Parse(Console.ReadLine());
            acount.withdraw(a);
            Console.WriteLine("Ban con so tien la : ");
            int c = acount.Balance ();
            Console.WriteLine(c);
             
        }
    }
}
