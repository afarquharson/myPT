using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Interfaces
{
    interface ISession : IHistoryItem
    {
        String Id { get; set; }
        DateTime StartTime { get; set; }
        DateTime EndTime { get; set; }
        List<IActivity> Activities { get; set; }
    }
}
