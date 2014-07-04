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
    public class Presenter
    {
        private IDataLoaderFactory _loader;
        public IDataLoaderFactory Loader { get { return _loader ?? (_loader = new DataLoaderFactory()); } }
        internal IDataModel _model;
        public IDataModel Model { get { return _model ?? (_model = new DataModel()); } }
        internal Dictionary<Command, Action> _actions;
        public Dictionary<Command, Action> Actions
        {
            get
            {
                return _actions ?? (_actions = new Dictionary<Command, Action>
                {
                        {_view.State.Commands[CommandKey.TopLeft], Back},
                        {_view.State.Commands[CommandKey.ItemSelect], ToSelectedItem}
                });
            }
            set
            {
                _actions = value;
            }
        }
        internal IGUIDMaker _maker;
        public IGUIDMaker Maker { get { return _maker ?? (_maker = new GUIDMaker()); } }
        internal NavigationData _navData;
        internal String _selectedItem;
        internal IView _view;

        public Presenter() { }
        public Presenter(IDataLoaderFactory loader, IDataModel model, IView view)
            : this()
        {
            _loader = loader;
            _model = model;
            _view = view;
        }

        public NavigationData Execute(CommandKey button, string[] data)
        {
            _navData = new NavigationData //Refresh the data
            {
                FromItem = _view.GUID,
                Model = Model,
                ToScreen = Command.None,
                ToItem = String.Empty,
                FromView = _view
            };
            _selectedItem = data.FirstOrDefault(); //Save the selected item, if any

            Action action = null;
            Actions.TryGetValue(_view.State.Commands[button], out action);
            if (action != null) action();

            return _navData;
        }

        public void Back()
        {
            _navData.ToItem = _view.ParentGUID;
            _navData.ToScreen = _view.State.Commands[CommandKey.TopLeft];
        }

        public void ToSelectedItem()
        {
            _navData.ToItem = _selectedItem;
            _navData.ToScreen = _view.State.Commands[CommandKey.ItemSelect];
        }
    }
}
