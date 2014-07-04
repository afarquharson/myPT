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
using myPT.Core.Implementation.Presenter.Loader;

namespace myPT.Core.Implementation
{
    class DataLoaderFactory : IDataLoaderFactory
    {
        IDictionary<Command, Func<IDataLoader>> _loaderInitialiserDictionary;

        public DataLoaderFactory() 
        {
            _loaderInitialiserDictionary = new Dictionary<Command, Func<IDataLoader>>()
            {
                {Command.ExerciseCreate, () => new DataLoader(new ExerciseMapper(), new ExerciseStateCreate())},
                {Command.ExerciseUpdate, () => new DataLoader(new ExerciseMapper(), new ExerciseStateUpdate())},
                {Command.Note, () => new DataLoader(new NoteMapper(), new NoteStateDefault())},
                {Command.ProgramUpdate, () => new DataLoader(new ProgramMapper(), new ProgramStateUpdate())},
                {Command.ProgramCreate, () => new DataLoader(new ProgramMapper(), new ProgramStateCreate())},
                {Command.SessionCreate, () => new DataLoader(new SessionMapper(), new SessionStateCreate())},
                {Command.SessionReadOnly, () => new DataLoader(new SessionMapper(), new SessionStateReadOnly())},
                {Command.Home, () => new DataLoader(new HomeMapper(), new HomeStateDefault())},
                {Command.Timeline, () => new DataLoader(new TimelineMapper(), new TimelineStateDefault())},
                {Command.ActivityReadOnly, () => new DataLoader(new ActivityMapper(), new ActivityStateReadOnly())},
                {Command.ActivityUpdate, () => new DataLoader(new ActivityMapper(), new ActivityStateUpdate())},
                {Command.None, () => new EmptyDataLoader()}
            };
        }

        public IDataLoader GetLoader(NavigationData data)
        {
            return _loaderInitialiserDictionary[data.ToScreen]();
        }
    }
}
