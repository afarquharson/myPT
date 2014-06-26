using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Interfaces
{
    interface IActivity : IExercise
    {
        String Id { get; set; }
        object Achievement { get; set; }
    }
}
