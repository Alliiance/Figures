using System;
using System.Drawing;

namespace FiguresProgram.Models
{
    [Serializable]
    public class Rectangle : Figure
    {
        public Rectangle(int x, int y, int width, int height, Direction dirX, Direction dirY)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            DirX = dirX;
            DirY = dirY;
            Condition = true;
        }

        public Rectangle()
        {

        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawRectangle(Pens.Purple, X, Y, Width, Height);
        }
    }
}
