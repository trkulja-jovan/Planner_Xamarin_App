using System;
using System.Collections.Generic;
using System.Text;
using PlannerMob.Entities;

namespace PlannerMob.Service
{
    class AttendeeService
    {
        public List<Attendee> GetAttendeeList()
            {
            return new List<Attendee>()
                {
                new Attendee()
                {
                    Name="Zarko", Surname="Nedeljkovic", ImageUrl="https://avatars.githubusercontent.com/u/56759839?s=400&u=fb234fd8d16fbefe452eb451d866b33e524068e4&v=4", Action = ActionAttendee.Joined, TimeStamp = DateTimeOffset.Now

                },
                 new Attendee()
                {
                    Name="Jovan", Surname="Trkulja", ImageUrl="https://avatars.githubusercontent.com/u/56934735?v=4", Action = ActionAttendee.Joined, TimeStamp = DateTimeOffset.Now

                },
                    new Attendee()
                {
                    Name="Nikola", Surname="Djokic", ImageUrl="https://cdn.pixabay.com/photo/2018/08/28/12/41/avatar-3637425_960_720.png4", Action = ActionAttendee.Joined, TimeStamp = DateTimeOffset.Now

                },

                };
            }
    }
}
