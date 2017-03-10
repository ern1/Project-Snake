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
        private List<Rektangle> snake = new List<Rektangle>();
        private int timer = 30;
        public int score { get; set; }
        public int speed { get; set; } = 30;
        public Direction direction { get; set; }
        

        public void Move()
        {
            timer--;
            if(timer == 0)
            {
                timer = speed;
            }
        }
    }
}
