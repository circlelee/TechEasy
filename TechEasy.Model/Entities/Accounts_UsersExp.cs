using System;
using System.Collections.Generic;

namespace TechEasy.Model
{
    public class Accounts_UsersExp
    {
        public Accounts_UsersExp()
        {
            this.SNS_Comments = new List<SNS_Comments>();
            this.SNS_FellowTopics = new List<SNS_FellowTopics>();
            this.SNS_Groups = new List<SNS_Groups>();
            this.SNS_GroupTopics = new List<SNS_GroupTopics>();
            this.SNS_GroupUsers = new List<SNS_GroupUsers>();
            this.SNS_GuestBook = new List<SNS_GuestBook>();
            this.SNS_GuestBook1 = new List<SNS_GuestBook>();
            this.SNS_Photos = new List<SNS_Photos>();
            this.SNS_UserAlbums = new List<SNS_UserAlbums>();
            this.SNS_Posts = new List<SNS_Posts>();
            this.SNS_PostsTopics = new List<SNS_PostsTopics>();
            this.SNS_PostsTopics1 = new List<SNS_PostsTopics>();
            this.SNS_Products = new List<SNS_Products>();
            this.SNS_ReferUsers = new List<SNS_ReferUsers>();
            this.SNS_Star = new List<SNS_Star>();
            this.SNS_Star1 = new List<SNS_Star>();
            this.SNS_GroupTopicFav = new List<SNS_GroupTopicFav>();
            this.SNS_GroupTopicFav1 = new List<SNS_GroupTopicFav>();
            this.SNS_GroupTopicReply = new List<SNS_GroupTopicReply>();
            this.SNS_GroupTopicReply1 = new List<SNS_GroupTopicReply>();
            this.SNS_UserFavourite = new List<SNS_UserFavourite>();
            this.SNS_UserShipCategories = new List<SNS_UserShipCategories>();
            this.SNS_VisiteLogs = new List<SNS_VisiteLogs>();
            this.SNS_VisiteLogs1 = new List<SNS_VisiteLogs>();
        }

        public int UserID { get; set; }
        public string Gravatar { get; set; }
        public string Singature { get; set; }
        public string TelPhone { get; set; }
        public string QQ { get; set; }
        public string MSN { get; set; }
        public string HomePage { get; set; }
        public Nullable<System.DateTime> Birthday { get; set; }
        public short BirthdayVisible { get; set; }
        public bool BirthdayIndexVisible { get; set; }
        public string Constellation { get; set; }
        public short ConstellationVisible { get; set; }
        public bool ConstellationIndexVisible { get; set; }
        public string NativePlace { get; set; }
        public short NativePlaceVisible { get; set; }
        public bool NativePlaceIndexVisible { get; set; }
        public Nullable<int> RegionId { get; set; }
        public string Address { get; set; }
        public short AddressVisible { get; set; }
        public bool AddressIndexVisible { get; set; }
        public string BodilyForm { get; set; }
        public short BodilyFormVisible { get; set; }
        public bool BodilyFormIndexVisible { get; set; }
        public string BloodType { get; set; }
        public short BloodTypeVisible { get; set; }
        public bool BloodTypeIndexVisible { get; set; }
        public string Marriaged { get; set; }
        public short MarriagedVisible { get; set; }
        public bool MarriagedIndexVisible { get; set; }
        public string PersonalStatus { get; set; }
        public short PersonalStatusVisible { get; set; }
        public bool PersonalStatusIndexVisible { get; set; }
        public Nullable<int> Grade { get; set; }
        public Nullable<decimal> Balance { get; set; }
        public Nullable<int> Points { get; set; }
        public Nullable<int> PvCount { get; set; }
        public Nullable<int> FansCount { get; set; }
        public Nullable<int> FellowCount { get; set; }
        public Nullable<int> AblumsCount { get; set; }
        public Nullable<int> FavouritesCount { get; set; }
        public Nullable<int> FavoritedCount { get; set; }
        public Nullable<int> ShareCount { get; set; }
        public Nullable<int> ProductsCount { get; set; }
        public string PersonalDomain { get; set; }
        public Nullable<System.DateTime> LastAccessTime { get; set; }
        public string LastAccessIP { get; set; }
        public Nullable<System.DateTime> LastPostTime { get; set; }
        public Nullable<System.DateTime> LastLoginTime { get; set; }
        public string Remark { get; set; }
        public Nullable<int> ReplyTopicCount { get; set; }
        public Nullable<int> FavTopicCount { get; set; }
        public Nullable<int> TopicCount { get; set; }
        public Nullable<bool> IsUserDPI { get; set; }
        public string PayAccount { get; set; }
        public virtual ICollection<SNS_Comments> SNS_Comments { get; set; }
        public virtual ICollection<SNS_FellowTopics> SNS_FellowTopics { get; set; }
        public virtual ICollection<SNS_Groups> SNS_Groups { get; set; }
        public virtual ICollection<SNS_GroupTopics> SNS_GroupTopics { get; set; }
        public virtual ICollection<SNS_GroupUsers> SNS_GroupUsers { get; set; }
        public virtual ICollection<SNS_GuestBook> SNS_GuestBook { get; set; }
        public virtual ICollection<SNS_GuestBook> SNS_GuestBook1 { get; set; }
        public virtual ICollection<SNS_Photos> SNS_Photos { get; set; }
        public virtual ICollection<SNS_UserAlbums> SNS_UserAlbums { get; set; }
        public virtual ICollection<SNS_Posts> SNS_Posts { get; set; }
        public virtual ICollection<SNS_PostsTopics> SNS_PostsTopics { get; set; }
        public virtual ICollection<SNS_PostsTopics> SNS_PostsTopics1 { get; set; }
        public virtual ICollection<SNS_Products> SNS_Products { get; set; }
        public virtual ICollection<SNS_ReferUsers> SNS_ReferUsers { get; set; }
        public virtual ICollection<SNS_Star> SNS_Star { get; set; }
        public virtual ICollection<SNS_Star> SNS_Star1 { get; set; }
        public virtual ICollection<SNS_GroupTopicFav> SNS_GroupTopicFav { get; set; }
        public virtual ICollection<SNS_GroupTopicFav> SNS_GroupTopicFav1 { get; set; }
        public virtual ICollection<SNS_GroupTopicReply> SNS_GroupTopicReply { get; set; }
        public virtual ICollection<SNS_GroupTopicReply> SNS_GroupTopicReply1 { get; set; }
        public virtual ICollection<SNS_UserFavourite> SNS_UserFavourite { get; set; }
        public virtual ICollection<SNS_UserShipCategories> SNS_UserShipCategories { get; set; }
        public virtual ICollection<SNS_VisiteLogs> SNS_VisiteLogs { get; set; }
        public virtual ICollection<SNS_VisiteLogs> SNS_VisiteLogs1 { get; set; }
    }
}
