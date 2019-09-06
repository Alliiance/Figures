using CoorditatesLibrary;
using FiguresProgram.FileResources;
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
using System.Media;

namespace FiguresProgram
{
    
    public partial class FiguresForm : Form
    {
        bool isFormLoaded = false;
        int pictureBoxWidth;
        int pictureBoxHeight;
        readonly CoordinatesRandom rand = new CoordinatesRandom();

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
            InitializeTreewViewFiles();
            pictureBoxWidth = pictureBoxFigure.Size.Width;
            pictureBoxHeight = pictureBoxFigure.Size.Height;
        }

        #region Add figure

            private void AddCircle_Click(object sender, EventArgs e)
            {
                string name = Strings.Circle;
                int width = 50;
                int height = 50;
                int posX = rand.GetRandomX(pictureBoxWidth - width);
                int posY = rand.GetRandomY(pictureBoxHeight - height);
                Circle circle = new Circle(name, posX, posY, width, height, Direction.Left, Direction.Bottom);
                figures[0].Add(circle);
                AddTtreeViewFigure(name);
            }

            private void AddRectangle_Click(object sender, EventArgs e)
            {
                string name = Strings.Rectangle;
                int width = 50;
                int height = 50;
                int posX = rand.GetRandomX(pictureBoxWidth - width);
                int posY = rand.GetRandomY(pictureBoxHeight - height);
                Models.Rectangle rectangle = new Models.Rectangle(name, posX, posY, width, height, Direction.Left, Direction.Bottom);
                figures[1].Add(rectangle);
                AddTtreeViewFigure(name);
            }

            private void AddTriangle_Click(object sender, EventArgs e)
            {
                string name = Strings.Triangle;
                int width = 50;
                int height = 50;
                int posX = rand.GetRandomX(pictureBoxWidth - width);
                int posY = rand.GetRandomY(pictureBoxHeight - height);
                Triangle triangle = new Triangle(name, posX, posY, width, height, Direction.Left, Direction.Bottom);
                figures[2].Add(triangle);
                AddTtreeViewFigure(name);
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
                TreeViewChangeCheckBox(e.Node);
            }

            private void TreeViewChangeCheckBox(TreeNode Node)
            {
                for (int i = 0; i < Node.Nodes.Count; i++)
                {
                    Node.Nodes[i].Checked = Node.Checked;
                    TreeViewChangeCheckBox(Node.Nodes[i]);
                }
            }

        public void Refresh_TreeViewFigure()
        {
            for (int i = 0; i < figures.Count; i++)
            {
                treeViewFigures.Nodes[i].Nodes.Clear();
                for (int j = 0; j < figures[i].Count; j++)
                {
                   string name = figures[i][j].Name;
                   TreeNode newNode = new TreeNode(name);
                   treeViewFigures.Nodes[i].Nodes.Add(newNode);
                }
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
                        if (item.Checked)
                            figures[node.Index][item.Index].Condition = conditon;
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

            private void ComboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
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

            readonly XmlSerializer XmlFormatter = new XmlSerializer(typeof(List<List<Figure>>));
            readonly DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<List<Figure>>));
            readonly BinaryFormatter binaryFormatter = new BinaryFormatter();
            readonly string filePath = "SerializerFile/";
            readonly string xmlFileName = "Figures.xml";
            readonly string jsonFileName = "Figures.json";
            readonly string binaryFileName = "Figures.dat";

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
                using (FileStream fs = new FileStream(path, FileMode.Create))
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
                using (FileStream fs = new FileStream(path, FileMode.Create))
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
            Refresh_TreeViewFigure();
          }

        private void InitializeTreewViewFiles()
        {
            Directory.CreateDirectory(filePath);
            string[] files = Directory.GetFiles(filePath);

            foreach (string path in files)
            {
                string name = path;
                int indexPatch = path.LastIndexOf('/');
                name = name.Substring(indexPatch + 1);
                AddTtreeViewFile(name);
            }
        }

        #endregion

        #region Event buttons

        private void AddEvent_Click(object sender, EventArgs e)
        {
            ChangeEvenet(true);
        }

        private void MinusEvent_Click(object sender, EventArgs e)
        {
            ChangeEvenet(false);
        }

        private void ChangeEvenet(bool condition)
        {
            TreeNodeCollection nodes = treeViewFigures.Nodes;
            foreach (TreeNode node in nodes)
                foreach (TreeNode item in node.Nodes)
                    if (item.Checked)
                    {
                        Figure figure = figures[node.Index][item.Index];
                        figure.figureEvent = figure;
                        if (condition)
                            figure.MyPoint += Points_MyPointEvent;
                        else
                            figure.MyPoint -= Points_MyPointEvent;
                    }
        }

        private void Points_MyPointEvent(string name,int x , int y)
        {
            textBoxCoordinat.Text += $"\r\n{Strings.TypeFigure}: {name}" +
                                     $"\r\n{Strings.Coordinate}-X : {x}," +
                                     $"\r\n{Strings.Coordinate}-Y : {y}." +
                                     $"\r\n{new string('_', 20)} \r\n";

            using (SoundPlayer beep = new SoundPlayer("../../Sounds/beep.wav"))
            {
                beep.Play();
            }
        }

        #endregion

        private void Timer_Tick(object sender, EventArgs e)
        {
            pictureBoxFigure.Refresh();
            foreach (var figure in figures)
            {
                int indexElement = 0;
                foreach (var item in figure)
                {
                    try
                    {
                        if (item.IsEventNull())
                            item.GetPoints(figure, indexElement, pictureBoxWidth, pictureBoxHeight);
                    }
                    catch
                    {
                        continue;
                    }
                    finally
                    {
                        indexElement++;
                    }
                }
            }
        }
    }
}
