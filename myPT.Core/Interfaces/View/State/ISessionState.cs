using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Interfaces.View.State
{
    interface ISessionState : IViewState
    {
        bool CanUpdateAchievement();
        bool CanNextExercise();
        bool CanPreviousExercise();
    }
}
