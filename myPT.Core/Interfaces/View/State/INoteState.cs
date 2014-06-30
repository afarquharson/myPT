using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Interfaces.View.State
{
    interface INoteState : IViewState
    {
        bool CanEditDate();
        bool CanEditNote();
        bool CanDelete();
    }
}
