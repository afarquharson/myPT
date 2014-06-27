using myPT.Core.Interfaces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Interfaces.Model
{
    interface IProgram : IDataItem
    {
        String Name { get; set; }
        List<IExercise> Exercises { get; set; }
        Boolean CanEdit { get; set; }
    }
}
