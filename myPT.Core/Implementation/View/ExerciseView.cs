using myPT.Core.Interfaces.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.View
{
    class ExerciseView : IExerciseView
    {
        public Interfaces.Model.IExercise Exercise
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public event EventHandler UpdateGoalClicked;

        public event EventHandler AddFieldClicked;

        public event EventHandler BackClicked;

        public void Load(Common.NavigationData data)
        {
            throw new NotImplementedException();
        }
    }
}
