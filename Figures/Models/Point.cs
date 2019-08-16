namespace Figures.Models
{
    class Point
    {
        public int x;
        public int y;
        public Direction dirX;
        public Direction dirY;

        public Point(int x, int y, Direction dirX, Direction dirY)
        {
            this.x = x;
            this.y = y;
            this.dirX = dirX;
            this.dirY = dirY;
        }
    }
}
