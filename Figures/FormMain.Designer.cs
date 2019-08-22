namespace FiguressProgram
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
            this.RunFigure = new System.Windows.Forms.Button();
            this.StopFigure = new System.Windows.Forms.Button();
            this.AddTriangle = new System.Windows.Forms.Button();
            this.AddRectangle = new System.Windows.Forms.Button();
            this.AddCircle = new System.Windows.Forms.Button();
            this.treeView = new System.Windows.Forms.TreeView();
            this.pictureBoxFigure = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFigure)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.RunFigure);
            this.panel1.Controls.Add(this.StopFigure);
            this.panel1.Controls.Add(this.AddTriangle);
            this.panel1.Controls.Add(this.AddRectangle);
            this.panel1.Controls.Add(this.AddCircle);
            this.panel1.Location = new System.Drawing.Point(168, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 71);
            this.panel1.TabIndex = 0;
            // 
            // RunFigure
            // 
            this.RunFigure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RunFigure.Location = new System.Drawing.Point(376, 39);
            this.RunFigure.Name = "RunFigure";
            this.RunFigure.Size = new System.Drawing.Size(60, 28);
            this.RunFigure.TabIndex = 4;
            this.RunFigure.Text = "Run";
            this.RunFigure.UseVisualStyleBackColor = true;
            this.RunFigure.Click += new System.EventHandler(this.RunFigure_Click);
            // 
            // StopFigure
            // 
            this.StopFigure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopFigure.Location = new System.Drawing.Point(376, 4);
            this.StopFigure.Name = "StopFigure";
            this.StopFigure.Size = new System.Drawing.Size(60, 28);
            this.StopFigure.TabIndex = 3;
            this.StopFigure.Text = "Stop";
            this.StopFigure.UseVisualStyleBackColor = true;
            this.StopFigure.Click += new System.EventHandler(this.StopFigure_Click);
            // 
            // AddTriangle
            // 
            this.AddTriangle.BackColor = System.Drawing.Color.Green;
            this.AddTriangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddTriangle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AddTriangle.Location = new System.Drawing.Point(254, 14);
            this.AddTriangle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddTriangle.Name = "AddTriangle";
            this.AddTriangle.Size = new System.Drawing.Size(115, 39);
            this.AddTriangle.TabIndex = 2;
            this.AddTriangle.Text = "Add triangle";
            this.AddTriangle.UseVisualStyleBackColor = false;
            this.AddTriangle.Click += new System.EventHandler(this.AddTriangle_Click);
            // 
            // AddRectangle
            // 
            this.AddRectangle.BackColor = System.Drawing.Color.LightCoral;
            this.AddRectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddRectangle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AddRectangle.Location = new System.Drawing.Point(133, 14);
            this.AddRectangle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddRectangle.Name = "AddRectangle";
            this.AddRectangle.Size = new System.Drawing.Size(115, 39);
            this.AddRectangle.TabIndex = 1;
            this.AddRectangle.Text = "Add rectangle";
            this.AddRectangle.UseVisualStyleBackColor = false;
            this.AddRectangle.Click += new System.EventHandler(this.AddRectangle_Click);
            // 
            // AddCircle
            // 
            this.AddCircle.BackColor = System.Drawing.SystemColors.Highlight;
            this.AddCircle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddCircle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AddCircle.Location = new System.Drawing.Point(12, 14);
            this.AddCircle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddCircle.Name = "AddCircle";
            this.AddCircle.Size = new System.Drawing.Size(115, 39);
            this.AddCircle.TabIndex = 0;
            this.AddCircle.Text = "Add circle";
            this.AddCircle.UseVisualStyleBackColor = false;
            this.AddCircle.Click += new System.EventHandler(this.AddCircle_Click);
            // 
            // treeView
            // 
            this.treeView.BackColor = System.Drawing.Color.SeaShell;
            this.treeView.CheckBoxes = true;
            this.treeView.Location = new System.Drawing.Point(12, 11);
            this.treeView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(150, 453);
            this.treeView.TabIndex = 1;
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView_NodeMouseClick);
            // 
            // pictureBoxFigure
            // 
            this.pictureBoxFigure.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxFigure.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxFigure.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxFigure.Location = new System.Drawing.Point(168, 97);
            this.pictureBoxFigure.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxFigure.Name = "pictureBoxFigure";
            this.pictureBoxFigure.Size = new System.Drawing.Size(645, 367);
            this.pictureBoxFigure.TabIndex = 2;
            this.pictureBoxFigure.TabStop = false;
            this.pictureBoxFigure.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBoxFigure_Paint);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 5;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // FiguresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 475);
            this.Controls.Add(this.pictureBoxFigure);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FiguresForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Figures";
            this.Resize += new System.EventHandler(this.FiguresForm_Resize);
            this.panel1.ResumeLayout(false);
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
    }
}

