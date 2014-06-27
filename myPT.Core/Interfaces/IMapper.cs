using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Interfaces
{
    interface IMapper
    {
        void Map<TSource, TTarget>(TSource source, TTarget target);
        
        TTarget Map<TSource, TTarget>(TSource source)
            where TTarget: new();
    }
}
