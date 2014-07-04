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
            AddToConfig<INoteView, IDataModel>((s, t) => MapViewToModel((INoteView)s, (IDataModel)s));
        }

        private void MapViewToModel(INoteView noteView, IDataModel dataModel)
        {
            IHistoryItem existingNote = null;
            dataModel.History.TryGetValue(noteView.GUID, out existingNote);
            if (existingNote != null)
            {
                dataModel.History[noteView.GUID] = noteView.Item;
            }
            else
            {
                dataModel.History.Add(noteView.GUID, noteView.Item);
            }
        }

        private void MapNoteToView(IDataModel model, INoteView noteView)
        {
            IHistoryItem existingItem;
            model.History.TryGetValue(noteView.GUID, out existingItem);
            if (existingItem != null)
            {
                noteView.Item = model.History[noteView.GUID];
            }
        }
    }
}
