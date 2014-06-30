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
            AddToConfig<IDataModel, INoteView>((s, t) => MapNoteToView((IDataModel)s, (INoteView)t));
        }

        private void MapNoteToView(IDataModel model, INoteView noteView)
        {
            noteView.Item = model.GetHistoryItem(noteView.GUID);
        }
    }
}
