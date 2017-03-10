using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_game
{
    class Engine
    {
        public void TimeEventHandler(Object obj, EventArgs args)
        {
            snake1.Move();
            snake2.Move();
            foreach (food in foods)
            {
                food.checkCollison(snake1);
                food.checkCollison(snake2);
            }
            // kolla out of bounds    game over
        }
    }
}
