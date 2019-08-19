using Figures;
using System.Drawing;

namespace Figures.Models
{
    class Circle : Figures
    {
        Point point;
        public Circle(Point point)
        {
           this.point = point;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(Pens.Red, point.x, point.y, point.width, point.height);
        }

        public override void Move()
        {
            
        }
    }
}
