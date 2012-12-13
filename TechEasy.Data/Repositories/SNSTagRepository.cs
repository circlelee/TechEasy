using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechEasy.Data.Infrastructure;
using TechEasy.Model;

namespace TechEasy.Data.Repositories
{
    public class SNSTagRepository : RepositoryBase<SNS_Tags>, ISNSTagRepository
    {
        public SNSTagRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {

        }
    }

    public interface ISNSTagRepository : IRepository<SNS_Tags>
    {

    }
}
