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
    public partial class NeighborhoodOperationsForm : Form
    {
        public Image<Bgra, byte> image;
        private Image<Bgra, byte> inputImage;
        public bool fromPictureWindow;

        public NeighborhoodOperationsForm(Image<Bgra, byte> image)
        {
            InitializeComponent();
            this.image = image;
            this.inputImage = image;
            PictureBox.Image = image.ToBitmap();
            Histogram();
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                image = new Image<Bgra, byte>(dialog.FileName);
                inputImage = image;
                PictureBox.Image = image.ToBitmap();
                Histogram();
            }
        }

        private void Blur_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                Image<Bgra, byte> dst = new Image<Bgra, byte>(PictureBox.Size.Width, PictureBox.Size.Height);
                dst = image.SmoothGaussian(13);
                PictureBox.Image = dst.ToBitmap();
                Histogram();
            }
        }

        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog x = new SaveFileDialog();
            x.Filter = "Image Files (*.png;*.jpg)|*.png;*.jpg";
            x.FileName = "Image";
            x.ShowDialog();

            try { PictureBox.Image.Save(x.FileName); }
            catch { }
        }

        private void cannyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                Image<Gray, byte> imageCanny = new Image<Gray, byte>(image.Width, image.Height, new Gray(0));
                imageCanny = image.Canny(20, 50);
                PictureBox.Image = imageCanny.ToBitmap();
                Histogram();
            }
        }

        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                image = image.SmoothGaussian(9);
                Image<Gray, byte> imageGray = image.Convert<Gray, byte>();
                Image<Gray, float> imageSobel = imageGray.Sobel(0, 1, 3).Add(imageGray.Sobel(1, 0, 3)).AbsDiff(new Gray(0.0));
                PictureBox.Image = imageSobel.ToBitmap();
                Histogram();


                //Image<Gray, byte> gray = new Image<Gray, byte>(@"C:\Users\Public\Pictures\Sample Pictures\1.jpg");
                //Image<Gray, float> sobel = gray.Sobel(0, 1, 3).Add(gray.Sobel(1, 0, 3)).AbsDiff(new Gray(0.0));
                //pictureBox1.Image = sobel.ToBitmap();

                //imageSobel = imageGray.Sobel(1, 0, 3);

            }
        }

        private void laplacianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                Image<Gray, byte> imageGray = image.Convert<Gray, byte>();
                Image<Gray, float> imageLaplacian = new Image<Gray, float>(image.Width, image.Height, new Gray(0));

                imageLaplacian = imageGray.Laplace(7);
                PictureBox.Image = imageLaplacian.ToBitmap();
                Histogram();
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureBox.Image = inputImage.ToBitmap();
            Histogram();
        }

        private void masksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                MasksForm masksForm = new MasksForm(new Bitmap(PictureBox.Image).ToImage<Bgra, byte>());
                masksForm.Show();
                this.Close();
            }

        }

        private void doneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureWindow pictureWindow = new PictureWindow((Bitmap)PictureBox.Image);
            pictureWindow.Show();
            this.Close();
        }
        private void Histogram()
        {
            Dictionary<Color, int> map = Tools.HistogramMap((Bitmap)PictureBox.Image);
            int[] RedLut = Tools.HistogramLUT(map, "red");
            int[] GreenLut = Tools.HistogramLUT(map, "green");
            int[] BlueLut = Tools.HistogramLUT(map, "blue");

            NeighborhoodChart.Series.Clear();
            NeighborhoodChart.Series.Add("Red");
            NeighborhoodChart.Series.Add("Blue");
            NeighborhoodChart.Series.Add("Green");
            NeighborhoodChart.Series["Red"].Color = Color.Red;
            NeighborhoodChart.Series["Blue"].Color = Color.Blue;
            NeighborhoodChart.Series["Green"].Color = Color.Green;

            for (int i = 0; i < RedLut.Length; i++)
            {
                this.NeighborhoodChart.Series["Red"].Points.AddXY(i, RedLut[i]);
                this.NeighborhoodChart.Series["Green"].Points.AddXY(i, GreenLut[i]);
                this.NeighborhoodChart.Series["Blue"].Points.AddXY(i, BlueLut[i]);

            }
        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog x = new SaveFileDialog();
            x.Filter = "Image Files (*.png;*.jpg)|*.png;*.jpg";
            x.FileName = "Histogram";
            x.ShowDialog();

            try { this.NeighborhoodChart.SaveImage(x.FileName, ChartImageFormat.Jpeg); }
            catch { }
        }
    }
}
