using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Interfaces.Model
{
    interface IProxy
    {
        Dictionary<string, IProgram> Programs { get; set; }
        Dictionary<string, ISession> Sessions { get; set; }
        Dictionary<string, IHistoryItem> History { get; set; }
    }
}
