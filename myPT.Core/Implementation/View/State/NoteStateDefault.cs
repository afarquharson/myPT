﻿using myPT.Core.Common;
using myPT.Core.Interfaces.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.View.State
{
    class NoteStateDefault : IViewState
    {
        public Common.ViewState StateValue
        {
            get { return Common.ViewState.Default; }
        }

        private Dictionary<CommandKey, NavigateKey> _commands;
        public Dictionary<CommandKey, NavigateKey> Commands
        {
            get 
            {
                return _commands ?? (_commands = new Dictionary<CommandKey, NavigateKey>
                {
                    {CommandKey.TopLeft, NavigateKey.Timeline},
                    {CommandKey.TopRight, NavigateKey.None},
                    {CommandKey.LowerLeft, NavigateKey.None},
                    {CommandKey.LowerRight, NavigateKey.DeleteNote},
                    {CommandKey.ItemSelect,NavigateKey.None}
                });
            }
        }
    }
}
