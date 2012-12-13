using TechEasy.Data.Repositories;
using TechEasy.Domain.Interface;
using TechEasy.Model;
using TechEasy.ViewModel.SNS;
using System.Collections.Generic;
using System.Linq;
using TechEasy.Data.Infrastructure;

namespace TechEasy.Domain.Services
{
    public class SNSTagTypeService : ServiceBase<SNS_TagType>, ISNSTagTypeService
    {
        private readonly ISNSTagRepository snsTagrepository;
        public SNSTagTypeService(ISNSTagTypeRepository repository, ISNSTagRepository snsTagrepository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
            this.snsTagrepository = snsTagrepository;
        }

        public List<CType> GetTagListByCid(int Cid)
        {
            List<CType> list = new List<CType>();
            var tagTypes = GetList(m => m.Cid == Cid);
            foreach (var item in tagTypes)
            {
                CType ctype = new CType
                {
                    MTagType = item,
                    Taglist= snsTagrepository.GetMany(m=>m.TypeId==item.ID).ToList()
                };
                list.Add(ctype);
            }
            return list;
        }
    }

    public interface ISNSTagTypeService : IService<SNS_TagType>
    {
        List<CType> GetTagListByCid(int Cid);

    }

}
