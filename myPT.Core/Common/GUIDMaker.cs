using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Common
{
    public class GUIDMaker : IGUIDMaker
    {
        public string GetGUID()
        {
            return System.Guid.NewGuid().ToString();
        }
    }
}
