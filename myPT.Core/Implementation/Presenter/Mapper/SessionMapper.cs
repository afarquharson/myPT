using myPT.Core.Interfaces.Model;
using myPT.Core.Interfaces.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.Presenter.Mapper
{
    class SessionMapper : Common.Mapper
    {
        public SessionMapper()
        {
            Setup();
        }

        public void Setup()
        {
            AddToConfig<IDataModel, ISessionView>((s, t) => MapSessionToView((IDataModel)s, (ISessionView)t));
        }

        private void MapSessionToView(IDataModel model, ISessionView sessionView)
        {
            sessionView.Session = model.GetSession(sessionView.GUID);
        }
    }
}
