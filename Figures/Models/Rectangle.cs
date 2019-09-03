using FiguresProgram.FileResources;
using System;
using System.Drawing;
using System.Collections.Generic;

namespace FiguresProgram.Models
{
    [Serializable]
    public class Rectangle : Figure
    {
        public Rectangle() { }

        public Rectangle(string name,int x, int y, int width, int height, Direction dirX, Direction dirY)
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
            graphics.DrawRectangle(Pens.Purple, X, Y, Width, Height);
        }

        public override void GetPoints(List<Figure> figure, int index)
        {
            for (int i = 0; i<figure.Count; i++)
            {
                if (figure[i].Name == Name && i != index)
                {
                    int x = GetPointX(figure[i], figure[index]);
                    int y = GetPointY(figure[i], figure[index]);

                    if (x > 0 && y > 0)
                    {
                        InvokeEvent(figure[index].Name, x, y);
                    }
                }
            }   
        }


        public int GetPointX(Figure figure, Figure select)
        {
            for (int i = figure.X; i < figure.X + figure.Width; i++)
            {
                for (int k = select.X; k < select.X + select.Width; k++)
                    if (i == k)
                        return i;
            }
            return -1;
        }

        public int GetPointY(Figure figure, Figure select)
        {
            for (int i = figure.Y; i < figure.Y + figure.Height; i++)
            {
                for (int k = select.Y; k < select.Y + select.Height; k++)
                    if (i == k)
                        return i;
            }
            return -1;
        }

    }
}
