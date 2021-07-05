using PlannerMob.Refit.DTO.Meeting;
using PlannerMob.Refit.Interfaces;
using PlannerMob.Refit.RefitInterface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PlannerMob.Refit.ServiceImplementation
{
    public class MeetingServiceImplementation : BaseService.BaseService, IMeetingService
    {
        public List<MeetingDto> GetMeetings()
        {
            try
            {
                var list = new List<MeetingDto>
                {
                    new MeetingDto
                    {
                        AttendeeCount = 9,
                        Start = DateTime.Parse("2020-09-24T11:59:01"),
                        End = DateTime.Parse("2020-09-24T12:43:50"),
                        Id = Guid.Parse("9150d8ec-3b8e-490d-543a-08d93b449d23"),
                        Name = "meet",
                        Organizer = "znedeljkovic.b518.17@one.pmf.uns.ac.rs"
                    }
                };

                return list;

            } catch(Exception e)
            {
                return null;
            }
        }
    }
}
