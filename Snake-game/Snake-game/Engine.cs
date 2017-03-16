using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_game
{
    public partial class Form1 : Form
    {
        private Timer timer = new Timer();
       
        
        Snake snake1 = new Snake(2, 2);
        Snake snake2 = new Snake(2, 17);
        
        private ISet<Food> foods = new HashSet<Food>();
        private Random rnd = new Random();
        public static bool gameOver = false;
       


        
        public void Run()
        {
            GenerateFood();
            //Paint += new PaintEventHandler(Draw);
            //Paint += new PaintEventHandler(pictureBox1_Paint);
           
            timer.Tick += new EventHandler(TimerEventHandler);
            timer.Tick += new EventHandler(RefreshLabels);
            timer.Interval = 20;
            timer.Start();
        }

        public void TimerEventHandler(Object obj, EventArgs args)
        {
            snake1.Move();
            snake2.Move();
            isGameOver();

            if (gameOver == true)
            {
                timer.Stop();
                gameOverLbl.Visible = true;
                if(snake1.score > snake2.score)
                {
                    Player1winLbl.Visible = true;
                }
                if (snake2.score > snake1.score)
                {
                    player2winsLbl.Visible = true;
                }

                pictureBox2.Visible = true;  
            }

           
            foreach (var food in foods)
            {
                if (food.CheckCollision(snake1) || food.CheckCollision(snake2))
                {
                    foods.Remove(food);
                    GenerateFood();
                    break;
                }
            }
            Refresh();
        }
        
        public void GenerateFood()
        {
            switch (rnd.Next(1, 4))
            {
            case 1:
                foods.Add(new StandardFood());
                break;
            case 2:
                foods.Add(new FastFood());
                break;
            case 3:
                foods.Add(new SlowFood());
                break;
            case 4:
                foods.Add(new LongFood());
                break;
            }
        }
        public void isGameOver()
        {
            if(snake1.GetHead().Top < 0 || snake1.GetHead().Bottom > pictureBox1.Size.Height || snake1.GetHead().Left < 0 || snake1.GetHead().Right > pictureBox1.Size.Width || snake1.GetHead().IntersectsWith(snake2.GetHead()))
            {
                snake1.score = snake1.score - 100;
                gameOver = true;
            }
            if(snake2.GetHead().Top < 0 || snake2.GetHead().Bottom > pictureBox1.Size.Height || snake2.GetHead().Left < 0 || snake2.GetHead().Right > pictureBox1.Size.Width || snake2.GetHead().IntersectsWith(snake1.GetHead()))
            {
                snake2.score = snake2.score - 100;
                gameOver = true;
            }
            /*
            if(snake1.CheckSelfCollison())
            {
                snake1.score = snake1.score - 100;
                gameOver = true;
            }

            if (snake2.CheckSelfCollison())
            {
                snake2.score = snake1.score - 100;
                gameOver = true;
            }
            */
        }
       
    }
}
