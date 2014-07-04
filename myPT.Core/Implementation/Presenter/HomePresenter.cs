using myPT.Core.Common;
using myPT.Core.Interfaces.Model;
using myPT.Core.Interfaces.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.Presenter
{
    public class HomePresenter : Presenter
    {
        private IHomeView View
        {
            get
            {
                return (IHomeView)_view;
            }
            set
            {
                _view = value;
            }
        }

        public HomePresenter(IHomeView view, IDataLoaderFactory loader, IDataModel model) : base(loader, model, view) 
        {
            Setup(view);
        }

        public HomePresenter(IHomeView view) : base()
        {
            Setup(view);
        }

        public void Setup(IHomeView view)
        {
            View = view;
        }

        public void Load(NavigationData data)
        {
            base._model = data.Model; //Use this model from now on
            Loader.GetLoader(data).Load<IDataModel, IHomeView>(View, data);
            Actions.Add(Command.About, About);
            Actions.Add(Command.ProgramCreate, ProgramCreate);
            Actions.Add(Command.Timeline, Timeline);
        }

        private void Timeline()
        {
            _navData.ToScreen = Command.Timeline;
        }

        private void ProgramCreate()
        {
            _navData.ToScreen = Command.ProgramCreate;
        }

        private void About()
        {
            _navData.ToScreen = Command.About;
        }
    }
}
