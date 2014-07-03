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
    public class ProgramPresenter : Presenter
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
        }

        public void Load(NavigationData data)
        {
            base._model = data.Model; //Use this model from now on
            Loader.GetLoader(data).Load<IDataModel, IProgramView>(View, data);
        }

        public NavigationData Execute(CommandKey command, string[] data)
        {
            var result = new NavigationData();
            result.FromItem = View.GUID; //The GUID of the Program being viewed
            result.Model = base.Model; //Our model
            
            //Determine which NavigateKey and ToItem values to include based on CommandKey
            var commandName = View.State.Commands[command];

            return result;
        }
    }
}
