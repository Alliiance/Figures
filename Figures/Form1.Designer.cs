namespace Figures
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AddTriangle);
            this.panel1.Controls.Add(this.AddRectangle);
            this.panel1.Controls.Add(this.AddCircle);
            this.panel1.Location = new System.Drawing.Point(103, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 71);
            this.panel1.TabIndex = 0;
            // 
            // AddTriangle
            // 
            this.AddTriangle.BackColor = System.Drawing.Color.Gold;
            this.AddTriangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddTriangle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AddTriangle.Location = new System.Drawing.Point(516, 13);
            this.AddTriangle.Name = "AddTriangle";
            this.AddTriangle.Size = new System.Drawing.Size(115, 40);
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
            this.AddRectangle.Location = new System.Drawing.Point(306, 13);
            this.AddRectangle.Name = "AddRectangle";
            this.AddRectangle.Size = new System.Drawing.Size(115, 40);
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
            this.AddCircle.Location = new System.Drawing.Point(77, 13);
            this.AddCircle.Name = "AddCircle";
            this.AddCircle.Size = new System.Drawing.Size(115, 40);
            this.AddCircle.TabIndex = 0;
            this.AddCircle.Text = "Add circle";
            this.AddCircle.UseVisualStyleBackColor = false;
            this.AddCircle.Click += new System.EventHandler(this.AddCircle_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(-1, 2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(104, 441);
            this.treeView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 449);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox11.Location = new System.Drawing.Point(109, 79);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(690, 363);
            this.pictureBox11.TabIndex = 2;
            this.pictureBox11.TabStop = false;
            // 
            // Figures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 475);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Figures";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Figures";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddTriangle;
        private System.Windows.Forms.Button AddRectangle;
        private System.Windows.Forms.Button AddCircle;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox11;
    }
}

