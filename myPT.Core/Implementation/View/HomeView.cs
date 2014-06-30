using myPT.Core.Common;
using myPT.Core.Implementation.Model;
using myPT.Core.Interfaces.Model;
using myPT.Core.Interfaces.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.View
{
    class HomeView : IHomeView
    {
        private IDataLoaderFactory _loader;
        public IDataLoaderFactory Loader { get { return _loader ?? (_loader = new DataLoaderFactory());}}
        private IDataModel _model;
        public IDataModel Model {get {return _model ?? (_model = new DataModel());}}

        public List<IProgram> Programs { get; set; }

        public event EventHandler SettingsClicked = delegate { };
        public event EventHandler AddProgramClicked = delegate { };
        public event EventHandler TimelineClicked = delegate { };
        public event EventHandler ItemSelected = delegate { };

        public HomeView() { }

        public HomeView(IDataLoaderFactory loader, IDataModel model)
            : this()
        {
            _loader = loader;
            _model = model;
        }

        public void Load(NavigationData data)
        {
            Loader.GetLoader(data).Load<IDataModel, IHomeView>(Model, this, data);
        }

        public IViewState State
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string GUID
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string ParentGUID
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
