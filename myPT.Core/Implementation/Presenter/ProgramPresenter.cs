using myPT.Core.Common;
using myPT.Core.Implementation.Model;
using myPT.Core.Interfaces.Model;
using myPT.Core.Interfaces.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.Presenter
{
    public class ProgramPresenter : Presenter
    {
        private IProgramView View 
        { 
            get 
            {
                return (IProgramView)_view; 
            } 
            set 
            {
                _view = value;
            } 
        }

        public ProgramPresenter(IProgramView view, IDataLoaderFactory loader, IDataModel model)
            : base(loader, model, view)
        {
            Setup(view);
        }

        public ProgramPresenter(IProgramView view)
            : base()
        {
            Setup(view);
        }

        public void Setup(IProgramView view)
        {
            View = view;
        }

        public void Load(NavigationData data)
        {
            base._model = data.Model; //Use this model from now on
            Loader.GetLoader(data).Load<IDataModel, IProgramView>(View, data);

            if (View.Program == null)
            {
                var tmp = Maker.GetGUID();
                View.Program = new Program
                {
                    GUID = tmp,
                    Exercises = new ExerciseTreeItem()
                };
                View.GUID = tmp;
            }

            if (!Actions.ContainsKey(Command.AddSet)) Actions.Add(Command.AddSet, AddSet);
            if (!Actions.ContainsKey(Command.AddExercise)) Actions.Add(Command.AddExercise, AddExercise);
        }

        public void AddSet()
        {
            View.Program.Exercises.Children.Add(new ExerciseTreeItem 
            {
                Reps = 2 //Default value for reps
            });
        }

        public void AddExercise()
        {
            var guid = Maker.GetGUID();
            View.Program.Exercises.Exercises.Add(guid, new Exercise
            {
                GUID = guid,
                Detail = new Dictionary<ExerciseFieldKey, string>
                {
                    {ExerciseFieldKey.Description, "New Exercise"}
                }
            });
        }
    }
}
