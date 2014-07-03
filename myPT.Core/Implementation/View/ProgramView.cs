using myPT.Core.Common;
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
    public class ProgramView : IProgramView
    {
        private ProgramPresenter _presenter;
        public ProgramPresenter Presenter { get {return _presenter ?? (_presenter = new ProgramPresenter(this)); }}

        public IProgram Program { get; set; }
        public Dictionary<string, string> List { get { return Program.Print(); } }
        public IViewState State { get; set; }
        public string GUID { get; set; }
        public string ParentGUID { get; set; }

        public void Load(NavigationData data)
        {
            Presenter.Load(data);
        }

        public NavigationData Execute(CommandKey command, string[] data)
        {
            return Presenter.Execute(command, data);
        }


        public event EventHandler BackClicked;
    }
}
