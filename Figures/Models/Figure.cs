using System;
using System.Drawing;
using System.Xml.Serialization;

namespace FiguresProgram.Models
{
    [XmlInclude(typeof(Circle))]
    [XmlInclude(typeof(Rectangle))]
    [XmlInclude(typeof(Triangle))]
    [Serializable]
    public abstract class Figure
    {
        public int x;
        public int y;
        public int width;
        public int height;
        public Direction dirX;
        public Direction dirY;
        public bool condition;
        public bool Condition
        {
            get { return condition; }
            set { condition = value; }
        }

        abstract public void Draw(Graphics graphics);

        public virtual void Move(int pictureWidth, int pictureHeight)
        {
            if (condition)
            {
                if (x == 0)
                    dirX = Direction.Right;
                if (x >= pictureWidth - width)
                    dirX = Direction.Left;

                switch (dirX)
                {
                    case Direction.Right:
                        x++;
                        break;
                    case Direction.Left:
                        x--;
                        break;
                }

                if (y == 0)
                    dirY = Direction.Bottom;
                if (y >= pictureHeight - height)
                    dirY = Direction.Top;


                switch (dirY)
                {
                    case Direction.Top:
                        y--;
                        break;
                    case Direction.Bottom:
                        y++;
                        break;
                }
            }
        }
    }
}
