using myPT.Core.Common;
using myPT.Core.Interfaces.Model;
using myPT.Core.Interfaces.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.Presenter
{
    class SessionPresenter : Presenter
    {
        private ISessionView View;

        public SessionPresenter(ISessionView view, IDataLoaderFactory loader, IDataModel model) : base(loader, model) 
        {
            Setup(view);
        }

        public SessionPresenter(ISessionView view) : base()
        {
            Setup(view);
        }

        public void Setup(ISessionView view)
        {
            View = view;

            View.AchievementValueChanged += View_AchievementValueChanged;
            View.BackClicked += View_BackClicked;
            View.StartSessionClicked += View_StartSessionClicked;
        }

        public void Load(NavigationData data)
        {
            Loader.GetLoader(data).Load<IDataModel, ISessionView>(Model, View, data);
        }

        void View_StartSessionClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void View_BackClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void View_AchievementValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
