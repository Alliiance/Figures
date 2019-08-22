using System.Drawing;

namespace FiguressProgram.Models
{
    class Circle : Figure
    {
        public Circle(int x, int y, int width,int height, Direction dirX, Direction dirY) 
            : base(x, y, width, height, dirX, dirY)
        {
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(Pens.Blue, x, y, width, height);
        }
    }
}
