using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechEasy.Data.Infrastructure;
using TechEasy.Model;

namespace TechEasy.Data.Repositories
{
    public class SiteMessageRepository : RepositoryBase<SA_SiteMessage>, ISiteMessageRepository
    {
        public SiteMessageRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {

        }
    }

    public interface ISiteMessageRepository : IRepository<SA_SiteMessage>
    {

    }
}
