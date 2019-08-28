using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresProgram.Models
{
    class RandomCoordinates
    {
        Random random = new Random();
        public int GetRandomX(int x)
        {
            return random.Next(0,x);
        }

        public int GetRandomY(int y)
        {
            return random.Next(0, y);
        }
    }
}
