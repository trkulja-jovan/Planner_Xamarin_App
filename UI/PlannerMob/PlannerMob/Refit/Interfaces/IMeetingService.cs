using PlannerMob.Refit.DTO.Meeting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PlannerMob.Refit.Interfaces
{
    public interface IMeetingService
    {
        public List<MeetingDto> GetMeetings();
    }
}
