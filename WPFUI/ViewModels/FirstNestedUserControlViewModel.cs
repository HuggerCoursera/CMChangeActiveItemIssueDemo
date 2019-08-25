using Caliburn.Micro;
using WPFUI;
using WPFUI.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUI.ViewModels
{
    public class FirstNestedUserControlViewModel : Screen
    {
        public FirstNestedUserControlViewModel()
        {

        }

        public void OpenSecondScreen()
        {
            SecondNestedUserControlVMCalledEvent calledEvent = new SecondNestedUserControlVMCalledEvent();
            EventArggregatorProvider.DemoEventAggregator.PublishOnUIThread(calledEvent);
        }
    }
}
