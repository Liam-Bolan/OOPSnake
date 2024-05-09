using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace OOPSnake
{
    class HeadPart : BodyPart
    {
        public HeadPart(int Size, int X, int Y) : base(Size , X , Y)
        {

        }
        public override void Draw(Graphics g)
        {
            _edge = new Rectangle(X, Y, _size, _size);
            g.FillRectangle(Brushes.Orange, _edge);

        }
        // add the missing attributes, methods and constructor

    }
}
