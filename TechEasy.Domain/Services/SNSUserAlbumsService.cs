using TechEasy.Data.Repositories;
using TechEasy.Domain.Interface;
using TechEasy.Model;
using TechEasy.Data.Infrastructure;

namespace TechEasy.Domain.Services
{
    public class SNSUserAlbumsService : ServiceBase<SNS_UserAlbums>, ISNSUserAlbumsService
    {
        public SNSUserAlbumsService(ISNSUserAlbumsRepository repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {

        }
    }

    public interface ISNSUserAlbumsService : IService<SNS_UserAlbums>
    {

    }
}
