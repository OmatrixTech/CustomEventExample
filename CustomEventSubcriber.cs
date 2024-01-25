using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfAppActionDelegate
{
    internal class CustomEventSubcriber
    {
        public static void SubscribeEvent(object arg1, CustomEventArgs arg2)
        {
            MessageBox.Show("Event raised by custom class method "+arg2.Message);
        }
    }
}
