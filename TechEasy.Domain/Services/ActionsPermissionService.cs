using TechEasy.Data.Repositories;
using TechEasy.Domain.Interface;
using TechEasy.Model;
using TechEasy.Data.Infrastructure;
using System.Collections;
using TechEasy.Core.Common;
using System;
using TechEasy.Core.Helper;

namespace TechEasy.Domain.Services
{
    public class ActionsPermissionService : ServiceBase<Accounts_Actions_Permission>, IActionsPermissionService
    {
        public ActionsPermissionService(IActionsPermissionRepository repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {

        }

        public Hashtable GetHashListByCache()
        {
            string cacheKey = "ActionsPermissionHashList";
            object cache = DataCache.GetCache(cacheKey);
            if (cache == null)
            {
                try
                {
                    cache = GetHashList();
                    if (cache != null)
                    {
                        int configInt = ConfigHelper.GetConfigInt("CacheTime");
                        DataCache.SetCache(cacheKey, cache, DateTime.Now.AddMinutes((double)configInt), TimeSpan.Zero);
                    }
                }
                catch
                {
                }
            }
            return (Hashtable)cache;
        }

        private object GetHashList()
        {
            Hashtable hashTable = new Hashtable();
            var list = GetAllList();
            foreach (var item in list)
            {
                hashTable.Add(item.ActionID.ToString(), item.PermissionID.ToString());
            }
            return hashTable;
        }

    }

    public interface IActionsPermissionService : IService<Accounts_Actions_Permission>
    {
        Hashtable GetHashListByCache();
    }

}
