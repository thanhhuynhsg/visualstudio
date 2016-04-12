using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic5_Classes
{
    class MyStack
    {
        private int stack;

        public int Stack 
        { 
            get {return stack;}
            set {stack = value;}
        }

        public void put(int item) 
        {
            stack = stack + item;
        }

        public int pop()
        {
            return stack;
        }
       /* public int count()
        {
 
        }*/
    }
}
