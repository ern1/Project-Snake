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
            
            player1_score.Text = Convert.ToString(snake1.score);
            player2_score.Text = Convert.ToString(snake2.score);
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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           
            switch (e.KeyCode)
            {
                case Keys.Down: snake1.direction = Direction.Down; break;
                case Keys.Up: snake1.direction = Direction.Up; break;
                case Keys.Left: snake1.direction = Direction.Left; break;
                case Keys.Right: snake1.direction = Direction.Right; break;
            }
            switch (e.KeyCode)
            {
                case Keys.S: snake2.direction = Direction.Down; break;
                case Keys.W: snake2.direction = Direction.Up; break;
                case Keys.A: snake2.direction = Direction.Left; break;
                case Keys.D: snake2.direction = Direction.Right; break;
            }
            if(e.KeyCode == Keys.Enter)
            {
                Application.Restart();
            }
        }
    }
}
