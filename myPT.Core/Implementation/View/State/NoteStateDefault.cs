using myPT.Core.Interfaces.View.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.View.State
{
    class NoteStateDefault : INoteState
    {
        public bool CanEditDate()
        {
            return true;
        }

        public bool CanEditNote()
        {
            return true;
        }

        public bool CanDelete()
        {
            return true;
        }

        public Common.ViewState StateValue
        {
            get { return Common.ViewState.Default; }
        }

        public bool CanBack()
        {
            return true;
        }
    }
}
