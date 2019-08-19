using System.Drawing;

namespace FiguressProgram.Models
{
    class Circle : Figures
    {
        public Circle(int x, int y, int width,int height, Direction dirX, Direction dirY) 
            : base(x, y, width, height, dirX, dirY)
        {
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(Pens.Red, x, y, width, height);
        }

        public override void Move()
        {
            
        }
    }
}
