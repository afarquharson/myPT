using myPT.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Interfaces.View
{
    public interface IView
    {
        Dictionary<string, string> List { get; } //The items being displayed
        IViewState State { get; set; } //The buttons available
        string GUID { get; set; } //The ID of the item being viewed
        String ParentGUID { get; set; } //The ID of the parent item
        
        event EventHandler BackClicked;
        
        void Load(NavigationData data);

        void Execute(CommandKey command, string[] data);
    }
}
