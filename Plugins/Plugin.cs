using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Plugins
{
    public interface Plugin
    {
        Bitmap run(Bitmap bitmap);
        String PluginName();
    }
}
