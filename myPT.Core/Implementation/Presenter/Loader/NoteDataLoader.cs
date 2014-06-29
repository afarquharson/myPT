using myPT.Core.Common;
using myPT.Core.Implementation.Presenter.Mapper;
using myPT.Core.Interfaces;
using myPT.Core.Interfaces.Model;
using myPT.Core.Interfaces.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myPT.Core.Implementation
{
    class NoteDataLoader : IDataLoader
    {
        private NoteMapper _mapper;

        public NoteDataLoader(NoteMapper noteMapper)
        {
            _mapper = noteMapper;
        }

        public void Load<TModel, TView>(TModel model, TView view, NavigationData data)
            where TView : IView
            where TModel : IDataModel
        {
            _mapper.Map<TModel, TView>(model, view);
        }
    }
}
