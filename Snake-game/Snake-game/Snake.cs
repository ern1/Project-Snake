using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_game
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    };

    public class Snake
    {
        private List<Rektangle> snakeParts = new List<Rektangle>();
        private int timer = 10;
        public int score { get; set; } = 0;
        public int speed { get; set; } = 30;
        public Direction direction { get; set; } = Direction.Right;

        public Snake(int x, int y)
        {
            snakeParts.Add(new Rektangle(x, y));
        }


        public void Move()
        {
            timer--;
            if (timer == 0)
            {
                if(snakeParts.Count > 0)
                {
                    var item = snakeParts[0];
                    snakeParts.RemoveAt(snakeParts.Count - 1);
                    snakeParts.Insert(0, item);
                }
                
                switch (direction)
                {
                    case Direction.Up:
                        snakeParts[0].rect.Y -= Constants.size;
                        break;
                    case Direction.Down:
                        snakeParts[0].rect.Y += Constants.size;
                        break;
                    case Direction.Left:
                        snakeParts[0].rect.X -= Constants.size;
                        break;
                    case Direction.Right:
                        snakeParts[0].rect.X += Constants.size;
                        break;
                }
                timer = speed;

            }
        }

        public void IncreaseLength()
        {
            //Skapar ny på samma position som sista. Ormen blir längre först när den rör sig ett steg framåt.
            snakeParts.Add(snakeParts[snakeParts.Count - 1]);


            //Tänkte fel. Detta gör så att den nya hamnar bakom den sista direkt.
            /*
            switch (direction)
            {
                case Direction.Up:
                    snakeParts[snakeParts.Count - 1].rect.Y += Constants.size;
                    break;
                case Direction.Down:
                    snakeParts[snakeParts.Count - 1].rect.Y -= Constants.size;
                    break;
                case Direction.Left:
                    snakeParts[snakeParts.Count - 1].rect.X += Constants.size;
                    break;
                case Direction.Right:
                    snakeParts[snakeParts.Count - 1].rect.X -= Constants.size;
                    break;
            }*/
        }

        public void Draw(Graphics g)
        {
            foreach(var rekt in snakeParts)
            {
                g.FillRectangle(rekt.brush, rekt.rect);
                g.DrawRectangle(rekt.pen, rekt.rect);
            }
        }
    }
}
