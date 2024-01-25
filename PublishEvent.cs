using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppActionDelegate
{
    internal class PublishEvent
    {
        List<string> lstString=new List<string>();
        public PublishEvent() {
            lstString.Add("Lst1");
            lstString.Add("Lst2");
            lstString.Add("Lst3");
            EventManager eventManager = new EventManager();
            EventArgsModel model = new EventArgsModel();
            model.Message = "Demo Event Publish value";
            model.lstStr = lstString;
            eventManager.RaiseCustomEvent(model);
            eventManager.Raise_CustomHandlerEvent(model);
        }   
    }
}
