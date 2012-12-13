using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechEasy.Data.Infrastructure;
using TechEasy.Model;

namespace TechEasy.Data.Repositories
{
    public class AccountUserExpRepository : RepositoryBase<Accounts_UsersExp>, IAccountUserExpRepository
    {
        public AccountUserExpRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {

        }
    }

    public interface IAccountUserExpRepository : IRepository<Accounts_UsersExp>
    {

    }
}
