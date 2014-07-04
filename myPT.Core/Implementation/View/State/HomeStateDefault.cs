using myPT.Core.Common;
using myPT.Core.Interfaces.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.View.State
{
    class HomeStateDefault : IViewState
    {
        public Common.ViewState StateValue
        {
            get { return Common.ViewState.Default; }
        }

        private Dictionary<CommandKey, Command> _commands;
        public Dictionary<CommandKey, Command> Commands
        {
            get 
            {
                return _commands ?? (_commands = new Dictionary<CommandKey, Command>
                {
                    {CommandKey.TopLeft, Command.None},
                    {CommandKey.TopRight, Command.About},
                    {CommandKey.LowerLeft, Command.ProgramCreate},
                    {CommandKey.LowerRight, Command.Timeline},
                    {CommandKey.ItemSelect, Command.ProgramUpdate}
                });
            }
        }
    }
}
