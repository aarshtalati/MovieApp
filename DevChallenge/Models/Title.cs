using System;
using System.Collections.Generic;

namespace DevChallenge.Models
{
    public partial class Title
    {
        public Title()
        {
            this.Awards = new List<Award>();
            this.OtherNames = new List<OtherName>();
            this.StoryLines = new List<StoryLine>();
            this.TitleGenres = new List<TitleGenre>();
            this.TitleParticipants = new List<TitleParticipant>();
        }

        public int TitleId { get; set; }
        public string TitleName { get; set; }
        public string TitleNameSortable { get; set; }
        public Nullable<int> TitleTypeId { get; set; }
        public Nullable<int> ReleaseYear { get; set; }
        public Nullable<System.DateTime> ProcessedDateTimeUTC { get; set; }
        public virtual ICollection<Award> Awards { get; set; }
        public virtual ICollection<OtherName> OtherNames { get; set; }
        public virtual ICollection<StoryLine> StoryLines { get; set; }
        public virtual ICollection<TitleGenre> TitleGenres { get; set; }
        public virtual ICollection<TitleParticipant> TitleParticipants { get; set; }
    }
}
