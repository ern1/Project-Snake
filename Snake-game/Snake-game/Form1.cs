﻿using System;
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

        private void RefreshLabels(Object obj, EventArgs args)
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
                case Keys.Down:
                    if(snake1.lastDirection != Direction.Up) { snake1.currentDirection = Direction.Down; }
                    break;
                case Keys.Up:
                    if (snake1.lastDirection != Direction.Down) { snake1.currentDirection = Direction.Up; }
                    break;
                case Keys.Left:
                    if (snake1.lastDirection != Direction.Right) { snake1.currentDirection = Direction.Left; }
                    break;
                case Keys.Right:
                    if (snake1.lastDirection != Direction.Left) { snake1.currentDirection = Direction.Right; }
                    break;
            }
            switch (e.KeyCode)
            {
                case Keys.S:
                    if (snake2.lastDirection != Direction.Up) { snake2.currentDirection = Direction.Down; }
                    break;
                case Keys.W:
                    if (snake2.lastDirection != Direction.Down) { snake2.currentDirection = Direction.Up; }
                    break;
                case Keys.A:
                    if (snake2.lastDirection != Direction.Right) { snake2.currentDirection = Direction.Left; }
                    break;
                case Keys.D:
                    if (snake2.lastDirection != Direction.Left) { snake2.currentDirection = Direction.Right; }
                    break;
            }
            if(e.KeyCode == Keys.Enter)
            {
                Application.Restart();
            }
        }
    }
}
