using myPT.Core.Interfaces.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.View
{
    class SessionView : ISessionView
    {
        public Interfaces.Model.ISession Session { get; set; }
        public IViewState State { get; set; }
        public string GUID { get; set; }
        public string ParentGUID { get; set; }

        public event EventHandler AchievementValueChanged;
        public event EventHandler StartSessionClicked;
        public event EventHandler BackClicked;

        public void Load(Common.NavigationData data)
        {
            throw new NotImplementedException();
        }
    }
}
