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
    public class TimelinePresenter : Presenter
    {
        private ITimelineView View
        {
            get
            {
                return (ITimelineView)_view;
            }
            set
            {
                _view = value;
            }
        }

        public TimelinePresenter(ITimelineView view, IDataLoaderFactory loader, IDataModel model) : base(loader, model, view) 
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
        }

        public void Load(NavigationData data)
        {
            _model = data.Model; //Use this model from now on
            Loader.GetLoader(data).Load<IDataModel, ITimelineView>(View, data);
        }
    }
}
