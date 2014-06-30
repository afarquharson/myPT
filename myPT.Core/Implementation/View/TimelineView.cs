using myPT.Core.Interfaces.Model;
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
        public Dictionary<string, IHistoryItem> History { get; set; }

        public event EventHandler BackClicked;
        public event EventHandler ItemSelected;
        public event EventHandler AddClicked;
    }
}
