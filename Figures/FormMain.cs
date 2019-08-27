using FiguresProgram.Enums;
using FiguresProgram.FileResoursec;
using FiguresProgram.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;


namespace FiguresProgram
{
    
    public partial class FiguresForm : Form
    {
        bool isFormLoaded = false;
        XmlSerializer XmlFormatter = new XmlSerializer(typeof(List<List<Figure>>));
        DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<List<Figure>>));

        Graphics graphics;
        List<List<Figure>> figures = new List<List<Figure>>
        {
              new List<Figure>(),
              new List<Figure>(),
              new List<Figure>()
        };


        int pictureBoxWidth;
        int pictureBoxHeight;

        public FiguresForm()
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.Language))
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
            }
            InitializeComponent();
            pictureBoxWidth = pictureBoxFigure.Size.Width;
            pictureBoxHeight = pictureBoxFigure.Size.Height;
            foreach (FigureEnum figure in Enum.GetValues(typeof(FigureEnum)))
            {
                treeView.Nodes.Add($"All {figure.ToString()}:");
            }
            button1.Text = Strings.LanguageBtn;

            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-us");

        }

        private void PictureBoxFigure_Paint(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;
            for (int i = 0; i < figures.Count; i++)
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
                createNode.Nodes.Add(newNode);
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
        private void FiguresForm_Resize(object sender, EventArgs e)
        {
            pictureBoxWidth = pictureBoxFigure.Size.Width;
            pictureBoxHeight = pictureBoxFigure.Size.Height;
        }
        private void FiguresForm_Load(object sender, EventArgs e)
        {
            comboBoxLanguage.DataSource = new CultureInfo[]
            {
                CultureInfo.GetCultureInfo("ru-RU"),
                CultureInfo.GetCultureInfo("en-US")
            };

            comboBoxLanguage.DisplayMember = "NativeName";
            comboBoxLanguage.ValueMember = "Name";

            if (!String.IsNullOrEmpty(Properties.Settings.Default.Language))
            {
                comboBoxLanguage.SelectedValue = Properties.Settings.Default.Language;
            }

            isFormLoaded = true;
        }

        private void comboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFormLoaded)
            {
                Properties.Settings.Default.Language = comboBoxLanguage.SelectedValue.ToString();
                Properties.Settings.Default.Save();
                Application.Restart();
            }
        }

        #region Serialization

        // Serialization .Xml
        private void XMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("SerializerFile/Figures.xml", FileMode.Create))
            {
                XmlFormatter.Serialize(fs, figures);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("SerializerFile/Figures.xml", FileMode.OpenOrCreate))
            {
                figures = (List<List<Figure>>)XmlFormatter.Deserialize(fs);
            }
        }

        // Serialization .JSON
        private void JSONToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using (FileStream fs = new FileStream("SerializerFile/people.json", FileMode.Create))
            {
                jsonFormatter.WriteObject(fs, figures);
            }
        }

        // Serialization .Bin
        private void BinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        #endregion
    }
}
