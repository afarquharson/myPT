using myPT.Core.Interfaces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.Model
{
    [Serializable]
    public class Program : IProgram
    {
        public string Name { get; set; }

        public List<List<Set>> Exercises
        {
            get;
            set;
        }

        public string Id
        {
            get;
            set;
        }
    }
}
