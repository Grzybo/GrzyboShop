using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;


namespace APO
{
    public partial class PictureWindow : Form
    {
        public Bitmap bitmap { get; set; }
        public Chart chart { get; set; }
        public bool gray { get; set; }
        public bool rgb { get; set; }

        public PictureWindow(Bitmap bitmap)
        {
            InitializeComponent();
            PictureBox.Image = bitmap;
            PictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureWindowChart.ChartAreas[0].AxisX.Maximum = 255;
            PictureWindowChart.ChartAreas[0].AxisX.Minimum = 0;
            
            this.bitmap = bitmap;
            gray = false;
            rgb = false;
        }

        

        private void Enableing()
        {
            histogramToolStripMenuItem1.Enabled = true;
            GreyHistogramMenuStripItem.Enabled = false;
            RGBHistogramMenuStrip.Enabled = false;
            StretchButton.Enabled = true;
            EqualButton.Enabled = true;
            SelectiveEqualizationButton.Enabled = true; 
            this.chart = PictureWindowChart;
        }

// ######################################## Histogram ###########################################################################
        private void GreyHistogramMenuStripItem_Click(object sender, EventArgs e)
        {
            
            Dictionary<Color, int> map = Tools.HistogramMap((Bitmap)PictureBox.Image);
            int[] GrayLut = Tools.HistogramLUT(map);
            int sum = 0;
            PictureWindowChart.Series.Add("Gray");
            PictureWindowChart.Series["Gray"].Color = Color.Gray;
            for (int i = 0; i < GrayLut.Length; i++)
            {
                this.PictureWindowChart.Series["Gray"].Points.AddXY(i, GrayLut[i]);
                sum += GrayLut[i];
            }

            Enableing();
            PixelsTextBox.Text = sum.ToString();
            gray = true;
        }



        private void AllinOneMenuStripItem_Click(object sender, EventArgs e)
        {
            Dictionary<Color,int> map = Tools.HistogramMap((Bitmap)PictureBox.Image);
            int[] RedLut = Tools.HistogramLUT(map,"red");
            int[] GreenLut = Tools.HistogramLUT(map,"green");
            int[] BlueLut = Tools.HistogramLUT(map,"blue");
            int sum = 0;

            PictureWindowChart.Series.Add("Red");
            PictureWindowChart.Series.Add("Blue");
            PictureWindowChart.Series.Add("Green");
            PictureWindowChart.Series["Red"].Color = Color.Red;
            PictureWindowChart.Series["Blue"].Color = Color.Blue;
            PictureWindowChart.Series["Green"].Color = Color.Green;

            for (int i = 0; i < RedLut.Length; i++)
            {
                this.PictureWindowChart.Series["Red"].Points.AddXY(i, RedLut[i]);
                this.PictureWindowChart.Series["Green"].Points.AddXY(i, GreenLut[i]);
                this.PictureWindowChart.Series["Blue"].Points.AddXY(i, BlueLut[i]);
                sum += RedLut[i];
            }

            Enableing();
            PixelsTextBox.Text = sum.ToString();
            rgb = true;
        }

// ######################################## Duplicate ###########################################################################
        private void DuplicateMenuStripItem_Click(object sender, EventArgs e)
        {
            PictureWindow pictureWindow = new PictureWindow((Bitmap)PictureBox.Image);
            pictureWindow.Size = this.Size;
            pictureWindow.Show();
        }

// ######################################## Save ###########################################################################
        private void saveHistogramAsPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog x = new SaveFileDialog();
            x.Filter = "Image Files (*.png;*.jpg)|*.png;*.jpg";
            x.FileName = "Histogram";
            x.ShowDialog();

            try { this.PictureWindowChart.SaveImage(x.FileName, ChartImageFormat.Jpeg); }
            catch { }
        }
        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog x = new SaveFileDialog();
            x.Filter = "Image Files (*.png;*.jpg)|*.png;*.jpg";
            x.FileName = "Image";
            x.ShowDialog();

            try { this.PictureBox.Image.Save(x.FileName); }
            catch { }
        }
// ######################################## Stretch ###########################################################################
        private void StretchButton_Click(object sender, EventArgs e)
        {
            StretchWindow stretchWindow = new StretchWindow(this);
            stretchWindow.Text = this.Text;
            stretchWindow.Show();
            this.Close();
        }
