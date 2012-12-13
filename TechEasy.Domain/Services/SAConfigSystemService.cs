using TechEasy.Data.Repositories;
using TechEasy.Domain.Interface;
using TechEasy.Model;
using System.Collections;
using TechEasy.Core.Common;
using System;
using TechEasy.Data.Infrastructure;
using TechEasy.Domain.Services.SystemManger;

namespace TechEasy.Domain.Services
{
    public class SAConfigSystemService : ServiceBase<SA_Config_System>, ISAConfigSystemService
    {
        public SAConfigSystemService(ISAConfigSystemRepository repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {

        }

        public string GetValueByCache(string keyName)
        {
            Hashtable hashListByCache = GetHashListByCache();
            if (((hashListByCache != null) && hashListByCache.ContainsKey(keyName)) && (hashListByCache[keyName] != null))
            {
                return hashListByCache[keyName].ToString();
            }
            return Get(m => m.Keyname == keyName).Value;

        }

        public string GetValueByCache(string Keyname, ApplicationKeyType KeyType)
        {
            Hashtable hashListByCache = GetHashListByCache(KeyType);
            if (hashListByCache[Keyname] != null)
            {
                return hashListByCache[Keyname].ToString();
            }
            return Get(m => m.Keyname == Keyname).Value;
        }

        private Hashtable GetHashListByCache(ApplicationKeyType KeyType)
        {
            string cacheKey = "ConfigSystemHashList_" + KeyType;
            object cache = DataCache.GetCache(cacheKey);
            if (cache == null)
            {
                try
                {
                    cache = GetHashList();
                    if (cache != null)
                    {
                        int num = Globals.SafeInt(Get(m => m.Keyname == "CacheTime").Value, 30);
                        DataCache.SetCache(cacheKey, cache, DateTime.Now.AddMinutes((double)num), TimeSpan.Zero);
                    }
                }
                catch
                {

                }
            }
            return (Hashtable)cache;
        }

        private Hashtable GetHashListByCache()
        {
            string cacheKey = "ConfigSystemHashList";
            object cache = DataCache.GetCache(cacheKey);
            if (cache == null)
            {
                try
                {
                    cache = GetHashList();
                    if (cache != null)
                    {
                        int num = Globals.SafeInt(Get(m => m.Keyname == "CacheTime").Value, 30);
                        DataCache.SetCache(cacheKey, cache, DateTime.Now.AddMinutes((double)num), TimeSpan.Zero);
                    }
                }
                catch
                {

                }
            }
            return (Hashtable)cache;
        }

        private Hashtable GetHashList()
        {
            Hashtable hashTable = new Hashtable();
            var list = this.GetAllList();
            foreach (var item in list)
            {
                hashTable.Add(item.Keyname, item.Value);
            }
            return hashTable;
        }
    }

    public interface ISAConfigSystemService : IService<SA_Config_System>
    {
        string GetValueByCache(string keyName);
        string GetValueByCache(string Keyname, ApplicationKeyType KeyType);
    }

}
