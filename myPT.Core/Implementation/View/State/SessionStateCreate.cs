﻿using myPT.Core.Common;
using myPT.Core.Interfaces.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.View.State
{
    class SessionStateCreate : IViewState
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
                    {CommandKey.LowerLeft, CommandName.None},
                    {CommandKey.LowerRight, CommandName.None},
                    {CommandKey.ItemSelect, CommandName.EditActivity}
                });
            }
        }
    }
}
