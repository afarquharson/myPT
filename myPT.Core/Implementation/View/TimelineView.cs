using myPT.Core.Common;
using myPT.Core.Implementation.Presenter;
using myPT.Core.Interfaces.Model;
using myPT.Core.Interfaces.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.View
{
    public class TimelineView : ITimelineView
    {
        private TimelinePresenter _presenter;
        public TimelinePresenter Presenter { get {return _presenter ?? (_presenter = new TimelinePresenter(this)); }}

        public Dictionary<string, IHistoryItem> History { get; set; }
        public IViewState State { get; set; }
        public string GUID { get; set; }
        public string ParentGUID { get; set; }

        public Dictionary<string, string> List
        {
            get 
            { 
                var result = new Dictionary<string, string>();
                foreach (var i in History)
                {
                    result.Add(i.Value.GUID, i.Value.Summary);
                }
                return result;
            }
        }

        public event EventHandler BackClicked = delegate { };
        public event EventHandler ItemSelected = delegate { };
        public event EventHandler AddClicked = delegate { };

        public void Load(NavigationData data)
        {
            Presenter.Load(data);
        }

        public NavigationData Execute(CommandKey command, string[] data)
        {
            return Presenter.Execute(command, data);
        }
    }
}
