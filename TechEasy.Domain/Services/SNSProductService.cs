using TechEasy.Data.Repositories;
using TechEasy.Domain.Interface;
using TechEasy.Model;
using System.Collections.Generic;
using TechEasy.ViewModel.SNS;
using System.Linq.Expressions;
using System;
using System.Linq;
using TechEasy.Data.Infrastructure;

namespace TechEasy.Domain.Services
{
    public class SNSProductService : ServiceBase<SNS_Products>, ISNSProductService
    {
        private ISNSCategoryRepository _repostoryCate;
        public SNSProductService(ISNSProductRepository repository, ISNSCategoryRepository repositoryCate, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
            this._repostoryCate = repositoryCate;
        }

        public List<SNS_Products> GetProductListByPage(ProductQuery query, int count)
        {
            var queryProducts = this.BuiderQuery(query);
            return (from p in queryProducts
                    orderby p.FavouriteCount descending
                    select p).Take(count).ToList();
        }

        private IQueryable<SNS_Products> BuiderQuery(ProductQuery query)
        {
            var queryProducts = this.Get();
            string cateId = query.CategoryID.ToString();
            if (query.CategoryID.HasValue && query.CategoryID.Value != 0 && !query.IsTopCategory && query.CategoryID != -1)
            {
                var id = query.CategoryID.Value;
                queryProducts = from p in queryProducts
                                where p.CategoryID == id
                                select p;
            }
            else if (query.CategoryID != -1)
            {
                var queryCate = this._repostoryCate.Get();
                queryProducts = from p in queryProducts
                                where (from cate in queryCate
                                       where cate.Path.StartsWith(cateId) && cate.CategoryId == p.CategoryID
                                       select 1).Any()
                                select p;

            }

            if (!string.IsNullOrEmpty(query.Keywords))
            {
                queryProducts = from p in queryProducts
                                where p.ProductName.Contains(query.Keywords) || p.Tags.Contains(query.Keywords)
                                select p;
            }
            if (query.IsRecomend.HasValue)
            {
                queryProducts = from p in queryProducts
                                where p.IsRecomend == query.IsRecomend
                                select p;
            }
            if (query.MaxPrice.HasValue && query.MaxPrice.Value != 0m)
            {
                queryProducts = from p in queryProducts
                                where p.Price < query.MaxPrice
                                select p;
            }
            if (query.MinPrice.HasValue && query.MinPrice.Value != 0m)
            {
                queryProducts = from p in queryProducts
                                where p.Price > query.MinPrice
                                select p;
            }
            if (!string.IsNullOrEmpty(query.Tags))
            {
                queryProducts = from p in queryProducts
                                where p.Tags.Contains(query.Tags)
                                select p;
            }
            if (!string.IsNullOrEmpty(query.Color) && (query.Color != "all"))
            {
                queryProducts = from p in queryProducts
                                where p.Color == query.Color
                                select p;
            }

            return from p in queryProducts where p.Status != 0 select p;
        }
    }

    public interface ISNSProductService : IService<SNS_Products>
    {
        List<SNS_Products> GetProductListByPage(ProductQuery query, int count);
    }

}
