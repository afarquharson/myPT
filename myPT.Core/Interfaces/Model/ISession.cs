using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Interfaces.Model
{
    interface ISession : IHistoryItem
    {
        DateTime StartTime { get; set; }
        DateTime EndTime { get; set; }
        List<IExercise> Exercises { get; set; }
    }
}
