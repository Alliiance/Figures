using System.Drawing;

namespace FiguressProgram.Models
{
    abstract class Figure
    {
        protected int x;
        protected int y;
        protected int width;
        protected int height;
        protected Direction dirX;
        protected Direction dirY;
        private bool condition;

        public Figure(int x, int y, int width, int height, Direction dirX, Direction dirY)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.dirX = dirX;
            this.dirY = dirY;
            condition = true;
        }
        public  bool Condition {
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
