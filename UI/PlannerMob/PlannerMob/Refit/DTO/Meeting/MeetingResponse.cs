using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlannerMob.Refit.DTO.Meeting
{
    public class MeetingResponse
    {
        [JsonProperty("meetings")]
        public List<MeetingDto> Meetings { get; set; }
        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}
