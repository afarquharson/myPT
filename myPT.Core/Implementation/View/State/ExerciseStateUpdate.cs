using myPT.Core.Interfaces.View.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.View.State
{
    class ExerciseStateUpdate : IExerciseState
    {

        public bool CanEditDetail()
        {
            return false;
        }

        public bool CanAddField()
        {
            return false;
        }

        public bool CanEditGoalValue()
        {
            return true;
        }

        public bool CanEditAchievementValue()
        {
            return false;
        }

        public Common.ViewState State
        {
            get { return Common.ViewState.Update; }
        }

        public bool CanBack()
        {
            return true;
        }
    }
}
