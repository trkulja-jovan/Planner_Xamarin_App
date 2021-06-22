using System;

namespace PlannerMob.Refit.DTO.Meeting
{
    public class MeetingDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Organizer { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int AtendeeCount { get; set; }
    }
}
