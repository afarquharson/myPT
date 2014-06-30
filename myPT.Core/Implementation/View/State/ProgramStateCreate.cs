using myPT.Core.Interfaces.View.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.View.State
{
    class ProgramStateCreate : IProgramState
    {
        public bool CanAddSet()
        {
            return true;
        }

        public bool CanAddExercise()
        {
            return true;
        }

        public bool CanAddExerciseToSet()
        {
            return true;
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

        public Common.ViewState State
        {
            get { return Common.ViewState.Create; }
        }

        public bool CanBack()
        {
            return true;
        }
    }
}
