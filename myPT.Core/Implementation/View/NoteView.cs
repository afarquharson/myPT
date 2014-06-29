using myPT.Core.Interfaces.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.View
{
    class NoteView : INoteView
    {
        public Interfaces.Model.IHistoryItem Item
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public event EventHandler DeleteNoteClicked;

        public event EventHandler BackClicked;

        public void Load(Common.NavigationData data)
        {
            throw new NotImplementedException();
        }
    }
}
