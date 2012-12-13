using System.Collections.Generic;
using TechEasy.Data.Repositories;
using TechEasy.Domain.Interface;
using TechEasy.Model;
using TechEasy.Data.Infrastructure;

namespace TechEasy.Domain.Services
{
    public class SNSFavouriteService : ServiceBase<SNS_UserFavourite>, ISNSFavouriteService
    {
        public SNSFavouriteService(ISNSFavouriteRepository repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {

        }

    }

    public interface ISNSFavouriteService : IService<SNS_UserFavourite>
    {
    }

}
