using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myPT.Core.Interfaces;
using myPT.Core.Interfaces.Model;
using myPT.Core.Common;
using myPT.Core.Implementation.Presenter.Mapper;
using myPT.Core.Implementation.View.State;
using myPT.Core.Implementation.Presenter;

namespace myPT.Core.Implementation
{
    class DataLoaderFactory : IDataLoaderFactory
    {
        IDictionary<NavigateKey, Func<IDataLoader>> _loaderInitialiserDictionary;

        public DataLoaderFactory() 
        {
            _loaderInitialiserDictionary = new Dictionary<NavigateKey, Func<IDataLoader>>()
            {
                {NavigateKey.ToExerciseCreate, () => new DataLoader(new ExerciseMapper(), new ExerciseStateCreate())},
                {NavigateKey.ToExerciseUpdate, () => new DataLoader(new ExerciseMapper(), new ExerciseStateUpdate())},
                {NavigateKey.ToNote, () => new DataLoader(new NoteMapper(), new NoteStateDefault())},
                {NavigateKey.ToProgramUpdate, () => new DataLoader(new ProgramMapper(), new ProgramStateUpdate())},
                {NavigateKey.ToProgramCreate, () => new DataLoader(new ProgramMapper(), new ProgramStateCreate())},
                {NavigateKey.ToSessionCreate, () => new DataLoader(new SessionMapper(), new SessionStateCreate())},
                {NavigateKey.ToSessionReadOnly, () => new DataLoader(new SessionMapper(), new SessionStateReadOnly())},
                {NavigateKey.ToHome, () => new DataLoader(new HomeMapper(), new HomeStateDefault())},
                {NavigateKey.ToTimeline, () => new DataLoader(new TimelineMapper(), new TimelineStateDefault())},
                {NavigateKey.ToActivityReadOnly, () => new DataLoader(new ActivityMapper(), new ActivityStateReadOnly())},
                {NavigateKey.ToActivityUpdate, () => new DataLoader(new ActivityMapper(), new ActivityStateUpdate())}
            };
        }

        public IDataLoader GetLoader(NavigationData data)
        {
            return _loaderInitialiserDictionary[data.Key]();
        }
    }
}
