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
            AddToConfig<IDataModel, IHomeView>((s, t) => MapProgramsToView((IDataModel)s, (IHomeView)t));
        }

        private void MapProgramsToView(IDataModel list, IHomeView mainView)
        {
            mainView.Programs = list.Programs;
        }
    }
}
