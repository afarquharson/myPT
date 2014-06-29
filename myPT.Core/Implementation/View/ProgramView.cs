using myPT.Core.Interfaces.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.View
{
    class ProgramView : IProgramView
    {
        public Interfaces.Model.IProgram Program
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public event EventHandler AddSetClicked;

        public event EventHandler AddExerciseClicked;

        public event EventHandler CloneClicked;

        public event EventHandler StartSessionClicked;

        public event EventHandler BackClicked;

        public void Load(Common.NavigationData data)
        {
            throw new NotImplementedException();
        }
    }
}
