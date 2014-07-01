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
    class NoteView : INoteView
    {
        private IDataLoaderFactory _loader;
        public IDataLoaderFactory Loader { get { return _loader ?? (_loader = new DataLoaderFactory()); } }
        private IDataModel _model;
        public IDataModel Model { get { return _model ?? (_model = new DataModel()); } }

        public IHistoryItem Item { get; set; }
        public IViewState State { get; set; }
        public string GUID { get; set; }
        public string ParentGUID { get; set; }

        public event EventHandler DeleteNoteClicked = delegate { };
        public event EventHandler BackClicked = delegate { };

        public NoteView() { }
        public NoteView(IDataLoaderFactory loader, IDataModel model)
            : this()
        {
            _loader = loader;
            _model = model;
        }

        public void Load(Common.NavigationData data)
        {
            Loader.GetLoader(data).Load<IDataModel, INoteView>(Model, this, data);
        }
    }
}
