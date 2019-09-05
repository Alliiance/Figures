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

        public override void GetPoints(List<Figure> figure, int index, int pictureWidth, int pictureHeight)
        {
            for (int i = 0; i < figure.Count; i++)
            {
                if (figure[i].Name == Name && i != index)
                {
                    int x = GetPointX(figure[i].Width, figure[i].X, figure[index].X);
                    int y = GetPointY(figure[i].Height, figure[i].Y, figure[index].Y);

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
                            f1.Move(pictureWidth, pictureHeight);
                            f2.Move(pictureWidth, pictureHeight);
                            int x1 = GetPointX(f1.Width, f1.X, f2.X);
                            int y1 = GetPointY(f1.Height, f1.Y, f2.Y);
                            if (x1 == -1 || y1 == -1)
                                coordinateCondition = true;
                        }
                    }
                }
            }
        }
        private int GetPointX(int figureLength, int firstCoord, int secondCoord)
        {
            for (int i = firstCoord; i < firstCoord + figureLength; i++)
            {
                for (int k = secondCoord; k < secondCoord + figureLength; k++)
                    if (i == k)
                        return i;
            }
            return -1;
        }

        private int GetPointY(int figureLength, int firstCoord, int secondCoord)
        {
            for (int i = firstCoord; i < firstCoord + figureLength; i++)
            {
                for (int k = secondCoord; k < secondCoord + (i - firstCoord); k++)
                    if (i == k)
                        return i;
            }
            return -1;
        }
    }
}
