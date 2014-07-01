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
    class SessionFactory : ISessionFactory
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
                Exercises = new Dictionary<string,IExercise>()
            };
            var flatProgram = program.Exercises.Flatten(); //Get the exercises
            foreach (var v in flatProgram.Values)
            {
                result.Exercises.Add(GuidMaker.GetGUID(), v); //Add the exercises with new GUIDs as keys
            }
            return result;
        }
    }
}
