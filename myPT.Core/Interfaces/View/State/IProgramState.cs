using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Interfaces.View.State
{
    interface IProgramState : IViewState
    {
        bool CanAddSet();
        bool CanAddExercise();
        bool CanAddExerciseToSet();
        bool CanUpdateGoals();
        bool CanCloneProgram();
        bool CanStartSession();
    }
}
