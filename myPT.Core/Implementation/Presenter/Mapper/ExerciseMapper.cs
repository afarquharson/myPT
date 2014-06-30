using myPT.Core.Interfaces.Model;
using myPT.Core.Interfaces.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.Presenter.Mapper
{
    class ExerciseMapper : Common.Mapper
    {
        public ExerciseMapper()
        {
            Setup();
        }

        public void Setup()
        {
            AddToConfig<IExercise, IExerciseView>((s, t) => MapExerciseToView((IExercise)s, (IExerciseView)t));
        }

        private void MapExerciseToView(IExercise exercise, IExerciseView exerciseView)
        {
            //TODO Get state from view, load appropriate exercise from model based on state
            //IF view is ExerciseComplete, use Session. If view is ExerciseCreate/Update, use Program
            exerciseView.Exercise = exercise;
        }

        private void MapViewToExercise(IExerciseView exerciseView, IExercise exercise)
        {
            exercise = exerciseView.Exercise;
        }
    }
}
