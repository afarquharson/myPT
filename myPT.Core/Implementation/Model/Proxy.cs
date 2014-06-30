using myPT.Core.Interfaces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace myPT.Core.Implementation.Model
{
    class Proxy : IProxy
    {
        private string pFileName = "Programs";
        private string hFileName = "History";
        private string sFileName = "Sessions";

        private IDataWriter _writer;
        private IDataWriter Writer
        {
            get { return _writer ?? (_writer = new Writer()); }
        }

        public Proxy() { }

        public Proxy(IDataWriter s) : this()
        {
            _writer = s;
        }

        public Dictionary<string, IProgram> Programs
        {
            get
            {
                return _writer.Read<Dictionary<string, IProgram>>(pFileName);
            }
            set
            {
                _writer.Write<Dictionary<string, IProgram>>(pFileName, value);
            }
        }

        public Dictionary<string, ISession> Sessions
        {
            get
            {
                return _writer.Read<Dictionary<string, ISession>>(sFileName);
            }
            set
            {
                _writer.Write<Dictionary<string, ISession>>(sFileName, value);
            }
        }

        public Dictionary<string, IHistoryItem> History
        {
            get
            {
                return _writer.Read<Dictionary<string, IHistoryItem>>(hFileName);
            }
            set
            {
                _writer.Write<Dictionary<string, IHistoryItem>>(hFileName, value);
            }
        }
    }
}
