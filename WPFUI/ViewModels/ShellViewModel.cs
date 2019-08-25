using Caliburn.Micro;
using WPFUI.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFUI.ViewModels;

namespace WPFUI.ViewModels
{
    public class ShellViewModel : Conductor<object>.Collection.OneActive, IHandle<SecondNestedUserControlVMCalledEvent>, IHandle<SecondNestedUserControlVMClosedEvent>
    {
        public ShellViewModel()
        {
            EventArggregatorProvider.DemoEventAggregator.Subscribe(this);
            ActivateItem(new FirstNestedUserControlViewModel());
        }

        public void Handle(SecondNestedUserControlVMCalledEvent message)
        {
            ActivateItem(new SecondNestedUserControlViewModel());
        }

        public void Handle(SecondNestedUserControlVMClosedEvent message)
        {
            ChangeActiveItem(Items.OfType<FirstNestedUserControlViewModel>().First(), true);
        }
    }
}
