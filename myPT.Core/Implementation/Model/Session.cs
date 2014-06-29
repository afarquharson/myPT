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
        public Session() { }

        public Session(IProgram program)
            : this()
        {
            StartTime = DateTime.Now;
            EndTime = DateTime.MinValue;
            Summary = String.Format("{0} - {1}", DateTime.Now.Date.ToString(), program.Name);
            Id = System.Guid.NewGuid().ToString();

            //Expand Program
            var output = new List<IExercise>();
            foreach (var compoundSet in program.Exercises)
            {
                foreach (var set in compoundSet)
                {
                    for (int i = 0; i < set.Reps; i++)
                    {
                        Exercises.AddRange(set.Activities);
                    }
                }
            }
        }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public List<IExercise> Exercises { get; set; }

        public DateTime Date
        {
            get { return StartTime.Date; }
            set {  } //Do nothing - since Date is derived we don't want to overwrite the source field
        }

        public string Summary { get; set; }

        public string Id { get; set; }

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
                    && String.Equals(this.Id, other.Id);
            }
        }
    }
}
