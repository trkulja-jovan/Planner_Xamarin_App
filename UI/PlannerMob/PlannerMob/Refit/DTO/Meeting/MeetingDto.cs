using Newtonsoft.Json;
using System;

namespace PlannerMob.Refit.DTO.Meeting
{
    public class MeetingDto
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("organizer")]
        public string Organizer { get; set; }
        [JsonProperty("start")]
        public DateTime Start { get; set; }
        [JsonProperty("end")]
        public DateTime End { get; set; }
        [JsonProperty("attendeeCount")]
        public int AttendeeCount { get; set; }
    }
}
