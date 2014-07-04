using myPT.Core.Common;
using myPT.Core.Interfaces.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.View.State
{
    class ActivityStateUpdate : IViewState
    {
        public Common.ViewState StateValue
        {
            get { return Common.ViewState.Update; }
        }

        private Dictionary<CommandKey, Command> _commands;
        public Dictionary<CommandKey, Command> Commands
        {
            get 
            { 
                return _commands ?? (_commands = new Dictionary<CommandKey,Command>
                {
                    {CommandKey.TopLeft, Command.SessionCreate},
                    {CommandKey.TopRight, Command.None},
                    {CommandKey.LowerLeft, Command.PreviousActivity},
                    {CommandKey.LowerRight, Command.NextActivity},
                    {CommandKey.ItemSelect, Command.None}
                });
            }
        }
    }
}
