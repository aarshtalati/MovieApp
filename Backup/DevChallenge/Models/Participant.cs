using System;
using System.Collections.Generic;

namespace DevChallenge.Models
{
    public partial class Participant
    {
        public Participant()
        {
            this.TitleParticipants = new List<TitleParticipant>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string ParticipantType { get; set; }
        public virtual ICollection<TitleParticipant> TitleParticipants { get; set; }
    }
}
