using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechEasy.Data.Infrastructure;
using TechEasy.Model;

namespace TechEasy.Data.Repositories
{
    public class FriendLinkRepository : RepositoryBase<CMS_FLinks>, IFriendLinkRepository
    {
        public FriendLinkRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {

        }
    }

    public interface IFriendLinkRepository : IRepository<CMS_FLinks>
    {

    }
}
