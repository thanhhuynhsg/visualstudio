using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T145588_Test05_031616
{
    class Problem3
    {
        public static bool palindrome(String n) 
        {
            bool flag = false;
            int dodai = n.Length;
            for (int i = 0; i < (dodai / 2); i++) 
            {
                if (n[i] != n[dodai - i - 1])
                {
                    flag = false;
                    break;
                }
                else 
                {
                    flag = true;
                }
            }
            return flag;
        }
    }
}
