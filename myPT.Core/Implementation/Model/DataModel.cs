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
        List<IProgram> _cachedPrograms;
        List<ISession> _cachedSessions;
        List<IHistoryItem> _cachedHistory;

        IProxyService ProxyService;

        public DataModel(IProxyService service)
        {
            ProxyService = service;
        }

        public List<IProgram> Programs
        {
            get
            {
                return _cachedPrograms ?? ProxyService.Programs;
            }
            set
            {
                ProxyService.Programs = value;
                _cachedPrograms = value;
            }
        }

        public List<ISession> Sessions
        {
            get
            {
                return _cachedSessions ?? ProxyService.Sessions;
            }
            set
            {
                ProxyService.Sessions = value;
                _cachedSessions = value;
            }
        }

        public List<IHistoryItem> History
        {
            get
            {
                return _cachedHistory ?? ProxyService.History;
            }
            set
            {
                ProxyService.History = value;
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
