using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechEasy.Data.Infrastructure;
using TechEasy.Model;

namespace TechEasy.Data.Repositories
{
    public class SNSCategoryRepository : RepositoryBase<SNS_Categories>, ISNSCategoryRepository
    {
        public SNSCategoryRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {

        }
    }

    public interface ISNSCategoryRepository : IRepository<SNS_Categories>
    {

    }
}
