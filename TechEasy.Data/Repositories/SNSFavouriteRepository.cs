using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechEasy.Data.Infrastructure;
using TechEasy.Model;

namespace TechEasy.Data.Repositories
{
    public class SNSFavouriteRepository : RepositoryBase<SNS_UserFavourite>, ISNSFavouriteRepository
    {
        public SNSFavouriteRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {

        }
    }

    public interface ISNSFavouriteRepository : IRepository<SNS_UserFavourite>
    {

    }
}
