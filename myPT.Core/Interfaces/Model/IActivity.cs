using myPT.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Interfaces.Model
{
    public interface IActivity : IDataItem
    {
        IExercise Exercise { get; set; }
        String Achievement { get; set; }
    }
}
