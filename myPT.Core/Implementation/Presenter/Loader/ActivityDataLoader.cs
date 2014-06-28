using myPT.Core.Common;
using myPT.Core.Implementation.Model;
using myPT.Core.Interfaces;
using myPT.Core.Interfaces.Model;
using myPT.Core.Interfaces.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myPT.Core.Implementation
{
    class ActivityDataLoader : IDataLoader
    {
        private IDataModel _model;
        public IDataModel Model { get { return _model ?? (_model = new DataModel()); } } 

        public ActivityDataLoader() { }

        public ActivityDataLoader(IDataModel model)
            : this()
        {
            _model = model;
        }

        public void Load<TModel, TView>(TModel model, TView view, NavigationData data)
            where TView : IView
            where TModel : IDataModel
        {
            throw new NotImplementedException();
        }
    }
}
