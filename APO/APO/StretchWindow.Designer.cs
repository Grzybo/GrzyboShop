namespace APO
{
    partial class StretchWindow
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
            this.StretchWindowPictureBox = new System.Windows.Forms.PictureBox();
            this.StretchWindowChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TrackBarMin = new System.Windows.Forms.TrackBar();
            this.TrackBarMinValueTextBox = new System.Windows.Forms.TextBox();
            this.TrackBarMaxValueTextBox = new System.Windows.Forms.TextBox();
            this.TrackBarMax = new System.Windows.Forms.TrackBar();
            this.CalculateStrechButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RestoreDefaultImageButton = new System.Windows.Forms.Button();
            this.DoneButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.StretchWindowPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StretchWindowChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarMax)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StretchWindowPictureBox
            // 
            this.StretchWindowPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StretchWindowPictureBox.Location = new System.Drawing.Point(12, 27);
            this.StretchWindowPictureBox.Name = "StretchWindowPictureBox";
            this.StretchWindowPictureBox.Size = new System.Drawing.Size(482, 300);
            this.StretchWindowPictureBox.TabIndex = 0;
            this.StretchWindowPictureBox.TabStop = false;
            // 
            // StretchWindowChart
            // 
            this.StretchWindowChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.StretchWindowChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.StretchWindowChart.Legends.Add(legend1);
            this.StretchWindowChart.Location = new System.Drawing.Point(500, 27);
            this.StretchWindowChart.Name = "StretchWindowChart";
            this.StretchWindowChart.Size = new System.Drawing.Size(509, 300);
            this.StretchWindowChart.TabIndex = 1;
            this.StretchWindowChart.Text = "chart1";
            // 
            // TrackBarMin
            // 
            this.TrackBarMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TrackBarMin.Location = new System.Drawing.Point(261, 333);
            this.TrackBarMin.Maximum = 256;
            this.TrackBarMin.Name = "TrackBarMin";
            this.TrackBarMin.Size = new System.Drawing.Size(505, 45);
            this.TrackBarMin.TabIndex = 2;
            this.TrackBarMin.ValueChanged += new System.EventHandler(this.TrackBarMin_ValueChanged);
            // 
            // TrackBarMinValueTextBox
            // 
            this.TrackBarMinValueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TrackBarMinValueTextBox.Enabled = false;
            this.TrackBarMinValueTextBox.Location = new System.Drawing.Point(772, 340);
            this.TrackBarMinValueTextBox.Name = "TrackBarMinValueTextBox";
            this.TrackBarMinValueTextBox.Size = new System.Drawing.Size(98, 20);
            this.TrackBarMinValueTextBox.TabIndex = 3;
            this.TrackBarMinValueTextBox.Text = "0";
            // 
            // TrackBarMaxValueTextBox
            // 
            this.TrackBarMaxValueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TrackBarMaxValueTextBox.Enabled = false;
            this.TrackBarMaxValueTextBox.Location = new System.Drawing.Point(772, 379);
            this.TrackBarMaxValueTextBox.Name = "TrackBarMaxValueTextBox";
            this.TrackBarMaxValueTextBox.Size = new System.Drawing.Size(98, 20);
            this.TrackBarMaxValueTextBox.TabIndex = 5;
            this.TrackBarMaxValueTextBox.Text = "255";
            // 
            // TrackBarMax
            // 
            this.TrackBarMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TrackBarMax.Location = new System.Drawing.Point(261, 377);
            this.TrackBarMax.Maximum = 255;
            this.TrackBarMax.Minimum = 1;
            this.TrackBarMax.Name = "TrackBarMax";
            this.TrackBarMax.Size = new System.Drawing.Size(505, 45);
            this.TrackBarMax.TabIndex = 4;
            this.TrackBarMax.Value = 255;
            this.TrackBarMax.ValueChanged += new System.EventHandler(this.TrackBarMax_ValueChanged);
            // 
            // CalculateStrechButton
            // 
            this.CalculateStrechButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CalculateStrechButton.Location = new System.Drawing.Point(56, 333);
            this.CalculateStrechButton.Name = "CalculateStrechButton";
            this.CalculateStrechButton.Size = new System.Drawing.Size(139, 27);
            this.CalculateStrechButton.TabIndex = 6;
            this.CalculateStrechButton.Text = "Strech";
            this.CalculateStrechButton.UseVisualStyleBackColor = true;
            this.CalculateStrechButton.Click += new System.EventHandler(this.CalculateStrechButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(876, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Min Value";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(876, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Max Value";
            // 
            // RestoreDefaultImageButton
            // 
            this.RestoreDefaultImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RestoreDefaultImageButton.Location = new System.Drawing.Point(56, 366);
            this.RestoreDefaultImageButton.Name = "RestoreDefaultImageButton";
            this.RestoreDefaultImageButton.Size = new System.Drawing.Size(139, 27);
            this.RestoreDefaultImageButton.TabIndex = 9;
            this.RestoreDefaultImageButton.Text = "Restore Default Image";
            this.RestoreDefaultImageButton.UseVisualStyleBackColor = true;
            this.RestoreDefaultImageButton.Click += new System.EventHandler(this.RestoreDefaultImageButton_Click);
            // 
            // DoneButton
            // 
            this.DoneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DoneButton.Location = new System.Drawing.Point(56, 399);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(139, 27);
            this.DoneButton.TabIndex = 10;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1021, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageToolStripMenuItem,
            this.histogramToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.saveToolStripMenuItem.Text = "Save...";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.imageToolStripMenuItem.Text = "Image";
            this.imageToolStripMenuItem.Click += new System.EventHandler(this.imageToolStripMenuItem_Click);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.histogramToolStripMenuItem.Text = "Histogram";
            this.histogramToolStripMenuItem.Click += new System.EventHandler(this.histogramToolStripMenuItem_Click);
            // 
            // StretchWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 434);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.RestoreDefaultImageButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalculateStrechButton);
            this.Controls.Add(this.TrackBarMaxValueTextBox);
            this.Controls.Add(this.TrackBarMax);
            this.Controls.Add(this.TrackBarMinValueTextBox);
            this.Controls.Add(this.TrackBarMin);
            this.Controls.Add(this.StretchWindowChart);
            this.Controls.Add(this.StretchWindowPictureBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StretchWindow";
            this.Text = "StretchWindow";
            ((System.ComponentModel.ISupportInitialize)(this.StretchWindowPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StretchWindowChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarMax)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox StretchWindowPictureBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart StretchWindowChart;
        private System.Windows.Forms.TrackBar TrackBarMin;
        private System.Windows.Forms.TextBox TrackBarMinValueTextBox;
        private System.Windows.Forms.TextBox TrackBarMaxValueTextBox;
        private System.Windows.Forms.TrackBar TrackBarMax;
        private System.Windows.Forms.Button CalculateStrechButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RestoreDefaultImageButton;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
    }
}