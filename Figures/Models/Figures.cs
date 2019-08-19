using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Models
{
    abstract class Figures
    {
        public Figures(int x, int y, int width, int height, Direction dirX, Direction dirY)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.dirX = dirX;
            this.dirY = dirY;
        }

        protected int x { get; set; }
        protected int y { get; set; }
        protected int width { get; set; }
        protected int height { get; set; }
        protected Direction dirX { get; set; }
        protected Direction dirY { get; set; }

        abstract public void Move();

        abstract public void Draw(Graphics g);

    }
}
