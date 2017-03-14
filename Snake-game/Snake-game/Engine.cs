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
        public static bool GameOver;
       


        
        public void Run()
        {
            GameOver = false;
            GenerateFood();
            //Paint += new PaintEventHandler(Draw);
            //Paint += new PaintEventHandler(pictureBox1_Paint);
           
                timer.Tick += new EventHandler(TimerEventHandler);
                timer.Interval = 1000 / 25;
                timer.Start();
            
            
            
                       
        }

        public void TimerEventHandler(Object obj, EventArgs args)
        {

            if(isGameOver() == true)
            {
                timer.Stop();
                gameOverLbl.Visible = true;
                pictureBox2.Visible = true;  
            }
            snake1.Move();
            snake2.Move();
           
            foreach (var food in foods)
            {
                if (food.CheckCollision(snake1) || food.CheckCollision(snake2))
                {
                    foods.Remove(food);
                    GenerateFood();
                    //
                    // INCREASE SCORE
                    //
                    
                    player1_score.Text = Convert.ToString(snake1.score);
                    player2_score.Text = Convert.ToString(snake2.score);
                    break;
                }
                
            }
            // if out of bounds -> game over
            Refresh();
        }
        
        public void GenerateFood()
        {
            
            //fixa constuctor i Food
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
        public bool isGameOver()
        {
            if(snake1.GetHead().Top < 0 || snake1.GetHead().Bottom > pictureBox1.Size.Height || snake1.GetHead().Left < 0 || snake1.GetHead().Right > pictureBox1.Size.Width || snake1.GetHead().IntersectsWith(snake2.GetHead()))
            {
                return true;
            }
            else if(snake2.GetHead().Top < 0 || snake2.GetHead().Bottom > pictureBox1.Size.Height || snake2.GetHead().Left < 0 || snake2.GetHead().Right > pictureBox1.Size.Width || snake2.GetHead().IntersectsWith(snake1.GetHead()))
            {
                return true;
            }
            return false;
            
        }
       
    }
}
