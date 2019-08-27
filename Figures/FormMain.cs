using FiguresProgram.FileResoursec;
using FiguresProgram.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace FiguresProgram
{
    
    public partial class FiguresForm : Form
    {
        bool isFormLoaded = false;
        int pictureBoxWidth;
        int pictureBoxHeight;

        Graphics graphics;
        List<List<Figure>> figures = new List<List<Figure>>
        {
              new List<Figure>(),
              new List<Figure>(),
              new List<Figure>()
        };

        public FiguresForm()
        {
            InitializeLanguage();
            InitializeComponent();
            pictureBoxWidth = pictureBoxFigure.Size.Width;
            pictureBoxHeight = pictureBoxFigure.Size.Height;

            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-us");

        }

        #region Add figure

            private void AddCircle_Click(object sender, EventArgs e)
            {
                Circle circle = new Circle(220, 100, 50, 50, Direction.Left, Direction.Bottom);
                figures[0].Add(circle);
                AddTtreeViewFigure(Strings.Circle);
            }

            private void AddRectangle_Click(object sender, EventArgs e)
            {
                Models.Rectangle rectangle = new Models.Rectangle(220, 100, 50, 50, Direction.Left, Direction.Bottom);
                figures[1].Add(rectangle);
                AddTtreeViewFigure(Strings.Rectangle);
            }

            private void AddTriangle_Click(object sender, EventArgs e)
            {
                Triangle triangle = new Triangle(220, 100, 50, 50, Direction.Left, Direction.Bottom);
                figures[2].Add(triangle);
                AddTtreeViewFigure(Strings.Triangle);
            }

        #endregion

        #region TreeView Figure

            private void AddTtreeViewFigure(string name)
            {
                TreeNode newNode = new TreeNode(name);

                TreeNode createNode = treeViewFigures.Nodes.OfType<TreeNode>()
                    .FirstOrDefault(x => x.Text.Contains(name));

                if (createNode != null)
                    createNode.Nodes.Add(newNode);
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

        #endregion

        #region Condition figure

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
                TreeNodeCollection nodes = treeViewFigures.Nodes;
                foreach (TreeNode node in nodes)
                    foreach (TreeNode item in node.Nodes)
                    {
                        if (item.Checked)
                            figures[node.Index][item.Index].Condition = conditon;
                    }
            }

            private void FiguresForm_Resize(object sender, EventArgs e)
            {
                pictureBoxWidth = pictureBoxFigure.Size.Width;
                pictureBoxHeight = pictureBoxFigure.Size.Height;
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

        #endregion

        #region Language

            private void InitializeComboBoxLanguage()
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

            private void InitializeLanguage()
            {
                if (!string.IsNullOrEmpty(Properties.Settings.Default.Language))
                {
                    Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
                }
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

            private void FiguresForm_Load(object sender, EventArgs e)
            {
                InitializeComboBoxLanguage();
            }

        #endregion

        #region Serialization and Deserialize

            XmlSerializer XmlFormatter = new XmlSerializer(typeof(List<List<Figure>>));
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<List<Figure>>));
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            string filePath = "SerializerFile/";
            string xmlFileName = "Figures.xml";
            string jsonFileName = "Figures.json";
            string binaryFileName = "Figures.dat";

            private void SerializationXml_Click(object sender, EventArgs e)
            {
                 string path = filePath + xmlFileName;
                 using (FileStream fs = new FileStream(path, FileMode.Create))
                 {
                     XmlFormatter.Serialize(fs, figures);
                     AddTtreeViewFile(xmlFileName);
                 }
            }

            private void DeserializeXml()
            {
                string path = filePath + xmlFileName;
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                {
                    figures = (List<List<Figure>>)XmlFormatter.Deserialize(fs);
                }
            }

            private void SerializationJson_Click(object sender, EventArgs e)
            {
                string path = filePath + jsonFileName;
                using (FileStream fs = new FileStream(filePath + jsonFileName, FileMode.Create))
                {
                    jsonFormatter.WriteObject(fs, figures);
                    AddTtreeViewFile(jsonFileName);
                }
            }

            private void DeserializeJson()
            {
                string path = filePath + jsonFileName;
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                {
                    figures = (List<List<Figure>>)jsonFormatter.ReadObject(fs);
                }
            }

            private void SerializationBin_Click(object sender, EventArgs e)
            {
                string path = filePath + binaryFileName;
                using (FileStream fs = new FileStream(filePath + binaryFileName, FileMode.Create))
                {
                    binaryFormatter.Serialize(fs, figures);
                    AddTtreeViewFile(binaryFileName);
                }
            }

            private void DeserializeBinaty()
            {
                string path = filePath + binaryFileName;
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                {
                    figures = (List<List<Figure>>)binaryFormatter.Deserialize(fs);
                }
            }

        #endregion

        #region TreewView Serialization

        private void AddTtreeViewFile(string name)
            {
                TreeNode newNode = new TreeNode(name);
                TreeNode node = treeViewFiles.Nodes.OfType<TreeNode>()
                                .FirstOrDefault(x => x.Text.Equals(name));

                if (node == null)
                    treeViewFiles.Nodes.Add(newNode);
            }

            private void TreeViewFiles_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
            {
                string path = e.Node.FullPath;
                int indexPatch = path.LastIndexOf('.');
                path = path.Substring(indexPatch).ToLower();

                switch (path)
                {
                    case ".dat":
                        DeserializeBinaty();
                        break;
                    case ".json":
                        DeserializeJson();
                        break;
                    case ".xml":
                        DeserializeXml();
                        break;
                }
            }

        #endregion

        private void Timer_Tick(object sender, EventArgs e)
        {
            pictureBoxFigure.Refresh();
        }
    }
}
