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
            exerciseView.Exercise = exercise;
        }
    }
}
