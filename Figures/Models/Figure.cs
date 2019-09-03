using System;
using System.Collections.Generic;
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
        public delegate void PointDelegate(Figure f);
        public event PointDelegate MyPoint;
        public int indexElement;

        public Figure figureEvent;

        public void GetPoint(List<Figure> figure, int count)
        {
            if (figureEvent.X == 10)
                foreach (var f in figure)
                    {
                        if (f.Name == Name && indexElement != count)
                        {                            
                            MyPoint(figureEvent);
                        }
                    }                       
        }

        [DataMember]
        public int X { get; set; }

        [DataMember]
        public int Y { get; set; }

        [DataMember]
        public int Width { get; set; }

        [DataMember]
        public int Height { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public Direction DirX { get; set; }

        [DataMember]
        public Direction DirY { get; set; }

        [DataMember]
        public bool Condition { get; set; }

        abstract public void Draw(Graphics graphics);

        public virtual void Move(int pictureWidth, int pictureHeight)
        {
            if (Condition)
            {
                if (X == 0)
                    DirX = Direction.Right;
                if (X >= pictureWidth - Width)
                    DirX = Direction.Left;

                switch (DirX)
                {
                    case Direction.Right:
                        X++;
                        break;
                    case Direction.Left:
                        X--;
                        break;
                }

                if (Y == 0)
                    DirY = Direction.Bottom;
                if (Y >= pictureHeight - Height)
                    DirY = Direction.Top;


                switch (DirY)
                {
                    case Direction.Top:
                        Y--;
                        break;
                    case Direction.Bottom:
                        Y++;
                        break;
                }
            }
        }
    }
}
