using System;
using System.Drawing;

namespace FiguresProgram.Models
{

    [Serializable]
    public class Circle : Figure
    {
        public Circle(int x, int y, int width, int height, Direction dirX, Direction dirY)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.dirX = dirX;
            this.dirY = dirY;
            condition = true;
        }

        public Circle()
        {

        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(Pens.Blue, x, y, width, height);
        }
    }
}
