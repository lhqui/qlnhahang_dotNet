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
        private static string _keyAdmin = "isAdmin";
        //private static string _keyUser = "userId";
        private static readonly MemoryCache _cache = MemoryCache.Default;


        //cache.Add(CacheKey, availableStocks, cacheItemPolicy);
        public void storeItemInCache(String idRoll) {
            var cacheItemPolicy = new CacheItemPolicy()
            {
                //Set time expiration.
                AbsoluteExpiration = DateTime.Now.AddHours(1)
            };
            //add item to cache
            _cache.Add(_keyAdmin, idRoll, cacheItemPolicy);
            //_cache.Add(_keyUser, userId, cacheItemPolicy);
        }
        public static String GetPermissionFromCache()
        {
              return _cache.Get(_keyAdmin) as String;
        }
        //public static String GetUserIdFromCache()
        //{
        //    return _cache.Get(_keyUser) as String;
        //}
        public static void RemoveItemsFromCache()
        {
            if (string.IsNullOrEmpty(_keyAdmin))
            {
               // _cache.Remove(_keyUser);
                _cache.Dispose();
            }
            else
            {
                _cache.Remove(_keyAdmin);
                //_cache.Remove(_keyUser);
            }
        }
    }
}
