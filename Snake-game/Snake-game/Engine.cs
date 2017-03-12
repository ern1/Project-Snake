using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_game
{
    class Engine
    {
        Snake snake1(2, 2);
        Snake snake2(2, 8);
        private HashSet<Food> foods = new HashSet<Food>();
        private Random rnd = new Random();
        //jhudhsajdhsajdhsajd
        public void TimeEventHandler(Object obj, EventArgs args)
        {
            snake1.Move();
            snake2.Move();
            foreach (food in foods)
            {
                if (food.CheckCollison(snake1) || food.CheckCollison(snake2))
                {
                    foods.Remove(food);
                }
            }
            // kolla out of bounds    game over
            GenerateFood();
        }

        public void GenerateFood()
        {
            //fixa constuctor i Food
            switch (new Random().Next(0, 100))
            {
                case 1:
                    foods.Add(new StandardFood(rnd.Next(0, 10), rnd.Next(0, 10)));
                    break;
                case 2:
                    foods.Add(new FastFood(rnd.Next(0, 10), rnd.Next(0, 10)));
                    break;
                case 3:
                    foods.Add(new SlowFood(rnd.Next(0, 10), rnd.Next(0, 10)));
                    break;
                case 4:
                    foods.Add(new LongFood(rnd.Next(0, 10), rnd.Next(0, 10)));
                    break;

            }
        }
    }
}
