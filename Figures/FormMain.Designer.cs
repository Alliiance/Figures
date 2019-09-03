namespace FiguresProgram
{
    partial class FiguresForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FiguresForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.addEvent = new System.Windows.Forms.Button();
            this.minusEvent = new System.Windows.Forms.Button();
            this.languageTitle = new System.Windows.Forms.Label();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.NewElementCaption = new System.Windows.Forms.Label();
            this.RunFigure = new System.Windows.Forms.Button();
            this.StopFigure = new System.Windows.Forms.Button();
            this.AddTriangle = new System.Windows.Forms.Button();
            this.AddRectangle = new System.Windows.Forms.Button();
            this.AddCircle = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SerializationBin = new System.Windows.Forms.ToolStripMenuItem();
            this.SerializationXml = new System.Windows.Forms.ToolStripMenuItem();
            this.SerializationJson = new System.Windows.Forms.ToolStripMenuItem();
            this.treeViewFigures = new System.Windows.Forms.TreeView();
            this.pictureBoxFigure = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.listFiguresTitle = new System.Windows.Forms.Label();
            this.SaveFilesTitle = new System.Windows.Forms.Label();
            this.treeViewFiles = new System.Windows.Forms.TreeView();
            this.textBoxCoordinat = new System.Windows.Forms.TextBox();
            this.labelCoordinat = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFigure)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.addEvent);
            this.panel1.Controls.Add(this.minusEvent);
            this.panel1.Controls.Add(this.languageTitle);
            this.panel1.Controls.Add(this.comboBoxLanguage);
            this.panel1.Controls.Add(this.NewElementCaption);
            this.panel1.Controls.Add(this.RunFigure);
            this.panel1.Controls.Add(this.StopFigure);
            this.panel1.Controls.Add(this.AddTriangle);
            this.panel1.Controls.Add(this.AddRectangle);
            this.panel1.Controls.Add(this.AddCircle);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Name = "panel1";
            // 
            // addEvent
            // 
            this.addEvent.BackColor = System.Drawing.Color.Lime;
            resources.ApplyResources(this.addEvent, "addEvent");
            this.addEvent.Name = "addEvent";
            this.addEvent.UseVisualStyleBackColor = false;
            this.addEvent.Click += new System.EventHandler(this.AddEvent_Click);
            // 
            // minusEvent
            // 
            this.minusEvent.BackColor = System.Drawing.Color.Salmon;
            resources.ApplyResources(this.minusEvent, "minusEvent");
            this.minusEvent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minusEvent.Name = "minusEvent";
            this.minusEvent.UseVisualStyleBackColor = false;
            this.minusEvent.Click += new System.EventHandler(this.MinusEvent_Click);
            // 
            // languageTitle
            // 
            resources.ApplyResources(this.languageTitle, "languageTitle");
            this.languageTitle.Name = "languageTitle";
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLanguage.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxLanguage, "comboBoxLanguage");
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.SelectedIndexChanged += new System.EventHandler(this.ComboBoxLanguage_SelectedIndexChanged);
            // 
            // NewElementCaption
            // 
            resources.ApplyResources(this.NewElementCaption, "NewElementCaption");
            this.NewElementCaption.ForeColor = System.Drawing.Color.Tomato;
            this.NewElementCaption.Name = "NewElementCaption";
            // 
            // RunFigure
            // 
            this.RunFigure.BackColor = System.Drawing.Color.GreenYellow;
            this.RunFigure.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.RunFigure, "RunFigure");
            this.RunFigure.Name = "RunFigure";
            this.RunFigure.UseVisualStyleBackColor = false;
            this.RunFigure.Click += new System.EventHandler(this.RunFigure_Click);
            // 
            // StopFigure
            // 
            this.StopFigure.BackColor = System.Drawing.Color.Crimson;
            this.StopFigure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopFigure.ForeColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.StopFigure, "StopFigure");
            this.StopFigure.Name = "StopFigure";
            this.StopFigure.UseVisualStyleBackColor = false;
            this.StopFigure.Click += new System.EventHandler(this.StopFigure_Click);
            // 
            // AddTriangle
            // 
            this.AddTriangle.BackColor = System.Drawing.Color.Green;
            this.AddTriangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddTriangle.ForeColor = System.Drawing.SystemColors.HighlightText;
            resources.ApplyResources(this.AddTriangle, "AddTriangle");
            this.AddTriangle.Name = "AddTriangle";
            this.AddTriangle.UseVisualStyleBackColor = false;
            this.AddTriangle.Click += new System.EventHandler(this.AddTriangle_Click);
            // 
            // AddRectangle
            // 
            this.AddRectangle.BackColor = System.Drawing.Color.LightCoral;
            this.AddRectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddRectangle.ForeColor = System.Drawing.SystemColors.HighlightText;
            resources.ApplyResources(this.AddRectangle, "AddRectangle");
            this.AddRectangle.Name = "AddRectangle";
            this.AddRectangle.UseVisualStyleBackColor = false;
            this.AddRectangle.Click += new System.EventHandler(this.AddRectangle_Click);
            // 
            // AddCircle
            // 
            this.AddCircle.BackColor = System.Drawing.SystemColors.Highlight;
            this.AddCircle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddCircle.ForeColor = System.Drawing.SystemColors.HighlightText;
            resources.ApplyResources(this.AddCircle, "AddCircle");
            this.AddCircle.Name = "AddCircle";
            this.AddCircle.UseVisualStyleBackColor = false;
            this.AddCircle.Click += new System.EventHandler(this.AddCircle_Click);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.Orange;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SerializationBin,
            this.SerializationXml,
            this.SerializationJson});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            // 
            // SerializationBin
            // 
            this.SerializationBin.Name = "SerializationBin";
            resources.ApplyResources(this.SerializationBin, "SerializationBin");
            this.SerializationBin.Click += new System.EventHandler(this.SerializationBin_Click);
            // 
            // SerializationXml
            // 
            this.SerializationXml.Name = "SerializationXml";
            resources.ApplyResources(this.SerializationXml, "SerializationXml");
            this.SerializationXml.Click += new System.EventHandler(this.SerializationXml_Click);
            // 
            // SerializationJson
            // 
            this.SerializationJson.Name = "SerializationJson";
            resources.ApplyResources(this.SerializationJson, "SerializationJson");
            this.SerializationJson.Click += new System.EventHandler(this.SerializationJson_Click);
            // 
            // treeViewFigures
            // 
            this.treeViewFigures.BackColor = System.Drawing.Color.SeaShell;
            this.treeViewFigures.CheckBoxes = true;
            resources.ApplyResources(this.treeViewFigures, "treeViewFigures");
            this.treeViewFigures.Name = "treeViewFigures";
            this.treeViewFigures.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            ((System.Windows.Forms.TreeNode)(resources.GetObject("treeViewFigures.Nodes"))),
            ((System.Windows.Forms.TreeNode)(resources.GetObject("treeViewFigures.Nodes1"))),
            ((System.Windows.Forms.TreeNode)(resources.GetObject("treeViewFigures.Nodes2")))});
            this.treeViewFigures.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView_NodeMouseClick);
            // 
            // pictureBoxFigure
            // 
            resources.ApplyResources(this.pictureBoxFigure, "pictureBoxFigure");
            this.pictureBoxFigure.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxFigure.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxFigure.Name = "pictureBoxFigure";
            this.pictureBoxFigure.TabStop = false;
            this.pictureBoxFigure.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBoxFigure_Paint);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 5;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // listFiguresTitle
            // 
            resources.ApplyResources(this.listFiguresTitle, "listFiguresTitle");
            this.listFiguresTitle.Name = "listFiguresTitle";
            // 
            // SaveFilesTitle
            // 
            resources.ApplyResources(this.SaveFilesTitle, "SaveFilesTitle");
            this.SaveFilesTitle.Name = "SaveFilesTitle";
            // 
            // treeViewFiles
            // 
            resources.ApplyResources(this.treeViewFiles, "treeViewFiles");
            this.treeViewFiles.BackColor = System.Drawing.Color.LemonChiffon;
            this.treeViewFiles.Name = "treeViewFiles";
            this.treeViewFiles.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeViewFiles_NodeMouseClick);
            // 
            // textBoxCoordinat
            // 
            resources.ApplyResources(this.textBoxCoordinat, "textBoxCoordinat");
            this.textBoxCoordinat.Name = "textBoxCoordinat";
            // 
            // labelCoordinat
            // 
            resources.ApplyResources(this.labelCoordinat, "labelCoordinat");
            this.labelCoordinat.Name = "labelCoordinat";
            // 
            // FiguresForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelCoordinat);
            this.Controls.Add(this.textBoxCoordinat);
            this.Controls.Add(this.treeViewFiles);
            this.Controls.Add(this.SaveFilesTitle);
            this.Controls.Add(this.listFiguresTitle);
            this.Controls.Add(this.pictureBoxFigure);
            this.Controls.Add(this.treeViewFigures);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FiguresForm";
            this.Load += new System.EventHandler(this.FiguresForm_Load);
            this.Resize += new System.EventHandler(this.FiguresForm_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFigure)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddTriangle;
        private System.Windows.Forms.Button AddRectangle;
        private System.Windows.Forms.Button AddCircle;
        private System.Windows.Forms.TreeView treeViewFigures;
        private System.Windows.Forms.PictureBox pictureBoxFigure;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button RunFigure;
        private System.Windows.Forms.Button StopFigure;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SerializationBin;
        private System.Windows.Forms.ToolStripMenuItem SerializationXml;
        private System.Windows.Forms.ToolStripMenuItem SerializationJson;
        private System.Windows.Forms.Label NewElementCaption;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.Label listFiguresTitle;
        private System.Windows.Forms.Label SaveFilesTitle;
        private System.Windows.Forms.TreeView treeViewFiles;
        private System.Windows.Forms.Label languageTitle;
        private System.Windows.Forms.TextBox textBoxCoordinat;
        private System.Windows.Forms.Label labelCoordinat;
        private System.Windows.Forms.Button minusEvent;
        private System.Windows.Forms.Button addEvent;
    }
}

