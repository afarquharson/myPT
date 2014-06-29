using myPT.Core.Interfaces.Model;
using myPT.Core.Interfaces.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.Presenter.Mapper
{
    class ProgramMapper : Common.Mapper
    {
        public ProgramMapper()
        {
            Setup();
        }

        public void Setup()
        {
            AddToConfig<IProgram, IProgramView>((s, t) => MapProgramToView((IProgram)s, (IProgramView)t));
        }

        private void MapProgramToView(IProgram program, IProgramView programUpdateView)
        {
            programUpdateView.Program = program;
        }
    }
}
