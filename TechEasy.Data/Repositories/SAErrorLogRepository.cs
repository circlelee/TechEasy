using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechEasy.Data.Infrastructure;
using TechEasy.Model;

namespace TechEasy.Data.Repositories
{
    public class SAErrorLogRepository : RepositoryBase<SA_ErrorLog>, ISAErrorLogRepository
    {
        public SAErrorLogRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {

        }
    }

    public interface ISAErrorLogRepository : IRepository<SA_ErrorLog>
    {

    }
}
