using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechEasy.Model;
using System.Linq.Expressions;
using TechEasy.Data.Infrastructure;
using TechEasy.Data.Repositories;
using TechEasy.Domain.Interface;

namespace TechEasy.Domain.Services
{

    public class SNSPostService : ServiceBase<SNS_Posts>, ISNSPostService
    {
        public SNSPostService(ISNSPostRepository repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {

        }
    }

    public interface ISNSPostService : IService<SNS_Posts>
    {

    }
}
