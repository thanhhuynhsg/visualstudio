using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace T145588_Test07_033016
{
    class Problem2
    {
        public static void maxmin(String a) 
        {
            string line;
            int min = 234;
            int max = 0;
            StreamReader file = new StreamReader(a);
            while ((line = file.ReadLine()) != null)
            {
                Console.WriteLine(line);
                int n = Convert.ToInt32(line);
                if (max <= n)
                {
                    max = n;
                }
                
                if(min >= n)
                {
                    min = n;
                }
            }
            Console.WriteLine("max: "+max);
            Console.WriteLine("min: "+min);
            file.Close();
        }


    }
}
