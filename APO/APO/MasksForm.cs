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
    public partial class MasksForm : Form
    {
        public Image<Bgra, byte> image;
        private Emgu.CV.CvEnum.BorderType borderType = Emgu.CV.CvEnum.BorderType.Isolated;

        //TextBox[,] grid = new TextBox[7,7];

        public MasksForm(Image<Bgra, byte> image)
        {
            InitializeComponent();
            RadioButtonChange();
            MasksPictureBox.Image = image.ToBitmap();
            this.image = image;
            Tools.Histogram(MasksChart, (Bitmap)MasksPictureBox.Image);

            /*
            TextBox[,] grid = new TextBox[,]
            {
                { Row1Col1Value, Row1Col2Value, Row1Col3Value, Row1Col4Value, Row1Col5Value, Row1Col6Value, Row1Col7Value},
                { Row2Col1Value, Row2Col2Value, Row2Col3Value, Row2Col4Value, Row2Col5Value, Row2Col6Value, Row2Col7Value},
                { Row3Col1Value, Row3Col2Value, Row3Col3Value, Row3Col4Value, Row3Col5Value, Row3Col6Value, Row3Col7Value},
                { Row4Col1Value, Row4Col2Value, Row4Col3Value, Row4Col4Value, Row4Col5Value, Row4Col6Value, Row4Col7Value},
                { Row5Col1Value, Row5Col2Value, Row5Col3Value, Row5Col4Value, Row5Col5Value, Row5Col6Value, Row5Col7Value},
                { Row6Col1Value, Row6Col2Value, Row6Col3Value, Row6Col4Value, Row6Col5Value, Row6Col6Value, Row6Col7Value},
                { Row7Col1Value, Row7Col2Value, Row7Col3Value, Row7Col4Value, Row7Col5Value, Row7Col6Value, Row7Col7Value}
            };
            */

        }
        public MasksForm()
        {
            InitializeComponent();
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            float[,] k = Filter3x3();

            if (RadioButton5X5.Checked)
            {
                k = Filter5x5();
            }
            if (RadioButton7X7.Checked)
            {
                Filter7x7();
            }

            ConvolutionKernelF kernel = new ConvolutionKernelF(k);
            Image<Gray, float> imageFiltered = new Image<Gray, float>(image.Width, image.Height);
            Image<Gray, byte> imageGray = image.Convert<Gray, byte>();
            CvInvoke.Filter2D(imageGray, imageFiltered, kernel, new Point(-1, -1), 0, borderType);
            //Image<Gray, float> imageFiltered = imageGray * kernel;
            MasksPictureBox.Image = imageFiltered.ToBitmap();

            Tools.Histogram(MasksChart, (Bitmap)MasksPictureBox.Image);
        }
        private float[,] Filter3x3()
        {
            float[,] k = {  {Convert.ToInt32(Row1Col1Value.Text), Convert.ToInt32(Row1Col2Value.Text), Convert.ToInt32(Row1Col3Value.Text)},
                            {Convert.ToInt32(Row2Col1Value.Text), Convert.ToInt32(Row2Col2Value.Text), Convert.ToInt32(Row2Col3Value.Text)},
                            {Convert.ToInt32(Row3Col1Value.Text), Convert.ToInt32(Row3Col2Value.Text), Convert.ToInt32(Row3Col3Value.Text)}};
            return k;
        }


        private float[,] Filter5x5()
        {
            float[,] k = {  {Convert.ToInt32(Row1Col1Value.Text), Convert.ToInt32(Row1Col2Value.Text), Convert.ToInt32(Row1Col3Value.Text),
                            Convert.ToInt32(Row1Col4Value.Text), Convert.ToInt32(Row1Col5Value.Text)},
                            {Convert.ToInt32(Row2Col1Value.Text), Convert.ToInt32(Row2Col2Value.Text), Convert.ToInt32(Row2Col3Value.Text),
                            Convert.ToInt32(Row2Col4Value.Text), Convert.ToInt32(Row2Col5Value.Text)},
                            {Convert.ToInt32(Row3Col1Value.Text), Convert.ToInt32(Row3Col2Value.Text), Convert.ToInt32(Row3Col3Value.Text),
                            Convert.ToInt32(Row3Col4Value.Text), Convert.ToInt32(Row3Col5Value.Text)},
                            {Convert.ToInt32(Row4Col1Value.Text), Convert.ToInt32(Row4Col2Value.Text), Convert.ToInt32(Row4Col3Value.Text),
                            Convert.ToInt32(Row4Col4Value.Text), Convert.ToInt32(Row4Col5Value.Text)},
                            {Convert.ToInt32(Row5Col1Value.Text), Convert.ToInt32(Row5Col2Value.Text), Convert.ToInt32(Row5Col3Value.Text),
                            Convert.ToInt32(Row5Col4Value.Text), Convert.ToInt32(Row5Col5Value.Text)}};
            return k;
        }
        private float[,] Filter7x7()
        {
            float[,] k = {  {Convert.ToInt32(Row1Col1Value.Text), Convert.ToInt32(Row1Col2Value.Text), Convert.ToInt32(Row1Col3Value.Text),
                            Convert.ToInt32(Row1Col4Value.Text), Convert.ToInt32(Row1Col5Value.Text), Convert.ToInt32(Row1Col6Value.Text),
                            Convert.ToInt32(Row1Col7Value.Text)},
                            {Convert.ToInt32(Row2Col1Value.Text), Convert.ToInt32(Row2Col2Value.Text), Convert.ToInt32(Row2Col3Value.Text),
                            Convert.ToInt32(Row2Col4Value.Text), Convert.ToInt32(Row2Col5Value.Text), Convert.ToInt32(Row2Col6Value.Text),
                            Convert.ToInt32(Row2Col7Value.Text)},
                            {Convert.ToInt32(Row3Col1Value.Text), Convert.ToInt32(Row3Col2Value.Text), Convert.ToInt32(Row3Col3Value.Text),
                            Convert.ToInt32(Row3Col4Value.Text), Convert.ToInt32(Row3Col5Value.Text), Convert.ToInt32(Row3Col6Value.Text),
                            Convert.ToInt32(Row3Col7Value.Text)},
                            {Convert.ToInt32(Row1Col1Value.Text), Convert.ToInt32(Row4Col2Value.Text), Convert.ToInt32(Row4Col3Value.Text),
                            Convert.ToInt32(Row4Col4Value.Text), Convert.ToInt32(Row4Col5Value.Text), Convert.ToInt32(Row4Col6Value.Text),
                            Convert.ToInt32(Row4Col7Value.Text)},
                            {Convert.ToInt32(Row5Col1Value.Text), Convert.ToInt32(Row5Col2Value.Text), Convert.ToInt32(Row5Col3Value.Text),
                            Convert.ToInt32(Row5Col4Value.Text), Convert.ToInt32(Row5Col5Value.Text), Convert.ToInt32(Row5Col6Value.Text),
                            Convert.ToInt32(Row5Col7Value.Text)},
                            {Convert.ToInt32(Row6Col1Value.Text), Convert.ToInt32(Row6Col2Value.Text), Convert.ToInt32(Row6Col3Value.Text),
                            Convert.ToInt32(Row6Col4Value.Text), Convert.ToInt32(Row6Col5Value.Text), Convert.ToInt32(Row6Col6Value.Text),
                            Convert.ToInt32(Row6Col7Value.Text)},
                            {Convert.ToInt32(Row7Col1Value.Text), Convert.ToInt32(Row7Col2Value.Text), Convert.ToInt32(Row7Col3Value.Text),
                            Convert.ToInt32(Row7Col4Value.Text), Convert.ToInt32(Row7Col5Value.Text), Convert.ToInt32(Row7Col6Value.Text),
                            Convert.ToInt32(Row7Col7Value.Text)}};
            return k;

        }

        private void RadioButtonChange()
        {
            if (RadioButton3X3.Checked)
            {
                Checked3x3();
            }
            if (RadioButton5X5.Checked)
            {
                Checked5x5();
            }
            if (RadioButton7X7.Checked)
            {
                Checked7x7();
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



        private void Checked3x3()
        {
            Row1Col4Value.Enabled = false; Row1Col5Value.Enabled = false; Row1Col6Value.Enabled = false; Row1Col7Value.Enabled = false;
            Row2Col4Value.Enabled = false; Row2Col5Value.Enabled = false; Row2Col6Value.Enabled = false; Row2Col7Value.Enabled = false;
            Row3Col4Value.Enabled = false; Row3Col5Value.Enabled = false; Row3Col6Value.Enabled = false; Row3Col7Value.Enabled = false;
            Row4Col1Value.Enabled = false; Row4Col2Value.Enabled = false; Row4Col3Value.Enabled = false;
            Row4Col4Value.Enabled = false; Row4Col5Value.Enabled = false; Row4Col6Value.Enabled = false; Row4Col7Value.Enabled = false;
            Row5Col1Value.Enabled = false; Row5Col2Value.Enabled = false; Row5Col3Value.Enabled = false;
            Row5Col4Value.Enabled = false; Row5Col5Value.Enabled = false; Row5Col6Value.Enabled = false; Row5Col7Value.Enabled = false;
            Row6Col1Value.Enabled = false; Row6Col2Value.Enabled = false; Row6Col3Value.Enabled = false;
            Row6Col4Value.Enabled = false; Row6Col5Value.Enabled = false; Row6Col6Value.Enabled = false; Row6Col7Value.Enabled = false;
            Row7Col1Value.Enabled = false; Row7Col2Value.Enabled = false; Row7Col3Value.Enabled = false;
            Row7Col4Value.Enabled = false; Row7Col5Value.Enabled = false; Row7Col6Value.Enabled = false; Row7Col7Value.Enabled = false;
        }
        private void Checked5x5()
        {
            Row1Col4Value.Enabled = true; Row1Col5Value.Enabled = true;
            Row2Col4Value.Enabled = true; Row2Col5Value.Enabled = true;
            Row3Col4Value.Enabled = true; Row3Col5Value.Enabled = true;
            Row4Col1Value.Enabled = true; Row4Col2Value.Enabled = true; Row4Col3Value.Enabled = true;
            Row4Col4Value.Enabled = true; Row4Col5Value.Enabled = true;
            Row5Col1Value.Enabled = true; Row5Col2Value.Enabled = true; Row5Col3Value.Enabled = true;
            Row5Col4Value.Enabled = true; Row5Col5Value.Enabled = true;

            Row1Col6Value.Enabled = false; Row1Col7Value.Enabled = false;
            Row2Col6Value.Enabled = false; Row2Col7Value.Enabled = false;
            Row3Col6Value.Enabled = false; Row3Col7Value.Enabled = false;
            Row4Col6Value.Enabled = false; Row4Col7Value.Enabled = false;
            Row5Col6Value.Enabled = false; Row5Col7Value.Enabled = false;
            Row6Col6Value.Enabled = false; Row6Col7Value.Enabled = false;
            Row7Col6Value.Enabled = false; Row7Col7Value.Enabled = false;
            Row6Col1Value.Enabled = false; Row6Col2Value.Enabled = false; Row6Col3Value.Enabled = false;
            Row6Col4Value.Enabled = false; Row6Col5Value.Enabled = false;
            Row7Col1Value.Enabled = false; Row7Col2Value.Enabled = false; Row7Col3Value.Enabled = false;
            Row7Col4Value.Enabled = false; Row7Col5Value.Enabled = false;
        }
        private void Checked7x7()
        {
            Checked5x5();
            Row1Col6Value.Enabled = true; Row1Col7Value.Enabled = true;
            Row2Col6Value.Enabled = true; Row2Col7Value.Enabled = true;
            Row3Col6Value.Enabled = true; Row3Col7Value.Enabled = true;
            Row4Col6Value.Enabled = true; Row4Col7Value.Enabled = true;
            Row5Col6Value.Enabled = true; Row5Col7Value.Enabled = true;
            Row6Col6Value.Enabled = true; Row6Col7Value.Enabled = true;
            Row7Col6Value.Enabled = true; Row7Col7Value.Enabled = true;
            Row6Col1Value.Enabled = true; Row6Col2Value.Enabled = true; Row6Col3Value.Enabled = true;
            Row6Col4Value.Enabled = true; Row6Col5Value.Enabled = true;
            Row7Col1Value.Enabled = true; Row7Col2Value.Enabled = true; Row7Col3Value.Enabled = true;
            Row7Col4Value.Enabled = true; Row7Col5Value.Enabled = true;
        }

        private void Laplasian_1_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton3X3.Checked = true;
            Row1Col1Value.Text = Convert.ToString(0); Row1Col2Value.Text = Convert.ToString(-1); Row1Col3Value.Text = Convert.ToString(0);
            Row2Col1Value.Text = Convert.ToString(-1); Row2Col2Value.Text = Convert.ToString(4); Row2Col3Value.Text = Convert.ToString(-1);
            Row3Col1Value.Text = Convert.ToString(0); Row3Col2Value.Text = Convert.ToString(-1); Row3Col3Value.Text = Convert.ToString(0);
        }

        private void Laplasian_2_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton3X3.Checked = true;
            Row1Col1Value.Text = Convert.ToString(-1); Row1Col2Value.Text = Convert.ToString(-1); Row1Col3Value.Text = Convert.ToString(-1);
            Row2Col1Value.Text = Convert.ToString(-1); Row2Col2Value.Text = Convert.ToString(8); Row2Col3Value.Text = Convert.ToString(-1);
            Row3Col1Value.Text = Convert.ToString(-1); Row3Col2Value.Text = Convert.ToString(-1); Row3Col3Value.Text = Convert.ToString(-1);
        }

        private void Laplasian_3_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton3X3.Checked = true;
            Row1Col1Value.Text = Convert.ToString(1); Row1Col2Value.Text = Convert.ToString(-2); Row1Col3Value.Text = Convert.ToString(1);
            Row2Col1Value.Text = Convert.ToString(-2); Row2Col2Value.Text = Convert.ToString(4); Row2Col3Value.Text = Convert.ToString(-2);
            Row3Col1Value.Text = Convert.ToString(1); Row3Col2Value.Text = Convert.ToString(-2); Row3Col3Value.Text = Convert.ToString(1);
        }

        private void PrewittUpLeft_Click(object sender, EventArgs e)
        {
            RadioButton3X3.Checked = true;
            Row1Col1Value.Text = Convert.ToString(1); Row1Col2Value.Text = Convert.ToString(1); Row1Col3Value.Text = Convert.ToString(0);
            Row2Col1Value.Text = Convert.ToString(1); Row2Col2Value.Text = Convert.ToString(0); Row2Col3Value.Text = Convert.ToString(-1);
            Row3Col1Value.Text = Convert.ToString(0); Row3Col2Value.Text = Convert.ToString(-1); Row3Col3Value.Text = Convert.ToString(-1);
        }

        private void PrewittUp_Click(object sender, EventArgs e)
        {
            RadioButton3X3.Checked = true;
            Row1Col1Value.Text = Convert.ToString(1); Row1Col2Value.Text = Convert.ToString(1); Row1Col3Value.Text = Convert.ToString(1);
            Row2Col1Value.Text = Convert.ToString(0); Row2Col2Value.Text = Convert.ToString(0); Row2Col3Value.Text = Convert.ToString(0);
            Row3Col1Value.Text = Convert.ToString(-1); Row3Col2Value.Text = Convert.ToString(-1); Row3Col3Value.Text = Convert.ToString(-1);
        }

        private void PrewittUpRight_Click(object sender, EventArgs e)
        {
            RadioButton3X3.Checked = true;
            Row1Col1Value.Text = Convert.ToString(0); Row1Col2Value.Text = Convert.ToString(1); Row1Col3Value.Text = Convert.ToString(1);
            Row2Col1Value.Text = Convert.ToString(-1); Row2Col2Value.Text = Convert.ToString(0); Row2Col3Value.Text = Convert.ToString(1);
            Row3Col1Value.Text = Convert.ToString(-1); Row3Col2Value.Text = Convert.ToString(-1); Row3Col3Value.Text = Convert.ToString(0);
        }

        private void PrewittLeft_Click(object sender, EventArgs e)
        {
            RadioButton3X3.Checked = true;
            Row1Col1Value.Text = Convert.ToString(1); Row1Col2Value.Text = Convert.ToString(0); Row1Col3Value.Text = Convert.ToString(-1);
            Row2Col1Value.Text = Convert.ToString(1); Row2Col2Value.Text = Convert.ToString(0); Row2Col3Value.Text = Convert.ToString(-1);
            Row3Col1Value.Text = Convert.ToString(1); Row3Col2Value.Text = Convert.ToString(0); Row3Col3Value.Text = Convert.ToString(-1);
        }

        private void PrewittRight_Click(object sender, EventArgs e)
        {
            RadioButton3X3.Checked = true;
            Row1Col1Value.Text = Convert.ToString(-1); Row1Col2Value.Text = Convert.ToString(0); Row1Col3Value.Text = Convert.ToString(1);
            Row2Col1Value.Text = Convert.ToString(-1); Row2Col2Value.Text = Convert.ToString(0); Row2Col3Value.Text = Convert.ToString(1);
            Row3Col1Value.Text = Convert.ToString(-1); Row3Col2Value.Text = Convert.ToString(0); Row3Col3Value.Text = Convert.ToString(1);
        }

        private void PrewittDownLeft_Click(object sender, EventArgs e)
        {
            RadioButton3X3.Checked = true;
            Row1Col1Value.Text = Convert.ToString(0); Row1Col2Value.Text = Convert.ToString(-1); Row1Col3Value.Text = Convert.ToString(-1);
            Row2Col1Value.Text = Convert.ToString(1); Row2Col2Value.Text = Convert.ToString(0); Row2Col3Value.Text = Convert.ToString(-1);
            Row3Col1Value.Text = Convert.ToString(1); Row3Col2Value.Text = Convert.ToString(1); Row3Col3Value.Text = Convert.ToString(0);
        }

        private void PrewittDown_Click(object sender, EventArgs e)
        {
            RadioButton3X3.Checked = true;
            Row1Col1Value.Text = Convert.ToString(-1); Row1Col2Value.Text = Convert.ToString(-1); Row1Col3Value.Text = Convert.ToString(-1);
            Row2Col1Value.Text = Convert.ToString(0); Row2Col2Value.Text = Convert.ToString(0); Row2Col3Value.Text = Convert.ToString(0);
            Row3Col1Value.Text = Convert.ToString(1); Row3Col2Value.Text = Convert.ToString(1); Row3Col3Value.Text = Convert.ToString(1);
        }

        private void PrewittDownRight_Click(object sender, EventArgs e)
        {
            RadioButton3X3.Checked = true;
            Row1Col1Value.Text = Convert.ToString(-1); Row1Col2Value.Text = Convert.ToString(-1); Row1Col3Value.Text = Convert.ToString(0);
            Row2Col1Value.Text = Convert.ToString(-1); Row2Col2Value.Text = Convert.ToString(0); Row2Col3Value.Text = Convert.ToString(1);
            Row3Col1Value.Text = Convert.ToString(0); Row3Col2Value.Text = Convert.ToString(1); Row3Col3Value.Text = Convert.ToString(1);
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

        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog x = new SaveFileDialog();
            x.Filter = "Image Files (*.png;*.jpg)|*.png;*.jpg";
            x.FileName = "Image";
            x.ShowDialog();

            try { MasksPictureBox.Image.Save(x.FileName); }
            catch { }
        }

        private void doneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(MasksPictureBox.Image);
            Image<Bgra, byte> img = bitmap.ToImage<Bgra, byte>();
            NeighborhoodOperationsForm operationsForm = new NeighborhoodOperationsForm(img);
            operationsForm.Show();
            this.Close();
        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog x = new SaveFileDialog();
            x.Filter = "Image Files (*.png;*.jpg)|*.png;*.jpg";
            x.FileName = "Histogram";
            x.ShowDialog();

            try { this.MasksChart.SaveImage(x.FileName, ChartImageFormat.Jpeg); }
            catch { }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                image = new Image<Bgra, byte>(dialog.FileName);
                MasksPictureBox.Image = image.ToBitmap();
                Tools.Histogram(MasksChart, (Bitmap)MasksPictureBox.Image);
            }
        }
    }
}
