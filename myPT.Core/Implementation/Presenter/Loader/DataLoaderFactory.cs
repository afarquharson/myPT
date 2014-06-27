using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myPT.Core.Interfaces;
using myPT.Core.Interfaces.Model;
using myPT.Core.Common;
using myPT.Core.Implementation.Presenter.Loader;

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
                {NavigateKey.ToActivity, () => new ActivityDataLoader()},
                {NavigateKey.ToExerciseCreate, () => new ExerciseDataLoader()},
                {NavigateKey.ToExerciseUpdate, () => new ExerciseDataLoader()},
                {NavigateKey.ToNote, () => new NoteDataLoader()},
                {NavigateKey.ToProgramReadOnly, () => new ProgramDataLoader()},
                {NavigateKey.ToProgramUpdate, () => new ProgramDataLoader()},
                {NavigateKey.ToSessionCreate, () => new SessionDataLoader()},
                {NavigateKey.ToSessionReadOnly, () => new SessionDataLoader()},
                {NavigateKey.ToHome, () => new HomeDataLoader()},
                {NavigateKey.ToTimeline, () => new TimelineDataLoader()}
            };
        }

        public IDataLoader GetLoader(NavigationData data)
        {
            return _loaderInitialiserDictionary[data.Key]();
        }
    }
}
