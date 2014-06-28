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

        public List<IProgram> Programs
        {
            get
            {
                return _writer.Read<List<IProgram>>(pFileName);
            }
            set
            {
                _writer.Write<List<IProgram>>(pFileName, value);
            }
        }

        public List<ISession> Sessions
        {
            get
            {
                return _writer.Read<List<ISession>>(sFileName);
            }
            set
            {
                _writer.Write<List<ISession>>(sFileName, value);
            }
        }

        public List<IHistoryItem> History
        {
            get
            {
                return _writer.Read<List<IHistoryItem>>(hFileName);
            }
            set
            {
                _writer.Write<List<IHistoryItem>>(hFileName, value);
            }
        }
    }
}
