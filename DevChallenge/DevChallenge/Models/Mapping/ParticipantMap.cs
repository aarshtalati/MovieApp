using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DevChallenge.Models.Mapping
{
    public class ParticipantMap : EntityTypeConfiguration<Participant>
    {
        public ParticipantMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .HasMaxLength(100);

            this.Property(t => t.ParticipantType)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Participant");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ParticipantType).HasColumnName("ParticipantType");
        }
    }
}
