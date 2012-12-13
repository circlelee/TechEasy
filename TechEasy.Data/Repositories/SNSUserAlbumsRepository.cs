using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechEasy.Data.Infrastructure;
using TechEasy.Model;

namespace TechEasy.Data.Repositories
{
    public class SNSUserAlbumsRepository : RepositoryBase<SNS_UserAlbums>, ISNSUserAlbumsRepository
    {
        public SNSUserAlbumsRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {

        }
    }

    public interface ISNSUserAlbumsRepository : IRepository<SNS_UserAlbums>
    {

    }
}
