namespace APO
{
    partial class SegmentationForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.PbSegmentation = new System.Windows.Forms.PictureBox();
            this.ChartSegmentation = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BtnThreshold = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpDownTreshold = new System.Windows.Forms.NumericUpDown();
            this.BtnAdaptiveThreshold = new System.Windows.Forms.Button();
            this.BtnOtsu = new System.Windows.Forms.Button();
            this.BtnWatershed = new System.Windows.Forms.Button();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.PbSegmentation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartSegmentation)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownTreshold)).BeginInit();
            this.SuspendLayout();
            // 
            // PbSegmentation
            // 
            this.PbSegmentation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PbSegmentation.Location = new System.Drawing.Point(215, 27);
            this.PbSegmentation.Name = "PbSegmentation";
            this.PbSegmentation.Size = new System.Drawing.Size(520, 320);
            this.PbSegmentation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbSegmentation.TabIndex = 0;
            this.PbSegmentation.TabStop = false;
            // 
            // ChartSegmentation
            // 
            this.ChartSegmentation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.ChartSegmentation.ChartAreas.Add(chartArea3);
            this.ChartSegmentation.Location = new System.Drawing.Point(741, 27);
            this.ChartSegmentation.Name = "ChartSegmentation";
            series3.ChartArea = "ChartArea1";
            series3.Name = "Series1";
            this.ChartSegmentation.Series.Add(series3);
            this.ChartSegmentation.Size = new System.Drawing.Size(493, 320);
            this.ChartSegmentation.TabIndex = 1;
            this.ChartSegmentation.Text = "chart1";
            // 
            // BtnThreshold
            // 
            this.BtnThreshold.Location = new System.Drawing.Point(21, 27);
            this.BtnThreshold.Name = "BtnThreshold";
            this.BtnThreshold.Size = new System.Drawing.Size(89, 36);
            this.BtnThreshold.TabIndex = 2;
            this.BtnThreshold.Text = "Threshold";
            this.BtnThreshold.UseVisualStyleBackColor = true;
            this.BtnThreshold.Click += new System.EventHandler(this.BtnTreshold_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1237, 24);
            this.menuStrip1.TabIndex = 3;
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
            // UpDownTreshold
            // 
            this.UpDownTreshold.Location = new System.Drawing.Point(133, 37);
            this.UpDownTreshold.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.UpDownTreshold.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UpDownTreshold.Name = "UpDownTreshold";
            this.UpDownTreshold.Size = new System.Drawing.Size(55, 20);
            this.UpDownTreshold.TabIndex = 4;
            this.UpDownTreshold.Value = new decimal(new int[] {
            126,
            0,
            0,
            0});
            // 
            // BtnAdaptiveThreshold
            // 
            this.BtnAdaptiveThreshold.Location = new System.Drawing.Point(21, 80);
            this.BtnAdaptiveThreshold.Name = "BtnAdaptiveThreshold";
            this.BtnAdaptiveThreshold.Size = new System.Drawing.Size(89, 36);
            this.BtnAdaptiveThreshold.TabIndex = 5;
            this.BtnAdaptiveThreshold.Text = "Adaptive Threshold";
            this.BtnAdaptiveThreshold.UseVisualStyleBackColor = true;
            this.BtnAdaptiveThreshold.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnOtsu
            // 
            this.BtnOtsu.Location = new System.Drawing.Point(116, 80);
            this.BtnOtsu.Name = "BtnOtsu";
            this.BtnOtsu.Size = new System.Drawing.Size(72, 36);
            this.BtnOtsu.TabIndex = 6;
            this.BtnOtsu.Text = "Otsu";
            this.BtnOtsu.UseVisualStyleBackColor = true;
            this.BtnOtsu.Click += new System.EventHandler(this.BtnOtsu_Click);
            // 
            // BtnWatershed
            // 
            this.BtnWatershed.Location = new System.Drawing.Point(21, 135);
            this.BtnWatershed.Name = "BtnWatershed";
            this.BtnWatershed.Size = new System.Drawing.Size(89, 36);
            this.BtnWatershed.TabIndex = 7;
            this.BtnWatershed.Text = "Watershed";
            this.BtnWatershed.UseVisualStyleBackColor = true;
            this.BtnWatershed.Visible = false;
            this.BtnWatershed.Click += new System.EventHandler(this.BtnWatershed_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageToolStripMenuItem,
            this.histogramToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
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
            // SegmentationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 371);
            this.Controls.Add(this.BtnWatershed);
            this.Controls.Add(this.BtnOtsu);
            this.Controls.Add(this.BtnAdaptiveThreshold);
            this.Controls.Add(this.UpDownTreshold);
            this.Controls.Add(this.BtnThreshold);
            this.Controls.Add(this.ChartSegmentation);
            this.Controls.Add(this.PbSegmentation);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SegmentationForm";
            this.Text = "SegmentationForm";
            ((System.ComponentModel.ISupportInitialize)(this.PbSegmentation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartSegmentation)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownTreshold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbSegmentation;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartSegmentation;
        private System.Windows.Forms.Button BtnThreshold;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.NumericUpDown UpDownTreshold;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Button BtnAdaptiveThreshold;
        private System.Windows.Forms.Button BtnOtsu;
        private System.Windows.Forms.Button BtnWatershed;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
    }
}