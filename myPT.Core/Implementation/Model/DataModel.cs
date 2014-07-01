using myPT.Core.Interfaces;
using myPT.Core.Interfaces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.Model
{
    class DataModel : IDataModel
    {
        Dictionary<string, IProgram> _cachedPrograms;
        Dictionary<string, ISession> _cachedSessions;
        Dictionary<string, IHistoryItem> _cachedHistory;

        private IProxy _proxy;
        public IProxy Proxy { get { return _proxy ?? (_proxy = new Proxy()); } }

        public DataModel() { }

        public DataModel(IProxy service)
            : this()
        {
            _proxy = service;
        }

        public Dictionary<string, IProgram> Programs
        {
            get
            {
                return _cachedPrograms ?? (_cachedPrograms = Proxy.Programs);
            }
            set
            {
                if (!value.SequenceEqual(_cachedPrograms)) this.Proxy.Programs = _cachedPrograms = value;
            }
        }

        public Dictionary<string, ISession> Sessions
        {
            get
            {
                return _cachedSessions ?? (_cachedSessions = Proxy.Sessions);
            }
            set
            {
                if (!value.SequenceEqual(_cachedSessions)) this.Proxy.Sessions = _cachedSessions = value;
            }
        }

        public Dictionary<string, IHistoryItem> History
        {
            get
            {
                return _cachedHistory ?? (_cachedHistory = Proxy.History);
            }
            set
            {
                if (!value.SequenceEqual(_cachedHistory)) this.Proxy.History = _cachedHistory = value;
            }
        }

        public IExercise GetExercise(bool isSession, string parentID, string ExerciseID)
        {
            IExercise result = null;
            if (isSession)
            {
                Sessions[parentID].Exercises.TryGetValue(ExerciseID, out result);
            }
            else
            {
                var output = Programs[parentID].Exercises.FindExercise(ExerciseID);
                if (output != null)
                {
                    result = output.Exercises[ExerciseID];
                }
                else
                {
                    result = null;
                }
            }
            return result;
        }

        public void SaveAll()
        {
            Proxy.History = _cachedHistory;
            Proxy.Programs = _cachedPrograms;
            Proxy.Sessions = _cachedSessions;
        }

        public void LoadAll()
        {
            _cachedHistory = Proxy.History;
            _cachedPrograms = Proxy.Programs;
            _cachedSessions = Proxy.Sessions;
        }
    }
}