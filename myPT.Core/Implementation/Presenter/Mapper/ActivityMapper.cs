using myPT.Core.Interfaces.Model;
using myPT.Core.Interfaces.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.Presenter.Mapper
{
    class ActivityMapper : Common.Mapper
    {
        public ActivityMapper()
        {
            Setup();
        }

        public void Setup()
        {
            AddToConfig<IDataModel, IActivityView>((s, t) => MapActivityToView((IDataModel)s, (IActivityView)t));
        }

        private void MapActivityToView(IDataModel dataModel, IActivityView activityView)
        {
            activityView.Activity = dataModel.GetActivity(activityView.ParentGUID, activityView.GUID);
        }
    }
}
