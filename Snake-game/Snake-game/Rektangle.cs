using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Snake_game
{
    public abstract class Rektangle : Shape
    {
        protected Rectangle rect;
        protected Pen pen;
        
        public Rektangle(int x, int y) : base(new Point(x, y))
        {
            this.rect = new Rectangle(position.X, position.Y, Constants.size, Constants.size);
        }

        public override void Draw(Graphics g)
        {

        }
       
    }
}
