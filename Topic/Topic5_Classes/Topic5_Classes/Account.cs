using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic5_Classes
{
    class Account
    {
        private int money;

        public int Money
        {
            get { return money; }
            set { money = value; }
        }

        public void deposit(int amount)
        {
            //  Acount acount = new Acount();
            money += amount;
        }
        public void withdraw(int amount)
        {
            money -= amount;
        }
        public int Balance()
        {
            return money;
        }
    }
}
