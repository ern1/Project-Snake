using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach(var rekt in snake1.GetSnakeParts)
            {
                e.Graphics.FillRectangle(rekt.brush,rekt.rect);
            }

            foreach (var rekt in snake2.GetSnakeParts)
            {
                e.Graphics.FillRectangle(rekt.brush, rekt.rect);
            }

            foreach (var food in foods)
            {
                e.Graphics.FillRectangle(food.rekt.brush, food.rekt.rect);
                
            }

        }
    }
}
