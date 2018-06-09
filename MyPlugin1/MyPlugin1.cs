using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPlugin1;
using System.Windows.Forms;
using Plugins;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;


namespace MyPlugin1
{
    public class MyPlugin1 : Plugin
    {
        public string PluginName()
        {
            return "GrayScale Plugin";
        }

        public Bitmap run(Bitmap bitmap)
        {
           return SetGrayscale(bitmap);
        }

        public Bitmap SetGrayscale(Bitmap _currentBitmap)
        {
            Bitmap temp = (Bitmap)_currentBitmap;
            Bitmap bmap = (Bitmap)temp.Clone();
            Color c;
            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    c = bmap.GetPixel(i, j);
                    byte gray = (byte)(.299 * c.R + .587 * c.G + .114 * c.B);

                    bmap.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                }
            }
            return bmap;
        }


    }
}
