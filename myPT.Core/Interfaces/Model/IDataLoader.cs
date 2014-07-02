using myPT.Core.Common;
using myPT.Core.Interfaces.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Interfaces.Model
{
    public interface IDataLoader
    {
        void Load<TModel, TView>(TView view, NavigationData data)
            where TModel : IDataModel
            where TView : IView;

        void Save<TView, TModel>(TView view, TModel model)
            where TView : IView
            where TModel : IDataModel;
    }
}
