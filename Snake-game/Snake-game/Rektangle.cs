﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Snake_game
{
    public class Rektangle : Shape
    {
        private Rectangle rect;
        private SolidBrush brush;
        public Rectangle getRect { get { return rect; } }
        public SolidBrush getBrush { get { return brush; } }

        public Rektangle(int x, int y, Color color) : base(new Point(Constants.size * x, Constants.size * y))
        {
            this.rect = new Rectangle(position.X, position.Y, Constants.size, Constants.size);
            this.brush = new SolidBrush(color);
        }

        public override void Draw(Graphics g)
        {
        }
       
    }
}
