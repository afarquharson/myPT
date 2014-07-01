using myPT.Core.Implementation.Model;
using myPT.Core.Interfaces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Interfaces.Model
{
    public interface IProgram : IDataItem
    {
        String Name { get; set; }
        ExerciseTreeItem Exercises { get; set; } //Tree to allow compound sets with reps and recursive search
    }
}
