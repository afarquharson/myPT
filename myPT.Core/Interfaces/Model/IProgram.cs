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
        List<List<Set>> Exercises { get; set; } //2D array to allow compund sets with reps
    }

    [Serializable]
    public struct Set
    {
        public List<IExercise> Activities;
        public int Reps;
    }
}
