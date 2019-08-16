using Figures;

namespace Figures.Models
{
    class Circle : Figures
    {
        Point point;
        object sender;
        public Circle(object sender,Point point)
        {
           this.point = point;
           this.sender = sender;
        }


        public override void Draw()
        {
            
        }

        public override void Move()
        {
            
        }
    }
}
