using PlannerMob.Refit.DTO.Meeting;
using PlannerMob.Refit.Interfaces;
using PlannerMob.Refit.RefitInterface;
using System;
using System.Threading.Tasks;

namespace PlannerMob.Refit.ServiceImplementation
{
    public class MeetingServiceImplementation : BaseService.BaseService, IMeetingService
    {
        public async Task<MeetingResponse> GetMeetings()
        {
            try
            {
                var res = await GetServiceFor<IMetting>().GetMeetings();
                return res;
            } catch(Exception e)
            {
                return null;
            }
        }
    }
}
