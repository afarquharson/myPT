using myPT.Core.Interfaces.Model;
using myPT.Core.Interfaces.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Common
{
    public class NavigationData
    {
        public Command ToScreen { get; set; }
        public String ToItem { get; set; }
        public String FromItem { get; set; }
        public IDataModel Model { get; set; } //Pass the model around instead of creating a new one each time
        public IView FromView { get; set; }
    }
}
