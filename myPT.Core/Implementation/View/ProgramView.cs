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
    class ProgramView : IProgramView
    {
        private ProgramPresenter _presenter;
        public ProgramPresenter Presenter { get {return _presenter ?? (_presenter = new ProgramPresenter(this)); }}

        public IProgram Program { get; set; }
        public IViewState State { get; set; }
        public string GUID { get; set; }
        public string ParentGUID { get; set; }

        public event EventHandler AddSetClicked = delegate { };
        public event EventHandler AddExerciseClicked = delegate { };
        public event EventHandler CloneClicked = delegate { };
        public event EventHandler StartSessionClicked = delegate { };
        public event EventHandler BackClicked = delegate { };

        public void Load(Common.NavigationData data)
        {
            Presenter.Load(data);
        }
    }
}
