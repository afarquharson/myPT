using myPT.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Interfaces.View
{
    interface IViewState
    {
        ViewState StateValue { get; }
        bool CanBack();
    }
}
