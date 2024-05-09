using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace OOPSnake
{
    class Food
    {
        // add the missing attributes and methods and constructor
        Random rng = new Random();
        public int Value { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Rectangle Edge { get; set; }

        public Food(int sx, int sy)
        {
            X = sx;
            Y = sy;
            Edge = new Rectangle(X, Y, 30, 30);
            Value = rng.Next(1, 6);
        }
        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color.Red);
            g.FillEllipse(b, Edge);
        }
        public void Clear(Graphics g)
        {
            Brush b = new SolidBrush(Color.White);
            g.FillEllipse(b, Edge);
        }
    }
}
