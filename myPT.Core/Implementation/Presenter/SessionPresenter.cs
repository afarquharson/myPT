using myPT.Core.Common;
using myPT.Core.Implementation.Model;
using myPT.Core.Interfaces.Model;
using myPT.Core.Interfaces.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.Presenter
{
    public class SessionPresenter : Presenter
    {
        private ISessionView View
        {
            get
            {
                return (ISessionView)_view;
            }
            set
            {
                _view = value;
            }
        }

        public SessionPresenter(ISessionView view, IDataLoaderFactory loader, IDataModel model) : base(loader, model, view) 
        {
            Setup(view);
        }

        public SessionPresenter(ISessionView view) : base()
        {
            Setup(view);
        }

        public void Setup(ISessionView view)
        {
            View = view;
        }

        public void Load(NavigationData data)
        {
            _model = data.Model; //Use this model from now on
            Loader.GetLoader(data).Load<IDataModel, ISessionView>(View, data);
            Actions.Add(Command.QuitSession, SaveAndQuit);
        }

        public void SaveAndQuit()
        {
            Model.History.Add(View.Session.GUID, View.Session); //Save the session to history
            _navData.ToScreen = Command.Home; //Go back to the Home screen
        }
    }
}
