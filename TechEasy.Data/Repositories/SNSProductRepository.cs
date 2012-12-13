using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechEasy.Data.Infrastructure;
using TechEasy.Model;

namespace TechEasy.Data.Repositories
{
    public class SNSProductRepository : RepositoryBase<SNS_Products>, ISNSProductRepository
    {
        public SNSProductRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {

        }
    }

    public interface ISNSProductRepository : IRepository<SNS_Products>
    {

    }
}
