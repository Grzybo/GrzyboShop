﻿using System;
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

    class Tools
    {
        public static Size FitSize(Size pictureSize)
        {
            int newHeight, newWidth;

            if ((pictureSize.Height >= MainForm.ActiveForm.Size.Height) || (pictureSize.Width >= MainForm.ActiveForm.Size.Width))
            {
                newHeight = (int)(pictureSize.Height * 0.5);
                newWidth = (int)(pictureSize.Width * 0.5);
            }
            else
            {
                newHeight = pictureSize.Height;
                newWidth = pictureSize.Width;
            }

            Size newSize = new Size(newWidth, newHeight);

            return newSize;
        }

        public static Dictionary<Color, int> HistogramMap(Bitmap bitmap)
        {

            Dictionary<Color, int> histDic = new Dictionary<Color, int>();

            for (int x = 0; x < bitmap.Width; ++x)
            {
                for (int y = 0; y < bitmap.Height; ++y)
                {
                    Color color = bitmap.GetPixel(x, y);
                    if (histDic.ContainsKey(color))
                        histDic[color] = histDic[color] + 1;
                    else
                        histDic.Add(color, 1);
                }
            } 
            return histDic;

        }

        public static int[] HistogramLUT(Dictionary<Color, int> histogramMap, string color = "red")
        {
            Dictionary<byte, int> pairs = new Dictionary<byte, int>();
            int[] LUT = new int[256];

            switch (color)
            {
                case "red":
                    foreach (var key in histogramMap.Keys)
                    {
                        if (pairs.ContainsKey(key.R))
                            pairs[key.R] += histogramMap[key];
                        else
                            pairs.Add(key.R, histogramMap[key]);
                    }
                    foreach (var key in pairs.Keys)
                    {
                        LUT[key] = pairs[key];
                    }
                    break;

                case "green":
                    foreach (var key in histogramMap.Keys)
                    {
                        if (pairs.ContainsKey(key.G))
                            pairs[key.G] += histogramMap[key];
                        else
                            pairs.Add(key.G, histogramMap[key]);
                    }
                    foreach (var key in pairs.Keys)
                    {
                        LUT[key] = pairs[key];
                    }
                    break;
                case "blue":
                    foreach (var key in histogramMap.Keys)
                    {
                        if (pairs.ContainsKey(key.B))
                            pairs[key.B] += histogramMap[key];
                        else
                            pairs.Add(key.B, histogramMap[key]);
                    }
                    foreach (var key in pairs.Keys)
                    {
                        LUT[key] = pairs[key];
                    }
                    break;
            }
            return LUT;
        }

        

       




    }
}
