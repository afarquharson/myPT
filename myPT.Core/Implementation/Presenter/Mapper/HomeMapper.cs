using myPT.Core.Interfaces.Model;
using myPT.Core.Interfaces.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.Presenter.Mapper
{
    class HomeMapper : Common.Mapper
    {
        public HomeMapper()
        {
            Setup();
        }

        public void Setup()
        {
            AddToConfig<IDataModel, IHomeView>((s, t) => MapModelToView((IDataModel)s, (IHomeView)t));
            AddToConfig<IHomeView, IDataModel>((s, t) => MapViewToModel((IHomeView)s, (IDataModel)t));
        }

        private void MapModelToView(IDataModel list, IHomeView mainView)
        {
            mainView.Programs = list.Programs;
        }

        private void MapViewToModel(IHomeView mainView, IDataModel model)
        {
            model.Programs = mainView.Programs;
        }
    }
}
