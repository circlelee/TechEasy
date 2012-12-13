using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using TechEasy.Model;
using System.Data.Entity.ModelConfiguration.Conventions;
using TechEasy.Model.Mapping;
using System.Data.Entity.Infrastructure;

namespace TechEasy.Data
{
    public class TechEasyContext:DbContext
    {
        public TechEasyContext(bool isLazy)
            : base("name=TechEasyContext")
        {
            this.Configuration.ProxyCreationEnabled = isLazy;
            this.Configuration.LazyLoadingEnabled = isLazy;
        }

        public DbSet<Accounts_Actions_Permission> Accounts_Actions_Permission { get; set; }
        public DbSet<Accounts_EmailQueue> Accounts_EmailQueue { get; set; }
        public DbSet<Accounts_MailConfig> Accounts_MailConfig { get; set; }
        public DbSet<Accounts_PermissionCategories> Accounts_PermissionCategories { get; set; }
        public DbSet<Accounts_Permissions> Accounts_Permissions { get; set; }
        public DbSet<Accounts_PointsDetail> Accounts_PointsDetail { get; set; }
        public DbSet<Accounts_PointsLimit> Accounts_PointsLimit { get; set; }
        public DbSet<Accounts_PointsRule> Accounts_PointsRule { get; set; }
        public DbSet<Accounts_Roles> Accounts_Roles { get; set; }
        public DbSet<Accounts_UserAssignmentRoles> Accounts_UserAssignmentRoles { get; set; }
        public DbSet<Accounts_UserBind> Accounts_UserBind { get; set; }
        public DbSet<Accounts_UserRank> Accounts_UserRank { get; set; }
        public DbSet<Accounts_Users> Accounts_Users { get; set; }
        public DbSet<Accounts_UsersApprove> Accounts_UsersApprove { get; set; }
        public DbSet<Accounts_UsersExp> Accounts_UsersExp { get; set; }
        public DbSet<Accounts_UserType> Accounts_UserType { get; set; }
        public DbSet<Accounts_VerifyMail> Accounts_VerifyMail { get; set; }
        public DbSet<AD_Advertisement> AD_Advertisement { get; set; }
        public DbSet<AD_AdvertisePosition> AD_AdvertisePosition { get; set; }
        public DbSet<CMS_Brand> CMS_Brand { get; set; }
        public DbSet<CMS_ClassType> CMS_ClassType { get; set; }
        public DbSet<CMS_Comment> CMS_Comment { get; set; }
        public DbSet<CMS_Content> CMS_Content { get; set; }
        public DbSet<CMS_ContentClass> CMS_ContentClass { get; set; }
        public DbSet<CMS_FLinks> CMS_FLinks { get; set; }
        public DbSet<CMS_Guestbook> CMS_Guestbook { get; set; }
        public DbSet<CMS_Photo> CMS_Photo { get; set; }
        public DbSet<CMS_PhotoAlbum> CMS_PhotoAlbum { get; set; }
        public DbSet<CMS_PhotoClass> CMS_PhotoClass { get; set; }
        public DbSet<CMS_PrototypeStore> CMS_PrototypeStore { get; set; }
        public DbSet<CMS_Video> CMS_Video { get; set; }
        public DbSet<CMS_VideoAlbum> CMS_VideoAlbum { get; set; }
        public DbSet<CMS_VideoClass> CMS_VideoClass { get; set; }
        public DbSet<CMS_WebMenuConfig> CMS_WebMenuConfig { get; set; }
        public DbSet<Ms_EmailTemplet> Ms_EmailTemplet { get; set; }
        public DbSet<Ms_Enterprise> Ms_Enterprise { get; set; }
        public DbSet<Ms_EntryForm> Ms_EntryForm { get; set; }
        public DbSet<Ms_Maps> Ms_Maps { get; set; }
        public DbSet<Ms_Regions> Ms_Regions { get; set; }
        public DbSet<Ms_SEORelation> Ms_SEORelation { get; set; }
        public DbSet<Poll_Forms> Poll_Forms { get; set; }
        public DbSet<Poll_Options> Poll_Options { get; set; }
        public DbSet<Poll_Reply> Poll_Reply { get; set; }
        public DbSet<Poll_Topics> Poll_Topics { get; set; }
        public DbSet<Poll_UserPoll> Poll_UserPoll { get; set; }
        public DbSet<Poll_Users> Poll_Users { get; set; }
        public DbSet<SA_Config_System> SA_Config_System { get; set; }
        public DbSet<SA_Config_Type> SA_Config_Type { get; set; }
        public DbSet<SA_ErrorLog> SA_ErrorLog { get; set; }
        public DbSet<SA_Feedback> SA_Feedback { get; set; }
        public DbSet<SA_FilterWords> SA_FilterWords { get; set; }
        public DbSet<SA_Language_mstr> SA_Language_mstr { get; set; }
        public DbSet<SA_Log> SA_Log { get; set; }
        public DbSet<SA_MultiLang_det> SA_MultiLang_det { get; set; }
        public DbSet<SA_ReceivedMessages> SA_ReceivedMessages { get; set; }
        public DbSet<SA_SendedMessages> SA_SendedMessages { get; set; }
        public DbSet<SA_SiteMessage> SA_SiteMessage { get; set; }
        public DbSet<SA_SiteMessageLog> SA_SiteMessageLog { get; set; }
        public DbSet<SA_SiteSettings> SA_SiteSettings { get; set; }
        public DbSet<SA_Tree> SA_Tree { get; set; }
        public DbSet<SA_TreeFavorite> SA_TreeFavorite { get; set; }
        public DbSet<SA_UserLog> SA_UserLog { get; set; }
        public DbSet<SNS_AlbumType> SNS_AlbumType { get; set; }
        public DbSet<SNS_Categories> SNS_Categories { get; set; }
        public DbSet<SNS_CategorySource> SNS_CategorySource { get; set; }
        public DbSet<SNS_Comments> SNS_Comments { get; set; }
        public DbSet<SNS_FellowTopics> SNS_FellowTopics { get; set; }
        public DbSet<SNS_GradeConfig> SNS_GradeConfig { get; set; }
        public DbSet<SNS_Groups> SNS_Groups { get; set; }
        public DbSet<SNS_GroupTags> SNS_GroupTags { get; set; }
        public DbSet<SNS_GroupTopicFav> SNS_GroupTopicFav { get; set; }
        public DbSet<SNS_GroupTopicReply> SNS_GroupTopicReply { get; set; }
        public DbSet<SNS_GroupTopics> SNS_GroupTopics { get; set; }
        public DbSet<SNS_GroupUsers> SNS_GroupUsers { get; set; }
        public DbSet<SNS_GuestBook> SNS_GuestBook { get; set; }
        public DbSet<SNS_HotWords> SNS_HotWords { get; set; }
        public DbSet<SNS_OnLineShopPhoto> SNS_OnLineShopPhoto { get; set; }
        public DbSet<SNS_Photos> SNS_Photos { get; set; }
        public DbSet<SNS_PhotoTags> SNS_PhotoTags { get; set; }
        public DbSet<SNS_Posts> SNS_Posts { get; set; }
        public DbSet<SNS_PostsTopics> SNS_PostsTopics { get; set; }
        public DbSet<SNS_Products> SNS_Products { get; set; }
        public DbSet<SNS_ProductSources> SNS_ProductSources { get; set; }
        public DbSet<SNS_ReferUsers> SNS_ReferUsers { get; set; }
        public DbSet<SNS_Report> SNS_Report { get; set; }
        public DbSet<SNS_ReportType> SNS_ReportType { get; set; }
        public DbSet<SNS_SearchWordLog> SNS_SearchWordLog { get; set; }
        public DbSet<SNS_SearchWordTop> SNS_SearchWordTop { get; set; }
        public DbSet<SNS_Star> SNS_Star { get; set; }
        public DbSet<SNS_StarRank> SNS_StarRank { get; set; }
        public DbSet<SNS_StarType> SNS_StarType { get; set; }
        public DbSet<SNS_Tags> SNS_Tags { get; set; }
        public DbSet<SNS_TagType> SNS_TagType { get; set; }
        public DbSet<SNS_UserAlbumDetail> SNS_UserAlbumDetail { get; set; }
        public DbSet<SNS_UserAlbums> SNS_UserAlbums { get; set; }
        public DbSet<SNS_UserAlbumsType> SNS_UserAlbumsType { get; set; }
        public DbSet<SNS_UserFavAlbum> SNS_UserFavAlbum { get; set; }
        public DbSet<SNS_UserFavourite> SNS_UserFavourite { get; set; }
        public DbSet<SNS_UserShip> SNS_UserShip { get; set; }
        public DbSet<SNS_UserShipCategories> SNS_UserShipCategories { get; set; }
        public DbSet<SNS_Videos> SNS_Videos { get; set; }
        public DbSet<SNS_VisiteLogs> SNS_VisiteLogs { get; set; }
        public DbSet<View_Content> View_Content { get; set; }
        public DbSet<View_ContentClass> View_ContentClass { get; set; }
        public DbSet<View_Video> View_Video { get; set; }
        public DbSet<View_VideoAlbum> View_VideoAlbum { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Accounts_Actions_PermissionMap());
            modelBuilder.Configurations.Add(new Accounts_EmailQueueMap());
            modelBuilder.Configurations.Add(new Accounts_MailConfigMap());
            modelBuilder.Configurations.Add(new Accounts_PermissionCategoriesMap());
            modelBuilder.Configurations.Add(new Accounts_PermissionsMap());
            modelBuilder.Configurations.Add(new Accounts_PointsDetailMap());
            modelBuilder.Configurations.Add(new Accounts_PointsLimitMap());
            modelBuilder.Configurations.Add(new Accounts_PointsRuleMap());
            modelBuilder.Configurations.Add(new Accounts_RolesMap());
            modelBuilder.Configurations.Add(new Accounts_UserAssignmentRolesMap());
            modelBuilder.Configurations.Add(new Accounts_UserBindMap());
            modelBuilder.Configurations.Add(new Accounts_UserRankMap());
            modelBuilder.Configurations.Add(new Accounts_UsersMap());
            modelBuilder.Configurations.Add(new Accounts_UsersApproveMap());
            modelBuilder.Configurations.Add(new Accounts_UsersExpMap());
            modelBuilder.Configurations.Add(new Accounts_UserTypeMap());
            modelBuilder.Configurations.Add(new Accounts_VerifyMailMap());
            modelBuilder.Configurations.Add(new AD_AdvertisementMap());
            modelBuilder.Configurations.Add(new AD_AdvertisePositionMap());
            modelBuilder.Configurations.Add(new CMS_BrandMap());
            modelBuilder.Configurations.Add(new CMS_ClassTypeMap());
            modelBuilder.Configurations.Add(new CMS_CommentMap());
            modelBuilder.Configurations.Add(new CMS_ContentMap());
            modelBuilder.Configurations.Add(new CMS_ContentClassMap());
            modelBuilder.Configurations.Add(new CMS_FLinksMap());
            modelBuilder.Configurations.Add(new CMS_GuestbookMap());
            modelBuilder.Configurations.Add(new CMS_PhotoMap());
            modelBuilder.Configurations.Add(new CMS_PhotoAlbumMap());
            modelBuilder.Configurations.Add(new CMS_PhotoClassMap());
            modelBuilder.Configurations.Add(new CMS_PrototypeStoreMap());
            modelBuilder.Configurations.Add(new CMS_VideoMap());
            modelBuilder.Configurations.Add(new CMS_VideoAlbumMap());
            modelBuilder.Configurations.Add(new CMS_VideoClassMap());
            modelBuilder.Configurations.Add(new CMS_WebMenuConfigMap());
            modelBuilder.Configurations.Add(new Ms_EmailTempletMap());
            modelBuilder.Configurations.Add(new Ms_EnterpriseMap());
            modelBuilder.Configurations.Add(new Ms_EntryFormMap());
            modelBuilder.Configurations.Add(new Ms_MapsMap());
            modelBuilder.Configurations.Add(new Ms_RegionsMap());
            modelBuilder.Configurations.Add(new Ms_SEORelationMap());
            modelBuilder.Configurations.Add(new Poll_FormsMap());
            modelBuilder.Configurations.Add(new Poll_OptionsMap());
            modelBuilder.Configurations.Add(new Poll_ReplyMap());
            modelBuilder.Configurations.Add(new Poll_TopicsMap());
            modelBuilder.Configurations.Add(new Poll_UserPollMap());
            modelBuilder.Configurations.Add(new Poll_UsersMap());
            modelBuilder.Configurations.Add(new SA_Config_SystemMap());
            modelBuilder.Configurations.Add(new SA_Config_TypeMap());
            modelBuilder.Configurations.Add(new SA_ErrorLogMap());
            modelBuilder.Configurations.Add(new SA_FeedbackMap());
            modelBuilder.Configurations.Add(new SA_FilterWordsMap());
            modelBuilder.Configurations.Add(new SA_Language_mstrMap());
            modelBuilder.Configurations.Add(new SA_LogMap());
            modelBuilder.Configurations.Add(new SA_MultiLang_detMap());
            modelBuilder.Configurations.Add(new SA_ReceivedMessagesMap());
            modelBuilder.Configurations.Add(new SA_SendedMessagesMap());
            modelBuilder.Configurations.Add(new SA_SiteMessageMap());
            modelBuilder.Configurations.Add(new SA_SiteMessageLogMap());
            modelBuilder.Configurations.Add(new SA_SiteSettingsMap());
            modelBuilder.Configurations.Add(new SA_TreeMap());
            modelBuilder.Configurations.Add(new SA_TreeFavoriteMap());
            modelBuilder.Configurations.Add(new SA_UserLogMap());
            modelBuilder.Configurations.Add(new SNS_AlbumTypeMap());
            modelBuilder.Configurations.Add(new SNS_CategoriesMap());
            modelBuilder.Configurations.Add(new SNS_CategorySourceMap());
            modelBuilder.Configurations.Add(new SNS_CommentsMap());
            modelBuilder.Configurations.Add(new SNS_FellowTopicsMap());
            modelBuilder.Configurations.Add(new SNS_GradeConfigMap());
            modelBuilder.Configurations.Add(new SNS_GroupsMap());
            modelBuilder.Configurations.Add(new SNS_GroupTagsMap());
            modelBuilder.Configurations.Add(new SNS_GroupTopicFavMap());
            modelBuilder.Configurations.Add(new SNS_GroupTopicReplyMap());
            modelBuilder.Configurations.Add(new SNS_GroupTopicsMap());
            modelBuilder.Configurations.Add(new SNS_GroupUsersMap());
            modelBuilder.Configurations.Add(new SNS_GuestBookMap());
            modelBuilder.Configurations.Add(new SNS_HotWordsMap());
            modelBuilder.Configurations.Add(new SNS_OnLineShopPhotoMap());
            modelBuilder.Configurations.Add(new SNS_PhotosMap());
            modelBuilder.Configurations.Add(new SNS_PhotoTagsMap());
            modelBuilder.Configurations.Add(new SNS_PostsMap());
            modelBuilder.Configurations.Add(new SNS_PostsTopicsMap());
            modelBuilder.Configurations.Add(new SNS_ProductsMap());
            modelBuilder.Configurations.Add(new SNS_ProductSourcesMap());
            modelBuilder.Configurations.Add(new SNS_ReferUsersMap());
            modelBuilder.Configurations.Add(new SNS_ReportMap());
            modelBuilder.Configurations.Add(new SNS_ReportTypeMap());
            modelBuilder.Configurations.Add(new SNS_SearchWordLogMap());
            modelBuilder.Configurations.Add(new SNS_SearchWordTopMap());
            modelBuilder.Configurations.Add(new SNS_StarMap());
            modelBuilder.Configurations.Add(new SNS_StarRankMap());
            modelBuilder.Configurations.Add(new SNS_StarTypeMap());
            modelBuilder.Configurations.Add(new SNS_TagsMap());
            modelBuilder.Configurations.Add(new SNS_TagTypeMap());
            modelBuilder.Configurations.Add(new SNS_UserAlbumDetailMap());
            modelBuilder.Configurations.Add(new SNS_UserAlbumsMap());
            modelBuilder.Configurations.Add(new SNS_UserAlbumsTypeMap());
            modelBuilder.Configurations.Add(new SNS_UserFavAlbumMap());
            modelBuilder.Configurations.Add(new SNS_UserFavouriteMap());
            modelBuilder.Configurations.Add(new SNS_UserShipMap());
            modelBuilder.Configurations.Add(new SNS_UserShipCategoriesMap());
            modelBuilder.Configurations.Add(new SNS_VideosMap());
            modelBuilder.Configurations.Add(new SNS_VisiteLogsMap());
            modelBuilder.Configurations.Add(new View_ContentMap());
            modelBuilder.Configurations.Add(new View_ContentClassMap());
            modelBuilder.Configurations.Add(new View_VideoMap());
            modelBuilder.Configurations.Add(new View_VideoAlbumMap());
        }
    }
}
