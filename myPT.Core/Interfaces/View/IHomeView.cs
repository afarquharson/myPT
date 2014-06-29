using myPT.Core.Interfaces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Interfaces.View
{
    interface IHomeView : IView
    {
        List<IProgram> Programs { get; set; }

        event EventHandler SettingsClicked;
        event EventHandler AddProgramClicked;
        event EventHandler TimelineClicked;
        event EventHandler ItemSelected;
    }
}
