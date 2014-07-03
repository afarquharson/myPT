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
                {NavigateKey.ExerciseCreate, () => new DataLoader(new ExerciseMapper(), new ExerciseStateCreate())},
                {NavigateKey.ExerciseUpdate, () => new DataLoader(new ExerciseMapper(), new ExerciseStateUpdate())},
                {NavigateKey.Note, () => new DataLoader(new NoteMapper(), new NoteStateDefault())},
                {NavigateKey.ProgramUpdate, () => new DataLoader(new ProgramMapper(), new ProgramStateUpdate())},
                {NavigateKey.ProgramCreate, () => new DataLoader(new ProgramMapper(), new ProgramStateCreate())},
                {NavigateKey.SessionCreate, () => new DataLoader(new SessionMapper(), new SessionStateCreate())},
                {NavigateKey.SessionReadOnly, () => new DataLoader(new SessionMapper(), new SessionStateReadOnly())},
                {NavigateKey.Home, () => new DataLoader(new HomeMapper(), new HomeStateDefault())},
                {NavigateKey.Timeline, () => new DataLoader(new TimelineMapper(), new TimelineStateDefault())},
                {NavigateKey.ActivityReadOnly, () => new DataLoader(new ActivityMapper(), new ActivityStateReadOnly())},
                {NavigateKey.ActivityUpdate, () => new DataLoader(new ActivityMapper(), new ActivityStateUpdate())}
            };
        }

        public IDataLoader GetLoader(NavigationData data)
        {
            return _loaderInitialiserDictionary[data.Key]();
        }
    }
}
