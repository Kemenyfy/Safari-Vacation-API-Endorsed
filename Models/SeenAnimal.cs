using System;

namespace safari_vacation_api_endorsed
{
    public class SeenAnimal {

        public int Id { get; set; }
        public string Species { get; set; }
        public int CountOfTimesSeen { get; set; }
        public string LocationOfLastSeen { get; set; }
        public DateTime LastSeenAt { get; set; }
    }
}