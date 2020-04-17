using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;
using System.Windows.Forms.DataVisualization.Charting;

namespace APO
{
    public partial class BinaryOperationsForm : Form
    {
        private Image<Bgra, byte> imageA;
        private Image<Bgra, byte> imageB;

        public BinaryOperationsForm()
        {
            InitializeComponent();
        }

        private void imageAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();

            try
            {
                ImageA_PictureBox.Image = new Bitmap(dialog.FileName);
                Bitmap bitmapA = (Bitmap)ImageA_PictureBox.Image;
                this.imageA = bitmapA.ToImage<Bgra, byte>();
                Histogram_ImageA();
            }
            catch
            {
                MessageBox.Show("You didn't pick an image!");
            }
        }

        private void imageBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();

            try
            {
                ImageB_PictureBox.Image = new Bitmap(dialog.FileName);
                Bitmap bitmapB = (Bitmap)ImageB_PictureBox.Image;
                this.imageB = bitmapB.ToImage<Bgra, byte>();
                Histogram_ImageB();
            }
            catch
            {
                MessageBox.Show("You didn't pick an image!");
            }

        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            if (ImageA_PictureBox.Image == null)
            {
                MessageBox.Show("Select image A.");
                return;
            }

            if (NotRadioButton.Checked)
            {
                Image<Bgra, byte> resultImage = new Image<Bgra, byte>(imageA.Size.Width, imageA.Size.Height);
                resultImage = imageA.Not();
                //CvInvoke.BitwiseNot(imageA, resultImage);
                ResultImagePictureBox.Image = resultImage.ToBitmap();
                Histogram_ResultImage();
                return;
            }

            if (ImageB_PictureBox.Image == null)
            {
                MessageBox.Show("Select image B.");
                return;
            }

