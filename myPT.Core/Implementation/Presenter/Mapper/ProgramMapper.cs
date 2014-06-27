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
            AddToConfig<IProgram, IProgramReadView>((s, t) => MapProgramToReadView((IProgram)s, (IProgramReadView)t));
            AddToConfig<IProgram, IProgramUpdateView>((s, t) => MapProgramToUpdateView((IProgram)s, (IProgramUpdateView)t));
        }

        private void MapProgramToUpdateView(IProgram program, IProgramUpdateView programUpdateView)
        {
            programUpdateView.Program = program;
        }

        private void MapProgramToReadView(IProgram program, IProgramReadView programReadView)
        {
            programReadView.Program = program;
        }
    }
}
