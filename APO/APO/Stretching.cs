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
    class Stretching
    {
        public static Bitmap StretchGray(Bitmap bitmap, int max, int min)
        {
            Bitmap newBitmap = new Bitmap(bitmap);

            Dictionary<Color, int> histDic = Tools.HistogramMap(bitmap);

            for (int x = 0; x < bitmap.Width; ++x)
            {
                for (int y = 0; y < bitmap.Height; ++y)
                {
                    if (bitmap.GetPixel(x, y).R >= max)
                    {
                        Color newColor = Color.FromArgb(255, 255, 255);
                        newBitmap.SetPixel(x, y, newColor);
                    }
                    if (bitmap.GetPixel(x, y).R <= min)
                    {
                        Color newColor = Color.FromArgb(0, 0, 0);
                        newBitmap.SetPixel(x, y, newColor);
                    }
                    if ((bitmap.GetPixel(x, y).R > min) && (bitmap.GetPixel(x, y).R < max))
                    {
                        int color = (((bitmap.GetPixel(x, y).R - min) * 255) / (max - min));
                        Color newColor = Color.FromArgb(color, color, color);
                        newBitmap.SetPixel(x, y, newColor);
                    }
                }
            }
            return newBitmap;
        }

        public static Bitmap StretchRGB(Bitmap bitmap, int max, int min)
        {
            Bitmap newBitmap = new Bitmap(bitmap);

            Dictionary<Color, int> histDic = Tools.HistogramMap(bitmap);

            for (int x = 0; x < bitmap.Width; ++x)
            {
                for (int y = 0; y < bitmap.Height; ++y)
                {
                    if (bitmap.GetPixel(x, y).R > max)
                    {
                        Color newColor = Color.FromArgb(255, bitmap.GetPixel(x, y).G, bitmap.GetPixel(x, y).B);
                        bitmap.SetPixel(x, y, newColor);
                    }
                    if (bitmap.GetPixel(x, y).G > max)
                    {
                        Color newColor = Color.FromArgb(bitmap.GetPixel(x, y).R, 255, bitmap.GetPixel(x, y).B);
                        bitmap.SetPixel(x, y, newColor);
                    }
                    if (bitmap.GetPixel(x, y).B > max)
                    {
                        Color newColor = Color.FromArgb(bitmap.GetPixel(x, y).R, bitmap.GetPixel(x, y).G, 255);
                        bitmap.SetPixel(x, y, newColor);
                    }
                    // # 
                    // #
                    if (bitmap.GetPixel(x, y).R < min)
                    {
                        Color newColor = Color.FromArgb(0, bitmap.GetPixel(x, y).G, bitmap.GetPixel(x, y).B);
                        bitmap.SetPixel(x, y, newColor);
                    }
                    if (bitmap.GetPixel(x, y).G < min)
                    {
                        Color newColor = Color.FromArgb(bitmap.GetPixel(x, y).R, 0, bitmap.GetPixel(x, y).B);
                        bitmap.SetPixel(x, y, newColor);
                    }
                    if (bitmap.GetPixel(x, y).B < min)
                    {
                        Color newColor = Color.FromArgb(bitmap.GetPixel(x, y).R, bitmap.GetPixel(x, y).G, 0);
                        bitmap.SetPixel(x, y, newColor);
                    }


                    // # 
                    // #
                    if ((bitmap.GetPixel(x, y).R >= min) && (bitmap.GetPixel(x, y).R <= max))
                    {
                        int color = (((bitmap.GetPixel(x, y).R - min) * 255) / (max - min));
                        Color newColor = Color.FromArgb(color, bitmap.GetPixel(x, y).G, bitmap.GetPixel(x, y).B);
                        bitmap.SetPixel(x, y, newColor);
                    }
                    if ((bitmap.GetPixel(x, y).G >= min) && (bitmap.GetPixel(x, y).G <= max))
                    {
                        int color = (((bitmap.GetPixel(x, y).G - min) * 255) / (max - min));
                        Color newColor = Color.FromArgb(bitmap.GetPixel(x, y).R, color, bitmap.GetPixel(x, y).B);
                        bitmap.SetPixel(x, y, newColor);
                    }
                    if ((bitmap.GetPixel(x, y).B >= min) && (bitmap.GetPixel(x, y).B <= max))
                    {
                        int color = (((bitmap.GetPixel(x, y).B - min) * 255) / (max - min));
                        Color newColor = Color.FromArgb(bitmap.GetPixel(x, y).R, bitmap.GetPixel(x, y).G, color);
                        bitmap.SetPixel(x, y, newColor);
                    }

                    // # 
                    // #
                }
            }
            return bitmap;
        }


    }
}
