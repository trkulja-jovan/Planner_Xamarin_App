using PlannerMob.Refit.DTO.Meeting;
using PlannerMob.Refit.Interfaces;
using PlannerMob.Refit.RefitInterface;
using System.Threading.Tasks;

namespace PlannerMob.Refit.ServiceImplementation
{
    public class MeetingServiceImplementation : BaseService.BaseService, IMeetingService
    {
        public async Task<MeetingResponse> GetMeetings() => await GetServiceFor<IMetting>().GetMeetings();
    }
}
