using TechEasy.Data.Repositories;
using TechEasy.Domain.Interface;
using TechEasy.Model;
using TechEasy.Data.Infrastructure;

namespace TechEasy.Domain.Services
{
    public class FriendLinkService : ServiceBase<CMS_FLinks>, IFriendLinkService
    {
        public FriendLinkService(IFriendLinkRepository repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {

        }
    }

    public interface IFriendLinkService : IService<CMS_FLinks>
    {

    }

}
