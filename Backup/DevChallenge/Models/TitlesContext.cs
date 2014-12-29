using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DevChallenge.Models.Mapping;

namespace DevChallenge.Models
{
    public partial class TitlesContext : DbContext
    {
        static TitlesContext()
        {
            Database.SetInitializer<TitlesContext>(null);
        }

        public TitlesContext()
            : base("Name=TitlesContext")
        {
        }

        public DbSet<Award> Awards { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<OtherName> OtherNames { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<StoryLine> StoryLines { get; set; }
        public DbSet<Title> Titles { get; set; }
        public DbSet<TitleGenre> TitleGenres { get; set; }
        public DbSet<TitleParticipant> TitleParticipants { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AwardMap());
            modelBuilder.Configurations.Add(new GenreMap());
            modelBuilder.Configurations.Add(new OtherNameMap());
            modelBuilder.Configurations.Add(new ParticipantMap());
            modelBuilder.Configurations.Add(new StoryLineMap());
            modelBuilder.Configurations.Add(new TitleMap());
            modelBuilder.Configurations.Add(new TitleGenreMap());
            modelBuilder.Configurations.Add(new TitleParticipantMap());
        }
    }
}
