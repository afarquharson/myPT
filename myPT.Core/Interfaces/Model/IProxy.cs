using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Interfaces.Model
{
    interface IProxy
    {
        List<IProgram> Programs { get; set; }
        List<ISession> Sessions { get; set; }
        List<IHistoryItem> History { get; set; }
    }
}
