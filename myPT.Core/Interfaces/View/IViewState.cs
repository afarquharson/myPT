using myPT.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Interfaces.View
{
    public interface IViewState
    {
        ViewState StateValue { get; }
        Dictionary<CommandKey, CommandName> Commands { get; }
    }
}
