using myPT.Core.Interfaces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.Model
{
    [Serializable]
    public class Exercise : IExercise
    {
        public Dictionary<Common.ExerciseFieldKey, string> Detail
        {
            get;
            set;
        }

        public string Id
        {
            get;
            set;
        }
    }
}
