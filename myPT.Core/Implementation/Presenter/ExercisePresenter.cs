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
            : base(loader, model, view)
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
        }

        public void Load(NavigationData data)
        {
            base._model = data.Model; //Use this model from now on
            Loader.GetLoader(data).Load<IDataModel, IExerciseView>(View, data);
        }
    }
}
