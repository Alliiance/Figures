namespace Figures.Models
{
    class Point
    {
        public int x;
        public int y;
        public int width;
        public int height;
        public Direction dirX;
        public Direction dirY;

        public Point(int x, int y, int width, int height, Direction dirX, Direction dirY)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.dirX = dirX;
            this.dirY = dirY;
        }
    }
}
