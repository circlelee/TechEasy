using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechEasy.Data.Infrastructure;
using TechEasy.Model;

namespace TechEasy.Data.Repositories
{
    public class SNSUserAlbumsDetailRepository : RepositoryBase<SNS_UserAlbumDetail>, ISNSUserAlbumsDetailRepository
    {
        private readonly ISNSUserAlbumsDetailRepository snsUserAlbumsDetailRepository
        public SNSUserAlbumsDetailRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {

        }

        public List<string> GetThumbImageByAlbum(int albumeID)
        {
            var queryAlbum = snsUserAlbumsDetailService.Get();
            var queryProduct = snsProductService.Get();
            var queryPhoto = snsPhotoService.Get();

            var queryImage = from item in
                                 (from d in queryAlbum
                                  from p in queryProduct
                                  where d.Type == 1 && d.AlbumID == albumID && d.TargetID == p.ProductID
                                  select new { Image = p.ThumbImageUrl, ID = p.ProductID }).Take(9)
                                         .Union(
                                             (from d in queryAlbum
                                              from p in queryPhoto
                                              where d.Type == 0 && d.AlbumID == albumID && d.TargetID == p.PhotoID
                                              select new { Image = p.ThumbImageUrl, ID = p.PhotoID }).Take(9)
                                         )
                             orderby item.ID descending
                             select item.Image;
            list.Add(new AlbumIndex(albums.Find(m => m.AlbumID == albumID)) { TopImages = queryImage.Take(9).ToList() });
        }
    }

    public interface ISNSUserAlbumsDetailRepository : IRepository<SNS_UserAlbumDetail>
    {

        List<string> GetThumbImageByAlbum(int albumeID);
    }
}
