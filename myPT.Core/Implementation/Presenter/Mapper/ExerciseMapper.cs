using myPT.Core.Common;
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
            AddToConfig<IDataModel, IExerciseView>((s, t) => MapExerciseToView((IDataModel)s, (IExerciseView)t));
        }

        private void MapExerciseToView(IDataModel model, IExerciseView exerciseView)
        {
            exerciseView.Exercise = model.GetExercise(exerciseView.ParentGUID, exerciseView.GUID);
        }

        private void MapViewToModel(IExerciseView exerciseView, IDataModel model)
        {
            var existingExercise = model.GetExercise(exerciseView.ParentGUID, exerciseView.GUID);
            existingExercise = exerciseView.Exercise; //Update existing exercise only - don't create new ones
        }
    }
}
