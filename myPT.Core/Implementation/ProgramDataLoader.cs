using myPT.Core.Common;
using myPT.Core.Interfaces;
using myPT.Core.Interfaces.Model;
using myPT.Core.Interfaces.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myPT.Core.Implementation
{
    class ProgramDataLoader : IDataLoader
    {
        private Interfaces.IDataModel model;

        public ProgramDataLoader(Interfaces.IDataModel model)
        {
            // TODO: Complete member initialization
            this.model = model;
        }

        void Load<TModel, TView>(TModel model, TView view, NavigationData data)
            where TView : IView
            where TModel : IDataModel
        {
            throw new NotImplementedException();
        }
    }
}
