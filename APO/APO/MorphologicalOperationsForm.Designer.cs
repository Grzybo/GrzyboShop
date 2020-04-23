namespace APO
{
    partial class MorphologicalOperationsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.MorfologicalPictureBox = new System.Windows.Forms.PictureBox();
            this.ErodeButton = new System.Windows.Forms.Button();
            this.DilateButton = new System.Windows.Forms.Button();
            this.OpeningButton = new System.Windows.Forms.Button();
            this.ClosingButton = new System.Windows.Forms.Button();
            this.DiamondRadioButton = new System.Windows.Forms.RadioButton();
            this.SquareRadioButton = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ReplicateRadioButton = new System.Windows.Forms.RadioButton();
            this.ReflectRadioButton = new System.Windows.Forms.RadioButton();
            this.IsolatedRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NxMGroupBox = new System.Windows.Forms.GroupBox();
            this.RadioButton3X3 = new System.Windows.Forms.RadioButton();
            this.RadioButton5X5 = new System.Windows.Forms.RadioButton();
            this.RadioButton7X7 = new System.Windows.Forms.RadioButton();
            this.MorfologicalChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SkeletonButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MorfologicalPictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.NxMGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MorfologicalChart)).BeginInit();
            this.SuspendLayout();
            // 
            // MorfologicalPictureBox
            // 
            this.MorfologicalPictureBox.Location = new System.Drawing.Point(337, 27);
            this.MorfologicalPictureBox.Name = "MorfologicalPictureBox";
            this.MorfologicalPictureBox.Size = new System.Drawing.Size(501, 309);
            this.MorfologicalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MorfologicalPictureBox.TabIndex = 0;
            this.MorfologicalPictureBox.TabStop = false;
            // 
            // ErodeButton
            // 
            this.ErodeButton.Location = new System.Drawing.Point(21, 15);
            this.ErodeButton.Name = "ErodeButton";
            this.ErodeButton.Size = new System.Drawing.Size(144, 39);
            this.ErodeButton.TabIndex = 1;
            this.ErodeButton.Text = "Erode";
            this.ErodeButton.UseVisualStyleBackColor = true;
            this.ErodeButton.Click += new System.EventHandler(this.ErodeButton_Click);
            // 
            // DilateButton
            // 
            this.DilateButton.Location = new System.Drawing.Point(21, 60);
            this.DilateButton.Name = "DilateButton";
            this.DilateButton.Size = new System.Drawing.Size(144, 39);
            this.DilateButton.TabIndex = 2;
            this.DilateButton.Text = "Dilate";
            this.DilateButton.UseVisualStyleBackColor = true;
            this.DilateButton.Click += new System.EventHandler(this.DilateButton_Click);
            // 
            // OpeningButton
            // 
            this.OpeningButton.Location = new System.Drawing.Point(21, 105);
            this.OpeningButton.Name = "OpeningButton";
            this.OpeningButton.Size = new System.Drawing.Size(144, 39);
            this.OpeningButton.TabIndex = 3;
            this.OpeningButton.Text = "Opening";
            this.OpeningButton.UseVisualStyleBackColor = true;
            this.OpeningButton.Click += new System.EventHandler(this.OpeningButton_Click);
            // 
            // ClosingButton
            // 
            this.ClosingButton.Location = new System.Drawing.Point(21, 150);
            this.ClosingButton.Name = "ClosingButton";
            this.ClosingButton.Size = new System.Drawing.Size(144, 39);
            this.ClosingButton.TabIndex = 4;
            this.ClosingButton.Text = "Closing";
            this.ClosingButton.UseVisualStyleBackColor = true;
            this.ClosingButton.Click += new System.EventHandler(this.ClosingButton_Click);
            // 
            // DiamondRadioButton
            // 
            this.DiamondRadioButton.AutoSize = true;
            this.DiamondRadioButton.Location = new System.Drawing.Point(21, 210);
            this.DiamondRadioButton.Name = "DiamondRadioButton";
            this.DiamondRadioButton.Size = new System.Drawing.Size(65, 17);
            this.DiamondRadioButton.TabIndex = 5;
            this.DiamondRadioButton.TabStop = true;
            this.DiamondRadioButton.Text = "diamond";
            this.DiamondRadioButton.UseVisualStyleBackColor = true;
            this.DiamondRadioButton.CheckedChanged += new System.EventHandler(this.DiamondRadioButton_CheckedChanged);
            // 
            // SquareRadioButton
            // 
            this.SquareRadioButton.AutoSize = true;
            this.SquareRadioButton.Checked = true;
            this.SquareRadioButton.Location = new System.Drawing.Point(108, 210);
            this.SquareRadioButton.Name = "SquareRadioButton";
            this.SquareRadioButton.Size = new System.Drawing.Size(57, 17);
            this.SquareRadioButton.TabIndex = 6;
            this.SquareRadioButton.TabStop = true;
            this.SquareRadioButton.Text = "square";
            this.SquareRadioButton.UseVisualStyleBackColor = true;
            this.SquareRadioButton.CheckedChanged += new System.EventHandler(this.SquareRadioButton_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1272, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ReplicateRadioButton);
            this.groupBox2.Controls.Add(this.ReflectRadioButton);
            this.groupBox2.Controls.Add(this.IsolatedRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(127, 89);
            this.groupBox2.TabIndex = 68;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edge Pixel Values";
            // 
            // ReplicateRadioButton
            // 
            this.ReplicateRadioButton.AutoSize = true;
            this.ReplicateRadioButton.Location = new System.Drawing.Point(10, 59);
            this.ReplicateRadioButton.Name = "ReplicateRadioButton";
            this.ReplicateRadioButton.Size = new System.Drawing.Size(70, 17);
            this.ReplicateRadioButton.TabIndex = 2;
            this.ReplicateRadioButton.TabStop = true;
            this.ReplicateRadioButton.Text = "Replicate";
            this.ReplicateRadioButton.UseVisualStyleBackColor = true;
            this.ReplicateRadioButton.CheckedChanged += new System.EventHandler(this.ReplicateRadioButton_CheckedChanged);
            // 
            // ReflectRadioButton
            // 
            this.ReflectRadioButton.AutoSize = true;
            this.ReflectRadioButton.Location = new System.Drawing.Point(10, 40);
            this.ReflectRadioButton.Name = "ReflectRadioButton";
            this.ReflectRadioButton.Size = new System.Drawing.Size(59, 17);
            this.ReflectRadioButton.TabIndex = 1;
            this.ReflectRadioButton.TabStop = true;
            this.ReflectRadioButton.Text = "Reflect";
            this.ReflectRadioButton.UseVisualStyleBackColor = true;
            this.ReflectRadioButton.CheckedChanged += new System.EventHandler(this.ReflectRadioButton_CheckedChanged);
            // 
            // IsolatedRadioButton
            // 
            this.IsolatedRadioButton.AutoSize = true;
            this.IsolatedRadioButton.Location = new System.Drawing.Point(10, 20);
            this.IsolatedRadioButton.Name = "IsolatedRadioButton";
            this.IsolatedRadioButton.Size = new System.Drawing.Size(62, 17);
            this.IsolatedRadioButton.TabIndex = 0;
            this.IsolatedRadioButton.TabStop = true;
            this.IsolatedRadioButton.Text = "Isolated";
            this.IsolatedRadioButton.UseVisualStyleBackColor = true;
            this.IsolatedRadioButton.CheckedChanged += new System.EventHandler(this.IsolatedRadioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NxMGroupBox);
            this.groupBox1.Controls.Add(this.SquareRadioButton);
            this.groupBox1.Controls.Add(this.DiamondRadioButton);
            this.groupBox1.Controls.Add(this.ClosingButton);
            this.groupBox1.Controls.Add(this.OpeningButton);
            this.groupBox1.Controls.Add(this.DilateButton);
            this.groupBox1.Controls.Add(this.ErodeButton);
            this.groupBox1.Location = new System.Drawing.Point(145, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 309);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operations";
            // 
            // NxMGroupBox
            // 
            this.NxMGroupBox.Controls.Add(this.RadioButton3X3);
            this.NxMGroupBox.Controls.Add(this.RadioButton5X5);
            this.NxMGroupBox.Controls.Add(this.RadioButton7X7);
            this.NxMGroupBox.Location = new System.Drawing.Point(21, 233);
            this.NxMGroupBox.Name = "NxMGroupBox";
            this.NxMGroupBox.Size = new System.Drawing.Size(144, 52);
            this.NxMGroupBox.TabIndex = 70;
            this.NxMGroupBox.TabStop = false;
            // 
            // RadioButton3X3
            // 
            this.RadioButton3X3.AutoSize = true;
            this.RadioButton3X3.Checked = true;
            this.RadioButton3X3.Location = new System.Drawing.Point(6, 19);
            this.RadioButton3X3.Name = "RadioButton3X3";
            this.RadioButton3X3.Size = new System.Drawing.Size(42, 17);
            this.RadioButton3X3.TabIndex = 49;
            this.RadioButton3X3.TabStop = true;
            this.RadioButton3X3.Text = "3x3";
            this.RadioButton3X3.UseVisualStyleBackColor = true;
            this.RadioButton3X3.CheckedChanged += new System.EventHandler(this.RadioButton3X3_CheckedChanged);
            // 
            // RadioButton5X5
            // 
            this.RadioButton5X5.AutoSize = true;
            this.RadioButton5X5.Location = new System.Drawing.Point(48, 19);
            this.RadioButton5X5.Name = "RadioButton5X5";
            this.RadioButton5X5.Size = new System.Drawing.Size(42, 17);
            this.RadioButton5X5.TabIndex = 50;
            this.RadioButton5X5.Text = "5x5";
            this.RadioButton5X5.UseVisualStyleBackColor = true;
            this.RadioButton5X5.CheckedChanged += new System.EventHandler(this.RadioButton5X5_CheckedChanged);
            // 
            // RadioButton7X7
            // 
            this.RadioButton7X7.AutoSize = true;
            this.RadioButton7X7.Location = new System.Drawing.Point(96, 19);
            this.RadioButton7X7.Name = "RadioButton7X7";
            this.RadioButton7X7.Size = new System.Drawing.Size(42, 17);
            this.RadioButton7X7.TabIndex = 51;
            this.RadioButton7X7.Text = "7x7";
            this.RadioButton7X7.UseVisualStyleBackColor = true;
            this.RadioButton7X7.CheckedChanged += new System.EventHandler(this.RadioButton7X7_CheckedChanged);
            // 
            // MorfologicalChart
            // 
            chartArea2.Name = "ChartArea1";
            this.MorfologicalChart.ChartAreas.Add(chartArea2);
            this.MorfologicalChart.Location = new System.Drawing.Point(844, 27);
            this.MorfologicalChart.Name = "MorfologicalChart";
            this.MorfologicalChart.Size = new System.Drawing.Size(416, 309);
            this.MorfologicalChart.TabIndex = 70;
            this.MorfologicalChart.Text = "chart1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.imageToolStripMenuItem,
            this.histogramToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imageToolStripMenuItem.Text = "Image";
            this.imageToolStripMenuItem.Click += new System.EventHandler(this.imageToolStripMenuItem_Click);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.histogramToolStripMenuItem.Text = "Histogram";
            this.histogramToolStripMenuItem.Click += new System.EventHandler(this.histogramToolStripMenuItem_Click);
            // 
            // SkeletonButton
            // 
            this.SkeletonButton.Location = new System.Drawing.Point(12, 132);
            this.SkeletonButton.Name = "SkeletonButton";
            this.SkeletonButton.Size = new System.Drawing.Size(127, 39);
            this.SkeletonButton.TabIndex = 71;
            this.SkeletonButton.Text = "Skeleton";
            this.SkeletonButton.UseVisualStyleBackColor = true;
            this.SkeletonButton.Click += new System.EventHandler(this.SkeletonButton_Click);
            // 
            // MorphologicalOperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 354);
            this.Controls.Add(this.SkeletonButton);
            this.Controls.Add(this.MorfologicalChart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.MorfologicalPictureBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MorphologicalOperationsForm";
            this.Text = "MorphologicalOperationsForm";
            ((System.ComponentModel.ISupportInitialize)(this.MorfologicalPictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.NxMGroupBox.ResumeLayout(false);
            this.NxMGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MorfologicalChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MorfologicalPictureBox;
        private System.Windows.Forms.Button ErodeButton;
        private System.Windows.Forms.Button DilateButton;
        private System.Windows.Forms.Button OpeningButton;
        private System.Windows.Forms.Button ClosingButton;
        private System.Windows.Forms.RadioButton DiamondRadioButton;
        private System.Windows.Forms.RadioButton SquareRadioButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton ReplicateRadioButton;
        private System.Windows.Forms.RadioButton ReflectRadioButton;
        private System.Windows.Forms.RadioButton IsolatedRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox NxMGroupBox;
        private System.Windows.Forms.RadioButton RadioButton3X3;
        private System.Windows.Forms.RadioButton RadioButton5X5;
        private System.Windows.Forms.RadioButton RadioButton7X7;
        private System.Windows.Forms.DataVisualization.Charting.Chart MorfologicalChart;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.Button SkeletonButton;
    }
}