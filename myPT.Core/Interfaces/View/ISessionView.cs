using myPT.Core.Interfaces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Interfaces.View
{
    public interface ISessionView : IView
    {
        ISession Session { get; set; }
        event EventHandler AchievementValueChanged;
        event EventHandler StartSessionClicked;
        event EventHandler ExerciseClicked;
    }
}
