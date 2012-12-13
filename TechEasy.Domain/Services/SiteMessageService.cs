using TechEasy.Data.Repositories;
using TechEasy.Domain.Interface;
using TechEasy.Model;
using TechEasy.Data.Infrastructure;

namespace TechEasy.Domain.Services
{
    public class SiteMessageService : ServiceBase<SA_SiteMessage>, ISiteMessageService
    {
        public SiteMessageService(ISiteMessageRepository repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {

        }
    }

    public interface ISiteMessageService : IService<SA_SiteMessage>
    {

    }
}
