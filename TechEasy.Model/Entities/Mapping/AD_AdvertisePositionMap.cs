using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
 

namespace TechEasy.Model.Mapping
{
    public class AD_AdvertisePositionMap : EntityTypeConfiguration<AD_AdvertisePosition>
    {
        public AD_AdvertisePositionMap()
        {
            // Primary Key
            this.HasKey(t => t.AdvPositionId);

            // Properties
            this.Property(t => t.AdvPositionName)
                .HasMaxLength(50);

            this.Property(t => t.AdvHtml)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("AD_AdvertisePosition");
            this.Property(t => t.AdvPositionId).HasColumnName("AdvPositionId");
            this.Property(t => t.AdvPositionName).HasColumnName("AdvPositionName");
            this.Property(t => t.ShowType).HasColumnName("ShowType");
            this.Property(t => t.RepeatColumns).HasColumnName("RepeatColumns");
            this.Property(t => t.Width).HasColumnName("Width");
            this.Property(t => t.Height).HasColumnName("Height");
            this.Property(t => t.AdvHtml).HasColumnName("AdvHtml");
            this.Property(t => t.IsOne).HasColumnName("IsOne");
            this.Property(t => t.TimeInterval).HasColumnName("TimeInterval");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.CreatedUserID).HasColumnName("CreatedUserID");
        }
    }
}
