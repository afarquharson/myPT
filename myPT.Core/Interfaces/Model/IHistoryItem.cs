using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Interfaces
{
    interface IHistoryItem
    {
        String Id { get; set; }
        DateTime Date { get; set; }
        String Summary { get; set; }
    }
}
