﻿using System;
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
using System.Runtime.Remoting.Messaging;

namespace APO
{
    public partial class MasksForm : Form
    {
        public Image<Bgra, byte> image;
        private Emgu.CV.CvEnum.BorderType borderType = Emgu.CV.CvEnum.BorderType.Isolated;
        public Panel panel;

        TextBox[,] grid;

        public MasksForm(Image<Bgra, byte> image, Panel panel)
        {
            InitializeComponent();
            this.grid = MakeGrid();
            RadioButtonChange();
            MasksPictureBox.Image = image.ToBitmap();
            this.image = image;
            Tools.Histogram(MasksChart, (Bitmap)MasksPictureBox.Image);
            Checked3x3();
            this.panel = panel;

        }
        public MasksForm(Panel panel)
        {
            InitializeComponent();
            this.grid = MakeGrid();
            Checked3x3();
            this.panel = panel;
            

        }

        private TextBox[,] MakeGrid() 
        {
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
            return grid;
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            if (image == null)
            {
                MessageBox.Show("You didn't pick an image!");
                return;
            }
            
            
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
            Image<Gray, byte> imageFiltered = new Image<Gray, byte>(image.Width, image.Height);
            Image<Gray, byte> imageGray = image.Convert<Gray, byte>();
            CvInvoke.Filter2D(imageGray, imageFiltered, kernel, new Point(-1, -1), 0, borderType); 
            
            MasksPictureBox.Image = imageFiltered.ToBitmap();

            Tools.Histogram(MasksChart, (Bitmap)MasksPictureBox.Image);
        }
        private void BtnMedianFilter_Click(object sender, EventArgs e)
        {
            int size = 3;

            if (RadioButton5X5.Checked)
            {
                size = 5;
            }
            if (RadioButton7X7.Checked)
            {
                size = 7;
            }

            CvInvoke.MedianBlur(image, image, size);
            MasksPictureBox.Image = image.ToBitmap();
            Tools.Histogram(MasksChart, (Bitmap)MasksPictureBox.Image);
        }
        private float[,] Filter3x3()
        {
            float[,] k = new float[3,3];
            for (int i = 0; i < 3; ++i)
                for (int j = 0; j < 3; ++j)
                    k[i, j] = Convert.ToInt32(grid[i, j].Text);

            return k;
        }


        private float[,] Filter5x5()
        {
            float[,] k = new float[5, 5];
            for (int i = 0; i < 5; ++i)
                for (int j = 0; j < 5; ++j)
                    k[i, j] = Convert.ToInt32(grid[i, j].Text);
            return k;
        }
        private float[,] Filter7x7()
        {
            float[,] k = new float[7, 7];
            for (int i = 0; i < 7; ++i)
                for (int j = 0; j < 7; ++j)
                    k[i, j] = Convert.ToInt32(grid[i, j].Text);
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
            for (int i = 0; i < 7; ++i)
                for (int j = 0; j < 7; ++j)
                    grid[i, j].Enabled = false;

            for (int i = 0; i < 3; ++i)
                for (int j = 0; j < 3; ++j)
                    grid[i, j].Enabled = true;

        }
        private void Checked5x5()
        {
            for (int i = 0; i < 7; ++i)
                for (int j = 0; j < 7; ++j)
                    grid[i, j].Enabled = false;
            for (int i = 0; i < 5; ++i)
                for (int j = 0; j < 5; ++j)
                    grid[i, j].Enabled = true;
        }
        private void Checked7x7()
        {
            for (int i = 0; i < 7; ++i)
                for (int j = 0; j < 7; ++j)
                    grid[i, j].Enabled = true;
        }

        private void Laplasian_1_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton3X3.Checked = true;
            string[,] mask = {
                                { "0", "-1", "0"},
                                { "-1", "4", "-1"},
                                { "0", "-1", "0"}
            };

            Tools.toGrid(this.grid, mask);
        }

        private void Laplasian_2_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton3X3.Checked = true;
            string[,] mask = {
                                { "-1", "-1", "-1"},
                                { "-1", "8", "-1"},
                                { "-1", "-1", "-1"}
            };

            Tools.toGrid(this.grid, mask);
            
        }

        private void Laplasian_3_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton3X3.Checked = true;
            string[,] mask = {
                                { "1", "-2", "1"},
                                { "-2", "4", "-2"},
                                { "1", "-2", "1"}
            };

            Tools.toGrid(this.grid, mask);
        }

        private void PrewittUpLeft_Click(object sender, EventArgs e)
        {
            RadioButton3X3.Checked = true;
            string[,] mask = {
                                { "1", "1", "0"},
                                { "1", "0", "-1"},
                                { "0", "-1", "-1"}
            };

            Tools.toGrid(this.grid, mask);
        }

        private void PrewittUp_Click(object sender, EventArgs e)
        {
            RadioButton3X3.Checked = true;
            string[,] mask = {
                                { "1", "1", "1"},
                                { "0", "0", "0"},
                                { "-1", "-1", "-1"}
            };

            Tools.toGrid(this.grid, mask);
            
        }

        private void PrewittUpRight_Click(object sender, EventArgs e)
        {
            RadioButton3X3.Checked = true;
            string[,] mask = {
                                { "0", "1", "1"},
                                { "-1", "0", "1"},
                                { "-1", "-1", "0"}
            };

            Tools.toGrid(this.grid, mask);
        }

        private void PrewittLeft_Click(object sender, EventArgs e)
        {
            RadioButton3X3.Checked = true;
            string[,] mask = {
                                { "1", "0", "-1"},
                                { "1", "0", "-1"},
                                { "1", "0", "-1"}
            };

            Tools.toGrid(this.grid, mask);
        }

        private void PrewittRight_Click(object sender, EventArgs e)
        {

            RadioButton3X3.Checked = true;
            string[,] mask = {
                                { "-1", "0", "1"},
                                { "-1", "0", "1"},
                                { "-1", "0", "1"}
            };

            Tools.toGrid(this.grid, mask); 
        }

        private void PrewittDownLeft_Click(object sender, EventArgs e)
        {
            RadioButton3X3.Checked = true;
            string[,] mask = {
                                { "0", "-1", "-1"},
                                { "1", "0", "-1"},
                                { "1", "1", "0"}
            };

            Tools.toGrid(this.grid, mask);
        }

        private void PrewittDown_Click(object sender, EventArgs e)
        {
            RadioButton3X3.Checked = true;
            string[,] mask = {
                                { "-1", "-1", "-1"},
                                { "0", "0", "0"},
                                { "1", "1", "1"}
            };

            Tools.toGrid(this.grid, mask);
        }

        private void PrewittDownRight_Click(object sender, EventArgs e)
        {
            RadioButton3X3.Checked = true;
            string[,] mask = {
                                { "-1", "-1", "0"},
                                { "-1", "0", "1"},
                                { "0", "1", "1"}
            };

            Tools.toGrid(this.grid, mask);
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
            NeighborhoodOperationsForm operationsForm = new NeighborhoodOperationsForm(img, panel) { TopLevel = false};
            panel.Controls.Add(panel);
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

        private void ConvolutionButton_Click(object sender, EventArgs e)
        {

        }

    }
}
