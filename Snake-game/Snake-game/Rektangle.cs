using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Snake_game
{
    public class Rektangle : Shape
    {
        public Rectangle rect { get; private set; }
        public SolidBrush brush { get;private set; }
       

        public Rektangle(int x, int y, Color color) : base(new Point(Constants.size * x, Constants.size * y))
        {
            this.rect = new Rectangle(position.X, position.Y, Constants.size, Constants.size);
            this.brush = new SolidBrush(color);
        }
   
    }
}
