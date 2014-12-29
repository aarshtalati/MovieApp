using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DevChallenge.Models.Mapping
{
    public class TitleGenreMap : EntityTypeConfiguration<TitleGenre>
    {
        public TitleGenreMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("TitleGenre");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.TitleId).HasColumnName("TitleId");
            this.Property(t => t.GenreId).HasColumnName("GenreId");

            // Relationships
            this.HasRequired(t => t.Genre)
                .WithMany(t => t.TitleGenres)
                .HasForeignKey(d => d.GenreId);
            this.HasRequired(t => t.Title)
                .WithMany(t => t.TitleGenres)
                .HasForeignKey(d => d.TitleId);

        }
    }
}
