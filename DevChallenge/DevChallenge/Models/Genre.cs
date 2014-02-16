using System;
using System.Collections.Generic;

namespace DevChallenge.Models
{
    public partial class Genre
    {
        public Genre()
        {
            this.TitleGenres = new List<TitleGenre>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<TitleGenre> TitleGenres { get; set; }
    }
}
