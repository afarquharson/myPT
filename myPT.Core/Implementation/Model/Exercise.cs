using myPT.Core.Common;
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
        public Dictionary<ExerciseFieldKey, string> Detail { get; set; }

        public string GUID { get; set; }

        public override bool Equals(object obj)
        {
            bool result;
            var other = (Exercise)obj;
            if (other == null)
            {
                result = false;
            }
            else
            {
                result = String.Equals(GUID, other.GUID) && Detail.SequenceEqual(other.Detail); //ok, but do we care about the order here?
            }
            return result;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
