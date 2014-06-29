using myPT.Core.Interfaces.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.View
{
    class TimelineView : ITimelineView
    {
        public List<Interfaces.Model.IHistoryItem> History
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public event EventHandler BackClicked;

        public event EventHandler ItemSelected;

        public event EventHandler AddClicked;
    }
}
