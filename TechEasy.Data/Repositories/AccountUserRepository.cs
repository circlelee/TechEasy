using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechEasy.Data.Infrastructure;
using TechEasy.Model;

namespace TechEasy.Data.Repositories
{
    public class AccountUserRepository : RepositoryBase<Accounts_Users>, IAccountUserRepository
    {
        public AccountUserRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {

        }
    }

    public interface IAccountUserRepository : IRepository<Accounts_Users>
    {

    }
}
