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
    public class ActivityView : IActivityView
    {
        private ActivityPresenter _presenter;
        public ActivityPresenter Presenter { get { return _presenter ?? (_presenter = new ActivityPresenter(this)); } }
        public IActivity Activity { get; set; }
        public IViewState State  { get; set; }
        public string GUID { get; set; }
        public string ParentGUID { get; set; }

        public event EventHandler BackClicked = delegate { };

        public Dictionary<string, string> List
        {
            get { return Activity.Print(); }
        }

        public void Load(Common.NavigationData data)
        {
            Presenter.Load(data);
        }

        public void Execute(Common.CommandKey command, string[] data)
        {
            throw new NotImplementedException();
        }
    }
}
