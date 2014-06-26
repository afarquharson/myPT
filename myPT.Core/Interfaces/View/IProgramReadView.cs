using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Interfaces.View
{
    interface IProgramReadView
    {
        interface IProgramReadView : IProgramView
        {
            event EventHandler CloneClicked;
            event EventHandler StartSessionClicked;
        }
    }
}
