using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace TechEasy.Model.Mapping
{
    public class Accounts_EmailQueueMap : EntityTypeConfiguration<Accounts_EmailQueue>
    {
        public Accounts_EmailQueueMap()
        {
            // Primary Key
            this.HasKey(t => new { t.EmailId, t.EmailPriority, t.IsBodyHtml, t.NextTryTime, t.NumberOfTries });

            // Properties
            this.Property(t => t.EmailPriority)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.EmailTo)
                .HasMaxLength(2000);

            this.Property(t => t.EmailFrom)
                .HasMaxLength(256);

            this.Property(t => t.EmailSubject)
                .HasMaxLength(1024);

            this.Property(t => t.NumberOfTries)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Accounts_EmailQueue");
            this.Property(t => t.EmailId).HasColumnName("EmailId");
            this.Property(t => t.EmailPriority).HasColumnName("EmailPriority");
            this.Property(t => t.IsBodyHtml).HasColumnName("IsBodyHtml");
            this.Property(t => t.EmailTo).HasColumnName("EmailTo");
            this.Property(t => t.EmailCc).HasColumnName("EmailCc");
            this.Property(t => t.EmailBcc).HasColumnName("EmailBcc");
            this.Property(t => t.EmailFrom).HasColumnName("EmailFrom");
            this.Property(t => t.EmailSubject).HasColumnName("EmailSubject");
            this.Property(t => t.EmailBody).HasColumnName("EmailBody");
            this.Property(t => t.NextTryTime).HasColumnName("NextTryTime");
            this.Property(t => t.NumberOfTries).HasColumnName("NumberOfTries");
        }
    }
}
