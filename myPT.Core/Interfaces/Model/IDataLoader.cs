using myPT.Core.Common;
using myPT.Core.Interfaces.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Interfaces.Model
{
    interface IDataLoader
    {
        void Load<TModel, TView>(TModel model, TView view, NavigationData data)
            where TView : IView
            where TModel : IDataModel;
    }
}
