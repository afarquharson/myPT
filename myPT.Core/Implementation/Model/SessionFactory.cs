using myPT.Core.Common;
using myPT.Core.Interfaces;
using myPT.Core.Interfaces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.Model
{
    public class SessionFactory : ISessionFactory
    {
        private IGUIDMaker _maker { get; set; }
        public IGUIDMaker GuidMaker { get { return _maker ?? new GUIDMaker(); } }

        public SessionFactory() { }
        public SessionFactory(IGUIDMaker maker)
            : this()
        {
            _maker = maker;
        }

        public ISession GetSession(IProgram program)
        {
            var result = new Session
            {
                GUID = GuidMaker.GetGUID(),
                StartTime = DateTime.Now,
                EndTime = DateTime.MinValue,
                Summary = String.Format("{0} - {1}", DateTime.Now.Date.ToString(), program.Name),
                ProgramGUID = program.GUID,
                Activities = new Dictionary<string,IActivity>(),
                Order = new List<string>()
            };
            var flatProgram = program.Exercises.Flatten(); //Get the exercises
            foreach (var v in flatProgram)
            {
                //Make an Activity using the exercise
                var tmp = new Activity()
                {
                    GUID =  GuidMaker.GetGUID(),
                    Exercise = v
                };
                result.Order.Add(tmp.GUID); //Preserve the order of activities since Dictionaries can't be trusted with this (assume order won't change)
                result.Activities.Add(tmp.GUID, tmp); //New GUIDs as keys, but Exercise remembers its own GUID field - allows us to trace back to parent Exercise
            }
            return result;
        }
    }
}
