using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfAppActionDelegate
{
    internal class EvenSubscriber1
    {
        public EvenSubscriber1()
        {
            //EventManager.CustomEvent += EventManager_CustomEvent1;
            EventManager.CustomEvent += CustomEventSubcriber.SubscribeEvent;
            EventManager.CustomHandlerEvent += EventManager_CustomHandlerEvent;
        }

        private void EventManager_CustomHandlerEvent(object? sender, CustomEventArgs e)
        {
            MessageBox.Show("Event subscriber by EventHandler 1 " + e.Message);
        }

        private void EventManager_CustomEvent1(object arg1, CustomEventArgs arg2)
        {
            MessageBox.Show("Event subscriber "+arg2.Message);
        }

        private void EventManager_CustomEvent()
        {
           
        }
    }
}
