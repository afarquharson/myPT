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
    public class ActivityPresenter : Presenter
    {
        private IActivityView View
        {
            get
            {
                return (IActivityView)_view;
            }
            set
            {
                _view = value;
            }
        }

        public ActivityPresenter(IActivityView view, IDataLoaderFactory loader, IDataModel model)
            : base(loader, model, view)
        {
            Setup(view);
        }

        public ActivityPresenter(IActivityView view)
        {
            Setup(view);
        }

        private void Setup(IActivityView view)
        {
            View = view;
        }

        public void Load(NavigationData data)
        {
            _model = data.Model; //Use this model from now on
            Loader.GetLoader(data).Load<IDataModel, IActivityView>(View, data);
            Actions.Add(Command.PreviousActivity, PreviousActivity);
            Actions.Add(Command.NextActivity, NextActivity);
        }

        public void PreviousActivity()
        {
            //ToItem - infer the previous activity's GUID
            var thisActivityIndex = GetActivityIndex();
            if (thisActivityIndex > 0)
            {
                _navData.ToScreen = Command.ActivityUpdate;
                _navData.ToItem = _model.Sessions[_view.ParentGUID].Order.ElementAt(thisActivityIndex - 1);
            }
        }

        public void NextActivity()
        {
            //ToItem - infer the next activity's GUID
            var thisActivityIndex = GetActivityIndex();
            if (thisActivityIndex < _model.Sessions[_view.ParentGUID].Order.Count - 1)
            {
                _navData.ToScreen = Command.ActivityUpdate;
                _navData.ToItem = _model.Sessions[_view.ParentGUID].Order.ElementAt(thisActivityIndex + 1);
            }
        }

        private int GetActivityIndex()
        {
            return _model.Sessions[_view.ParentGUID].Order.IndexOf(_view.GUID);
        }
    }
}
