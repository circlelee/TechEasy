using TechEasy.Data.Repositories;
using TechEasy.Domain.Interface;
using TechEasy.Model;
using TechEasy.ViewModel.SNS;
using System.Collections.Generic;
using System.Linq;
using TechEasy.Data.Infrastructure;

namespace TechEasy.Domain.Services
{
    public class SNSTagService : ServiceBase<SNS_Tags>, ISNSTagService
    {
        public SNSTagService(ISNSTagRepository repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
        }

       
    }

    public interface ISNSTagService : IService<SNS_Tags>
    {
    
    }
}
