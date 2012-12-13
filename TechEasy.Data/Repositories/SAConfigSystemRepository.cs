using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechEasy.Data.Infrastructure;
using TechEasy.Model;

namespace TechEasy.Data.Repositories
{
    public class SAConfigSystemRepository : RepositoryBase<SA_Config_System>, ISAConfigSystemRepository
    {
        public SAConfigSystemRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {

        }
    }

    public interface ISAConfigSystemRepository : IRepository<SA_Config_System>
    {

    }
}
