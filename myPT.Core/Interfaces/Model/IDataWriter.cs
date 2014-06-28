using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace myPT.Core.Interfaces.Model
{
    interface IDataWriter
    {
        void Write<TData>(String fileName, TData data);

        TData Read<TData>(String fileName);
    }
}
