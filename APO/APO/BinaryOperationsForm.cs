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
        public Panel panel;

        public BinaryOperationsForm(Panel panel)
        {
            InitializeComponent();
            this.panel = panel;
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
                Tools.Histogram(ImageA_Chart, (Bitmap)ImageA_PictureBox.Image);
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
                Tools.Histogram(ImageB_Chart, (Bitmap)ImageB_PictureBox.Image);
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
                //resultImage = imageA.Not();
                CvInvoke.BitwiseNot(imageA, resultImage);
                ResultImagePictureBox.Image = resultImage.ToBitmap();
                Tools.Histogram(BinaryOperationsChart, (Bitmap)ResultImagePictureBox.Image);
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
                Tools.Histogram(BinaryOperationsChart, (Bitmap)ResultImagePictureBox.Image);
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
                Tools.Histogram(BinaryOperationsChart, (Bitmap)ResultImagePictureBox.Image);
                return;
            }
            if (AndRadioButton.Checked)
            {
                Image<Bgra, byte> resultImage = new Image<Bgra, byte>(ResultImagePictureBox.Size.Width, ResultImagePictureBox.Size.Height);
                Image<Bgra, byte> imageBresized = new Image<Bgra, byte>(imageA.Size.Width, imageA.Size.Height);
                CvInvoke.Resize(imageB, imageBresized, imageA.Size);
                resultImage = imageA.And(imageBresized, null);
                ResultImagePictureBox.Image = resultImage.ToBitmap();
                Tools.Histogram(BinaryOperationsChart, (Bitmap)ResultImagePictureBox.Image);
                return;
            }
            if (OrRadioButton.Checked)
            {
                Image<Bgra, byte> resultImage = new Image<Bgra, byte>(ResultImagePictureBox.Size.Width, ResultImagePictureBox.Size.Height);
                Image<Bgra, byte> imageBresized = new Image<Bgra, byte>(imageA.Size.Width, imageA.Size.Height);
                CvInvoke.Resize(imageB, imageBresized, imageA.Size);
                resultImage = imageA.Or(imageBresized, null);
                ResultImagePictureBox.Image = resultImage.ToBitmap();
                Tools.Histogram(BinaryOperationsChart, (Bitmap)ResultImagePictureBox.Image);
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
                Tools.Histogram(BinaryOperationsChart, (Bitmap)ResultImagePictureBox.Image);
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
