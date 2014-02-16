using System;
using System.Collections.Generic;

namespace DevChallenge.Models
{
    public partial class OtherName
    {
        public Nullable<int> TitleId { get; set; }
        public string TitleNameLanguage { get; set; }
        public string TitleNameType { get; set; }
        public string TitleNameSortable { get; set; }
        public string TitleName { get; set; }
        public int Id { get; set; }
        public virtual Title Title { get; set; }
    }
}
