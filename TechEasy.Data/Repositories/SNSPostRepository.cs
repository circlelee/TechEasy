using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechEasy.Data.Infrastructure;
using TechEasy.Model;

namespace TechEasy.Data.Repositories
{
    public class SNSPostRepository : RepositoryBase<SNS_Posts>, ISNSPostRepository
    {
        public SNSPostRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {

        }
    }

    public interface ISNSPostRepository : IRepository<SNS_Posts>
    {

    }
}
