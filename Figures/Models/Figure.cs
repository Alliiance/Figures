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
    public abstract class Figure : ICloneable
    {
        public delegate void PointDelegate(string name, int x, int y);

        [field: NonSerialized]
        public event PointDelegate MyPoint;

        [XmlIgnore]
        public bool coordinateCondition = true;

        [XmlIgnore]
        public Figure figureEvent;

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
        abstract public int GetPointX(Figure f1, Figure f2);
        abstract public int GetPointY(Figure f1, Figure f2);


        object locker1 = new object();
        object locker2 = new object();

        public void Move(int pictureWidth, int pictureHeight)
        {
            if (X > pictureWidth || Y > pictureHeight)
                throw new ArgumentOutOfRangeException($" {Name}, coordinate X : {X}, coordinate Y : {Y};");


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

        public void GetPoints(List<Figure> figure, int index, int pictureWidth, int pictureHeight)
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

        protected bool GetNextPoint(Figure f1, Figure f2, int pictureWidth, int pictureHeight)
        {
            bool IsItNextPoint = false;

            f1.Move(pictureWidth, pictureHeight);
            f2.Move(pictureWidth, pictureHeight);
            int x = GetPointX(f1, f2);
            int y = GetPointY(f1, f2);
            if (x == -1 || y == -1)
                IsItNextPoint = true;
            
            return IsItNextPoint;
        }

        public bool IsEventNull()
        {
            bool IsItPoint = false;
            if (MyPoint != null)
                IsItPoint = true;

            return IsItPoint;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
        protected void InvokeEvent(string name, int x, int y)
        {
            MyPoint.Invoke(name, x, y);
        }

        public void NewСorrectСoordinates(int newX , int newY)
        {
            X = newX;
            Y = newY;
        }
    }
}