using myPT.Core.Common;
using myPT.Core.Interfaces.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.View.State
{
    class ActivityStateReadOnly : IViewState
    {
        public ViewState StateValue
        {
            get { return ViewState.ReadOnly; }
        }

        private Dictionary<CommandKey, NavigateKey> _commands;
        public Dictionary<CommandKey, NavigateKey> Commands
        {
            get 
            { 
                return _commands ?? (_commands = new Dictionary<CommandKey,NavigateKey>
                {
                    {CommandKey.TopLeft, NavigateKey.SessionReadOnly},
                    {CommandKey.TopRight, NavigateKey.None},
                    {CommandKey.LowerLeft, NavigateKey.None},
                    {CommandKey.LowerRight, NavigateKey.None},
                    {CommandKey.ItemSelect, NavigateKey.None}
                });
            }
        }
    }
    
}
