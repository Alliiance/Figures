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
        int pictureBoxWidth;
        int pictureBoxHeight;

        public FiguresForm()
        {
            InitializeComponent();
            pictureBoxWidth = pictureBoxFigure.Size.Width;
            pictureBoxHeight = pictureBoxFigure.Size.Height;
            treeView.CheckBoxes = true;

        }

        private void PictureBoxFigure_Paint(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;
            foreach (Figures figure in figures)
            {
                figure.Move(pictureBoxWidth, pictureBoxHeight);
                figure.Draw(graphics);
            }
        }

        private void AddCircle_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle(220, 100, 50, 50, Direction.Left, Direction.Bottom);
            figures.Add(circle);
            AddTtreeView("Circle");
        }

        private void AddRectangle_Click(object sender, EventArgs e)
        {
            Rectangles rectangle = new Rectangles(220, 100, 50, 50, Direction.Left, Direction.Bottom);
            figures.Add(rectangle);
            AddTtreeView("Rectangle");
        }

        private void AddTriangle_Click(object sender, EventArgs e)
        {
            Triangle triangle = new Triangle(220, 100, 50, 50, Direction.Left, Direction.Bottom);
            figures.Add(triangle);
            AddTtreeView("Triangle");
        }

        private void AddTtreeView(string name)
        {

            //TreeNode newNode = new TreeNode(name);
            //TreeNode node = treeView.Nodes.OfType<TreeNode>()
            //                .FirstOrDefault(x => x.Text.Equals(name));
            //if (node == null)
            //    treeView.Nodes.Add(newNode);
            //else
            //    node.Nodes.Add(newNode);

            TreeNode newNode = new TreeNode(name);          
            TreeNode node = treeView.Nodes.OfType<TreeNode>()
                .FirstOrDefault(x => x.Text.Equals($"All: {name}"));

            if (node == null)
                treeView.Nodes.Add($"All: {name}");

            TreeNode createNode = treeView.Nodes.OfType<TreeNode>()
                .FirstOrDefault(x => x.Text.Equals($"All: {name}"));
            createNode.Nodes.Add(newNode);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
           pictureBoxFigure.Refresh();          
        }

        private void StopFigure_Click(object sender, EventArgs e)
        {
            foreach (TreeNode item in treeView.Nodes)
            {
                if (item.Checked)
                {
                    label1.Text = "Сработало";
                }
            }
        }

        private void RunFigure_Click(object sender, EventArgs e)
        {

        }
    }
}
