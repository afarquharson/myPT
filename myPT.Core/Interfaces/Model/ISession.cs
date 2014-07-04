using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Interfaces.Model
{
    public interface ISession : IHistoryItem
    {
        String ProgramGUID { get; set; }
        DateTime StartTime { get; set; }
        DateTime EndTime { get; set; }
        Dictionary<string, IActivity> Activities { get; set; }
        List<string> Order { get; set; }
    }
}
