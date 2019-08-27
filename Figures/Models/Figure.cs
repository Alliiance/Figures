using System;
using System.Drawing;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace FiguresProgram.Models
{
    [Serializable]
    [XmlInclude(typeof(Circle))]
    [XmlInclude(typeof(Rectangle))]
    [XmlInclude(typeof(Triangle))]
    [DataContract]
    [KnownType(typeof(Circle))]
    [KnownType(typeof(Rectangle))]
    [KnownType(typeof(Triangle))]
    public abstract class Figure
    {
        private int x, y, width, height;

        private Direction dirX, dirY;

        private bool condition;

        [DataMember]
        public int X
        {
            get { return x; }
            set { x = value; }
        }

        [DataMember]
        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        [DataMember]
        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        [DataMember]
        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        [DataMember]
        public Direction DirX
        {
            get { return dirX; }
            set { dirX = value; }
        }
        [DataMember]
        public Direction DirY
        {
            get { return dirY; }
            set { dirY = value; }
        }

        [DataMember]
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
