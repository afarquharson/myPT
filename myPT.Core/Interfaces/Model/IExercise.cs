using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Interfaces
{
    interface IExercise
    {
        String Id { get; set; }
        Dictionary<String, object> Properties { get; set; }
    }
}
