using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rgik.Infrastucture
{
    /// <summary>
    /// Provide basic structure for class that will implement this interface!
    /// </summary>
    interface ICacheProvider
    {
        object Get(string key);
        void Set(string key, object date, int cacheTime);
        bool isSet(string key);
        void Invalidate(string key);
    }
}
