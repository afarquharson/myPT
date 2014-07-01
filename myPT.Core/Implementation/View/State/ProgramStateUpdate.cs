using myPT.Core.Interfaces.View.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.View.State
{
    class ProgramStateUpdate : IProgramState
    {
        public bool CanAddSet()
        {
            return false;
        }

        public bool CanAddExercise()
        {
            return false;
        }

        public bool CanAddExerciseToSet()
        {
            return false;
        }

        public bool CanUpdateGoals()
        {
            return false;
        }

        public bool CanCloneProgram()
        {
            return false;
        }

        public bool CanStartSession()
        {
            return false;
        }

        public Common.ViewState StateValue
        {
            get { return Common.ViewState.Update; }
        }

        public bool CanBack()
        {
            return true;
        }
    }
}
