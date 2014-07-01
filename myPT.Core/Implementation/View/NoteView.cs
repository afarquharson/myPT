using myPT.Core.Implementation.Model;
using myPT.Core.Implementation.Presenter;
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
        private NotePresenter _presenter;
        public NotePresenter Presenter { get {return _presenter ?? (_presenter = new NotePresenter(this)); }}

        public IHistoryItem Item { get; set; }
        public IViewState State { get; set; }
        public string GUID { get; set; }
        public string ParentGUID { get; set; }

        public event EventHandler DeleteNoteClicked = delegate { };
        public event EventHandler BackClicked = delegate { };

        public void Load(Common.NavigationData data)
        {
            Presenter.Load(data);
        }
    }
}
