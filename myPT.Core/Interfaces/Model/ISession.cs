using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Interfaces.Model
{
    interface ISession : IHistoryItem
    {
        String ProgramGUID { get; set; }
        DateTime StartTime { get; set; }
        DateTime EndTime { get; set; }
        Dictionary<string, IExercise> Exercises { get; set; }
    }
}
