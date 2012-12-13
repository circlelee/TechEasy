using TechEasy.Data.Repositories;
using TechEasy.Domain.Interface;
using TechEasy.Model;
using TechEasy.Data.Infrastructure;

namespace TechEasy.Domain.Services
{
    public class AccountUserService : ServiceBase<Accounts_Users>, IAccountUserService
    {
        public AccountUserService(IAccountUserRepository repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {

        }
    }

    public interface IAccountUserService : IService<Accounts_Users>
    {

    }

}
