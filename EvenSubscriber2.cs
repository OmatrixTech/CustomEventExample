using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfAppActionDelegate
{
    internal class EvenSubscriber2
    {
        public EvenSubscriber2()
        {
            EventManager.CustomEvent += EventManager_CustomEvent1;
            EventManager.CustomHandlerEvent += EventManager_CustomHandlerEvent;
        }

        private void EventManager_CustomHandlerEvent(object? sender, CustomEventArgs e)
        {
            MessageBox.Show("Event subscriber by EventHandler 2" + e.Message);
        }

        private void EventManager_CustomEvent1(object arg1, CustomEventArgs arg2)
        {
            MessageBox.Show("Event subscriber "+arg2.Message);
        }

        private void EventManager_CustomEvent()
        {
            MessageBox.Show("Event subscriber 2");
        }
    }
}
