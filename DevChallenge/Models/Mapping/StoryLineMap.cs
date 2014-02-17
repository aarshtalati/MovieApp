using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DevChallenge.Models.Mapping
{
    public class StoryLineMap : EntityTypeConfiguration<StoryLine>
    {
        public StoryLineMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Type)
                .HasMaxLength(100);

            this.Property(t => t.Language)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("StoryLine");
            this.Property(t => t.TitleId).HasColumnName("TitleId");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Language).HasColumnName("Language");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Id).HasColumnName("Id");

            // Relationships
            this.HasRequired(t => t.Title)
                .WithMany(t => t.StoryLines)
                .HasForeignKey(d => d.TitleId);

        }
    }
}
