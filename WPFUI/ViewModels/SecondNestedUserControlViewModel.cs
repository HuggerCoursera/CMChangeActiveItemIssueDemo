using Caliburn.Micro;
using WPFUI.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUI.ViewModels
{
    public class SecondNestedUserControlViewModel : Screen
    {
        public SecondNestedUserControlViewModel()
        {

        }

        public void Close()
        {
            SecondNestedUserControlVMClosedEvent closedEvent = new SecondNestedUserControlVMClosedEvent();
            EventArggregatorProvider.DemoEventAggregator.PublishOnUIThread(closedEvent);
        }
    }
}
