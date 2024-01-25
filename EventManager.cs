using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppActionDelegate
{
    internal class EventManager
    {
        public static event EventHandler<CustomEventArgs> CustomHandlerEvent;
        public static event Action<object, CustomEventArgs> CustomEvent;
        public void RaiseCustomEvent(EventArgsModel model)
        {
            CustomEventArgs customEventArgs = new CustomEventArgs();
            customEventArgs.Message =model.Message;
            customEventArgs.lstStr = model.lstStr;
            CustomEvent?.Invoke(this, customEventArgs);
        }

        public void Raise_CustomHandlerEvent(EventArgsModel model)
        {
            CustomEventArgs customEventArgs = new CustomEventArgs();
            customEventArgs.Message = model.Message;
            customEventArgs.lstStr = model.lstStr;
            CustomHandlerEvent?.Invoke(this, customEventArgs);
        }

    }

    public class CustomEventArgs : EventArgs
    {
        public string Message { get; set; }
        public List<string> lstStr { get; set; }
    }
}
