using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DevChallenge.Models.Mapping
{
    public class TitleMap : EntityTypeConfiguration<Title>
    {
        public TitleMap()
        {
            // Primary Key
            this.HasKey(t => t.TitleId);

            // Properties
            this.Property(t => t.TitleId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TitleName)
                .HasMaxLength(100);

            this.Property(t => t.TitleNameSortable)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Title");
            this.Property(t => t.TitleId).HasColumnName("TitleId");
            this.Property(t => t.TitleName).HasColumnName("TitleName");
            this.Property(t => t.TitleNameSortable).HasColumnName("TitleNameSortable");
            this.Property(t => t.TitleTypeId).HasColumnName("TitleTypeId");
            this.Property(t => t.ReleaseYear).HasColumnName("ReleaseYear");
            this.Property(t => t.ProcessedDateTimeUTC).HasColumnName("ProcessedDateTimeUTC");
        }
    }
}
