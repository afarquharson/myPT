using myPT.Core.Interfaces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.Presenter.Loader
{
    class TimelineDataLoader : IDataLoader
    {
        private Mapper.TimelineMapper _mapper;

        public TimelineDataLoader(Mapper.TimelineMapper timelineMapper)
        {
            _mapper = timelineMapper;
        }

        public void Load<TModel, TView>(TModel model, TView view, Common.NavigationData data)
            where TModel : IDataModel
            where TView : Interfaces.View.IView
        {
            _mapper.Map<TModel, TView>(model, view);
        }
    }
}
