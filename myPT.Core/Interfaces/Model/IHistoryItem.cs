using myPT.Core.Interfaces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Interfaces.Model
{
    public interface IHistoryItem : IDataItem
    {
        DateTime Date { get; set; }
        String Summary { get; set; }
    }
}
