using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using TechEasy.Model;
using TechEasy.Data.Infrastructure;
using TechEasy.Data.Repositories;
using TechEasy.Domain.Interface;

namespace TechEasy.Domain.Services
{

    public class SNSPhotoTagService : ServiceBase<SNS_PhotoTags>, ISNSPhotoTagService
    {
        public SNSPhotoTagService(ISNSPhotoTagRepository repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
            
        }
    }

    public interface ISNSPhotoTagService : IService<SNS_PhotoTags>
    {
    }
}
