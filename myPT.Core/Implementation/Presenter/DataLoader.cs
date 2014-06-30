using myPT.Core.Interfaces;
using myPT.Core.Interfaces.Model;
using myPT.Core.Interfaces.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.Presenter
{
    class DataLoader : IDataLoader
    {
        private IViewState _state;
        private IMapper _mapper;

        public DataLoader(IMapper mapper, IViewState state)
        {
            _mapper = mapper;
            _state = state;
        }

        public void Load<TModel, TView, TMapper, TState>(TModel model, TView view, Common.NavigationData data)
            where TModel : IDataModel
            where TView : IView
            where TState : IViewState
            where TMapper : IMapper
        {
            view.State = _state;
            _mapper.Map<TModel, TView>(model, view);
        }

        public void Save<TView, TModel>(TView view, TModel model)
            where TView : Interfaces.View.IView
            where TModel : IDataModel
        {
            _mapper.Map<TView, TModel>(view, model);
        }
    }
}
