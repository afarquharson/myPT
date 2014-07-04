using myPT.Core.Common;
using myPT.Core.Implementation.Model;
using myPT.Core.Interfaces.Model;
using myPT.Core.Interfaces.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.Presenter
{
    public class NotePresenter : Presenter
    {
        private INoteView View
        {
            get
            {
                return (INoteView)_view;
            }
            set
            {
                _view = value;
            }
        }

        public NotePresenter(INoteView view, IDataLoaderFactory loader, IDataModel model) : base(loader, model, view) 
        {
            Setup(view);
        }

        public NotePresenter(INoteView view) : base()
        {
            Setup(view);
        }

        public void Setup(INoteView view)
        {
            View = view;
        }

        public void Load(NavigationData data)
        {
            base._model = data.Model; //Use this model from now on
            Loader.GetLoader(data).Load<IDataModel, INoteView>(View, data);

            if (View.Item == null)
            {
                var tmp = Maker.GetGUID();
                View.Item = new HistoryItem()
                {
                    GUID = tmp
                };
                View.GUID = tmp;
            }

            Actions.Add(Command.DeleteNote, DeleteNote);
        }

        public void DeleteNote()
        {
            Model.History.Remove(_view.GUID); //Remove the note from the history
            _navData.ToScreen = Command.Timeline; //Go back to the Timeline view
        }
    }
}
