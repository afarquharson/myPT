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
    public class ExercisePresenter : Presenter
    {
        private IExerciseView View { get { return (IExerciseView)_view; } set { _view = value; } }

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

            if (View.Exercise == null)
            {
                var tmp = Maker.GetGUID();
                View.Exercise = new Exercise
                {
                    GUID = tmp
                };
                View.GUID = tmp;
            }
        }
    }
}
