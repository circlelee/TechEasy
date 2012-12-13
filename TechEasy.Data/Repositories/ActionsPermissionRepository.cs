using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechEasy.Data.Infrastructure;
using TechEasy.Model;

namespace TechEasy.Data.Repositories
{
    public class ActionsPermissionRepository : RepositoryBase<Accounts_Actions_Permission>, IActionsPermissionRepository
    {
        public ActionsPermissionRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {

        }
    }

    public interface IActionsPermissionRepository : IRepository<Accounts_Actions_Permission>
    {

    }
}
