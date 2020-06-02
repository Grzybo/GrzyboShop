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
        private Bitmap bitmap;
        private System.IO.MemoryStream myStream = new System.IO.MemoryStream();
        private Stack<Bitmap> stack;
        public Panel panel;
        public StretchWindow(Bitmap bitmap, Panel panel)
        {
            InitializeComponent();
            this.panel = panel;
            this.bitmap = bitmap;
            StretchWindowPictureBox.Image = bitmap;
            StretchWindowPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            StretchWindowPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            Tools.Histogram(StretchWindowChart, (Bitmap)StretchWindowPictureBox.Image);
            stack = new Stack<Bitmap>();
            stack.Push(bitmap);

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
            if (Tools.IsGray(this.bitmap))
            {
                stack.Push((Bitmap)StretchWindowPictureBox.Image);
                Bitmap bitmap = Stretching.StretchGray((Bitmap)StretchWindowPictureBox.Image, TrackBarMax.Value, TrackBarMin.Value);
                StretchWindowPictureBox.Image = bitmap;
                this.bitmap = bitmap;
                Tools.HistogramGray(StretchWindowChart, (Bitmap)StretchWindowPictureBox.Image);
            }
            if (Tools.IsGray(this.bitmap) == false)
            {
                stack.Push((Bitmap)StretchWindowPictureBox.Image);
                Bitmap bitmap = Stretching.StretchRGB((Bitmap)StretchWindowPictureBox.Image, TrackBarMax.Value, TrackBarMin.Value);
                StretchWindowPictureBox.Image = bitmap;
                this.bitmap = bitmap;
                Tools.Histogram(StretchWindowChart, (Bitmap)StretchWindowPictureBox.Image);
            } 
            
        }

        private void RestoreDefaultImageButton_Click(object sender, EventArgs e)
        {
            if (stack.Count > 1)
            {
                StretchWindowPictureBox.Image = stack.Pop();  // nie działa dla rgb!!!!!! 

                if (Tools.IsGray(this.bitmap))
                {
                    Tools.HistogramGray(StretchWindowChart, (Bitmap)StretchWindowPictureBox.Image);
                }

                if (Tools.IsGray(this.bitmap) == false)
                {
                    Tools.Histogram(StretchWindowChart, (Bitmap)StretchWindowPictureBox.Image);
                }

                TrackBarMax.Value = 255;
                TrackBarMin.Value = 1;
            }
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            PictureWindow window = new PictureWindow((Bitmap)StretchWindowPictureBox.Image, panel) { TopLevel = false};
            panel.Controls.Add(window);
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
