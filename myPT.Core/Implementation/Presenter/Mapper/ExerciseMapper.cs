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
            AddToConfig<IExercise, IExerciseUpdateView>((s, t) => MapExerciseToUpdateView((IExercise)s, (IExerciseUpdateView)t));
            AddToConfig<IExercise, IExerciseCreateView>((s, t) => MapExerciseToCreateView((IExercise)s, (IExerciseCreateView)t));
        }

        private void MapExerciseToCreateView(IExercise exercise, IExerciseCreateView exerciseCreateView)
        {
            exerciseCreateView.Exercise = exercise;
        }

        private void MapExerciseToUpdateView(IExercise exercise, IExerciseView exerciseView)
        {
            exerciseView.Exercise = exercise;
        }

    }
}
