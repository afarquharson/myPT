using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Interfaces.View
{
    interface IExerciseCreateView : IExerciseView
    {
        event EventHandler AddFieldClicked;
    }
}