// ######################################## Equalization ###########################################################################
        private void EqualButton_Click(object sender, EventArgs e)
        {
            if (gray)
            {
                
                PictureBox.Image = Equalization.EqualGray((Bitmap)PictureBox.Image);
                Dictionary<Color, int> map = Tools.HistogramMap((Bitmap)PictureBox.Image);
                int[] GrayLut = Tools.HistogramLUT(map);
                PictureWindowChart.Series.Clear();
                PictureWindowChart.Series.Add("Equal");
                PictureWindowChart.Series["Equal"].Color = Color.Violet;
                for (int i = 0; i < GrayLut.Length; i++)
                {
                    this.PictureWindowChart.Series["Equal"].Points.AddXY(i, GrayLut[i]);
                }
            }
            if (rgb)
            {
                PictureBox.Image = Equalization.EqualRGB((Bitmap)PictureBox.Image);
                Dictionary<Color, int> map = Tools.HistogramMap((Bitmap)PictureBox.Image);
                int[] RedLut = Tools.HistogramLUT(map, "red");
                int[] GreenLut = Tools.HistogramLUT(map, "green");
                int[] BlueLut = Tools.HistogramLUT(map, "blue");

                PictureWindowChart.Series.Clear();
                PictureWindowChart.Series.Add("Red");
                PictureWindowChart.Series.Add("Blue");
                PictureWindowChart.Series.Add("Green");
                PictureWindowChart.Series["Red"].Color = Color.Red;
                PictureWindowChart.Series["Blue"].Color = Color.Blue;
                PictureWindowChart.Series["Green"].Color = Color.Green;

                for (int i = 0; i < RedLut.Length; i++)
                {
                    this.PictureWindowChart.Series["Red"].Points.AddXY(i, RedLut[i]);
                    this.PictureWindowChart.Series["Green"].Points.AddXY(i, GreenLut[i]);
                    this.PictureWindowChart.Series["Blue"].Points.AddXY(i, BlueLut[i]);
                }

            }
        }
        private void SelectiveEqualizationButton_Click(object sender, EventArgs e)
        {
            if (gray)
            {
                PictureBox.Image = Equalization.SelectiveEqualGray((Bitmap)PictureBox.Image);
                Dictionary<Color, int> map = Tools.HistogramMap((Bitmap)PictureBox.Image);
                int[] GrayLut = Tools.HistogramLUT(map);
                PictureWindowChart.Series.Clear();
                PictureWindowChart.Series.Add("Gray");
                PictureWindowChart.Series["Gray"].Color = Color.Violet;
                for (int i = 0; i < GrayLut.Length; i++)
                {
                    this.PictureWindowChart.Series["Gray"].Points.AddXY(i, GrayLut[i]);
                }
            }
            if (rgb)
            {
                PictureBox.Image = Equalization.SelectiveEqualRGB((Bitmap)PictureBox.Image);
                Dictionary<Color, int> map = Tools.HistogramMap((Bitmap)PictureBox.Image);
                int[] RedLut = Tools.HistogramLUT(map, "red");
                int[] GreenLut = Tools.HistogramLUT(map, "green");
                int[] BlueLut = Tools.HistogramLUT(map, "blue");

                PictureWindowChart.Series.Clear();
                PictureWindowChart.Series.Add("Red");
                PictureWindowChart.Series.Add("Blue");
                PictureWindowChart.Series.Add("Green");
                PictureWindowChart.Series["Red"].Color = Color.Red;
                PictureWindowChart.Series["Blue"].Color = Color.Blue;
                PictureWindowChart.Series["Green"].Color = Color.Green;

                for (int i = 0; i < RedLut.Length; i++)
                {
                    this.PictureWindowChart.Series["Red"].Points.AddXY(i, RedLut[i]);
                    this.PictureWindowChart.Series["Green"].Points.AddXY(i, GreenLut[i]);
                    this.PictureWindowChart.Series["Blue"].Points.AddXY(i, BlueLut[i]);
                }

            }


        }

        // ######################################## Negation ###########################################################################
        private void NegationButton_Click(object sender, EventArgs e)
        {
            PictureBox.Image = Operations.Negation((Bitmap)PictureBox.Image);

            Dictionary<Color, int> map = Tools.HistogramMap((Bitmap)PictureBox.Image);
            int[] RedLut = Tools.HistogramLUT(map, "red");
            int[] GreenLut = Tools.HistogramLUT(map, "green");
            int[] BlueLut = Tools.HistogramLUT(map, "blue");

            PictureWindowChart.Series.Clear();
            PictureWindowChart.Series.Add("Red");
            PictureWindowChart.Series.Add("Blue");
            PictureWindowChart.Series.Add("Green");
            PictureWindowChart.Series["Red"].Color = Color.Red;
            PictureWindowChart.Series["Blue"].Color = Color.Blue;
            PictureWindowChart.Series["Green"].Color = Color.Green;

            for (int i = 0; i < RedLut.Length; i++)
            {
                this.PictureWindowChart.Series["Red"].Points.AddXY(i, RedLut[i]);
                this.PictureWindowChart.Series["Green"].Points.AddXY(i, GreenLut[i]);
                this.PictureWindowChart.Series["Blue"].Points.AddXY(i, BlueLut[i]);
            }
        }
