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
        public DateTime StartTime
        {
            get;
            set;
        }

        public DateTime EndTime
        {
            get;
            set;
        }

        public List<IExercise> Exercises
        {
            get;
            set;
        }

        public DateTime Date
        {
            get { return StartTime.Date; }
            set {  } //Do nothing
        }

        public string Summary
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
