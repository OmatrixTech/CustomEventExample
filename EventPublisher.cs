using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppActionDelegate
{
    public class EventPublisher
    {
        public EventPublisher()
        {
            CustomEventManager customEventManager = new CustomEventManager();
            customEventManager.RaiseCustomEvent("Custom Event");
        }
    }
}
