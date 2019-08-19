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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FiguresForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddTriangle = new System.Windows.Forms.Button();
            this.AddRectangle = new System.Windows.Forms.Button();
            this.AddCircle = new System.Windows.Forms.Button();
            this.treeView = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxFigure = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFigure)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AddTriangle);
            this.panel1.Controls.Add(this.AddRectangle);
            this.panel1.Controls.Add(this.AddCircle);
            this.panel1.Location = new System.Drawing.Point(77, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 58);
            this.panel1.TabIndex = 0;
            // 
            // AddTriangle
            // 
            this.AddTriangle.BackColor = System.Drawing.Color.Gold;
            this.AddTriangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddTriangle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AddTriangle.Location = new System.Drawing.Point(387, 11);
            this.AddTriangle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddTriangle.Name = "AddTriangle";
            this.AddTriangle.Size = new System.Drawing.Size(86, 32);
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
            this.AddRectangle.Location = new System.Drawing.Point(230, 11);
            this.AddRectangle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddRectangle.Name = "AddRectangle";
            this.AddRectangle.Size = new System.Drawing.Size(86, 32);
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
            this.AddCircle.Location = new System.Drawing.Point(58, 11);
            this.AddCircle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddCircle.Name = "AddCircle";
            this.AddCircle.Size = new System.Drawing.Size(86, 32);
            this.AddCircle.TabIndex = 0;
            this.AddCircle.Text = "Add circle";
            this.AddCircle.UseVisualStyleBackColor = false;
            this.AddCircle.Click += new System.EventHandler(this.AddCircle_Click);
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(-1, 2);
            this.treeView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(79, 359);
            this.treeView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 365);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // pictureBoxFigure
            // 
            this.pictureBoxFigure.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxFigure.Location = new System.Drawing.Point(82, 64);
            this.pictureBoxFigure.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxFigure.Name = "pictureBoxFigure";
            this.pictureBoxFigure.Size = new System.Drawing.Size(518, 295);
            this.pictureBoxFigure.TabIndex = 2;
            this.pictureBoxFigure.TabStop = false;
            // 
            // FiguresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 386);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxFigure);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FiguresForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Figures";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFigure)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddTriangle;
        private System.Windows.Forms.Button AddRectangle;
        private System.Windows.Forms.Button AddCircle;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.PictureBox pictureBoxFigure;
        private System.Windows.Forms.Label label1;
    }
}

