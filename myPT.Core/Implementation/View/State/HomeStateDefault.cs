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

        private Dictionary<CommandKey, NavigateKey> _commands;
        public Dictionary<CommandKey, NavigateKey> Commands
        {
            get 
            {
                return _commands ?? (_commands = new Dictionary<CommandKey, NavigateKey>
                {
                    {CommandKey.TopLeft, NavigateKey.None},
                    {CommandKey.TopRight, NavigateKey.About},
                    {CommandKey.LowerLeft, NavigateKey.ProgramCreate},
                    {CommandKey.LowerRight, NavigateKey.Timeline},
                    {CommandKey.ItemSelect, NavigateKey.ProgramUpdate}
                });
            }
        }
    }
}
