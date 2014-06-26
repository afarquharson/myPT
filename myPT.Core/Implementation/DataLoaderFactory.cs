using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myPT.Core.Interfaces;
using myPT.Core.Interfaces.Model;
using myPT.Core.Common;

namespace myPT.Core.Implementation
{
    class DataLoaderFactory : IDataLoaderFactory
    {
        IDataModel _model;
        IDictionary<NavigateKey, Func<IDataLoader>> _loaderInitialiserDictionary;

        public DataLoaderFactory(IDataModel model) 
        {
            _model = model;
            _loaderInitialiserDictionary = new Dictionary<NavigateKey, Func<IDataLoader>>()
            {
                {NavigateKey.ToActivity, () => new ActivityDataLoader(model)},
                {NavigateKey.ToExerciseCreate, () => new ExerciseDataLoader(model)},
                {NavigateKey.ToExerciseUpdate, () => new ExerciseDataLoader(model)},
                {NavigateKey.ToNote, () => new NoteDataLoader(model)},
                {NavigateKey.ToProgramReadOnly, () => new ProgramDataLoader(model)},
                {NavigateKey.ToProgramUpdate, () => new ProgramDataLoader(model)},
                {NavigateKey.ToSessionCreate, () => new SessionDataLoader(model)},
                {NavigateKey.ToSessionReadOnly, () => new SessionDataLoader(model)},
                {NavigateKey.ToHome, () => new HomeDataLoader(model)}
            };
        }

        public IDataLoader GetLoader(NavigationData data)
        {
            return _loaderInitialiserDictionary[data.Key]();
        }
    }
}
