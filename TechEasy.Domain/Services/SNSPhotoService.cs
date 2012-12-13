using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using TechEasy.Model;
using TechEasy.Data.Infrastructure;
using TechEasy.Data.Repositories;
using TechEasy.Domain.Interface;
using TechEasy.ViewModel.SNS;

namespace TechEasy.Domain.Services
{

    public class SNSPhotoService : ServiceBase<SNS_Photos>, ISNSPhotoService
    {
        private readonly ISNSCommentRepository snsCommentRepository;
        private readonly IAccountUserExpRepository accountUserExpRepository;
        private readonly ISNSUserAlbumsDetailRepository snsUserAlbumsDetailRepository;
        private readonly ISNSUserAlbumsRepository snsUserAlbumsRepository;
        public SNSPhotoService(
            ISNSPhotoRepository repository,
            IUnitOfWork unitOfWork,
            ISNSCommentRepository snsCommentRepository,
            IAccountUserExpRepository accountUserExpRepository,
            ISNSUserAlbumsDetailRepository snsUserAlbumsDetailRepository,
            ISNSUserAlbumsRepository snsUserAlbumsRepository)
            : base(repository, unitOfWork)
        {
            this.snsCommentRepository = snsCommentRepository;
            this.accountUserExpRepository = accountUserExpRepository;
            this.snsUserAlbumsDetailRepository = snsUserAlbumsDetailRepository;
            this.snsUserAlbumsRepository = snsUserAlbumsRepository;
        }

        public List<SNS_Photos> GetRecommandByPid(int pid)
        {
            var photo = Get(m => m.PhotoID == pid);
            if (photo == null)
            {
                return null;
            }

            List<SNS_Photos> list = new List<SNS_Photos>();
            list = GetTop<int>(m => m.Type == photo.Type, m => m.CommentCount, 0X18, true).ToList();
            //string[] strArray = (from item in list
            //                     where !string.IsNullOrEmpty(item.TopCommentsId)
            //                     select item.TopCommentsId).Distinct<string>().ToArray<string>();
            //int[] intArray = strArray.Select(s => Int32.Parse(s)).ToArray();
            //List<SNS_Comments> commentList = snsCommentRepository.GetMany(m => intArray.Contains(m.CommentID)).ToList();
            return list;
        }

        public bool Exist(int pid)
        {
            var photo = Get(m => m.PhotoID == pid);
            if (photo == null)
                return false;
            return true;
        }


        public TargetDetail GetPhotoAssistionInfo(int pid)
        {
            var detail = new TargetDetail();
            detail.Photo = Get(m => m.PhotoID == pid);
            detail.UserModel = accountUserExpRepository.Get(m => m.UserID == detail.Userid);
            var albumDetail = snsUserAlbumsDetailRepository.Get(m => m.AlbumUserId == detail.Userid && m.TargetID == detail.TargetId && m.Type == 0);
            if (albumDetail != null)
                detail.UserAlums = snsUserAlbumsRepository.Get(m => m.AlbumID == albumDetail.AlbumID);
            if (detail.UserAlums != null)
                detail.CovorImageList = snsUserAlbumsDetailRepository.GetThumbImageByAlbum(detail.UserAlums.AlbumID);
            return detail;
        }
    }

    public interface ISNSPhotoService : IService<SNS_Photos>
    {
        bool Exist(int pid);

        List<SNS_Photos> GetRecommandByPid(int pid);

        TargetDetail GetPhotoAssistionInfo(int pid);
    }
}
