using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Windows.Forms.DataVisualization.Charting;

namespace APO
{
    class Operations
    {
        public static Bitmap Negation(Bitmap bitmap)
        {
            Bitmap newBitmap = new Bitmap(bitmap);

            for (int x = 0; x < bitmap.Width; ++x)
            {
                for (int y = 0; y < bitmap.Height; ++y)
                {
                    Color newColor = Color.FromArgb(255 - (newBitmap.GetPixel(x, y).R),
                                                    255 - (newBitmap.GetPixel(x, y).G),
                                                    255 - (newBitmap.GetPixel(x, y).B));
                    newBitmap.SetPixel(x, y, newColor);
                }
            }
            return newBitmap;
        }



        public static Bitmap Thresholding(Bitmap bitmap, int p)
        {
            Bitmap newBitmap = new Bitmap(bitmap);

            for (int x = 0; x < bitmap.Width; ++x)
            {
                for (int y = 0; y < bitmap.Height; ++y)
                {
                    Color newColor = Color.FromArgb(Threshold(newBitmap.GetPixel(x, y).R,p),
                                                    Threshold(newBitmap.GetPixel(x, y).R, p),
                                                    Threshold(newBitmap.GetPixel(x, y).R, p));
                    newBitmap.SetPixel(x, y, newColor);
                }
            }
            return newBitmap;
        }

        public static Bitmap Thresholding2(Bitmap bitmap, int p1,int p2)
        {
            Bitmap newBitmap = new Bitmap(bitmap);

            for (int x = 0; x < bitmap.Width; ++x)
            {
                for (int y = 0; y < bitmap.Height; ++y)
                {
                    Color newColor = Color.FromArgb(Threshold2(newBitmap.GetPixel(x, y).R, p1,p2),
                                                    Threshold2(newBitmap.GetPixel(x, y).R, p1,p2),
                                                    Threshold2(newBitmap.GetPixel(x, y).R, p1,p2));
                    newBitmap.SetPixel(x, y, newColor);
                }
            }
            return newBitmap;
        }

        private static int Threshold(int value,int p)
        {
            if (value <= p) { return 0; }
            else { return 255; }
        }
        private static int Threshold2(int value, int p1,int p2)
        {
            if ((value >= p1 )&&(value <= p2)) { return value; }
            else  { return 0; }
        }

        public static Bitmap Reduction(Bitmap bitmap, int n) // n - liczba poziomow szarosci 
        {
            Bitmap newBitmap = new Bitmap(bitmap);
            int p = 256 / n; // ile przedziałek!  n = 4 -> 4 czesci -> 3 przedziałki   |--1--|--2--|--3--|--4--|
            Dictionary<Color, int> map = Tools.HistogramMap(bitmap); //                          1     2     3


            int p0 = 0;
            int p1 = 0; 

            for (int i = 0; i < n; ++i) {
                p0 = p1;
                p1 = p1 + p;
                for (int x = 0; x < bitmap.Width; ++x)
                {
                    for (int y = 0; y < bitmap.Height; ++y)
                    {
                        Color newColor  = Color.FromArgb(0,0,0);

                        if ((bitmap.GetPixel(x,y).R >= p0) && (bitmap.GetPixel(x, y).R < p1)){
                            newColor = Color.FromArgb(p0 + (n / 2),newColor.G, newColor.B);
                        }
                        if ((bitmap.GetPixel(x, y).G >= p0) && (bitmap.GetPixel(x, y).G < p1))
                        {
                            newColor = Color.FromArgb(newColor.R, p0 + (n / 2), newColor.B);
                        }
                        if ((bitmap.GetPixel(x, y).B >= p0) && (bitmap.GetPixel(x, y).B < p1))
                        {
                            newColor = Color.FromArgb(newColor.R, newColor.G, p0 + (n / 2));
                        }
                        newBitmap.SetPixel(x, y, newColor);

                    }
                }
            }
            return newBitmap;
        }


    }
}
