using myPT.Core.Interfaces.View.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.View.State
{
    class SessionStateCreate : ISessionState
    {
        public bool CanUpdateAchievement()
        {
            return true;
        }

        public bool CanNextExercise()
        {
            return true;
        }

        public bool CanPreviousExercise()
        {
            return true;
        }

        public Common.ViewState StateValue
        {
            get { return Common.ViewState.Create; }
        }

        public bool CanBack()
        {
            return true;
        }
    }
}
