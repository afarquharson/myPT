using myPT.Core.Interfaces;
using myPT.Core.Interfaces.Model;
using myPT.Core.Interfaces.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.Presenter.Mapper
{
    class TimelineMapper : Common.Mapper
    {
        public TimelineMapper()
        {
            Setup();
        }

        public void Setup()
        {
            AddToConfig<IDataModel, ITimelineView>((s, t) => MapHistoryItemsToView((IDataModel)s, (ITimelineView)t));
        }

        private void MapHistoryItemsToView(IDataModel model, ITimelineView historyView)
        {
            historyView.History = model.History;
        }
    }
}
