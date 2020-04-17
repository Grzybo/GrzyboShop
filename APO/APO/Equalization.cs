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
    class Equalization
    {
        public static Bitmap EqualGray(Bitmap bitmap)
        {
            Bitmap newBitmap = new Bitmap(bitmap);

            Dictionary<Color, int> map = Tools.HistogramMap(bitmap);
            int[] GrayLut = Tools.HistogramLUT(map);
            double[] D = new double[GrayLut.Length];
            int sum = 0;

            foreach (var x in GrayLut) { sum += x; }

            for (int i = 0; i < GrayLut.Length; ++i)
            {
                for (int j = 0; j < i; ++j)
                {
                    D[i] += GrayLut[j];
                }
                D[i] = D[i] / sum;
            }

            double D0 = 0;
            for (int i = D.Length - 1; i > 0; --i)
            {
                if (D[i] != 0) { D0 = D[i]; }
            }

            // ta tablica to wskażnik przejscia na nowy kolor / wartośc koloru!!! 

            Dictionary<int, int> LUT = new Dictionary<int, int>();

            for (int i = 0; i < D.Length; ++i)
            {
                LUT.Add(i, (int)(((D[i] - D0) / (1 - D0)) * (256 - 1)));
            }

            for (int x = 0; x < bitmap.Width; ++x)
            {
                for (int y = 0; y < bitmap.Height; ++y)
                {
                    Color newColor = Color.FromArgb(LUT[bitmap.GetPixel(x, y).R], LUT[bitmap.GetPixel(x, y).R], LUT[bitmap.GetPixel(x, y).R]);
                    newBitmap.SetPixel(x, y, newColor);
                }
            }
            return newBitmap;
        }

        public static Bitmap EqualRGB(Bitmap bitmap)
        {
            Dictionary<Color, int> map = Tools.HistogramMap(bitmap);
            int[] RedLut = Tools.HistogramLUT(map, "red");
            int[] GreenLut = Tools.HistogramLUT(map, "green");
            int[] BlueLut = Tools.HistogramLUT(map, "blue");
            double[] Dr = new double[RedLut.Length];
            double[] Dg = new double[GreenLut.Length];
            double[] Db = new double[BlueLut.Length];
            int sumR = 0;
            int sumG = 0;
            int sumB = 0;

            foreach (var x in RedLut) { sumR += x; }
            foreach (var x in GreenLut) { sumG += x; }
            foreach (var x in BlueLut) { sumB += x; }

            for (int i = 0; i < RedLut.Length; ++i)
            {
                for (int j = 0; j < i; ++j)
                {
                    Dr[i] += RedLut[j];
                    Dg[i] += GreenLut[j];
                    Db[i] += BlueLut[j];
                }
                Dr[i] = Dr[i] / sumR;
                Dg[i] = Dg[i] / sumG;
                Db[i] = Db[i] / sumB;
            }
            

            double Dr0 = 0;
            double Dg0 = 0;
            double Db0 = 0;

            for (int i = Dr.Length - 1; i > 0; --i)
            {
                if (Dr[i] != 0) { Dr0 = Dr[i]; }
                if (Dg[i] != 0) { Dg0 = Dg[i]; }
                if (Db[i] != 0) { Db0 = Db[i]; }
            }
            

            // ta tablica to wskażnik przejscia na nowy kolor / wartośc koloru!!! 

            Dictionary<int, int> LUTr = new Dictionary<int, int>();
            Dictionary<int, int> LUTg = new Dictionary<int, int>();
            Dictionary<int, int> LUTb = new Dictionary<int, int>();

            for (int i = 0; i < Dr.Length; ++i)
            {
                if (((int)(((Dr[i] - Dr0) / (1 - Dr0)) * (256 - 1))) < 0)
                { LUTr.Add(i, 0); }
                else
                {
                    LUTr.Add(i, (int)(((Dr[i] - Dr0) / (1 - Dr0)) * (256 - 1)));
                }
            }
            for (int i = 0; i < Dg.Length; ++i)
            {
                if (((int)(((Dg[i] - Dg0) / (1 - Dg0)) * (256 - 1))) < 0)
                { LUTg.Add(i, 0); }
                else
                {
                    LUTg.Add(i, (int)(((Dg[i] - Dg0) / (1 - Dg0)) * (256 - 1)));
                }
            }
            for (int i = 0; i < Db.Length; ++i)
            {
                if (((int)(((Db[i] - Db0) / (1 - Db0)) * (256 - 1))) < 0)
                { LUTb.Add(i, 0); }
                else
                {
                    LUTb.Add(i, (int)(((Db[i] - Db0) / (1 - Db0)) * (256 - 1)));
                }
            }

            for (int x = 0; x < bitmap.Width; ++x)
            {
                for (int y = 0; y < bitmap.Height; ++y)
                {
                    Color newColor = Color.FromArgb(LUTr[bitmap.GetPixel(x, y).R], LUTg[bitmap.GetPixel(x, y).G], LUTb[bitmap.GetPixel(x, y).B]);
                    bitmap.SetPixel(x, y, newColor);
                }
            }
            return bitmap;
        }
        // ############################# Selective #########################################################################
        public static Bitmap SelectiveEqualGray(Bitmap bitmap)
        {
            Bitmap newBitmap = new Bitmap(bitmap);

            Dictionary<Color, int> map = Tools.HistogramMap(bitmap);
            int[] GrayLut = Tools.HistogramLUT(map);
            double[] D = new double[GrayLut.Length];
            int sum = 0;

            foreach (var x in GrayLut) { sum += x; }

            for (int i = 0; i < GrayLut.Length; ++i)
            {
                for (int j = 0; j < i; ++j)
                {
                    D[i] += GrayLut[j];
                }
                D[i] = D[i] / sum;
            }

            double D0 = 0;
            for (int i = D.Length - 1; i > 0; --i)
            {
                if (D[i] != 0) { D0 = D[i]; }
            }

            // ta tablica to wskażnik przejscia na nowy kolor / wartośc koloru!!! 

            Dictionary<int, int> LUT = new Dictionary<int, int>();

            for (int i = 0; i < D.Length; ++i)
            {
                LUT.Add(i, (int)Math.Ceiling(255 * D[i])); // ew zamiast 5 - 255
            }

            for (int x = 0; x < bitmap.Width; ++x)
            {
                for (int y = 0; y < bitmap.Height; ++y)
                {
                    Color newColor = Color.FromArgb(LUT[bitmap.GetPixel(x, y).R], LUT[bitmap.GetPixel(x, y).R], LUT[bitmap.GetPixel(x, y).R]);
                    newBitmap.SetPixel(x, y, newColor);
                }
            }
            return newBitmap;
        }


        public static Bitmap SelectiveEqualRGB(Bitmap bitmap)
        {
            Dictionary<Color, int> map = Tools.HistogramMap(bitmap);
            int[] RedLut = Tools.HistogramLUT(map, "red");
            int[] GreenLut = Tools.HistogramLUT(map, "green");
            int[] BlueLut = Tools.HistogramLUT(map, "blue");
            double[] Dr = new double[RedLut.Length];
            double[] Dg = new double[GreenLut.Length];
            double[] Db = new double[BlueLut.Length];
            int sumR = 0;
            int sumG = 0;
            int sumB = 0;

            foreach (var x in RedLut) { sumR += x; }
            foreach (var x in GreenLut) { sumG += x; }
            foreach (var x in BlueLut) { sumB += x; }

            for (int i = 0; i < RedLut.Length; ++i)
            {
                for (int j = 0; j < i; ++j)
                {
                    Dr[i] += RedLut[j];
                    Dg[i] += GreenLut[j];
                    Db[i] += BlueLut[j];
                }
                Dr[i] = Dr[i] / sumR;
                Dg[i] = Dg[i] / sumG;
                Db[i] = Db[i] / sumB;
            }

            double Dr0 = 0;
            double Dg0 = 0;
            double Db0 = 0;

            for (int i = Dr.Length - 1; i > 0; --i)
            {
                if (Dr[i] != 0) { Dr0 = Dr[i]; }
                if (Dg[i] != 0) { Dg0 = Dg[i]; }
                if (Db[i] != 0) { Db0 = Db[i]; }
            }
            

            // ta tablica to wskażnik przejscia na nowy kolor / wartośc koloru!!! 

            Dictionary<int, int> LUTr = new Dictionary<int, int>();
            Dictionary<int, int> LUTg = new Dictionary<int, int>();
            Dictionary<int, int> LUTb = new Dictionary<int, int>();

            for (int i = 0; i < Dr.Length; ++i)
            {
                LUTr.Add(i, (int)Math.Ceiling(255 * Dr[i]));
                LUTg.Add(i, (int)Math.Ceiling(255 * Dg[i]));
                LUTb.Add(i, (int)Math.Ceiling(255 * Db[i]));
            }
            

            for (int x = 0; x < bitmap.Width; ++x)
            {
                for (int y = 0; y < bitmap.Height; ++y)
                {
                    Color newColor = Color.FromArgb(LUTr[bitmap.GetPixel(x, y).R], LUTg[bitmap.GetPixel(x, y).G], LUTb[bitmap.GetPixel(x, y).B]);
                    bitmap.SetPixel(x, y, newColor);
                }
            }
            return bitmap;

        }
    }
}
