using myPT.Core.Interfaces.View.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.View.State
{
    class HomeStateDefault : IHomeState
    {
        public bool CanEditSettings()
        {
            return true;
        }

        public bool CanStartSession()
        {
            return true;
        }

        public bool CanViewTimeline()
        {
            return true;
        }

        public Common.ViewState StateValue
        {
            get { return Common.ViewState.Default; }
        }

        public bool CanBack()
        {
            return false;
        }
    }
}
