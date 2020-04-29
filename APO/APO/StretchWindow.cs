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

namespace APO
{
    public partial class StretchWindow : Form
    {
        private PictureWindow pictureWindow;
        private System.IO.MemoryStream myStream = new System.IO.MemoryStream();

        public StretchWindow(PictureWindow pictureWindow)
        {
            InitializeComponent();
            this.pictureWindow = pictureWindow;
            StretchWindowPictureBox.Image = this.pictureWindow.bitmap;
            StretchWindowPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            StretchWindowPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureWindow.chart.Serializer.Save(myStream);

            StretchWindowChart.Serializer.Load(myStream);
            StretchWindowChart.Show();

        }

        private void TrackBarMin_ValueChanged(object sender, EventArgs e)
        {
            if (TrackBarMin.Value > TrackBarMax.Value) {
                TrackBarMin.Value = TrackBarMax.Value;
            }
            TrackBarMinValueTextBox.Text = Convert.ToString(TrackBarMin.Value);
        }

        private void TrackBarMax_ValueChanged(object sender, EventArgs e)
        {
            if (TrackBarMin.Value > TrackBarMax.Value)
            {
                TrackBarMin.Value = TrackBarMax.Value;
            }
            TrackBarMaxValueTextBox.Text = Convert.ToString(TrackBarMax.Value);
        }

        private void CalculateStrechButton_Click(object sender, EventArgs e)
        {
            if (this.pictureWindow.gray)
            {

                Bitmap bitmap = Stretching.StretchGray((Bitmap)StretchWindowPictureBox.Image, TrackBarMax.Value, TrackBarMin.Value);
                StretchWindowPictureBox.Image = bitmap;

                Tools.HistogramGray(StretchWindowChart, (Bitmap)StretchWindowPictureBox.Image);
            }
            if (this.pictureWindow.rgb)
            {
                StretchWindowPictureBox.Image = Stretching.StretchRGB((Bitmap)StretchWindowPictureBox.Image, TrackBarMax.Value, TrackBarMin.Value);

                Tools.Histogram(StretchWindowChart, (Bitmap)StretchWindowPictureBox.Image);
            }
        }

        private void RestoreDefaultImageButton_Click(object sender, EventArgs e)
        {
            StretchWindowPictureBox.Image = this.pictureWindow.bitmap; // nie działa dla rgb!!!!!! 

            if (this.pictureWindow.gray)
            {
                Tools.HistogramGray(StretchWindowChart, (Bitmap)StretchWindowPictureBox.Image);
            }

            if (this.pictureWindow.rgb)
            {
                Tools.Histogram(StretchWindowChart, (Bitmap)StretchWindowPictureBox.Image);
            }

            TrackBarMax.Value = 255;
            TrackBarMin.Value = 1;
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            PictureWindow window = new PictureWindow((Bitmap)StretchWindowPictureBox.Image);
            window.Show();
            this.Close();
        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog x = new SaveFileDialog();
            x.Filter = "Image Files (*.png;*.jpg)|*.png;*.jpg";
            x.FileName = "Stretched Histogram";
            x.ShowDialog();

            try { this.StretchWindowChart.SaveImage(x.FileName, ChartImageFormat.Jpeg); }
            catch { }
        }

        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog x = new SaveFileDialog();
            x.Filter = "Image Files (*.png;*.jpg)|*.png;*.jpg";
            x.FileName = "Image";
            x.ShowDialog();

            try { this.StretchWindowPictureBox.Image.Save(x.FileName); }
            catch { }
        }
    }
}
