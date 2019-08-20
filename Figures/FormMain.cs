using FiguressProgram.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FiguressProgram
{

    public partial class FiguresForm : Form
    {
        Graphics graphics;
        List<Models.Figures> figures = new List<Models.Figures>();
        int pictureBoxWidth;
        int pictureBoxHeight;

        public FiguresForm()
        {
            InitializeComponent();
            graphics = pictureBoxFigure.CreateGraphics();
            pictureBoxWidth = pictureBoxFigure.Size.Width;
            pictureBoxHeight = pictureBoxFigure.Size.Height;
        }

        private void PictureBoxFigure_Paint(object sender, PaintEventArgs e)
        {
        }

        private void AddCircle_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle(220, 100, 50, 50, Direction.Left, Direction.Bottom);
            circle.Draw(graphics);
            figures.Add(circle);
            AddTtreeView("Circle");
        }

        private void AddRectangle_Click(object sender, EventArgs e)
        {
            Models.Rectangle rectangle = new Models.Rectangle(220, 100, 50, 50, Direction.Left, Direction.Bottom);
            rectangle.Draw(graphics);
            figures.Add(rectangle);
            AddTtreeView("Rectangle");
        }

        private void AddTriangle_Click(object sender, EventArgs e)
        {
            Triangle triangle = new Triangle(220, 100, 50, 50, Direction.Left, Direction.Bottom);
            triangle.Draw(graphics);
            figures.Add(triangle);
            AddTtreeView("Triangle");
        }

        private void AddTtreeView(string name)
        {
            TreeNode newNode = new TreeNode(name);
            TreeNode node = treeView.Nodes.OfType<TreeNode>()
                            .FirstOrDefault(x => x.Text.Equals(name));

            if (node == null)
                treeView.Nodes.Add(newNode);
            else
                node.Nodes.Add(newNode);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // pictureBoxFigure.Refresh();
            graphics.Clear(Color.White);
            foreach (Models.Figures figure in figures)
            {
                figure.Move(pictureBoxWidth, pictureBoxHeight);
                figure.Draw(graphics);
            }
        }
    }
}
