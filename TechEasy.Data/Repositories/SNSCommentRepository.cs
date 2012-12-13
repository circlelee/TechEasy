using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechEasy.Data.Infrastructure;
using TechEasy.Model;

namespace TechEasy.Data.Repositories
{
    public class SNSCommentRepository : RepositoryBase<SNS_Comments>, ISNSCommentRepository
    {
        public SNSCommentRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {

        }
    }

    public interface ISNSCommentRepository : IRepository<SNS_Comments>
    {

    }
}
