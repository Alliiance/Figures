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
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.NewElementCaption = new System.Windows.Forms.Label();
            this.RunFigure = new System.Windows.Forms.Button();
            this.StopFigure = new System.Windows.Forms.Button();
            this.AddTriangle = new System.Windows.Forms.Button();
            this.AddRectangle = new System.Windows.Forms.Button();
            this.AddCircle = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView = new System.Windows.Forms.TreeView();
            this.pictureBoxFigure = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFigure)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.comboBoxLanguage);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.NewElementCaption);
            this.panel1.Controls.Add(this.RunFigure);
            this.panel1.Controls.Add(this.StopFigure);
            this.panel1.Controls.Add(this.AddTriangle);
            this.panel1.Controls.Add(this.AddRectangle);
            this.panel1.Controls.Add(this.AddCircle);
            this.panel1.Controls.Add(this.menuStrip1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLanguage.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxLanguage, "comboBoxLanguage");
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.SelectedIndexChanged += new System.EventHandler(this.comboBoxLanguage_SelectedIndexChanged);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.binToolStripMenuItem,
            this.xMLToolStripMenuItem,
            this.jSONToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            // 
            // binToolStripMenuItem
            // 
            this.binToolStripMenuItem.Name = "binToolStripMenuItem";
            resources.ApplyResources(this.binToolStripMenuItem, "binToolStripMenuItem");
            this.binToolStripMenuItem.Click += new System.EventHandler(this.BinToolStripMenuItem_Click);
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            resources.ApplyResources(this.xMLToolStripMenuItem, "xMLToolStripMenuItem");
            this.xMLToolStripMenuItem.Click += new System.EventHandler(this.XMLToolStripMenuItem_Click);
            // 
            // jSONToolStripMenuItem
            // 
            this.jSONToolStripMenuItem.Name = "jSONToolStripMenuItem";
            resources.ApplyResources(this.jSONToolStripMenuItem, "jSONToolStripMenuItem");
            this.jSONToolStripMenuItem.Click += new System.EventHandler(this.JSONToolStripMenuItem_Click);
            // 
            // treeView
            // 
            this.treeView.BackColor = System.Drawing.Color.SeaShell;
            this.treeView.CheckBoxes = true;
            resources.ApplyResources(this.treeView, "treeView");
            this.treeView.Name = "treeView";
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView_NodeMouseClick);
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
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // FiguresForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBoxFigure);
            this.Controls.Add(this.treeView);
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

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddTriangle;
        private System.Windows.Forms.Button AddRectangle;
        private System.Windows.Forms.Button AddCircle;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.PictureBox pictureBoxFigure;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button RunFigure;
        private System.Windows.Forms.Button StopFigure;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem;
        private System.Windows.Forms.Label NewElementCaption;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

