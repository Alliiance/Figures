using Figures.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Point = Figures.Models.Point;



namespace Figures
{

    public partial class FiguresForm : Form
    {
        Graphics graphics;
        Point point = new Point(30, 30, 100, 100, Direction.Left, Direction.Top);

        public FiguresForm()
        {
            InitializeComponent();
            graphics = pictureBoxFigure.CreateGraphics();
        }

        private void AddCircle_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle(point);
            circle.Draw(graphics);

        }

        private void AddRectangle_Click(object sender, EventArgs e)
        {

        }

        private void AddTriangle_Click(object sender, EventArgs e)
        {

        }
    }
}
