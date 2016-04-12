using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace topic9
{
    class Computer
    {
        private Game game;
        public Computer(Game g) 
        {
            game=g;
        }
        public void PickRandomBall() 
        {
            if (game.getGroup1() > 0) 
            {
                game.PickBall(1, 1);
            }
            else if (game.getGroup2() > 0)
            {
                game.PickBall(2, 1);
            }
            else 
            { 
                game.PickBall(3, 1); 
            }
        }
    }
}
