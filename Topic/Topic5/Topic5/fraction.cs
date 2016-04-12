using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic5
{
    class fraction
    {
        private int a, b;
        public fraction(int c, int d) 
        {
            a = c;
            b = d;
        }
        public int getA() { return a; }
        public void setA(int a) { a = -a; }

        public int geB() { return b; }
        public void setB(int b) { b = -b; }


        public void add(int c, int d) 
        {
            a = a * d + b * c;
            b = b * d;
        }

        public float toValue() 
        {
            return (float)a / b;
        }

    }
}
