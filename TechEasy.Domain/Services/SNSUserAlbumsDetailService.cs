using TechEasy.Data.Repositories;
using TechEasy.Domain.Interface;
using TechEasy.Model;
using TechEasy.Data.Infrastructure;

namespace TechEasy.Domain.Services
{
    public class SNSUserAlbumsDetailService : ServiceBase<SNS_UserAlbumDetail>, ISNSUserAlbumsDetailService
    {
        public SNSUserAlbumsDetailService(ISNSUserAlbumsDetailRepository repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {

        }
    }

    public interface ISNSUserAlbumsDetailService : IService<SNS_UserAlbumDetail>
    {

    }
}
