using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechEasy.Data.Infrastructure;
using TechEasy.Model;

namespace TechEasy.Data.Repositories
{
    public class SNSPhotoTagRepository : RepositoryBase<SNS_PhotoTags>, ISNSPhotoTagRepository
    {
        public SNSPhotoTagRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {

        }
    }

    public interface ISNSPhotoTagRepository : IRepository<SNS_PhotoTags>
    {

    }
}
