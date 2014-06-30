using myPT.Core.Interfaces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Interfaces.View
{
    interface IExerciseView : IChildView
    {
        IViewState State { get; set; }
        IExercise Exercise { get; set; }
        event EventHandler UpdateGoalClicked;
        event EventHandler AddFieldClicked;
    }
}
