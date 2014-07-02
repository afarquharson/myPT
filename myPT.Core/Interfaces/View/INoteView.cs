using myPT.Core.Interfaces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Interfaces.View
{
    public interface INoteView : IView
    {
        IHistoryItem Item { get; set; }

        event EventHandler DeleteNoteClicked;
    }
}
