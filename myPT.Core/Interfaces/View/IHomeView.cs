using myPT.Core.Interfaces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Interfaces.View
{
    public interface IHomeView : IView
    {
        Dictionary<string, IProgram> Programs { get; set; }

        event EventHandler SettingsClicked;
        event EventHandler AddProgramClicked;
        event EventHandler TimelineClicked;
        event EventHandler ItemSelected;
    }
}
