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
            AddToConfig<IDataModel, IProgramView>((s, t) => MapProgramToView((IDataModel)s, (IProgramView)t));
            AddToConfig<IProgramView, IDataModel>((s, t) => MapViewToModel((IProgramView)s, (IDataModel)t));
        }

        private void MapViewToModel(IProgramView programView, IDataModel dataModel)
        {
            dataModel.Programs[programView.GUID] = programView.Program;
        }

        private void MapProgramToView(IDataModel model, IProgramView programView)
        {
            IProgram existingProgram;
            model.Programs.TryGetValue(programView.GUID, out existingProgram);
            if (existingProgram != null)
            {
                programView.Program = model.Programs[programView.GUID];
            }
        }
    }
}
