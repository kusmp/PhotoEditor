using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using RotateFlip;
using Plugins;


namespace RotateFlip
{
    public class RotateFlip : Plugin
    {
        public string PluginName()
        {
            return "RotateFlip Plugin";
        }

        public Bitmap run(Bitmap bitmap)
        {
            return RotateAndFlip(bitmap);
        }

        private Bitmap RotateAndFlip(Bitmap _currentBitmap)
        {
            Bitmap temp = (Bitmap)_currentBitmap;
            Bitmap bmap = (Bitmap)temp.Clone();
            bmap.RotateFlip(RotateFlipType.Rotate180FlipY);
            return bmap;
        }
    }
}
