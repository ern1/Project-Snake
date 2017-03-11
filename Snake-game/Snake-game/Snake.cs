using System;
using System.Collections.Generic;
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

    class Snake
    {
        private List<Rektangle> snakeParts = new List<Rektangle>();
        private int timer = 30;
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
            if(timer == 0)
            {
                var item = snakeParts[snakeParts.Count - 1];
                snakeParts.RemoveAt(snakeParts.Count - 1);
                snakeParts.Insert(0, item);

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
    }
}
