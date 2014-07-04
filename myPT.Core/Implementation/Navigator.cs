using myPT.Core.Common;
using myPT.Core.Implementation.View;
using myPT.Core.Interfaces;
using myPT.Core.Interfaces.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation
{
    public class Navigator : INavigator
    {
        Dictionary<Command, Func<IView>> _navDictionary;
        Dictionary<Command, Func<IView>> NavDictionary 
        { 
            get 
            {
                return _navDictionary ?? (_navDictionary = new Dictionary<Command, Func<IView>>
                        {
                            {Command.ActivityReadOnly, () => new ActivityView()}, //Get a fresh view each time
                            {Command.ActivityUpdate, () => new ActivityView()},
                            {Command.ExerciseCreate, () => new ExerciseView()},
                            {Command.ExerciseUpdate, () => new ExerciseView()},
                            {Command.Home, () => new HomeView()},
                            {Command.Note, () => new NoteView()},
                            {Command.ProgramCreate, () => new ProgramView()},
                            {Command.ProgramUpdate, () => new ProgramView()},
                            {Command.SessionCreate, () => new SessionView()},
                            {Command.SessionReadOnly, () => new SessionView()},
                            {Command.Timeline, () => new TimelineView()}
                        });
            } 
        }

        public IView Navigate(NavigationData data)
        {
            var view = NavDictionary[data.ToScreen]();
            view.Load(data);
            return view;
        }
    }
}
