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
using Emgu.CV.Util;

namespace APO
{
    public partial class SegmentationForm : Form
    {
        private Image<Bgra, byte> image;

        public SegmentationForm()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.image = new Image<Bgra, byte>(dialog.FileName);
                PbSegmentation.Image = image.ToBitmap();
                Tools.Histogram(ChartSegmentation, (Bitmap)PbSegmentation.Image);
            }
        }

        private void BtnTreshold_Click(object sender, EventArgs e)
        {
            CvInvoke.Threshold(image, image, (double)UpDownTreshold.Value, 255, Emgu.CV.CvEnum.ThresholdType.Binary);
            PbSegmentation.Image = image.ToBitmap();
            Tools.Histogram(ChartSegmentation, (Bitmap)PbSegmentation.Image);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image<Gray, byte> img = new Bitmap(PbSegmentation.Image).ToImage<Gray, byte>();
            CvInvoke.AdaptiveThreshold(img, img, 255,
                                        Emgu.CV.CvEnum.AdaptiveThresholdType.GaussianC,
                                        Emgu.CV.CvEnum.ThresholdType.Binary, 11, 5); 
            
            PbSegmentation.Image = img.ToBitmap();
            Tools.Histogram(ChartSegmentation, (Bitmap)PbSegmentation.Image);
        }

        private void BtnOtsu_Click(object sender, EventArgs e)
        {
            Image<Gray, byte> img = new Bitmap(PbSegmentation.Image).ToImage<Gray, byte>();
            CvInvoke.Threshold(img, img, (double)UpDownTreshold.Value, 255, Emgu.CV.CvEnum.ThresholdType.Otsu);
            PbSegmentation.Image = img.ToBitmap();
            Tools.Histogram(ChartSegmentation, (Bitmap)PbSegmentation.Image);
        }

        private void BtnWatershed_Click(object sender, EventArgs e)
        {
            if (image != null)
            {

                /*
                Mat element = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Rectangle, new Size(3, 3), new Point(-1, -1));
                Emgu.CV.CvEnum.BorderType borderType = Emgu.CV.CvEnum.BorderType.Isolated;

                Image<Gray, byte> img = new Bitmap(PbSegmentation.Image).ToImage<Gray, byte>();
                CvInvoke.CvtColor(img, img, Emgu.CV.CvEnum.ColorConversion.BayerBg2Gray);
                Image<Gray, byte> thresh = new Image<Gray, byte>(img.Width, img.Height);
                CvInvoke.Threshold(img, thresh, (double)UpDownTreshold.Value, 255, Emgu.CV.CvEnum.ThresholdType.Binary);
                Image<Gray, byte> open = new Image<Gray, byte>(img.Width, img.Height);
                CvInvoke.MorphologyEx(thresh, open,
                                            Emgu.CV.CvEnum.MorphOp.Open,
                                            element, new Point(-1, -1), 1,
                                            borderType, new MCvScalar(255, 255, 255));
                Image<Gray, byte> dill = new Image<Gray, byte>(img.Width, img.Height);
                CvInvoke.Dilate(open, dill, element, new Point(-1, -1), 1, borderType, new MCvScalar(255, 255, 255));
                Image<Gray, byte> dist = new Image<Gray, byte>(img.Width, img.Height);
                CvInvoke.DistanceTransform(open, dist, null, Emgu.CV.CvEnum.DistType.L2, 5);
                
                Image<Bgra, byte> color = new Image<Bgra, byte>(img.Width, img.Height);
                CvInvoke.ApplyColorMap(open, color, Emgu.CV.CvEnum.ColorMapType.Jet);
                Image<Gray, byte> sure = new Image<Gray, byte>(img.Width, img.Height);
                CvInvoke.Threshold(dist, sure, 126, 255, Emgu.CV.CvEnum.ThresholdType.Binary);

                //CvInvoke.Watershed(img, open);
                PbSegmentation.Image = img.ToBitmap();
                Tools.Histogram(ChartSegmentation, (Bitmap)PbSegmentation.Image);
                */
            }
        }

        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog x = new SaveFileDialog();
            x.Filter = "Image Files (*.png;*.jpg)|*.png;*.jpg";
            x.FileName = "Image";
            x.ShowDialog();

            try { PbSegmentation.Image.Save(x.FileName); }
            catch { }
        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog x = new SaveFileDialog();
            x.Filter = "Image Files (*.png;*.jpg)|*.png;*.jpg";
            x.FileName = "Histogram";
            x.ShowDialog();

            try { this.ChartSegmentation.SaveImage(x.FileName, ChartImageFormat.Jpeg); }
            catch { }
        }
    }
}
