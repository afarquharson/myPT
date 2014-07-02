using myPT.Core.Interfaces.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.View.State
{
    class ActivityStateReadOnly : IViewState
    {
        public Common.ViewState StateValue
        {
            get { return Common.ViewState.ReadOnly; }
        }

        public string TopLeft
        {
            get { return "Back"; }
        }

        public string TopRight
        {
            get { return String.Empty; }
        }

        public string LowerLeft
        {
            get { return String.Empty; }
        }

        public string LowerRight
        {
            get { return String.Empty; }
        }

        public string ItemSelect
        {
            get { return String.Empty; }
        }
    }
}
