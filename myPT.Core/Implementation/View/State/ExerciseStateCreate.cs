using myPT.Core.Interfaces.View.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.View.State
{
    class ExerciseStateCreate : IExerciseState
    {
        public bool CanEditDetail()
        {
            return true;
        }

        public bool CanAddField()
        {
            return true;
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
            get { return Common.ViewState.Create; }
        }

        public bool CanBack()
        {
            return true;
        }
    }
}
