using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DevChallenge.Models.Mapping
{
    public class OtherNameMap : EntityTypeConfiguration<OtherName>
    {
        public OtherNameMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.TitleNameLanguage)
                .HasMaxLength(100);

            this.Property(t => t.TitleNameType)
                .HasMaxLength(100);

            this.Property(t => t.TitleNameSortable)
                .HasMaxLength(100);

            this.Property(t => t.TitleName)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OtherName");
            this.Property(t => t.TitleId).HasColumnName("TitleId");
            this.Property(t => t.TitleNameLanguage).HasColumnName("TitleNameLanguage");
            this.Property(t => t.TitleNameType).HasColumnName("TitleNameType");
            this.Property(t => t.TitleNameSortable).HasColumnName("TitleNameSortable");
            this.Property(t => t.TitleName).HasColumnName("TitleName");
            this.Property(t => t.Id).HasColumnName("Id");

            // Relationships
            this.HasOptional(t => t.Title)
                .WithMany(t => t.OtherNames)
                .HasForeignKey(d => d.TitleId);

        }
    }
}
