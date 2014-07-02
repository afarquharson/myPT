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
        private IActivityView View;

        public ActivityPresenter(IActivityView view, IDataLoaderFactory loader, IDataModel model)
            : base(loader, model)
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

            View.BackClicked += View_BackClicked;
        }

        public void Load(NavigationData data)
        {
            base._model = data.Model; //Use this model from now on
            Loader.GetLoader(data).Load<IDataModel, IActivityView>(View, data);
        }

        private void View_BackClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
