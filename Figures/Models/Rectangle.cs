using System.Drawing;

namespace FiguressProgram.Models
{
    class Rectangle : Figure
    {
        public Rectangle(int x, int y, int width, int height, Direction dirX, Direction dirY)
            : base(x, y, width, height, dirX, dirY)
        {
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawRectangle(Pens.Purple, x, y, width, height);
        }
    }
}
