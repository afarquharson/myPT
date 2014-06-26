using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Interfaces.View
{
    interface INoteView : IChildView
    {
        INote Note { get; set; }

        event EventHandler DeleteNoteClicked;
    }
}
