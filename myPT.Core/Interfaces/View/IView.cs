using myPT.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Interfaces.View
{
    interface IView
    {
        IViewState State { get; set; }
        string GUID { get; set; } //The ID of the item being viewed - some duplucation here. Can we just use the id passed in?
        String ParentGUID { get; set; } //The ID of the parent item
        void Load(NavigationData data);
    }
}
