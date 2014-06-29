using myPT.Core.Interfaces.Model;
using myPT.Core.Interfaces.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.Presenter.Mapper
{
    class NoteMapper : Common.Mapper
    {
        public NoteMapper()
        {
            Setup();
        }

        public void Setup()
        {
            AddToConfig<IHistoryItem, INoteView>((s, t) => MapNoteToView((IHistoryItem)s, (INoteView)t));
        }

        private void MapNoteToView(IHistoryItem historyItem, INoteView noteView)
        {
            noteView.Item = historyItem;
        }
    }
}
