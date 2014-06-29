using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myPT.Core.Interfaces;
using myPT.Core.Interfaces.Model;
using myPT.Core.Common;
using myPT.Core.Implementation.Presenter.Loader;
using myPT.Core.Implementation.Presenter.Mapper;

namespace myPT.Core.Implementation
{
    class DataLoaderFactory : IDataLoaderFactory
    {
        IDictionary<NavigateKey, Func<IDataLoader>> _loaderInitialiserDictionary;

        public DataLoaderFactory() 
        {
            _loaderInitialiserDictionary = new Dictionary<NavigateKey, Func<IDataLoader>>()
            {
                {NavigateKey.ToExerciseCreate, () => new ExerciseDataLoader(new ExerciseMapper())},
                {NavigateKey.ToExerciseUpdate, () => new ExerciseDataLoader(new ExerciseMapper())},
                {NavigateKey.ToNote, () => new NoteDataLoader(new NoteMapper())},
                {NavigateKey.ToProgramReadOnly, () => new ProgramDataLoader(new ProgramMapper())},
                {NavigateKey.ToProgramUpdate, () => new ProgramDataLoader(new ProgramMapper())},
                {NavigateKey.ToSessionCreate, () => new SessionDataLoader(new SessionMapper())},
                {NavigateKey.ToSessionReadOnly, () => new SessionDataLoader(new SessionMapper())},
                {NavigateKey.ToHome, () => new HomeDataLoader(new HomeMapper())},
                {NavigateKey.ToTimeline, () => new TimelineDataLoader(new TimelineMapper())}
            };
        }

        public IDataLoader GetLoader(NavigationData data)
        {
            return _loaderInitialiserDictionary[data.Key]();
        }
    }
}
