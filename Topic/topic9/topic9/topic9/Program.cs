using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace topic9
{
    class Program
    {
        static void Main(string[] args)
        {
            Game g = new Game(3, 4, 6);
            Computer c = new Computer(g);
            Human h = new Human(g);
            g.Display();

            while (true) 
            {
                c.PickRandomBall();
                g.Display();
                int n = g.getNumbersofBalls();
                if (n == 0) 
                {
                    Console.Write("Human");
                    break;
                }

                h.PickBall();
                g.Display();
                n = g.getNumbersofBalls();
                if (n == 0) 
                {
                    Console.Write("Computer");
                    break;
                }
            }
        }
    }
}
