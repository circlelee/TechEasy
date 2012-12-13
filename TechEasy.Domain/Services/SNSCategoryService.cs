using System.Linq;
using TechEasy.Data.Repositories;
using TechEasy.Model;
using TechEasy.Domain.Interface;
using TechEasy.ViewModel;
using TechEasy.ViewModel.SNS;
using TechEasy.Data.Infrastructure;

namespace TechEasy.Domain.Services
{

    public class SNSCategoryService : ServiceBase<SNS_Categories>, ISNSCategoryService
    {
        public SNSCategoryService(ISNSCategoryRepository repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {

        }

        public ProductCategory GetProductCategoryByParentID(int parentID)
        {
            ProductCategory category = new ProductCategory();
            if (parentID != 0)
            {
                SNS_Categories model = Get(m => m.ParentID == parentID);
                category.CurrentCateName = (model == null) ? "None" : model.Name;
                category.CurrentCid = parentID;
                var categories = GetList(m => m.ParentID == parentID);
                foreach (var item in categories)
                {
                    SonCategory sonItem = new SonCategory{
                        ParentModel = item,
                        Grandson= GetTop<int>(m=>m.ParentID==item.CategoryId,m=>m.CategoryId,5,true).ToList()                       
                    };
                    category.SonList.Add(sonItem);
                }
            }
            return category;
        }
    }

    public interface ISNSCategoryService : IService<SNS_Categories>
    {
        ProductCategory GetProductCategoryByParentID(int parentID);
    }
}
