namespace APO
{
    partial class PictureWindow
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GreyHistogramMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RGBHistogramMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.DuplicateMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neighborhoodOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.PictureWindowChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.StretchButton = new System.Windows.Forms.Button();
            this.EqualButton = new System.Windows.Forms.Button();
            this.PixelsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NegationButton = new System.Windows.Forms.Button();
            this.ThresholdingButton = new System.Windows.Forms.Button();
            this.P1TextBox = new System.Windows.Forms.TextBox();
            this.DiffrentThresholdingButton = new System.Windows.Forms.Button();
            this.P2TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ReductionButton = new System.Windows.Forms.Button();
            this.GrayLevelsUpDown = new System.Windows.Forms.NumericUpDown();
            this.SelectiveEqualizationButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureWindowChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrayLevelsUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.histogramToolStripMenuItem,
            this.DuplicateMenuStripItem,
            this.neighborhoodOperationsToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1286, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GreyHistogramMenuStripItem,
            this.RGBHistogramMenuStrip});
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.histogramToolStripMenuItem.Text = "Histogram";
            // 
            // GreyHistogramMenuStripItem
            // 
            this.GreyHistogramMenuStripItem.Name = "GreyHistogramMenuStripItem";
            this.GreyHistogramMenuStripItem.Size = new System.Drawing.Size(98, 22);
            this.GreyHistogramMenuStripItem.Text = "Gray";
            this.GreyHistogramMenuStripItem.Click += new System.EventHandler(this.GreyHistogramMenuStripItem_Click);
            // 
            // RGBHistogramMenuStrip
            // 
            this.RGBHistogramMenuStrip.Name = "RGBHistogramMenuStrip";
            this.RGBHistogramMenuStrip.Size = new System.Drawing.Size(98, 22);
            this.RGBHistogramMenuStrip.Text = "RGB";
            this.RGBHistogramMenuStrip.Click += new System.EventHandler(this.AllinOneMenuStripItem_Click);
            // 
            // DuplicateMenuStripItem
            // 
            this.DuplicateMenuStripItem.Name = "DuplicateMenuStripItem";
            this.DuplicateMenuStripItem.Size = new System.Drawing.Size(69, 20);
            this.DuplicateMenuStripItem.Text = "Duplicate";
            this.DuplicateMenuStripItem.Click += new System.EventHandler(this.DuplicateMenuStripItem_Click);
            // 
            // neighborhoodOperationsToolStripMenuItem
            // 
            this.neighborhoodOperationsToolStripMenuItem.Name = "neighborhoodOperationsToolStripMenuItem";
            this.neighborhoodOperationsToolStripMenuItem.Size = new System.Drawing.Size(158, 20);
            this.neighborhoodOperationsToolStripMenuItem.Text = "Neighborhood Operations";
            this.neighborhoodOperationsToolStripMenuItem.Click += new System.EventHandler(this.neighborhoodOperationsToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageToolStripMenuItem,
            this.histogramToolStripMenuItem1});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.imageToolStripMenuItem.Text = "Image";
            this.imageToolStripMenuItem.Click += new System.EventHandler(this.imageToolStripMenuItem_Click);
            // 
            // histogramToolStripMenuItem1
            // 
            this.histogramToolStripMenuItem1.Enabled = false;
            this.histogramToolStripMenuItem1.Name = "histogramToolStripMenuItem1";
            this.histogramToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.histogramToolStripMenuItem1.Text = "Histogram";
            this.histogramToolStripMenuItem1.Click += new System.EventHandler(this.saveHistogramAsPictureToolStripMenuItem_Click);
            // 
            // PictureBox
            // 
            this.PictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox.Location = new System.Drawing.Point(12, 27);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PictureBox.Size = new System.Drawing.Size(631, 548);
            this.PictureBox.TabIndex = 1;
            this.PictureBox.TabStop = false;
            // 
            // PictureWindowChart
            // 
            this.PictureWindowChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.PictureWindowChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.PictureWindowChart.Legends.Add(legend1);
            this.PictureWindowChart.Location = new System.Drawing.Point(649, 27);
            this.PictureWindowChart.Name = "PictureWindowChart";
            this.PictureWindowChart.Size = new System.Drawing.Size(625, 300);
            this.PictureWindowChart.TabIndex = 2;
            this.PictureWindowChart.Text = "chart1";
            // 
            // StretchButton
            // 
            this.StretchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StretchButton.Enabled = false;
            this.StretchButton.Location = new System.Drawing.Point(650, 333);
            this.StretchButton.Name = "StretchButton";
            this.StretchButton.Size = new System.Drawing.Size(100, 35);
            this.StretchButton.TabIndex = 3;
            this.StretchButton.Text = "Stretch";
            this.StretchButton.UseVisualStyleBackColor = true;
            this.StretchButton.Click += new System.EventHandler(this.StretchButton_Click);
            // 
            // EqualButton
            // 
            this.EqualButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EqualButton.Enabled = false;
            this.EqualButton.Location = new System.Drawing.Point(755, 333);
            this.EqualButton.Name = "EqualButton";
            this.EqualButton.Size = new System.Drawing.Size(100, 35);
            this.EqualButton.TabIndex = 4;
            this.EqualButton.Text = "Equalization";
            this.EqualButton.UseVisualStyleBackColor = true;
            this.EqualButton.Click += new System.EventHandler(this.EqualButton_Click);
            // 
            // PixelsTextBox
            // 
            this.PixelsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PixelsTextBox.Enabled = false;
            this.PixelsTextBox.Location = new System.Drawing.Point(1174, 333);
            this.PixelsTextBox.Multiline = true;
            this.PixelsTextBox.Name = "PixelsTextBox";
            this.PixelsTextBox.Size = new System.Drawing.Size(100, 19);
            this.PixelsTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1132, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "pixels:";
            // 
            // NegationButton
            // 
            this.NegationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NegationButton.Location = new System.Drawing.Point(650, 398);
            this.NegationButton.Name = "NegationButton";
            this.NegationButton.Size = new System.Drawing.Size(100, 35);
            this.NegationButton.TabIndex = 8;
            this.NegationButton.Text = "Negation";
            this.NegationButton.UseVisualStyleBackColor = true;
            this.NegationButton.Click += new System.EventHandler(this.NegationButton_Click);
            // 
            // ThresholdingButton
            // 
            this.ThresholdingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ThresholdingButton.Location = new System.Drawing.Point(650, 480);
            this.ThresholdingButton.Name = "ThresholdingButton";
            this.ThresholdingButton.Size = new System.Drawing.Size(100, 35);
            this.ThresholdingButton.TabIndex = 9;
            this.ThresholdingButton.Text = "Thresholding";
            this.ThresholdingButton.UseVisualStyleBackColor = true;
            this.ThresholdingButton.Click += new System.EventHandler(this.ThresholdingButton_Click);
            // 
            // P1TextBox
            // 
            this.P1TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.P1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.P1TextBox.Location = new System.Drawing.Point(784, 488);
            this.P1TextBox.Multiline = true;
            this.P1TextBox.Name = "P1TextBox";
            this.P1TextBox.Size = new System.Drawing.Size(73, 16);
            this.P1TextBox.TabIndex = 10;
            this.P1TextBox.Text = "128";
            // 
            // DiffrentThresholdingButton
            // 
            this.DiffrentThresholdingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DiffrentThresholdingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DiffrentThresholdingButton.Location = new System.Drawing.Point(649, 521);
            this.DiffrentThresholdingButton.Name = "DiffrentThresholdingButton";
            this.DiffrentThresholdingButton.Size = new System.Drawing.Size(100, 54);
            this.DiffrentThresholdingButton.TabIndex = 11;
            this.DiffrentThresholdingButton.Text = "Thresholding while maintaining gray levels";
            this.DiffrentThresholdingButton.UseVisualStyleBackColor = true;
            this.DiffrentThresholdingButton.Click += new System.EventHandler(this.DiffrentThresholdingButton_Click);
            // 
            // P2TextBox
            // 
            this.P2TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.P2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.P2TextBox.Location = new System.Drawing.Point(784, 539);
            this.P2TextBox.Multiline = true;
            this.P2TextBox.Name = "P2TextBox";
            this.P2TextBox.Size = new System.Drawing.Size(73, 16);
            this.P2TextBox.TabIndex = 12;
            this.P2TextBox.Text = "128";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(756, 489);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "p1:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(756, 540);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "p2:";
            // 
            // ReductionButton
            // 
            this.ReductionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ReductionButton.Location = new System.Drawing.Point(649, 439);
            this.ReductionButton.Name = "ReductionButton";
            this.ReductionButton.Size = new System.Drawing.Size(100, 35);
            this.ReductionButton.TabIndex = 15;
            this.ReductionButton.Text = "Gray levels reduction";
            this.ReductionButton.UseVisualStyleBackColor = true;
            this.ReductionButton.Click += new System.EventHandler(this.ReductionButton_Click);
            // 
            // GrayLevelsUpDown
            // 
            this.GrayLevelsUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GrayLevelsUpDown.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.GrayLevelsUpDown.Location = new System.Drawing.Point(782, 448);
            this.GrayLevelsUpDown.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.GrayLevelsUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.GrayLevelsUpDown.Name = "GrayLevelsUpDown";
            this.GrayLevelsUpDown.ReadOnly = true;
            this.GrayLevelsUpDown.Size = new System.Drawing.Size(75, 20);
            this.GrayLevelsUpDown.TabIndex = 16;
            this.GrayLevelsUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // SelectiveEqualizationButton
            // 
            this.SelectiveEqualizationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectiveEqualizationButton.Enabled = false;
            this.SelectiveEqualizationButton.Location = new System.Drawing.Point(861, 333);
            this.SelectiveEqualizationButton.Name = "SelectiveEqualizationButton";
            this.SelectiveEqualizationButton.Size = new System.Drawing.Size(100, 35);
            this.SelectiveEqualizationButton.TabIndex = 17;
            this.SelectiveEqualizationButton.Text = "Selective Equalization";
            this.SelectiveEqualizationButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SelectiveEqualizationButton.UseVisualStyleBackColor = true;
            this.SelectiveEqualizationButton.Click += new System.EventHandler(this.SelectiveEqualizationButton_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(756, 450);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "n:";
            // 
            // RefreshButton
            // 
            this.RefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshButton.Location = new System.Drawing.Point(1174, 540);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(100, 35);
            this.RefreshButton.TabIndex = 19;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // PictureWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1286, 587);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SelectiveEqualizationButton);
            this.Controls.Add(this.GrayLevelsUpDown);
            this.Controls.Add(this.ReductionButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.P2TextBox);
            this.Controls.Add(this.DiffrentThresholdingButton);
            this.Controls.Add(this.P1TextBox);
            this.Controls.Add(this.ThresholdingButton);
            this.Controls.Add(this.NegationButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PixelsTextBox);
            this.Controls.Add(this.EqualButton);
            this.Controls.Add(this.StretchButton);
            this.Controls.Add(this.PictureWindowChart);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PictureWindow";
            this.Text = "PictureWindow";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureWindowChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrayLevelsUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GreyHistogramMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem RGBHistogramMenuStrip;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.ToolStripMenuItem DuplicateMenuStripItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart PictureWindowChart;
        private System.Windows.Forms.Button StretchButton;
        private System.Windows.Forms.Button EqualButton;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem1;
        private System.Windows.Forms.TextBox PixelsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NegationButton;
        private System.Windows.Forms.Button ThresholdingButton;
        private System.Windows.Forms.TextBox P1TextBox;
        private System.Windows.Forms.Button DiffrentThresholdingButton;
        private System.Windows.Forms.TextBox P2TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ReductionButton;
        private System.Windows.Forms.NumericUpDown GrayLevelsUpDown;
        private System.Windows.Forms.Button SelectiveEqualizationButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.ToolStripMenuItem neighborhoodOperationsToolStripMenuItem;
    }
}