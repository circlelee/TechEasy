using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
 

namespace TechEasy.Model.Mapping
{
    public class AD_AdvertisementMap : EntityTypeConfiguration<AD_Advertisement>
    {
        public AD_AdvertisementMap()
        {
            // Primary Key
            this.HasKey(t => t.AdvertisementId);

            // Properties
            this.Property(t => t.AdvertisementName)
                .HasMaxLength(50);

            this.Property(t => t.FileUrl)
                .HasMaxLength(200);

            this.Property(t => t.AlternateText)
                .HasMaxLength(200);

            this.Property(t => t.NavigateUrl)
                .HasMaxLength(200);

            this.Property(t => t.AdvHtml)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("AD_Advertisement");
            this.Property(t => t.AdvertisementId).HasColumnName("AdvertisementId");
            this.Property(t => t.AdvertisementName).HasColumnName("AdvertisementName");
            this.Property(t => t.AdvPositionId).HasColumnName("AdvPositionId");
            this.Property(t => t.ContentType).HasColumnName("ContentType");
            this.Property(t => t.FileUrl).HasColumnName("FileUrl");
            this.Property(t => t.AlternateText).HasColumnName("AlternateText");
            this.Property(t => t.NavigateUrl).HasColumnName("NavigateUrl");
            this.Property(t => t.AdvHtml).HasColumnName("AdvHtml");
            this.Property(t => t.Impressions).HasColumnName("Impressions");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.CreatedUserID).HasColumnName("CreatedUserID");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.DayMaxPV).HasColumnName("DayMaxPV");
            this.Property(t => t.DayMaxIP).HasColumnName("DayMaxIP");
            this.Property(t => t.CPMPrice).HasColumnName("CPMPrice");
            this.Property(t => t.AutoStop).HasColumnName("AutoStop");
            this.Property(t => t.Sequence).HasColumnName("Sequence");
            this.Property(t => t.EnterpriseID).HasColumnName("EnterpriseID");
        }
    }
}
