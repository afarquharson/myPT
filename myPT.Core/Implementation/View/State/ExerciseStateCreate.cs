using myPT.Core.Common;
using myPT.Core.Interfaces.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.View.State
{
    class ExerciseStateCreate : IViewState
    {
        public Common.ViewState StateValue
        {
            get { return Common.ViewState.Create; }
        }

        private Dictionary<CommandKey, CommandName> _commands;
        public Dictionary<CommandKey, CommandName> Commands
        {
            get 
            { 
                return _commands ?? (_commands = new Dictionary<CommandKey,CommandName>
                {
                    {CommandKey.TopLeft, CommandName.Back},
                    {CommandKey.TopRight, CommandName.None},
                    {CommandKey.LowerLeft, CommandName.AddSet},
                    {CommandKey.LowerRight, CommandName.AddField},
                    {CommandKey.ItemSelect, CommandName.None}
                });
            }
        }

        public CommandName TopLeft
        {
            get { return CommandName.Back; }
        }

        public CommandName TopRight
        {
            get { return CommandName.None; }
        }

        public CommandName LowerLeft
        {
            get { return CommandName.AddSet; }
        }

        public CommandName LowerRight
        {
            get { return CommandName.AddField; }
        }

        public string ItemSelect
        {
            get { return String.Empty; }
        }
    }
}
