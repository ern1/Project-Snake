using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_game
{
    public abstract class Food
    {
        public Rektangle rekt { get; set; }
        protected Random rnd = new Random();

        public Food(Color color)
        {
            this.rekt = new Rektangle(rnd.Next(0,19), rnd.Next(0,19), color);
            
        }

        public abstract bool CheckCollision(Snake snake);
    }
    
    public class StandardFood : Food
    {
        public StandardFood() : base(Color.ForestGreen)
        {
        }

        public override bool CheckCollision(Snake snake)
        {

            if (rekt.rect.IntersectsWith(snake.GetHead()))
            {
                snake.score += 10;
                snake.IncreaseLength();

                return true;
            }
            return false;
        }
    }

    public class FastFood : Food
    {
        public FastFood() : base(Color.SaddleBrown)
        {

        }

        public override bool CheckCollision(Snake snake)
        {
            if(rekt.rect.IntersectsWith(snake.GetHead()))
            {
                if(snake.timer > 2 && snake.speed > 10)
                    snake.speed -= 10;
                snake.IncreaseLength();
                return true;
            }
            return false;
        }
    }

    public class SlowFood : Food
    {
        public SlowFood() : base(Color.IndianRed)
        {

        }

        public override bool CheckCollision(Snake snake)
        {
            if (rekt.rect.IntersectsWith(snake.GetHead()))
            {
                if(snake.timer > 2 && snake.speed < 30)
                    snake.speed += 10;
                snake.IncreaseLength();
                return true;
            }
            return false;
        }
    }

    public class LongFood : Food
    {
        public LongFood() : base(Color.LightGoldenrodYellow)
        {
        }

        public override bool CheckCollision(Snake snake)
        {
            if (rekt.rect.IntersectsWith(snake.GetHead()))
            {
                snake.IncreaseLength();

                return true;
            }
            return false;
        }
    }
}
