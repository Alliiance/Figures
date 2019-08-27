using System;
using System.Drawing;

namespace FiguresProgram.Models
{
    [Serializable]
    public class Triangle : Figure
    {
        public Triangle(int x, int y, int width, int height, Direction dirX, Direction dirY)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.dirX = dirX;
            this.dirY = dirY;
            condition = true;
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
                new Point(x, y),
                new Point(x + width, y),
                new Point(x + height, y + height)
            };
        }
    }
}
