using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechEasy.Data.Infrastructure;
using TechEasy.Model;

namespace TechEasy.Data.Repositories
{
    public class SNSTagTypeRepository : RepositoryBase<SNS_TagType>, ISNSTagTypeRepository
    {
        public SNSTagTypeRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {

        }
    }

    public interface ISNSTagTypeRepository : IRepository<SNS_TagType>
    {

    }
}
