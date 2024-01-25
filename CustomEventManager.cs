using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppActionDelegate
{
    public  class CustomEventManager
    {
        //public static event Action<object,Events> CreateMessageEvent;

        //public static void TriggerCreateMessageEvent(string message)
        //{
        //    CreateMessageEvent.Invoke(this, Events);
        //}
        public static event Action<object, CustomEventArgs> CustomEvent;

        // Method to trigger the event
        public  void RaiseCustomEvent(string message)
        {
            // Check if there are subscribers to the event
            if (CustomEvent != null)
            {
                // Create event arguments
                var eventArgs = new CustomEventArgs { Message = message };

                // Invoke the event, notifying all subscribers
                CustomEvent.Invoke(this, eventArgs);
            }
            else
            {
                Console.WriteLine("No subscribers to the event.");
            }
        }
    }

    public class CustomEventArgs : EventArgs
    {
        public string Message { get; set; }
    }
}