            if (AddRadioButton.Checked)
            {
                Image<Bgra, byte> resultImage = new Image<Bgra, byte>(ResultImagePictureBox.Size.Width, ResultImagePictureBox.Size.Height);
                Image<Bgra, byte> imageBresized = new Image<Bgra, byte>(imageA.Size.Width, imageA.Size.Height);
                CvInvoke.Resize(imageB, imageBresized, imageA.Size);
                resultImage = imageA.Add(imageBresized, null);
                ResultImagePictureBox.Image = resultImage.ToBitmap();
                Histogram_ResultImage();
                return;
            }
            if (BlendRadioButton.Checked)
            {
                Image<Bgra, byte> resultImage = new Image<Bgra, byte>(ResultImagePictureBox.Size.Width, ResultImagePictureBox.Size.Height);
                Image<Bgra, byte> imageBresized = new Image<Bgra, byte>(imageA.Size.Width, imageA.Size.Height);
                CvInvoke.Resize(imageB, imageBresized, imageA.Size);
                resultImage = imageA.AddWeighted(imageBresized, 0.5, 1-0.5, 0);
                //CvInvoke.BlendLinear(imageA, imageBresized, null, null, resultImage);
                ResultImagePictureBox.Image = resultImage.ToBitmap();
                Histogram_ResultImage();
                return;
            }
            if (AndRadioButton.Checked)
            {
                Image<Bgra, byte> resultImage = new Image<Bgra, byte>(ResultImagePictureBox.Size.Width, ResultImagePictureBox.Size.Height);
                Image<Bgra, byte> imageBresized = new Image<Bgra, byte>(imageA.Size.Width, imageA.Size.Height);
                CvInvoke.Resize(imageB, imageBresized, imageA.Size);
                resultImage = imageA.And(imageBresized, null);
                ResultImagePictureBox.Image = resultImage.ToBitmap();
                Histogram_ResultImage();
                return;
            }
            if (OrRadioButton.Checked)
            {
                Image<Bgra, byte> resultImage = new Image<Bgra, byte>(ResultImagePictureBox.Size.Width, ResultImagePictureBox.Size.Height);
                Image<Bgra, byte> imageBresized = new Image<Bgra, byte>(imageA.Size.Width, imageA.Size.Height);
                CvInvoke.Resize(imageB, imageBresized, imageA.Size);
                resultImage = imageA.Or(imageBresized, null);
                ResultImagePictureBox.Image = resultImage.ToBitmap();
                Histogram_ResultImage();
                return;
            }
            if (XorRadioButton.Checked)
            {
                Image<Bgra, byte> resultImage = new Image<Bgra, byte>(imageA.Size.Width, imageA.Size.Height);
                Image<Bgra, byte> imageBresized = new Image<Bgra, byte>(imageA.Size.Width, imageA.Size.Height);
                CvInvoke.Resize(imageB, imageBresized, imageA.Size);
                resultImage = imageA.Xor(imageBresized);
                //CvInvoke.BitwiseXor(imageA, imageBresized, resultImage);
                ResultImagePictureBox.Image = resultImage.ToBitmap();
                Histogram_ResultImage();
            }
            

        }
        private void Histogram_ResultImage()
        {
            Dictionary<Color, int> map = Tools.HistogramMap((Bitmap)ResultImagePictureBox.Image);
            int[] RedLut = Tools.HistogramLUT(map, "red");
            int[] GreenLut = Tools.HistogramLUT(map, "green");
            int[] BlueLut = Tools.HistogramLUT(map, "blue");

            BinaryOperationsChart.Series.Clear();
            BinaryOperationsChart.Series.Add("Red");
            BinaryOperationsChart.Series.Add("Blue");
            BinaryOperationsChart.Series.Add("Green");
            BinaryOperationsChart.Series["Red"].Color = Color.Red;
            BinaryOperationsChart.Series["Blue"].Color = Color.Blue;
            BinaryOperationsChart.Series["Green"].Color = Color.Green;

            for (int i = 0; i < RedLut.Length; i++)
            {
                this.BinaryOperationsChart.Series["Red"].Points.AddXY(i, RedLut[i]);
                this.BinaryOperationsChart.Series["Green"].Points.AddXY(i, GreenLut[i]);
                this.BinaryOperationsChart.Series["Blue"].Points.AddXY(i, BlueLut[i]);

            }
        }
        private void Histogram_ImageA()
        {
            Dictionary<Color, int> map = Tools.HistogramMap((Bitmap)ImageA_PictureBox.Image);
            int[] RedLut = Tools.HistogramLUT(map, "red");
            int[] GreenLut = Tools.HistogramLUT(map, "green");
            int[] BlueLut = Tools.HistogramLUT(map, "blue");

            ImageA_Chart.Series.Clear();
            ImageA_Chart.Series.Add("Red");
            ImageA_Chart.Series.Add("Blue");
            ImageA_Chart.Series.Add("Green");
            ImageA_Chart.Series["Red"].Color = Color.Red;
            ImageA_Chart.Series["Blue"].Color = Color.Blue;
            ImageA_Chart.Series["Green"].Color = Color.Green;

            for (int i = 0; i < RedLut.Length; i++)
            {
                this.ImageA_Chart.Series["Red"].Points.AddXY(i, RedLut[i]);
                this.ImageA_Chart.Series["Green"].Points.AddXY(i, GreenLut[i]);
                this.ImageA_Chart.Series["Blue"].Points.AddXY(i, BlueLut[i]);

            }
        }
        private void Histogram_ImageB()
        {
            Dictionary<Color, int> map = Tools.HistogramMap((Bitmap)ImageB_PictureBox.Image);
            int[] RedLut = Tools.HistogramLUT(map, "red");
            int[] GreenLut = Tools.HistogramLUT(map, "green");
            int[] BlueLut = Tools.HistogramLUT(map, "blue");

            ImageB_Chart.Series.Clear();
            ImageB_Chart.Series.Add("Red");
            ImageB_Chart.Series.Add("Blue");
            ImageB_Chart.Series.Add("Green");
            ImageB_Chart.Series["Red"].Color = Color.Red;
            ImageB_Chart.Series["Blue"].Color = Color.Blue;
            ImageB_Chart.Series["Green"].Color = Color.Green;

            for (int i = 0; i < RedLut.Length; i++)
            {
                this.ImageB_Chart.Series["Red"].Points.AddXY(i, RedLut[i]);
                this.ImageB_Chart.Series["Green"].Points.AddXY(i, GreenLut[i]);
                this.ImageB_Chart.Series["Blue"].Points.AddXY(i, BlueLut[i]);

            }
        }

        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog x = new SaveFileDialog();
            x.Filter = "Image Files (*.png;*.jpg)|*.png;*.jpg";
            x.FileName = "Image";
            x.ShowDialog();

            try { this.ResultImagePictureBox.Image.Save(x.FileName); }
            catch { }
        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog x = new SaveFileDialog();
            x.Filter = "Image Files (*.png;*.jpg)|*.png;*.jpg";
            x.FileName = "Histogram";
            x.ShowDialog();

            try { this.BinaryOperationsChart.SaveImage(x.FileName, ChartImageFormat.Jpeg); }
            catch { }
        }
    }
}
