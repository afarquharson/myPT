using myPT.Core.Interfaces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Interfaces.View
{
    public interface IProgramView : IView
    {
        IProgram Program { get; set; }
        event EventHandler AddSetClicked;
        event EventHandler AddExerciseClicked;
        event EventHandler CloneClicked;
        event EventHandler StartSessionClicked;
    }
}
