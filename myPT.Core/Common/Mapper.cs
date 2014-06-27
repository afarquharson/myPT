using myPT.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Common
{
    class Mapper : IMapper
    {
        public IDictionary<string, Action<object, object>> Config = new Dictionary<string, Action<object, object>>();
        
        public string GetKey<TSource, TTarget>()
        {
            return string.Format("{0}-{1}", typeof(TSource).FullName, typeof(TTarget).FullName);
        }

        public void AddToConfig<TSource, TTarget>(Action<object, object> act) 
        {
            var key = GetKey<TSource, TTarget>();
            Config.Add(key, act);
        }

        public void Map<TSource, TTarget>(TSource source, TTarget target)
        {
            Config[GetKey<TSource, TTarget>()](source, target);
        }

        public TTarget Map<TSource, TTarget>(TSource source) 
            where TTarget : new()
        {
            var target = new TTarget();
            Map(source, target);
            return target;
        }
    }
}
