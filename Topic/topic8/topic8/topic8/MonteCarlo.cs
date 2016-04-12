using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace topic8
{
    class MonteCarlo //Tính số pi
    {
        public static double monte(int n) 
        {

            Random r = new Random();
            double count = 0;
            for (int i = 0; i < n; i++) 
            {
                double x = r.NextDouble(); //between 0 and 1
                double y = r.NextDouble();

                int R =1;
                if ((x * x + y * y) <= R*R) 
                { 
                    count ++;
                }
            }

            double pi = (count * 4) / n;
            return pi;
        }
    }
}
