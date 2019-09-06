using FiguresProgram.FileResources;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace FiguresProgram.Models
{
    [Serializable]
    public class Triangle : Figure
    {
        public Triangle() { }

        public Triangle(string name, int x, int y, int width, int height, Direction dirX, Direction dirY)
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
            graphics.DrawPolygon(Pens.Green, GetTtiangle());
        }

        public Point[] GetTtiangle()
        {
            return new Point[] {
                new Point(X, Y),
                new Point(X + Width, Y),
                new Point(X + Height, Y + Height)
            };
        }

        public override int GetPointX(Figure figure, Figure select)
        {
            for (int i = figure.X; i < figure.X + figure.Width; i++)
            {
                for (int k = select.X; k < select.X + select.Width; k++)
                    if (i == k)
                        return i;
            }
            return -1;
        }

        public override int GetPointY(Figure figure, Figure select)
        {
            for (int i = figure.Y; i < figure.Y + figure.Height; i++)
            {
                for (int k = select.Y; k < select.Y + (i - figure.Y); k++)
                    if (i == k)
                        return i;
            }
            return -1;
        }
    }
}
