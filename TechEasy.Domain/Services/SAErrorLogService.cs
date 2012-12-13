using TechEasy.Data.Repositories;
using TechEasy.Domain.Interface;
using TechEasy.Model;
using TechEasy.Data.Infrastructure;

namespace TechEasy.Domain.Services
{
    public class SAErrorLogService : ServiceBase<SA_ErrorLog>, ISAErrorLogService
    {
        public SAErrorLogService(ISAErrorLogRepository repository, IUnitOfWork unitOfWork)
            : base(repository,unitOfWork)
        {
        }
    }

    public interface ISAErrorLogService : IService<SA_ErrorLog>
    {
    }

}
