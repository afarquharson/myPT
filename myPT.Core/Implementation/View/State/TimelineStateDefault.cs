using myPT.Core.Interfaces.View.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.View.State
{
    class TimelineStateDefault : ITimelineState
    {
        public bool CanViewItem()
        {
            return true;
        }

        public bool CanAddItem()
        {
            return true;
        }

        public Common.ViewState State
        {
            get { return Common.ViewState.Default; }
        }

        public bool CanBack()
        {
            return true;
        }
    }
}
