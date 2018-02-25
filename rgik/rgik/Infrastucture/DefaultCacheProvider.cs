using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;

namespace rgik.Infrastucture
{
    /// <summary>
    /// Expand default HtttpContextCache
    /// </summary>
    public class DefaultCacheProvider : ICacheProvider
    {
        private Cache cache { get { return HttpContext.Current.Cache; } } // Here we actually need to provide the cache itselft

        /// <summary>
        /// Here we will return our specified cache based on the given key 
        /// say for example "Reveolver" it will simply return all elements that are in cache with key "Revolver"
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public object Get(string key)
        {
            return cache[key];
        }

        public void Set(string key, object date, int cacheTime)
        {
            var expirationTime = DateTime.Now + TimeSpan.FromMinutes(cacheTime);
            cache.Insert(key, date,null, expirationTime, Cache.NoSlidingExpiration);//(Where,What,dependencies,how long,time between refreshes)
        }

        /// <summary>
        /// Provide a key to remove cache with key
        /// </summary>
        /// <param name="key"></param>
        public void Invalidate(string key)
        {
            cache.Remove(key);
        }

        /// <summary>
        /// True if the key is set,false if it is not
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool isSet(string key)
        {
            return (cache[key] != null); 
        }
    }
}