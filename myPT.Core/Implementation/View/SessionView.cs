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
    public class SessionView : ISessionView
    {
        private SessionPresenter _presenter;
        public SessionPresenter Presenter { get {return _presenter ?? (_presenter = new SessionPresenter(this)); }}

        public ISession Session { get; set; }
        public IViewState State { get; set; }
        public string GUID { get; set; }
        public string ParentGUID { get; set; }

        public event EventHandler AchievementValueChanged = delegate { };
        public event EventHandler StartSessionClicked = delegate { };
        public event EventHandler BackClicked = delegate { };
        public event EventHandler ExerciseClicked = delegate { };

        public void Load(NavigationData data)
        {
            Presenter.Load(data);
        }

        public NavigationData Execute(CommandKey command, string[] data)
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, string> List
        {
            get
            {
                return Session.Print();
            }
        }
    }
}
