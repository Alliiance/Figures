using System;
using System.Drawing;

namespace FiguresProgram.Models
{
    [Serializable]
    public class Triangle : Figure
    {
        public Triangle(int x, int y, int width, int height, Direction dirX, Direction dirY)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            DirX = dirX;
            DirY = dirY;
            Condition = true;
        }

        public Triangle()
        {

        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawPolygon(Pens.Green, GetTtiangle());
        }

        public Point[] GetTtiangle()
        {
           return new Point[] {
                new Point(X, Y),
                new Point(X + Width, Y),
                new Point(X + Height, Y + Height)
            };
        }
    }
}
