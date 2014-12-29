using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DevChallenge.Models.Mapping
{
    public class TitleParticipantMap : EntityTypeConfiguration<TitleParticipant>
    {
        public TitleParticipantMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.RoleType)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("TitleParticipant");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.TitleId).HasColumnName("TitleId");
            this.Property(t => t.ParticipantId).HasColumnName("ParticipantId");
            this.Property(t => t.IsKey).HasColumnName("IsKey");
            this.Property(t => t.RoleType).HasColumnName("RoleType");
            this.Property(t => t.IsOnScreen).HasColumnName("IsOnScreen");

            // Relationships
            this.HasRequired(t => t.Participant)
                .WithMany(t => t.TitleParticipants)
                .HasForeignKey(d => d.ParticipantId);
            this.HasRequired(t => t.Title)
                .WithMany(t => t.TitleParticipants)
                .HasForeignKey(d => d.TitleId);

        }
    }
}
