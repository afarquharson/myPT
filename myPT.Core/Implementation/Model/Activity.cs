using myPT.Core.Interfaces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.Model
{
    public class Activity : IActivity
    {
        public IExercise Exercise { get; set; }
        public string Achievement { get; set; }
        public string GUID { get; set; }

        public Dictionary<string, string> Print()
        {
            var result = new Dictionary<string, string>();
            var printedExercise = Exercise.Print();
            foreach (var e in printedExercise)
            {
                result.Add(e.Key, e.Value);
            }
            result.Add("Achievement", Achievement);
            return result;
        }

        public override bool Equals(object obj)
        {
            var other = (Activity)obj;
            if (other == null)
            {
                return false;
            }
            else
            {
                return this.Exercise.Equals(other)
                    && String.Equals(this.Achievement, other.Achievement)
                    && String.Equals(this.GUID, other.GUID);
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
