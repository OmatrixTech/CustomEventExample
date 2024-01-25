using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppActionDelegate
{
    internal class EventSubscriber
    {
        public EventSubscriber()
        {
            CustomEventManager.CustomEvent += CustomEventManager_CustomEvent;
        }

        private void CustomEventManager_CustomEvent(object arg1, CustomEventArgs arg2)
        {
            Console.WriteLine(arg2.Message);
        }

        private void CustomEventManager_CreateMessageEvent()
        {
            
        }
    }
}
