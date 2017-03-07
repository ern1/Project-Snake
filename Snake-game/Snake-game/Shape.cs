using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snake_game
{

    public abstract class Shape
    {
        protected Point position;

        public Shape(Point position)
        {
            this.position = position;
        }

        public abstract void Draw(Graphics g);
    }
}
