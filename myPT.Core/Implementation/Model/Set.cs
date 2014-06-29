using myPT.Core.Interfaces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.Model
{
    [Serializable]
    public class Set
    {
        public List<IExercise> Activities;
        public int Reps;

        public override bool Equals(object obj)
        {
            var other = (Set)obj;
            if (other == null)
            {
                return false;
            }
            else
            {
                return this.Reps == other.Reps && this.Activities.SequenceEqual(other.Activities);
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
