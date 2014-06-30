using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Interfaces.View.State
{
    interface IExerciseState : IViewState
    {
        bool CanEditDetail();
        bool CanAddField();
        bool CanEditGoalValue();
        bool CanEditAchievementValue();
    }
}
