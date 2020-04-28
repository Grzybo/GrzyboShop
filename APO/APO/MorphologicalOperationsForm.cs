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
    public partial class MorphologicalOperationsForm : Form
    {
        public Image<Bgra, byte> image;
        private Emgu.CV.CvEnum.BorderType borderType = Emgu.CV.CvEnum.BorderType.Isolated;
        private Size elementSize = new Size(3,3);
        private Mat element = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Rectangle, new Size(3, 3), new Point(-1, -1));
        private bool binary = false; 

        public MorphologicalOperationsForm()
        {
            InitializeComponent();
        }

        private void ErodeButton_Click(object sender, EventArgs e)
        {
            Image<Bgra, byte> resultImage = new Image<Bgra, byte>(image.Size.Width, image.Size.Height);
            CvInvoke.Erode(image, resultImage, element, new Point(-1, -1), 1, borderType, new MCvScalar(255, 255, 255));
            MorfologicalPictureBox.Image = resultImage.ToBitmap();
            Bitmap bitmap = (Bitmap)MorfologicalPictureBox.Image;
            this.image = bitmap.ToImage<Bgra, byte>();
            Histogram();
        }

        private void DilateButton_Click(object sender, EventArgs e)
        {
            Image<Bgra, byte> resultImage = new Image<Bgra, byte>(image.Size.Width, image.Size.Height);
            CvInvoke.Dilate(image, resultImage, element, new Point(-1, -1), 1, borderType, new MCvScalar(255, 255, 255));
            MorfologicalPictureBox.Image = resultImage.ToBitmap();
            Bitmap bitmap = (Bitmap)MorfologicalPictureBox.Image;
            this.image = bitmap.ToImage<Bgra, byte>();
            Histogram();
        }

        private void OpeningButton_Click(object sender, EventArgs e)
        {
            Image<Bgra, byte> resultImage = new Image<Bgra, byte>(image.Size.Width, image.Size.Height);
            CvInvoke.MorphologyEx(image, resultImage,
                                    Emgu.CV.CvEnum.MorphOp.Open, 
                                    element, new Point(-1, -1), 1, 
                                    borderType, new MCvScalar(255, 255, 255));
            MorfologicalPictureBox.Image = resultImage.ToBitmap();
            Bitmap bitmap = (Bitmap)MorfologicalPictureBox.Image;
            this.image = bitmap.ToImage<Bgra, byte>();
            Histogram();
        }

        private void ClosingButton_Click(object sender, EventArgs e)
        {
            Image<Bgra, byte> resultImage = new Image<Bgra, byte>(image.Size.Width, image.Size.Height);
            CvInvoke.MorphologyEx(image, resultImage, 
                                    Emgu.CV.CvEnum.MorphOp.Close, 
                                    element, new Point(-1, -1), 1, 
                                    borderType, new MCvScalar(255, 255, 255));
            MorfologicalPictureBox.Image = resultImage.ToBitmap();
            Bitmap bitmap = (Bitmap)MorfologicalPictureBox.Image;
            this.image = bitmap.ToImage<Bgra, byte>();
            Histogram();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();

            try
            {
                MorfologicalPictureBox.Image = new Bitmap(dialog.FileName);
                Bitmap bitmap = (Bitmap)MorfologicalPictureBox.Image;
                this.image = bitmap.ToImage<Bgra, byte>();
                Histogram();
            }
            catch
            {
                MessageBox.Show("You didn't pick an image!");
            }
        }
        private void IsolatedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            borderType = Emgu.CV.CvEnum.BorderType.Isolated;
        }

        private void ReflectRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            borderType = Emgu.CV.CvEnum.BorderType.Reflect;
        }

        private void ReplicateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            borderType = Emgu.CV.CvEnum.BorderType.Replicate;
        }

        private void DiamondRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            element = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Ellipse, elementSize, new Point(-1, -1));
        }

        private void SquareRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            element = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Rectangle, elementSize, new Point(-1, -1));
        }
        private void RadioButtonChange()
        {
            if (RadioButton3X3.Checked)
            {
                elementSize = new Size(3, 3);
            }
            if (RadioButton5X5.Checked)
            {
                elementSize = new Size(5, 5);
            }
            if (RadioButton7X7.Checked)
            {
                elementSize = new Size(7, 7);
            }
        }

        private void RadioButton3X3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButtonChange();
        }

        private void RadioButton5X5_CheckedChanged(object sender, EventArgs e)
        {
            RadioButtonChange();
        }

        private void RadioButton7X7_CheckedChanged(object sender, EventArgs e)
        {
            RadioButtonChange();
        }
        private void Histogram()
        {
            Dictionary<Color, int> map = Tools.HistogramMap((Bitmap)MorfologicalPictureBox.Image);
            int[] RedLut = Tools.HistogramLUT(map, "red");
            int[] GreenLut = Tools.HistogramLUT(map, "green");
            int[] BlueLut = Tools.HistogramLUT(map, "blue");

            MorfologicalChart.Series.Clear();
            MorfologicalChart.Series.Add("Red");
            MorfologicalChart.Series.Add("Blue");
            MorfologicalChart.Series.Add("Green");
            MorfologicalChart.Series["Red"].Color = Color.Red;
            MorfologicalChart.Series["Blue"].Color = Color.Blue;
            MorfologicalChart.Series["Green"].Color = Color.Green;

            for (int i = 0; i < RedLut.Length; i++)
            {
                this.MorfologicalChart.Series["Red"].Points.AddXY(i, RedLut[i]);
                this.MorfologicalChart.Series["Green"].Points.AddXY(i, GreenLut[i]);
                this.MorfologicalChart.Series["Blue"].Points.AddXY(i, BlueLut[i]);

            }
            if (map.Count == 2) { binary = true; }
            else { binary = false; }
        }
        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog x = new SaveFileDialog();
            x.Filter = "Image Files (*.png;*.jpg)|*.png;*.jpg";
            x.FileName = "Image";
            x.ShowDialog();

            try { MorfologicalPictureBox.Image.Save(x.FileName); }
            catch { }
        }
        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog x = new SaveFileDialog();
            x.Filter = "Image Files (*.png;*.jpg)|*.png;*.jpg";
            x.FileName = "Histogram";
            x.ShowDialog();

            try { this.MorfologicalChart.SaveImage(x.FileName, ChartImageFormat.Jpeg); }
            catch { }
        }

        private void SkeletonButton_Click(object sender, EventArgs e)
        {
            Image<Bgra, byte> skeleton = new Image<Bgra, byte>(image.Size.Width, image.Size.Height);
            int i = 0;
            while (i < 15)
            {
            
                Image<Bgra, byte> img_open = new Image<Bgra, byte>(image.Size.Width, image.Size.Height);
                // 2 otwarcie 
                CvInvoke.MorphologyEx(image, img_open,
                                        Emgu.CV.CvEnum.MorphOp.Open,
                                        element, new Point(-1, -1), 1,
                                        borderType, new MCvScalar(255, 255, 255));
                Image<Bgra, byte> img_temp = new Image<Bgra, byte>(image.Size.Width, image.Size.Height);
                // 3 odjecie 
                CvInvoke.Subtract(image, img_open, img_temp);
                Image<Bgra, byte> img_eroded = new Image<Bgra, byte>(image.Size.Width, image.Size.Height);
                // 4 erozja 
                CvInvoke.Erode(image, img_eroded, element, new Point(-1, -1), 1, borderType, new MCvScalar(255, 255, 255));
                CvInvoke.BitwiseOr(skeleton, img_eroded, skeleton);
                image = img_eroded.Copy();
                ++i;
                MorfologicalPictureBox.Image = image.ToBitmap();
            }
            //MorfologicalPictureBox.Image = image.ToBitmap();
        }
    }
}
