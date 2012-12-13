using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace TechEasy.Model.Mapping
{
    public class Accounts_Actions_PermissionMap : EntityTypeConfiguration<Accounts_Actions_Permission>
    {
        public Accounts_Actions_PermissionMap()
        {
            // Primary Key
            this.HasKey(t => t.ActionID);

            // Properties
            this.Property(t => t.Description)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Accounts_Actions_Permission");
            this.Property(t => t.ActionID).HasColumnName("ActionID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.PermissionID).HasColumnName("PermissionID");

            // Relationships
            this.HasOptional(t => t.Accounts_Permissions)
                .WithMany(t => t.Accounts_Actions_Permission)
                .HasForeignKey(d => d.PermissionID);

        }
    }
}
