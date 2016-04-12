using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace topic9
{
    class Game
    {
        private int group1,  group2, group3;
        public Game(int g1,int g2,int g3)
        {
            group1 = g1;
            group2 = g2;
            group3 = g3;
        }
        public void Display() 
        {
            Console.WriteLine("group 1: ");
            for (int i = 0; i < group1; i++) 
            {
                Console.Write("0 ");
            }
            Console.WriteLine();

            Console.WriteLine("group 2: ");
            for (int i = 0; i < group2; i++)
            {
                Console.Write("0 ");
            }
            Console.WriteLine();

            Console.WriteLine("group 3: ");
            for (int i = 0; i < group3; i++)
            {
                Console.Write("0 ");
            }
            Console.WriteLine();
            //..........................
            //group2, group 3
        }
        public void PickBall(int group, int balls) 
        {
            switch (group) 
            {
                case 1: group1 -= balls; break;
                case 2: group2 -= balls; break;
                case 3: group3 -= balls; break;
            }
        }
        public int getNumbersofBalls() 
        {
            return group1 + group2 + group3;
        }
        public int getGroup1() 
        {
            return group1;
        }
        public int getGroup2()
        {
            return group2;
        }
        public int getGroup3()
        {
            return group3;
        }
    }
}

