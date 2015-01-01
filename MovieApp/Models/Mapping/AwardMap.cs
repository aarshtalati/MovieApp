using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DevChallenge.Models.Mapping
{
    public class AwardMap : EntityTypeConfiguration<Award>
    {
        public AwardMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Award1)
                .HasMaxLength(100);

            this.Property(t => t.AwardCompany)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Award");
            this.Property(t => t.TitleId).HasColumnName("TitleId");
            this.Property(t => t.AwardWon).HasColumnName("AwardWon");
            this.Property(t => t.AwardYear).HasColumnName("AwardYear");
            this.Property(t => t.Award1).HasColumnName("Award");
            this.Property(t => t.AwardCompany).HasColumnName("AwardCompany");
            this.Property(t => t.Id).HasColumnName("Id");

            // Relationships
            this.HasRequired(t => t.Title)
                .WithMany(t => t.Awards)
                .HasForeignKey(d => d.TitleId);

        }
    }
}
