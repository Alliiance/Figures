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
        List<Figures> figures = new List<Figures>();
        public FiguresForm()
        {
            InitializeComponent();
            graphics = pictureBoxFigure.CreateGraphics();
        }

        private void AddCircle_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle(30, 30, 100, 100, Direction.Left, Direction.Top);
            circle.Draw(graphics);
            figures.Add(circle);
            AddTtreeView("Circle");
        }

        private void AddRectangle_Click(object sender, EventArgs e)
        {

        }

        private void AddTriangle_Click(object sender, EventArgs e)
        {

        }

        private void AddTtreeView(string name)
        {
            TreeNode newNode = new TreeNode(name);
            TreeNode node = treeView.Nodes.OfType<TreeNode>()
                            .FirstOrDefault(x => x.Text.Equals("Circle"));

            if (node == null)
                treeView.Nodes.Add(newNode);
            else
                node.Nodes.Add(newNode);
        }

    }
}
