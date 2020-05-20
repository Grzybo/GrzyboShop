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
        private Stack<Image<Bgra, byte>> imageBackup;
        
        private Emgu.CV.CvEnum.BorderType borderType = Emgu.CV.CvEnum.BorderType.Isolated;
        private Size elementSize = new Size(3,3);
        private Mat element = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Rectangle, new Size(3, 3), new Point(-1, -1));
         

        public MorphologicalOperationsForm()
        {
            InitializeComponent();
            imageBackup = new Stack<Image<Bgra, byte>>();
        }

        private void ErodeButton_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                if (Tools.IsBinary(image.ToBitmap()))
                {
                this.imageBackup.Push(this.image);
                Image<Bgra, byte> resultImage = new Image<Bgra, byte>(image.Size.Width, image.Size.Height);
                CvInvoke.Erode(image, resultImage, element, new Point(-1, -1), 1, borderType, new MCvScalar(255, 255, 255));
                MorfologicalPictureBox.Image = resultImage.ToBitmap();
                Bitmap bitmap = (Bitmap)MorfologicalPictureBox.Image;
                this.image = bitmap.ToImage<Bgra, byte>();
                Tools.Histogram(MorfologicalChart, (Bitmap)MorfologicalPictureBox.Image);

                }
                else { MessageBox.Show("Picture is not binary."); }

            }
        }

        private void DilateButton_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                if (Tools.IsBinary(image.ToBitmap()))
                {
                imageBackup.Push(image);
                Image<Bgra, byte> resultImage = new Image<Bgra, byte>(image.Size.Width, image.Size.Height);
                CvInvoke.Dilate(image, resultImage, element, new Point(-1, -1), 1, borderType, new MCvScalar(255, 255, 255));
                MorfologicalPictureBox.Image = resultImage.ToBitmap();
                Bitmap bitmap = (Bitmap)MorfologicalPictureBox.Image;
                this.image = bitmap.ToImage<Bgra, byte>();
                Tools.Histogram(MorfologicalChart, (Bitmap)MorfologicalPictureBox.Image);

                }
                else { MessageBox.Show("Picture is not binary."); }

            }
        }

        private void OpeningButton_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                if (Tools.IsBinary(image.ToBitmap()))
                {
                imageBackup.Push(image);
                Image<Bgra, byte> resultImage = new Image<Bgra, byte>(image.Size.Width, image.Size.Height);
                CvInvoke.MorphologyEx(image, resultImage,
                                        Emgu.CV.CvEnum.MorphOp.Open,
                                        element, new Point(-1, -1), 1,
                                        borderType, new MCvScalar(255, 255, 255));
                MorfologicalPictureBox.Image = resultImage.ToBitmap();
                Bitmap bitmap = (Bitmap)MorfologicalPictureBox.Image;
                this.image = bitmap.ToImage<Bgra, byte>();
                Tools.Histogram(MorfologicalChart, (Bitmap)MorfologicalPictureBox.Image);

                }
                else { MessageBox.Show("Picture is not binary."); }

            }
        }

        private void ClosingButton_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                if (Tools.IsBinary(image.ToBitmap()))
                {

                    imageBackup.Push(image);
                    Image<Bgra, byte> resultImage = new Image<Bgra, byte>(image.Size.Width, image.Size.Height);
                    CvInvoke.MorphologyEx(image, resultImage,
                                            Emgu.CV.CvEnum.MorphOp.Close,
                                            element, new Point(-1, -1), 1,
                                            borderType, new MCvScalar(255, 255, 255));
                    MorfologicalPictureBox.Image = resultImage.ToBitmap();
                    Bitmap bitmap = (Bitmap)MorfologicalPictureBox.Image;
                    this.image = bitmap.ToImage<Bgra, byte>();
                    Tools.Histogram(MorfologicalChart, (Bitmap)MorfologicalPictureBox.Image);
                }
                else { MessageBox.Show("Picture is not binary."); }
            }
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
                this.imageBackup.Push(this.image);
                Tools.Histogram(MorfologicalChart, (Bitmap)MorfologicalPictureBox.Image);
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
            if (image != null)
            {
                if (Tools.IsBinary(image.ToBitmap()))
                {


                    /*
                    Image<Gray, byte> skel = new Image<Gray, byte>(MorfologicalPictureBox.Image.Size);
                    for (int y = 0; y < skel.Height; y++)
                        for (int x = 0; x < skel.Width; x++)
                            skel.Data[y, x, 0] = 0;

                    MorfologicalPictureBox.Image = skel.ToBitmap();

                    Image<Gray, byte> img = image.ToBitmap().ToImage<Gray, byte>();

                    element = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Cross, new Size(3, 3), new Point(-1, -1));

                    while (CvInvoke.CountNonZero(img) > 0)
                    {

                        Image<Gray, byte> img_open = new Image<Gray, byte>(image.Size.Width, image.Size.Height);
                        // 2 otwarcie 
                        CvInvoke.MorphologyEx(img, img_open,
                                                Emgu.CV.CvEnum.MorphOp.Open,
                                                element, new Point(-1, -1), 1,
                                                borderType, new MCvScalar(255, 255, 255));

                        Image<Gray, byte> img_temp = new Image<Gray, byte>(image.Size.Width, image.Size.Height);
                        // 3 odjecie 
                        CvInvoke.Subtract(img, img_open, img_temp);
                        Image<Gray, byte> img_eroded = new Image<Gray, byte>(image.Size.Width, image.Size.Height);
                        // 4 erozja 
                        CvInvoke.Erode(img, img_eroded, element, new Point(-1, -1), 1, borderType, new MCvScalar(255, 255, 255));
                        CvInvoke.BitwiseOr(skel, img_eroded, skel);
                        img = img_eroded;
                    }
                    MorfologicalPictureBox.Image = skel.ToBitmap();
                    this.image = skel.ToBitmap().ToImage<Bgra, byte>();
                    Tools.Histogram(MorfologicalChart, (Bitmap)MorfologicalPictureBox.Image);
                    */
                    //if (CvInvoke.CountNonZero(img) == 0) { break; } 


                    imageBackup.Push(image);


                    Image<Gray, byte> skel = new Image<Gray, byte>(MorfologicalPictureBox.Image.Size);
                    for (int y = 0; y < skel.Height; y++)
                        for (int x = 0; x < skel.Width; x++)
                            skel.Data[y, x, 0] = 0;

                    MorfologicalPictureBox.Image = skel.ToBitmap();

                    Image<Gray, byte> img = skel.Copy();
                    for (int y = 0; y < skel.Height; y++)
                        for (int x = 0; x < skel.Width; x++)
                            img.Data[y, x, 0] = image.Data[y, x, 0];

                    element = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Cross, new Size(3, 3), new Point(-1, -1));
                    Image<Gray, byte> temp;

                    bool done = false;
                    do
                    {
                        temp = img.MorphologyEx(Emgu.CV.CvEnum.MorphOp.Open, element, new Point(-1, -1), 1, borderType, new MCvScalar(255, 255, 255));
                        temp = temp.Not();
                        temp = temp.And(img);
                        skel = skel.Or(temp);
                        img = img.Erode(1);
                        double[] min, max;
                        Point[] pmin, pmax;
                        img.MinMax(out min, out max, out pmin, out pmax);
                        done = (max[0] == 0);
                    } while (!done); // (CvInvoke.CountNonZero(img) == 0);  CountNonZero nie daje dobrych efektów  

                    MorfologicalPictureBox.Image = skel.ToBitmap();
                    image = skel.ToBitmap().ToImage<Bgra, byte>();
                }
                else { MessageBox.Show("Picture is not binary."); }
            }
            
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imageBackup.Count > 1) {
                image = imageBackup.Pop();
                MorfologicalPictureBox.Image = image.ToBitmap();
            }
            
        }
    }
}
