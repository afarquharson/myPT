using myPT.Core.Interfaces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.Model
{
    [Serializable]
    public class Program : IProgram
    {
        public string Name { get; set; }

        public List<List<Set>> Exercises { get; set; }

        public string GUID { get; set; }

        public override bool Equals(object obj)
        {
            var other = (Program)obj;
            if (other == null)
            {
                return false;
            }
            else
            {
                return String.Equals(this.Name, other.Name)
                    && String.Equals(this.GUID, other.GUID)
                    && this.Exercises.SequenceEqual(other.Exercises);
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
