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
            AddToConfig<ISessionView, IDataModel>((s, t) => MapViewToModel((ISessionView)s, (IDataModel)t));
        }

        private void MapViewToModel(ISessionView sessionView, IDataModel dataModel)
        {
            ISession existingSession = null;
            dataModel.Sessions.TryGetValue(sessionView.GUID, out existingSession);
            if (existingSession != null)
            {
                dataModel.Sessions[sessionView.GUID] = sessionView.Session;//If Session already exists, save it back to the model
            }
            else
            {
                dataModel.Sessions.Add(sessionView.GUID, sessionView.Session);//If Session does not exist, add a new one
            }
        }

        private void MapSessionToView(IDataModel model, ISessionView sessionView)
        {
            sessionView.Session = model.Sessions[sessionView.GUID];
        }
    }
}
