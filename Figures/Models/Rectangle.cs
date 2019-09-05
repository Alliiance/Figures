using FiguresProgram.FileResources;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Xml.Serialization;

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

        public override void GetPoints(List<Figure> figure, int index, int pictureWidth, int pictureHeight)
        {
            for (int i = 0; i < figure.Count; i++)
            {
                if (figure[i].Name == Name && i != index)
                {
                    int zX1 = figure[i].X;
                    int zY1 = figure[i].Y;
                    int zX2 = figure[index].X;
                    int zY2 = figure[index].Y;


                    int x = GetPoint(figure[i].Width, figure[index].Width, figure[i].X, figure[index].X);
                    int y = GetPoint(figure[i].Height, figure[index].Height, figure[i].Y, figure[index].Y);

                    if (x >= 0 && y >= 0)
                    {
                        if (coordinateCondition)
                        {
                            InvokeEvent(figure[index].Name, x, y);
                            coordinateCondition = false;
                        }
                        else
                        {
                            Figure f1 = figure[i];
                            Figure f2 = figure[index];
                            f1.Move(pictureWidth, pictureHeight);
                            f2.Move(pictureWidth, pictureHeight);
                            int x1 = GetPoint(f1.Width, f2.Width, f1.X, f2.X);
                            int y1 = GetPoint(f1.Height, f2.Height, f1.Y, f2.Y);
                            if (x1 == -1 || y1 == -1)
                            {
                                coordinateCondition = true;
                            }
                            f1.X = zX1;
                            f1.Y = zY1;
                            f2.X = zX2;
                            f2.Y = zY2;
                        }
                    }
                }
            }

        }

        private int GetPoint(int firstFigureWidth, int secondFigureWidth, int firstCoord, int secondCoord)
        {
            for (int i = firstCoord; i < firstCoord + firstFigureWidth; i++)
            {
                for (int k = secondCoord; k < secondCoord + secondFigureWidth; k++)
                    if (i == k)
                        return i;
            }
            return -1;
        }
    }
}
