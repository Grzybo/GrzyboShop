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
        public Bitmap firstBitmap; 


        public PictureWindow(Bitmap bitmap)
        {
            InitializeComponent();
            PictureBox.Image = bitmap;
            this.bitmap = bitmap;
            firstBitmap = bitmap;
            PictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureWindowChart.ChartAreas[0].AxisX.Maximum = 255;
            PictureWindowChart.ChartAreas[0].AxisX.Minimum = 0;
            
            this.bitmap = bitmap;

        }

        private void Enableing()
        {
            histogramToolStripMenuItem1.Enabled = true;
            GreyHistogramMenuStripItem.Enabled = false;
            RGBHistogramMenuStrip.Enabled = false;
            StretchButton.Enabled = true;
            EqualButton.Enabled = true;
            SelectiveEqualizationButton.Enabled = true; 

        }

// ######################################## Histogram ###########################################################################
        private void GreyHistogramMenuStripItem_Click(object sender, EventArgs e)
        {

            Tools.HistogramGray(PictureWindowChart, (Bitmap)PictureBox.Image);
            //PixelsTextBox.Text = sum.ToString();
        }

        private void AllinOneMenuStripItem_Click(object sender, EventArgs e)
        {
            Tools.Histogram(PictureWindowChart, (Bitmap)PictureBox.Image);
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
            StretchWindow stretchWindow = new StretchWindow((Bitmap)PictureBox.Image);
            stretchWindow.Text = this.Text;
            stretchWindow.Show();
            this.Close();
        }
// ######################################## Equalization ###########################################################################
        private void EqualButton_Click(object sender, EventArgs e)
        {
            if (Tools.IsGray(this.bitmap))
            {
                PictureBox.Image = Equalization.EqualGray((Bitmap)PictureBox.Image);
                Tools.HistogramGray(PictureWindowChart, (Bitmap)PictureBox.Image);
            }
            if (Tools.IsGray(this.bitmap) == false)
            {
                PictureBox.Image = Equalization.EqualRGB((Bitmap)PictureBox.Image);
                Tools.Histogram(PictureWindowChart, (Bitmap)PictureBox.Image);

            }
        }
        private void SelectiveEqualizationButton_Click(object sender, EventArgs e)
        {
            if (Tools.IsGray(this.bitmap))
            {
                PictureBox.Image = Equalization.SelectiveEqualGray((Bitmap)PictureBox.Image);
                Tools.HistogramGray(PictureWindowChart, (Bitmap)PictureBox.Image);
            }
            if (Tools.IsGray(this.bitmap) == false)
            {
                PictureBox.Image = Equalization.SelectiveEqualRGB((Bitmap)PictureBox.Image);
                Tools.Histogram(PictureWindowChart, (Bitmap)PictureBox.Image);
            }


        }

        // ######################################## Negation ###########################################################################
        private void NegationButton_Click(object sender, EventArgs e)
        {
            PictureBox.Image = Operations.Negation((Bitmap)PictureBox.Image);
            Tools.Histogram(PictureWindowChart, (Bitmap)PictureBox.Image);
        }
// ######################################## Thresholding ###########################################################################
        private void ThresholdingButton_Click(object sender, EventArgs e)
        {
            PictureBox.Image = Operations.Thresholding((Bitmap)PictureBox.Image,Convert.ToInt32(P1TextBox.Text));
            Tools.HistogramGray(PictureWindowChart, (Bitmap)PictureBox.Image);
        }

        private void DiffrentThresholdingButton_Click(object sender, EventArgs e)
        {
            PictureBox.Image = Operations.Thresholding2((Bitmap)PictureBox.Image, Convert.ToInt32(P1TextBox.Text), Convert.ToInt32(P2TextBox.Text));
            Tools.HistogramGray(PictureWindowChart, (Bitmap)PictureBox.Image);
        }
// ######################################## Reduction ###########################################################################
        private void ReductionButton_Click(object sender, EventArgs e)
        {
            PictureBox.Image = Operations.Reduction((Bitmap)PictureBox.Image, (int)GrayLevelsUpDown.Value);
            if (Tools.IsGray(this.bitmap)) {Tools.HistogramGray(PictureWindowChart, (Bitmap)PictureBox.Image);}
            if (Tools.IsGray(this.bitmap) == false) {Tools.Histogram(PictureWindowChart, (Bitmap)PictureBox.Image);}
        }

        

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            PictureBox.Image = this.bitmap;
            PictureWindowChart.Series.Clear();
            histogramToolStripMenuItem1.Enabled = false;
            GreyHistogramMenuStripItem.Enabled = true;
            RGBHistogramMenuStrip.Enabled = true;
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

