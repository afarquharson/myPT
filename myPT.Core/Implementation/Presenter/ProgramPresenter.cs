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
    class ProgramPresenter : Presenter
    {
        private IProgramView View;

        public ProgramPresenter(IProgramView view, IDataLoaderFactory loader, IDataModel model)
            : base(loader, model)
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

            View.AddExerciseClicked += View_AddExerciseClicked;
            View.AddSetClicked += View_AddSetClicked;
            View.BackClicked += View_BackClicked;
            View.CloneClicked += View_CloneClicked;
            View.StartSessionClicked += View_StartSessionClicked;
        }

        public void Load(NavigationData data)
        {
            Loader.GetLoader(data).Load<IDataModel, IProgramView>(Model, View, data);
        }

        void View_StartSessionClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void View_CloneClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void View_BackClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void View_AddSetClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void View_AddExerciseClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
