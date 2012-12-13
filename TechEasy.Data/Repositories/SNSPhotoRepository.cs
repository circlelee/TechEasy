using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechEasy.Data.Infrastructure;
using TechEasy.Model;

namespace TechEasy.Data.Repositories
{
    public class SNSPhotoRepository : RepositoryBase<SNS_Photos>, ISNSPhotoRepository
    {
        public SNSPhotoRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {

        }
    }

    public interface ISNSPhotoRepository: IRepository<SNS_Photos>
    {

    }
}
