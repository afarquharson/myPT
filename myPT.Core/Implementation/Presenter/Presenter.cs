using myPT.Core.Implementation.Model;
using myPT.Core.Interfaces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.Presenter
{
    public class Presenter
    {
        private IDataLoaderFactory _loader;
        public IDataLoaderFactory Loader { get { return _loader ?? (_loader = new DataLoaderFactory()); } }
        internal IDataModel _model;
        public IDataModel Model { get { return _model; } } //DON'T create a new Model every time

        public Presenter() { }
        public Presenter(IDataLoaderFactory loader, IDataModel model)
            : this()
        {
            _loader = loader;
            _model = model;
        }
    }
}
