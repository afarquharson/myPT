using myPT.Core.Interfaces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myPT.Core.Implementation
{
    class ActivityDataLoader : IDataLoader
    {
        private Interfaces.IDataModel model;

        public ActivityDataLoader(Interfaces.IDataModel model)
        {
            // TODO: Complete member initialization
            this.model = model;
        }

        public void Load<TData, TView>(TData data, TView view)
            where TData : Interfaces.IDataModel
            where TView : Interfaces.View.IView
        {
            throw new NotImplementedException();
        }
    }
}
