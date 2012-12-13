using TechEasy.Data.Repositories;
using TechEasy.Domain.Interface;
using TechEasy.Model;
using TechEasy.Data.Infrastructure;

namespace TechEasy.Domain.Services
{
    public class AccountUserExpService : ServiceBase<Accounts_UsersExp>, IAccountUserExpService
    {
        public AccountUserExpService(IAccountUserExpRepository repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {

        }
    }

    public interface IAccountUserExpService : IService<Accounts_UsersExp>
    {

    }

}
