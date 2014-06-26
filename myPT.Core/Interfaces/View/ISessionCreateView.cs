using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Interfaces.View
{
    interface ISessionCreateView : ISessionView
    {
        event EventHandler AchievementValueChanged;
        event EventHandler StartSessionClicked;
    }
}
