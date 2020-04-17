namespace APO
{
    partial class BinaryOperationsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.ImageA_PictureBox = new System.Windows.Forms.PictureBox();
            this.ImageB_PictureBox = new System.Windows.Forms.PictureBox();
            this.ResultImagePictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OperationsGroupBox = new System.Windows.Forms.GroupBox();
            this.XorRadioButton = new System.Windows.Forms.RadioButton();
            this.OrRadioButton = new System.Windows.Forms.RadioButton();
            this.AndRadioButton = new System.Windows.Forms.RadioButton();
            this.BlendRadioButton = new System.Windows.Forms.RadioButton();
            this.AddRadioButton = new System.Windows.Forms.RadioButton();
            this.ImageA_Label = new System.Windows.Forms.Label();
            this.ImageB_Label = new System.Windows.Forms.Label();
            this.BinaryOperationsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ImageB_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ImageA_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.NotRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.ImageA_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageB_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultImagePictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.OperationsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BinaryOperationsChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageB_Chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageA_Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageA_PictureBox
            // 
            this.ImageA_PictureBox.Location = new System.Drawing.Point(12, 27);
            this.ImageA_PictureBox.Name = "ImageA_PictureBox";
            this.ImageA_PictureBox.Size = new System.Drawing.Size(361, 249);
            this.ImageA_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageA_PictureBox.TabIndex = 0;
            this.ImageA_PictureBox.TabStop = false;
            // 
            // ImageB_PictureBox
            // 
            this.ImageB_PictureBox.Location = new System.Drawing.Point(458, 27);
            this.ImageB_PictureBox.Name = "ImageB_PictureBox";
            this.ImageB_PictureBox.Size = new System.Drawing.Size(361, 249);
            this.ImageB_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageB_PictureBox.TabIndex = 1;
            this.ImageB_PictureBox.TabStop = false;
            // 
            // ResultImagePictureBox
            // 
            this.ResultImagePictureBox.Location = new System.Drawing.Point(893, 27);
            this.ResultImagePictureBox.Name = "ResultImagePictureBox";
            this.ResultImagePictureBox.Size = new System.Drawing.Size(361, 249);
            this.ResultImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ResultImagePictureBox.TabIndex = 2;
            this.ResultImagePictureBox.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1266, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageAToolStripMenuItem,
            this.imageBToolStripMenuItem});
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.selectToolStripMenuItem.Text = "Select";
            // 
            // imageAToolStripMenuItem
            // 
            this.imageAToolStripMenuItem.Name = "imageAToolStripMenuItem";
            this.imageAToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.imageAToolStripMenuItem.Text = "Image A ";
            this.imageAToolStripMenuItem.Click += new System.EventHandler(this.imageAToolStripMenuItem_Click);
            // 
            // imageBToolStripMenuItem
            // 
            this.imageBToolStripMenuItem.Name = "imageBToolStripMenuItem";
            this.imageBToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.imageBToolStripMenuItem.Text = "Image B";
            this.imageBToolStripMenuItem.Click += new System.EventHandler(this.imageBToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageToolStripMenuItem,
            this.histogramToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.saveToolStripMenuItem.Text = "Save ";
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
            // OperationsGroupBox
            // 
            this.OperationsGroupBox.Controls.Add(this.NotRadioButton);
            this.OperationsGroupBox.Controls.Add(this.XorRadioButton);
            this.OperationsGroupBox.Controls.Add(this.OrRadioButton);
            this.OperationsGroupBox.Controls.Add(this.AndRadioButton);
            this.OperationsGroupBox.Controls.Add(this.BlendRadioButton);
            this.OperationsGroupBox.Controls.Add(this.AddRadioButton);
            this.OperationsGroupBox.Location = new System.Drawing.Point(379, 77);
            this.OperationsGroupBox.Name = "OperationsGroupBox";
            this.OperationsGroupBox.Size = new System.Drawing.Size(73, 160);
            this.OperationsGroupBox.TabIndex = 6;
            this.OperationsGroupBox.TabStop = false;
            this.OperationsGroupBox.Text = "Operations";
            // 
            // XorRadioButton
            // 
            this.XorRadioButton.AutoSize = true;
            this.XorRadioButton.Location = new System.Drawing.Point(6, 111);
            this.XorRadioButton.Name = "XorRadioButton";
            this.XorRadioButton.Size = new System.Drawing.Size(41, 17);
            this.XorRadioButton.TabIndex = 5;
            this.XorRadioButton.TabStop = true;
            this.XorRadioButton.Text = "Xor";
            this.XorRadioButton.UseVisualStyleBackColor = true;
            // 
            // OrRadioButton
            // 
            this.OrRadioButton.AutoSize = true;
            this.OrRadioButton.Location = new System.Drawing.Point(6, 88);
            this.OrRadioButton.Name = "OrRadioButton";
            this.OrRadioButton.Size = new System.Drawing.Size(36, 17);
            this.OrRadioButton.TabIndex = 3;
            this.OrRadioButton.TabStop = true;
            this.OrRadioButton.Text = "Or";
            this.OrRadioButton.UseVisualStyleBackColor = true;
            // 
            // AndRadioButton
            // 
            this.AndRadioButton.AutoSize = true;
            this.AndRadioButton.Location = new System.Drawing.Point(6, 65);
            this.AndRadioButton.Name = "AndRadioButton";
            this.AndRadioButton.Size = new System.Drawing.Size(44, 17);
            this.AndRadioButton.TabIndex = 2;
            this.AndRadioButton.TabStop = true;
            this.AndRadioButton.Text = "And";
            this.AndRadioButton.UseVisualStyleBackColor = true;
            // 
            // BlendRadioButton
            // 
            this.BlendRadioButton.AutoSize = true;
            this.BlendRadioButton.Location = new System.Drawing.Point(6, 42);
            this.BlendRadioButton.Name = "BlendRadioButton";
            this.BlendRadioButton.Size = new System.Drawing.Size(52, 17);
            this.BlendRadioButton.TabIndex = 1;
            this.BlendRadioButton.TabStop = true;
            this.BlendRadioButton.Text = "Blend";
            this.BlendRadioButton.UseVisualStyleBackColor = true;
            // 
            // AddRadioButton
            // 
            this.AddRadioButton.AutoSize = true;
            this.AddRadioButton.Location = new System.Drawing.Point(6, 19);
            this.AddRadioButton.Name = "AddRadioButton";
            this.AddRadioButton.Size = new System.Drawing.Size(44, 17);
            this.AddRadioButton.TabIndex = 0;
            this.AddRadioButton.TabStop = true;
            this.AddRadioButton.Text = "Add";
            this.AddRadioButton.UseVisualStyleBackColor = true;
            // 
            // ImageA_Label
            // 
            this.ImageA_Label.AutoSize = true;
            this.ImageA_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ImageA_Label.Location = new System.Drawing.Point(125, 289);
            this.ImageA_Label.Name = "ImageA_Label";
            this.ImageA_Label.Size = new System.Drawing.Size(94, 26);
            this.ImageA_Label.TabIndex = 7;
            this.ImageA_Label.Text = "Image A";
            // 
            // ImageB_Label
            // 
            this.ImageB_Label.AutoSize = true;
            this.ImageB_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ImageB_Label.Location = new System.Drawing.Point(591, 289);
            this.ImageB_Label.Name = "ImageB_Label";
            this.ImageB_Label.Size = new System.Drawing.Size(94, 26);
            this.ImageB_Label.TabIndex = 8;
            this.ImageB_Label.Text = "Image B";
            // 
            // BinaryOperationsChart
            // 
            chartArea1.Name = "ChartArea1";
            this.BinaryOperationsChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.BinaryOperationsChart.Legends.Add(legend1);
            this.BinaryOperationsChart.Location = new System.Drawing.Point(893, 357);
            this.BinaryOperationsChart.Name = "BinaryOperationsChart";
            this.BinaryOperationsChart.Size = new System.Drawing.Size(361, 149);
            this.BinaryOperationsChart.TabIndex = 9;
            this.BinaryOperationsChart.Text = "chart1";
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExecuteButton.Location = new System.Drawing.Point(841, 134);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(31, 31);
            this.ExecuteButton.TabIndex = 10;
            this.ExecuteButton.Text = "=";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ResultLabel.Location = new System.Drawing.Point(1042, 289);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(74, 26);
            this.ResultLabel.TabIndex = 11;
            this.ResultLabel.Text = "Result";
            // 
            // ImageB_Chart
            // 
            chartArea2.Name = "ChartArea1";
            this.ImageB_Chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ImageB_Chart.Legends.Add(legend2);
            this.ImageB_Chart.Location = new System.Drawing.Point(458, 357);
            this.ImageB_Chart.Name = "ImageB_Chart";
            this.ImageB_Chart.Size = new System.Drawing.Size(361, 149);
            this.ImageB_Chart.TabIndex = 12;
            this.ImageB_Chart.Text = "chart1";
            // 
            // ImageA_Chart
            // 
            chartArea3.Name = "ChartArea1";
            this.ImageA_Chart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.ImageA_Chart.Legends.Add(legend3);
            this.ImageA_Chart.Location = new System.Drawing.Point(12, 357);
            this.ImageA_Chart.Name = "ImageA_Chart";
            this.ImageA_Chart.Size = new System.Drawing.Size(361, 149);
            this.ImageA_Chart.TabIndex = 13;
            this.ImageA_Chart.Text = "chart1";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // NotRadioButton
            // 
            this.NotRadioButton.AutoSize = true;
            this.NotRadioButton.Location = new System.Drawing.Point(6, 134);
            this.NotRadioButton.Name = "NotRadioButton";
            this.NotRadioButton.Size = new System.Drawing.Size(42, 17);
            this.NotRadioButton.TabIndex = 6;
            this.NotRadioButton.TabStop = true;
            this.NotRadioButton.Text = "Not";
            this.NotRadioButton.UseVisualStyleBackColor = true;
            // 
            // BinaryOperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 545);
            this.Controls.Add(this.ImageA_Chart);
            this.Controls.Add(this.ImageB_Chart);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.ExecuteButton);
            this.Controls.Add(this.BinaryOperationsChart);
            this.Controls.Add(this.ImageB_Label);
            this.Controls.Add(this.ImageA_Label);
            this.Controls.Add(this.OperationsGroupBox);
            this.Controls.Add(this.ResultImagePictureBox);
            this.Controls.Add(this.ImageB_PictureBox);
            this.Controls.Add(this.ImageA_PictureBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BinaryOperationsForm";
            this.Text = "BinaryOperationsForm";
            ((System.ComponentModel.ISupportInitialize)(this.ImageA_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageB_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultImagePictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.OperationsGroupBox.ResumeLayout(false);
            this.OperationsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BinaryOperationsChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageB_Chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageA_Chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImageA_PictureBox;
        private System.Windows.Forms.PictureBox ImageB_PictureBox;
        private System.Windows.Forms.PictureBox ResultImagePictureBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox OperationsGroupBox;
        private System.Windows.Forms.RadioButton AddRadioButton;
        private System.Windows.Forms.Label ImageA_Label;
        private System.Windows.Forms.Label ImageB_Label;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageBToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart BinaryOperationsChart;
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.RadioButton XorRadioButton;
        private System.Windows.Forms.RadioButton OrRadioButton;
        private System.Windows.Forms.RadioButton AndRadioButton;
        private System.Windows.Forms.RadioButton BlendRadioButton;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart ImageB_Chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart ImageA_Chart;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.RadioButton NotRadioButton;
    }
}