using System;
using System.Collections.Generic;

namespace DevChallenge.Models
{
    public partial class Award
    {
        public int TitleId { get; set; }
        public Nullable<bool> AwardWon { get; set; }
        public Nullable<int> AwardYear { get; set; }
        public string Award1 { get; set; }
        public string AwardCompany { get; set; }
        public int Id { get; set; }
        public virtual Title Title { get; set; }
    }
}
