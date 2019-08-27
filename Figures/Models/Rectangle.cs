using System;
using System.Drawing;

namespace FiguresProgram.Models
{
    [Serializable]
    public class Rectangle : Figure
    {
        public Rectangle(int x, int y, int width, int height, Direction dirX, Direction dirY)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.dirX = dirX;
            this.dirY = dirY;
            condition = true;
        }

        public Rectangle()
        {

        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawRectangle(Pens.Purple, x, y, width, height);
        }
    }
}
