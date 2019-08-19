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
        abstract public void Move();

        abstract public void Draw(Graphics g);
    }
}
