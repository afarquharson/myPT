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
        private IGUIDMaker _maker { get; set; }
        public IGUIDMaker GuidMaker { get { return _maker ?? new GUIDMaker(); } }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime Date
        {
            get { return StartTime.Date; }
            set { } //Do nothing - since Date is derived we don't want to overwrite the source field
        }
        public string Summary { get; set; }
        public string GUID { get; set; }
        public string ProgramGUID { get; set; }
        public Dictionary<string, IExercise> Exercises { get; set; }

        public Session() { }

        public Session(IProgram program)
            : this()
        {
            StartTime = DateTime.Now;
            EndTime = DateTime.MinValue;
            Summary = String.Format("{0} - {1}", DateTime.Now.Date.ToString(), program.Name);
            GUID = GuidMaker.GetGUID();

            //Expand Program
            foreach (var compoundSet in program.Exercises)
            {
                foreach (var set in compoundSet)
                {
                    for (int i = 0; i < set.Reps; i++)
                    {
                        foreach (var e in set.Exercises)
                        {
                            this.Exercises.Add(GuidMaker.GetGUID(), e.Value);//May need a way to trace back to parent exercise?
                        }
                    }
                }
            }
        }

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
