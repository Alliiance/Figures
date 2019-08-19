using Figures.Models;
using System;
using System.Drawing;
using System.Windows.Forms;



namespace Figures
{

    public partial class FiguresForm : Form
    {
        Graphics graphics;

        public FiguresForm()
        {
            InitializeComponent();
            graphics = pictureBoxFigure.CreateGraphics();
        }

        private void AddCircle_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle(30, 30, 100, 100, Direction.Left, Direction.Top);
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
