using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPlugin1;
using System.Windows.Forms;
using Plugins;

namespace MyPlugin1
{
    public class MyPlugin1 : Plugin
    {
        public string PluginName()
        {
            return "Reverse Color Plugin";
        }

        public void run()
        {
            MessageBox.Show("Test");
        }
    }
}
