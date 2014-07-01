using myPT.Core.Common;
using myPT.Core.Implementation.Model;
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
    class HomeView : IHomeView
    {
        public Dictionary<string, IProgram> Programs { get; set; }
        public IViewState State { get; set; }
        public string GUID { get; set; }
        public string ParentGUID { get; set; }
        
        private HomePresenter _presenter;
        public HomePresenter Presenter { get {return _presenter ?? (_presenter = new HomePresenter(this)); }}

        public event EventHandler SettingsClicked = delegate { };
        public event EventHandler AddProgramClicked = delegate { };
        public event EventHandler TimelineClicked = delegate { };
        public event EventHandler ItemSelected = delegate { };

        public void Load(NavigationData data)
        {
            Presenter.Load(data);
        }
    }
}
