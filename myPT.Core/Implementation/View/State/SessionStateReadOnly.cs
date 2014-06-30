using myPT.Core.Interfaces.View.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.View.State
{
    class SessionStateReadOnly : ISessionState
    {

        public bool CanUpdateAchievement()
        {
            return false;
        }

        public bool CanNextExercise()
        {
            return true;
        }

        public bool CanPreviousExercise()
        {
            return true;
        }

        public Common.ViewState State
        {
            get { return Common.ViewState.ReadOnly; }
        }

        public bool CanBack()
        {
            return true;
        }
    }
}
