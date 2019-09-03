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
                    int x = GetPoint(figure[i].Width, figure[index].Width, figure[i].X, figure[index].X);
                    int y = GetPoint(figure[i].Width, figure[index].Width, figure[i].Y, figure[index].Y);

                    if (x > 0 && y > 0)
                    {
                        InvokeEvent(figure[index].Name, x, y);
                    }
                }
            }   
        }

        public int GetPoint(int firstFigureWidth, int secondFigureWidth, int firstCoord, int secondCoord)
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
