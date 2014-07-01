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
    class NotePresenter : Presenter
    {
        private INoteView View;

        public NotePresenter(INoteView view, IDataLoaderFactory loader, IDataModel model) : base(loader, model) 
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

            View.BackClicked += View_BackClicked;
            View.DeleteNoteClicked += View_DeleteNoteClicked;
        }

        public void Load(NavigationData data)
        {
            Loader.GetLoader(data).Load<IDataModel, INoteView>(Model, View, data);
        }

        void View_DeleteNoteClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void View_BackClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
