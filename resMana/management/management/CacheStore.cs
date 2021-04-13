using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Caching;
namespace management
{
    class CacheStore
    {
        private static string _key = "foo";
        private static readonly MemoryCache _cache = MemoryCache.Default;


        //cache.Add(CacheKey, availableStocks, cacheItemPolicy);
        public void storeItemInCache(String numberId) {
            var cacheItemPolicy = new CacheItemPolicy()
            {
                //Set time expiration.
                AbsoluteExpiration = DateTime.Now.AddHours(1)
            };
            //add item to cache
            _cache.Add(_key, numberId, cacheItemPolicy);
        }
        public static String GetItemsFromCache()
        {
              return _cache.Get(_key) as String;
        }
        public static void RemoveItemsFromCache(String item)
        {
            if (string.IsNullOrEmpty(item))
            {
                _cache.Dispose();
            }
            else
            {
                _cache.Remove(item);
            }
        }
    }
}
