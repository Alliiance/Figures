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

        public override void GetPoints(List<Figure> figure, int index, int pictureWidth, int pictureHeight)
        {
            for (int i = 0; i < figure.Count; i++)
            {
                if (figure[i].Name == Name && i != index)
                {
                    int x = GetPointX(figure[i], figure[index]);
                    int y = GetPointY(figure[i], figure[index]);

                    if (x >= 0 && y >= 0)
                    {
                        if (coordinateCondition)
                        {
                            InvokeEvent(figure[index].Name, x, y);
                            coordinateCondition = false;
                        }
                        else
                        {
                            Figure f1 = (Figure)figure[i].Clone();
                            Figure f2 = (Figure)figure[index].Clone();
                            coordinateCondition = GetNextPoint(f1, f2, pictureWidth, pictureHeight);
                        }
                    }
                }
            }
        }

        public int GetPointX(Figure figure, Figure select)
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

        public int GetPointY(Figure figure, Figure select)
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

        protected bool GetNextPoint(Figure f1, Figure f2, int pictureWidth, int pictureHeight)
        {
            f1.Move(pictureWidth, pictureHeight);
            f2.Move(pictureWidth, pictureHeight);
            int x = GetPointX(f1, f2);
            int y = GetPointY(f1, f2);
            if (x == -1 || y == -1)
                return true;
            else
                return false;
        }

    }
}
