using myPT.Core.Common;
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

        public void Load<TModel, TView>(TView view, NavigationData data)
            where TModel : IDataModel
            where TView : IView
        {
            view.State = _state;
            view.GUID = data.ToItem;
            view.ParentGUID = data.FromItem;
            _mapper.Map<TModel, TView>((TModel)data.Model, view);
        }

        public void Save<TView, TModel>(TView view, TModel model)
            where TView : IView
            where TModel : IDataModel
        {
            _mapper.Map<TView, TModel>(view, model);
        }
    }
}
