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

        public Rectangle(string name, int x, int y, int width, int height, Direction dirX, Direction dirY)
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
                    int x = GetPoint(figure[i].Width, figure[i].X, figure[index].X);
                    int y = GetPoint(figure[i].Height, figure[i].Y, figure[index].Y);

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
                            coordinateCondition = GetNextPoint(f1, f2, pictureWidth,pictureHeight);
                        }
                    }
                }
            }

        }

        private bool GetNextPoint(Figure f1, Figure f2 , int pictureWidth, int pictureHeight)
        {
            f1.Move(pictureWidth, pictureHeight);
            f2.Move(pictureWidth, pictureHeight);
            int x1 = GetPoint(f1.Width, f1.X, f2.X);
            int y1 = GetPoint(f1.Height, f1.Y, f2.Y);
            if (x1 == -1 || y1 == -1)
                return  true;
            return false;
        }

        private int GetPoint(int figureLength, int firstCoord, int secondCoord)
        {
            for (int i = firstCoord; i < firstCoord + figureLength; i++)
            {
                for (int k = secondCoord; k < secondCoord + figureLength; k++)
                    if (i == k)
                        return i;
            }
            return -1;
        }
    }
}
