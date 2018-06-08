using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReverseColors;
using System.Windows.Forms;
using System.Drawing;
using Plugins;

namespace ReverseColors
{
    public class ReverseColors : Plugin
    {
        public string PluginName()
        {
            return "Reverse Color Plugin";
        }

        public Bitmap run(Bitmap bitmap)
        {
            return invertColors(bitmap);
        }

        private Bitmap invertColors(Bitmap _currentBitmap)
        {
            Bitmap temp = (Bitmap)_currentBitmap;
            Bitmap bmap = (Bitmap)temp.Clone();
            Color c;
            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    c = bmap.GetPixel(i, j);
                    bmap.SetPixel(i, j, Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B));
                }
            }
            return bmap;
        }
    }
}
