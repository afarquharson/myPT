using myPT.Core.Common;
using myPT.Core.Implementation.Presenter;
using myPT.Core.Interfaces.Model;
using myPT.Core.Interfaces.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.View
{
    public class ExerciseView : IExerciseView
    {
        private ExercisePresenter _presenter;
        public ExercisePresenter Presenter { get {return _presenter ?? (_presenter = new ExercisePresenter(this)); }}

        public IExercise Exercise { get; set; }
        public IViewState State { get; set; }
        public string GUID { get; set; }
        public string ParentGUID { get; set; }

        public event EventHandler UpdateGoalClicked = delegate { };
        public event EventHandler AddFieldClicked = delegate {};
        public event EventHandler BackClicked = delegate { };

        public void Load(NavigationData data)
        {
            Presenter.Load(data);
        }

        public NavigationData Execute(CommandKey command, string[] data)
        {
            return Presenter.Execute(command, data);
        }

        public Dictionary<string, string> List
        {
            get 
            {
                return Exercise.Print();
            }
        }
    }
}
