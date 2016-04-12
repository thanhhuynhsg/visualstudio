using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace topic9
{
    class Human
    {
        private Game game;
        public Human(Game g) 
        {
            game = g;
        }
        public void PickBall() 
        {
            Console.WriteLine("which group? ");
            int g = int.Parse(Console.ReadLine());
            Console.WriteLine("how many balls?: ");
            int b = int.Parse(Console.ReadLine());
            game.PickBall(g, b);
        }
    }
}
