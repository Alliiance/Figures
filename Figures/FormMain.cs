using Figures.Enums;
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
        List<Figure>[] figures = new List<Figure>[]
        {
              new List<Figure>(),
              new List<Figure>(),
              new List<Figure>()
        };
        int pictureBoxWidth;
        int pictureBoxHeight;

        public FiguresForm()
        {
            InitializeComponent();
            pictureBoxWidth = pictureBoxFigure.Size.Width;
            pictureBoxHeight = pictureBoxFigure.Size.Height;

            foreach (FigureEnum figure in Enum.GetValues(typeof(FigureEnum)))
            {
                treeView.Nodes.Add($"All {figure.ToString()}:");
            }

        }

        private void PictureBoxFigure_Paint(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;
            for (int i = 0; i < figures.Length; i++)
            {
                foreach (Figure figure in figures[i])
                {
                    figure.Move(pictureBoxWidth, pictureBoxHeight);
                    figure.Draw(graphics);
                }
            }
        }

        private void AddCircle_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle(220, 100, 50, 50, Direction.Left, Direction.Bottom);
            figures[0].Add(circle);
            AddTtreeView(FigureEnum.Circle.ToString());
        }

        private void AddRectangle_Click(object sender, EventArgs e)
        {
            Models.Rectangle rectangle = new Models.Rectangle(220, 100, 50, 50, Direction.Left, Direction.Bottom);
            figures[1].Add(rectangle);
            AddTtreeView(FigureEnum.Rectangle.ToString());
        }

        private void AddTriangle_Click(object sender, EventArgs e)
        {
            Triangle triangle = new Triangle(220, 100, 50, 50, Direction.Left, Direction.Bottom);
            figures[2].Add(triangle);
            AddTtreeView(FigureEnum.Triangle.ToString());
        }

        private void AddTtreeView(string name)
        {
            TreeNode newNode = new TreeNode(name);

            TreeNode createNode = treeView.Nodes.OfType<TreeNode>()
                .FirstOrDefault(x => x.Text.Equals($"All {name}:"));

            if(createNode != null)
            {
                createNode.Nodes.Add(newNode);
                treeView.Nodes.OfType<TreeNode>()
                   .FirstOrDefault(x => x.Text.Equals($"All {name}:")).Expand();
            }



        }

        private void Timer_Tick(object sender, EventArgs e)
        {
           pictureBoxFigure.Refresh();
        }

        private void StopFigure_Click(object sender, EventArgs e)
        {
            ChangeCondition(false);
        }

        private void RunFigure_Click(object sender, EventArgs e)
        {
            ChangeCondition(true);
        }

        private void ChangeCondition(bool conditon)
        {
            TreeNodeCollection nodes = treeView.Nodes;
            foreach (TreeNode node in nodes)
                foreach (TreeNode item in node.Nodes)
                {
                    if (item.Checked)
                        figures[node.Index][item.Index].Condition = conditon;
                }
        }

        private void TreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            treeViewChangeCheckBox(e.Node);
        }
        private void treeViewChangeCheckBox(TreeNode Node)
        {
            for (int i = 0; i < Node.Nodes.Count; i++)
            {
                Node.Nodes[i].Checked = Node.Checked;
                treeViewChangeCheckBox(Node.Nodes[i]);
            }
        }
    }
}
