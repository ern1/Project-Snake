using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_game
{
    public class Engine
    {
        private Timer timer;
        private Form form;

        Snake snake1 = new Snake(2, 2);
        Snake snake2 = new Snake(2, 8);
        private HashSet<Food> foods = new HashSet<Food>();
        private Random rnd = new Random();

        public Engine()
        {
            timer = new Timer();
            form = new Form1();
        }

        public void Run()
        {
            form.Paint += new PaintEventHandler(Draw);

            timer.Tick += new EventHandler(TimerEventHandler);
            timer.Interval = 1000 / 25;
            timer.Start();

            //GenerateFood();
            Application.Run(form);
        }

        public void TimerEventHandler(Object obj, EventArgs args)
        {
            snake1.Move();
            snake2.Move();
            /*foreach (var food in foods)
            {
                if (food.CheckCollison(snake1) || food.CheckCollison(snake2))
                {
                    foods.Remove(food);
                }
            }*/
            // if out of bounds -> game over
            form.Refresh();
        }
        /*
        public void GenerateFood()
        {
            //fixa constuctor i Food
            switch (new Random().Next(0, 4))
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
        */
        private void Draw(Object obj, PaintEventArgs args)
        {
            snake1.Draw(args.Graphics);
            /*foreach(var food in foods)
            {
            food.Draw(args.Graphics);
            }*/
        }
    }
}
