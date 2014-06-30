using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Interfaces.View.State
{
    interface IHomeState : IViewState
    {
        bool CanEditSettings();
        bool CanStartSession();
        bool CanViewTimeline();
    }
}
