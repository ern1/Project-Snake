using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_game
{
    public abstract class Food
    {

        //public abstract bool CheckCollision(Snake snake);
    }
    /*
    public class StandardFood : Food
    {
        public override bool CheckCollision(Snake snake)
        {
            if(IntersectsWith(rekt, snake.SnakeParts[0].rect)
            {
                snake.points += 10;
                if(snake.timer > 2)
                    timer -= 2;
            }
        }
    }

    public class FastFood : Food
    {
        public override bool CheckCollision(Snake snake)
        {
            if(IntersectsWith(rekt, snake.SnakeParts[0].rect)
            {
                if(snake.timer > 2)
                    timer -= 2;
            }
        }
    }

    public class SlowFood : Food
    {
        public override bool CheckCollision(Snake snake)
        {
            if(IntersectsWith(rekt, snake.SnakeParts[0].rect)
            {
                if(snake.timer > 2)
                    timer += 2;
            }
        }
    }

    public class LongFood : Food
    {
        public override bool CheckCollision(Snake snake)
        {
            if(IntersectsWith(rekt, snake.SnakeParts[0].rect)
            {
                snake.IncreaseLength();
            }
        }
    }
    */
}
