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

        private Dictionary<CommandKey, CommandName> _commands;
        public Dictionary<CommandKey, CommandName> Commands
        {
            get 
            { 
                return _commands ?? (_commands = new Dictionary<CommandKey,CommandName>
                {
                    {CommandKey.TopLeft, CommandName.None},
                    {CommandKey.TopRight, CommandName.About},
                    {CommandKey.LowerLeft, CommandName.AddProgram},
                    {CommandKey.LowerRight, CommandName.ViewTimeline},
                    {CommandKey.ItemSelect, CommandName.ViewProgram}
                });
            }
        }
    }
}
