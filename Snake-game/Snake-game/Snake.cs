using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        
        public int score { get; set; }
        public int speed { get; set; }
        public Direction direction { get; set; }

    }
}
