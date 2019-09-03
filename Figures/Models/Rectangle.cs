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
                    for (int j = figure[i].X; j<figure[i].X + figure[i].Width; j++)
                    {
                        for (int k = figure[index].X; k<figure[index].X + figure[index].Width ; k++)
                        {
                            if (j == k)
                            {
                                InvokeEvent(j , k , figure[index].Name);
                                break;
                            }
                        }
                    }

                }
            }   
        }

    }
}
