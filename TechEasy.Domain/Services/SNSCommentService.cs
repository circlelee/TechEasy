using System.Linq;
using TechEasy.Data.Repositories;
using TechEasy.Domain.Interface;
using TechEasy.Model;
using TechEasy.Data.Infrastructure;

namespace TechEasy.Domain.Services
{
    public class SNSCommentService : ServiceBase<SNS_Comments>, ISNSCommentService
    {
        public SNSCommentService(ISNSCommentRepository repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {

        }

        public int GetCommentCount(int type, int targetId)
        {
            return GetMany(m => m.Type == type && m.TargetId == targetId).Count() ;
        }
    }

    public interface ISNSCommentService : IService<SNS_Comments>
    {
        int GetCommentCount(int type, int targetId);
    }

}
