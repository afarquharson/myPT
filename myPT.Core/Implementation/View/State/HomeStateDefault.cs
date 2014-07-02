using myPT.Core.Interfaces.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.View.State
{
    class HomeStateDefault : IViewState
    {
        public Common.ViewState StateValue
        {
            get { return Common.ViewState.Default; }
        }

        public string TopLeft
        {
            get { return "Back"; }
        }

        public string TopRight
        {
            get { return "About"; }
        }

        public string LowerLeft
        {
            get { return "AddProgram"; }
        }

        public string LowerRight
        {
            get { return "ViewTimeline"; }
        }

        public string ItemSelect
        {
            get { return "ViewProgram"; }
        }
    }
}
