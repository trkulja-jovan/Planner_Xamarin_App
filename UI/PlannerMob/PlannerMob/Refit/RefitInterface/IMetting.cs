using PlannerMob.Refit.DTO.Meeting;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PlannerMob.Refit.RefitInterface
{
    public interface IMetting
    {
        [Get("/api/MeetingAttendance/GetMeetings")]
        public Task<MeetingResponse> GetMeetings();
    }
}
