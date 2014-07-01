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
    class TimelinePresenter : Presenter
    {
        private ITimelineView View;

        public TimelinePresenter(ITimelineView view, IDataLoaderFactory loader, IDataModel model) : base(loader, model) 
        {
            Setup(view);
        }

        public TimelinePresenter(ITimelineView view) : base()
        {
            Setup(view);
        }

        public void Setup(ITimelineView view)
        {
            View = view;

            View.AddClicked += View_AddClicked;
            View.BackClicked += View_BackClicked;
            View.ItemSelected += View_ItemSelected;
        }

        public void Load(NavigationData data)
        {
            Loader.GetLoader(data).Load<IDataModel, ITimelineView>(Model, View, data);
        }

        void View_ItemSelected(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void View_BackClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void View_AddClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
