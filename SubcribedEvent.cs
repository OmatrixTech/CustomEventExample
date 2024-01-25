using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfAppActionDelegate
{
    public class SubcribedEvent
    {
        public SubcribedEvent()
        {
           // CustomEventManager.CreateMessageEvent += CustomEventManager_CreateMessageEvent;
        }

        private void CustomEventManager_CreateMessageEvent()
        {
            MessageBox.Show("Custom event subscribed here");
        }
    }
}
