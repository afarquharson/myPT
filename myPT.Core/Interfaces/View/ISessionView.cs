using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Interfaces.View
{
    interface ISessionView : IChildView
    {
        ISession Session { get; set; }
    }
}
