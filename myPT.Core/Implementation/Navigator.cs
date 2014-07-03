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
        Dictionary<NavigateKey, Func<IView>> _navDictionary;
        Dictionary<NavigateKey, Func<IView>> NavDictionary 
        { 
            get 
            {
                return _navDictionary ?? (_navDictionary = new Dictionary<NavigateKey, Func<IView>>
                        {
                            {NavigateKey.ActivityReadOnly, () => new ActivityView()}, //Get a fresh view each time
                            {NavigateKey.ActivityUpdate, () => new ActivityView()},
                            {NavigateKey.ExerciseCreate, () => new ExerciseView()},
                            {NavigateKey.ExerciseUpdate, () => new ExerciseView()},
                            {NavigateKey.Home, () => new HomeView()},
                            {NavigateKey.Note, () => new NoteView()},
                            {NavigateKey.ProgramCreate, () => new ProgramView()},
                            {NavigateKey.ProgramUpdate, () => new ProgramView()},
                            {NavigateKey.SessionCreate, () => new SessionView()},
                            {NavigateKey.SessionReadOnly, () => new SessionView()},
                            {NavigateKey.Timeline, () => new TimelineView()}
                        });
            } 
        }

        public IView Navigate(NavigationData data)
        {
            var view = NavDictionary[data.Key]();
            view.Load(data);
            return view;
        }
    }
}
