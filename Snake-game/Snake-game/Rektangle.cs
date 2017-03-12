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
        public Rectangle rect;
        public Pen pen = new Pen(Color.Blue);
        public SolidBrush brush = new SolidBrush(Color.Blue);


        public Rektangle(int x, int y) : base(new Point(Constants.size*x, Constants.size*y))
        {
            this.rect = new Rectangle(position.X, position.Y, Constants.size, Constants.size);
        }

        public override void Draw(Graphics g)
        {

        }
       
    }
}
