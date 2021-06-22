using System;
using System.Collections.Generic;
using System.Text;

namespace PlannerMob.Refit.DTO.Meeting
{
    public class MeetingResponse
    {
        public List<MeetingDto> Meetings { get; set; }
        public bool Success { get; set; }
    }
}
