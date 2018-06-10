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

        private Bitmap invertColors(Bitmap pic)
        {
           
            for (int y = 0; (y <= (pic.Height - 1)); y++)
            {
                for (int x = 0; (x <= (pic.Width - 1)); x++)
                {
                    Color inv = pic.GetPixel(x, y);
                    inv = Color.FromArgb(255, (255 - inv.R), (255 - inv.G), (255 - inv.B));
                    pic.SetPixel(x, y, inv);
                }
            }
            return pic;
        }
    }
}