// ######################################## Thresholding ###########################################################################
        private void ThresholdingButton_Click(object sender, EventArgs e)
        {
            PictureBox.Image = Operations.Thresholding((Bitmap)PictureBox.Image,Convert.ToInt32(P1TextBox.Text));
            Dictionary<Color, int> map = Tools.HistogramMap((Bitmap)PictureBox.Image);
            int[] GrayLut = Tools.HistogramLUT(map);
            PictureWindowChart.Series.Clear();
            PictureWindowChart.Series.Add("Gray");
            PictureWindowChart.Series["Gray"].Color = Color.Violet;
            for (int i = 0; i < GrayLut.Length; i++)
            {
                this.PictureWindowChart.Series["Gray"].Points.AddXY(i, GrayLut[i]);
            }
        }

        private void DiffrentThresholdingButton_Click(object sender, EventArgs e)
        {
            PictureBox.Image = Operations.Thresholding2((Bitmap)PictureBox.Image, Convert.ToInt32(P1TextBox.Text), Convert.ToInt32(P2TextBox.Text));
            Dictionary<Color, int> map = Tools.HistogramMap((Bitmap)PictureBox.Image);
            int[] GrayLut = Tools.HistogramLUT(map);
            PictureWindowChart.Series.Clear();
            PictureWindowChart.Series.Add("Gray");
            PictureWindowChart.Series["Gray"].Color = Color.Violet;
            for (int i = 0; i < GrayLut.Length; i++)
            {
                this.PictureWindowChart.Series["Gray"].Points.AddXY(i, GrayLut[i]);
            }
        }
// ######################################## Reduction ###########################################################################
        private void ReductionButton_Click(object sender, EventArgs e)
        {
            PictureBox.Image = Operations.Reduction((Bitmap)PictureBox.Image, (int)GrayLevelsUpDown.Value);
            Dictionary<Color, int> map = Tools.HistogramMap((Bitmap)PictureBox.Image);

            if (gray)
            {
                int[] GrayLut = Tools.HistogramLUT(map);
                PictureWindowChart.Series.Clear();
                PictureWindowChart.Series.Add("Gray");
                PictureWindowChart.Series["Gray"].Color = Color.Gray;
                for (int i = 0; i < GrayLut.Length; i++)
                {
                    this.PictureWindowChart.Series["Gray"].Points.AddXY(i, GrayLut[i]);
                }
            }
            if (rgb)
            {
                int[] RedLut = Tools.HistogramLUT(map, "red");
                int[] GreenLut = Tools.HistogramLUT(map, "green");
                int[] BlueLut = Tools.HistogramLUT(map, "blue");

                PictureWindowChart.Series.Clear();
                PictureWindowChart.Series.Add("Red");
                PictureWindowChart.Series.Add("Blue");
                PictureWindowChart.Series.Add("Green");
                PictureWindowChart.Series["Red"].Color = Color.Red;
                PictureWindowChart.Series["Blue"].Color = Color.Blue;
                PictureWindowChart.Series["Green"].Color = Color.Green;

                for (int i = 0; i < RedLut.Length; i++)
                {
                    this.PictureWindowChart.Series["Red"].Points.AddXY(i, RedLut[i]);
                    this.PictureWindowChart.Series["Green"].Points.AddXY(i, GreenLut[i]);
                    this.PictureWindowChart.Series["Blue"].Points.AddXY(i, BlueLut[i]);
                }

            }
        }

        

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            PictureBox.Image = bitmap;
            PictureWindowChart.Series.Clear();
            histogramToolStripMenuItem1.Enabled = false;
            GreyHistogramMenuStripItem.Enabled = true;
            RGBHistogramMenuStrip.Enabled = true;
            StretchButton.Enabled = false;
            EqualButton.Enabled = false;
            SelectiveEqualizationButton.Enabled = false;
        }

        

        private void neighborhoodOperationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image<Bgra, byte> image = bitmap.ToImage<Bgra, byte>();
            NeighborhoodOperationsForm operationsForm = new NeighborhoodOperationsForm(image);
            operationsForm.Show();
            this.Close();
        }
    }
}

