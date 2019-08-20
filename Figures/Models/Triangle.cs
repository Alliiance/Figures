using System.Drawing;

namespace FiguressProgram.Models
{
    class Triangle : Figures
    {
        public Triangle(int x, int y, int width, int height, Direction dirX, Direction dirY)
            : base(x, y, width, height, dirX, dirY)
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
