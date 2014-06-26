using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Interfaces
{
    interface IProgram
    {
        String Name { get; set; }
        List<IExercise> Exercises { get; set; }
        Boolean CanEdit { get; set; }
    }
}
