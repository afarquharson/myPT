using myPT.Core.Common;
using myPT.Core.Interfaces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.Model
{
    class Session : ISession
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime Date
        {
            get { return StartTime.Date; }
            set { throw new Exception("Cannot change Session Date."); }
        }
        public string Summary { get; set; }
        public string GUID { get; set; }
        public string ProgramGUID { get; set; }
        public Dictionary<string, IExercise> Exercises { get; set; }

        public override bool Equals(object obj)
        {
            var other = (Session)obj;
            if (other == null)
            {
                return false;
            }
            else
            {
                return 
                    this.StartTime == other.StartTime 
                    && this.EndTime == other.EndTime 
                    && this.Exercises.SequenceEqual(other.Exercises)
                    && String.Equals(this.Summary, other.Summary) 
                    && String.Equals(this.GUID, other.GUID);
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
