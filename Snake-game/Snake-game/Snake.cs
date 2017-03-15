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
        private List<Rektangle> snakeParts = new List<Rektangle>() ;
        public int timer { get; set; } = 20;
        public int score { get; set; } = 0;
        public int speed { get; set; } = 20;
        public Direction direction { get; set; } = Direction.Right;
        
        public List<Rektangle> GetSnakeParts{ get { return snakeParts; } } 
        public Rectangle GetHead() { return snakeParts[0].rect; }    

        public Snake(int x, int y)
        {
                snakeParts.Add(new Rektangle(x, y, Color.HotPink));      
        }


        public void Move()
        {
            timer--;
            if (timer == 0)
            {
                Rektangle part = snakeParts[0];
                snakeParts.RemoveAt(snakeParts.Count - 1);
                
                switch (direction)
                {
                    case Direction.Up:
                        snakeParts.Insert(0, new Rektangle(part.rect.X/Constants.size, part.rect.Y / Constants.size - 1, Color.HotPink));
                        break;
                    case Direction.Down:
                        snakeParts.Insert(0, new Rektangle(part.rect.X / Constants.size, part.rect.Y / Constants.size + 1, Color.HotPink));
                        break;
                    case Direction.Left:
                        snakeParts.Insert(0, new Rektangle(part.rect.X / Constants.size - 1, part.rect.Y / Constants.size, Color.HotPink));
                        break;
                    case Direction.Right:
                        snakeParts.Insert(0, new Rektangle(part.rect.X / Constants.size + 1, part.rect.Y / Constants.size, Color.HotPink));
                        break;
                }
                timer = speed;
            }
        }

        public void IncreaseLength()
        {
            //Skapar ny på samma position som sista. Ormen blir längre först när den rör sig ett steg framåt.
            snakeParts.Add(snakeParts[snakeParts.Count - 1]);
        }

        public bool CheckSelfCollison()
        {
            for(int i = 1; i < snakeParts.Count; i++)
            {
                if (snakeParts[0].rect.IntersectsWith(snakeParts[i].rect))
                    return true;
            }
            return false;
        }
    }
}
