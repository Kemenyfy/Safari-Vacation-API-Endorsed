using System;

namespace SafariVacationApiEndorsed
{
    public class SeenAnimal {

        public int Id { get; set; }
        public string Species { get; set; }
        public int CountOfTimesSeen { get; set; } = 1;
        public string LocationOfLastSeen { get; set; } = "Out There";
        public DateTime LastSeenAt { get; set; } = DateTime.Now;
    }
}