using myPT.Core.Interfaces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.Presenter.Loader
{
    class EmptyDataLoader : IDataLoader
    {
        public void Load<TModel, TView>(TView view, Common.NavigationData data)
            where TModel : IDataModel
            where TView : Interfaces.View.IView
        {
            
        }

        public void Save<TView, TModel>(TView view, TModel model)
            where TView : Interfaces.View.IView
            where TModel : IDataModel
        {
            
        }
    }
}
