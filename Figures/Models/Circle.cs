using FiguresProgram.FileResources;
using System;
using System.Collections.Generic;
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

        public override int GetPointX(Figure figure, Figure select)
        {
            int half = figure.Width / 2;
            int centerPoint = figure.X + half;
            for (int i = select.X - half / 2; i < select.X + figure.Width + half / 2; i++)
             {
                 if (i == centerPoint)
                     return i;
             }
            return -1;
        }

        public override int GetPointY(Figure figure, Figure select)
        {
            int half = figure.Height / 2;
            int centerPoint = figure.Y + half;
            for (int i = select.Y - half / 2; i < select.Y + figure.Height + half / 2; i++)
            {
                if (i == centerPoint)
                    return i;
            }
            return -1;
        }
    }
}
