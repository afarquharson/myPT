using myPT.Core.Common;
using myPT.Core.Interfaces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Interfaces.Model
{
    public interface IExercise : IDataItem
    {
        Dictionary<ExerciseFieldKey, String> Detail { get; set; }
        KeyValuePair<ExerciseFieldKey, String> Goal { get; set; }
    }
}
