using FiguresProgram.FileResources;
using System;
using System.Drawing;

namespace FiguresProgram.Models
{
    [Serializable]
    public class Circle : Figure
    {
        public Circle() { }

        public Circle(string name, int x, int y, int width, int height, Direction dirX, Direction dirY)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            DirX = dirX;
            DirY = dirY;
            Condition = true;
            Name = name;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(Pens.Blue, X, Y, Width, Height);
        }
    }
}
