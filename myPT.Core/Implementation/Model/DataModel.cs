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
        //TODO Make cache system work correctly. Use Validator pattern to check for changes?

        List<IProgram> _cachedPrograms;
        List<ISession> _cachedSessions;
        List<IHistoryItem> _cachedHistory;

        private IProxy _proxy;
        public IProxy Proxy { get { return _proxy ?? (_proxy = new Proxy()); } }

        public DataModel() { }

        public DataModel(IProxy service) : this()
        {
            _proxy = service;
        }

        public List<IProgram> Programs
        {
            get
            {
                return _cachedPrograms ?? (_cachedPrograms = Proxy.Programs);
            }
            set
            {
                Proxy.Programs = value;
                _cachedPrograms = value;
            }
        }

        public List<ISession> Sessions
        {
            get
            {
                return _cachedSessions ?? (_cachedSessions = Proxy.Sessions);
            }
            set
            {
                Proxy.Sessions = value;
                _cachedSessions = value;
            }
        }

        public List<IHistoryItem> History
        {
            get
            {
                return _cachedHistory ?? (_cachedHistory = Proxy.History);
            }
            set
            {
                Proxy.History = value;
                _cachedHistory = value;
            }
        }

        public IHistoryItem GetHistoryItem(string id)
        {
            if (History.Any(i => i.Id == id))
            {
                return History.Where(i => i.Id == id).First();
            }
            else
            {
                return null;
            }
        }

        public void AddHistoryItem(IHistoryItem item)
        {
            History.Add(item);
        }

        public ISession GetSession(string id)
        {
            if (Sessions.Any(i => i.Id == id))
            {
                return Sessions.Where(i => i.Id == id).First();
            } 
            else 
            {
                return null;
            }
        }

        public IProgram GetProgram(string id)
        {
            if (Programs.Any(i => i.Id == id))
            {
                return Programs.Where(i => i.Id == id).First();
            }
            else
            {
                return null;
            }
        }
    }
}
