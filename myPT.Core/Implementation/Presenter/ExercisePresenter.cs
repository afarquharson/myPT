using myPT.Core.Common;
using myPT.Core.Interfaces.Model;
using myPT.Core.Interfaces.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.Presenter
{
    public class ExercisePresenter : Presenter
    {
        private IExerciseView View;

        public ExercisePresenter(IExerciseView view, IDataLoaderFactory loader, IDataModel model)
            : base(loader, model)
        {
            Setup(view);
        }

        public ExercisePresenter(IExerciseView view)
        {
            Setup(view);
        }

        private void Setup(IExerciseView view)
        {
            View = view;

            View.AddFieldClicked += View_AddFieldClicked;
            View.BackClicked += View_BackClicked;
            View.UpdateGoalClicked += View_UpdateGoalClicked;
        }

        public void Load(NavigationData data)
        {
            base._model = data.Model; //Use this model from now on
            Loader.GetLoader(data).Load<IDataModel, IExerciseView>(View, data);
        }

        void View_UpdateGoalClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void View_BackClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void View_AddFieldClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

    }
}
