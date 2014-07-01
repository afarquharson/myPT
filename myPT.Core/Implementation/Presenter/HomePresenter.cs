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
    class HomePresenter : Presenter
    {
        private IHomeView View;

        public HomePresenter(IHomeView view, IDataLoaderFactory loader, IDataModel model) : base(loader, model) 
        {
            Setup(view);
        }

        public HomePresenter(IHomeView view) : base()
        {
            Setup(view);
        }

        public void Setup(IHomeView view)
        {
            View = view;

            View.AddProgramClicked += view_AddProgramClicked;
            View.ItemSelected += view_ItemSelected;
            View.SettingsClicked += view_SettingsClicked;
        }

        public void Load(NavigationData data)
        {
            Loader.GetLoader(data).Load<IDataModel, IHomeView>(Model, View, data);
        }

        void view_SettingsClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void view_ItemSelected(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void view_AddProgramClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
